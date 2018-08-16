using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Aura_Client.Model;
using Aura.Model;

namespace Aura_Client.View
{
    public partial class ReestrForm : AuraForm
    {
        private Purchase purchase;

        public ReestrForm(Purchase purchase)
        {
            InitializeComponent();
            this.purchase = purchase;
            LoadCatalogs();
            creator = new Controller.CommandStringCreator("Purchases", purchase.id.ToString());

            FillForm();
        }


        private void LoadCatalogs()
        {
            //заполнить справочники для выпадающих меню

            //способы определения поставщика
            for (int i = 0; i < Catalog.purchaseMethods.Count; i++)
            {
                ComboBoxItem item = new ComboBoxItem();
                item.Text = Catalog.purchaseMethods[i].name;
                item.Value = i;

                purchaseMethodID.Items.Add(item);

            }

            //статусы протоколов
            for (int i = 0; i < Catalog.protocolStatuses.Count; i++)
            {
                ComboBoxItem item = new ComboBoxItem();
                item.Text = Catalog.protocolStatuses[i];
                item.Value = i;

                protocolStatusID.Items.Add(item);

            }            

            //ответственный за размещение договора в реестре           
            foreach (var user in Program.dataManager.GetUserNames())
            {
                ComboBoxItem item = new ComboBoxItem();
                item.Text = user.Value;
                item.Value = int.Parse(user.Key);

                employeReestID.Items.Add(item);

            }

            //закон, по которой проводится закупка
            for (int i = 0; i < 3; i++)
            {
                law.Items.Add(new ComboBoxItem() { Text = Catalog.laws[i], Value = i });
            }

            //с АЦК или без неё

            withAZK.Items.Add(new ComboBoxItem() { Text = "С АЦК", Value = 0, });
            withAZK.Items.Add(new ComboBoxItem() { Text = "БЕЗ АЦК", Value = 1, });


            purchaseMethodID.MouseWheel += new MouseEventHandler(comboBox_ValueChanged);
            statusID.MouseWheel += new MouseEventHandler(comboBox_ValueChanged);
            protocolStatusID.MouseWheel += new MouseEventHandler(comboBox_ValueChanged);
            employeReestID.MouseWheel += new MouseEventHandler(comboBox_ValueChanged);
            employeReestID.MouseWheel += new MouseEventHandler(comboBox_ValueChanged);
            law.MouseWheel += new MouseEventHandler(comboBox_ValueChanged);
            withAZK.MouseWheel += new MouseEventHandler(comboBox_ValueChanged);

        }

        private void ReloadStatuses()
        {
            //изменить статусы в зависимости от выбранного способа определения поставщика
            statusID.Items.Clear();

            ComboBoxItem selectedItem = purchaseMethodID.SelectedItem as ComboBoxItem;
            PurchaseMethod method = Catalog.purchaseMethods[(int)selectedItem.Value];
            foreach (var st in method.purchaseStatuses)
            {
                ComboBoxItem item = new ComboBoxItem();
                item.Text = st.Value;
                item.Value = st.Key;

                statusID.Items.Add(item);
                statusID.SelectedIndex = 0;

            }

        }

        private void SetControllButton()
        {
            if (purchase.reestrStatus == 0)
            {
                reestrStatus.BackColor = Color.LightCoral;
                reestrStatus.Text = "Отметить после внесения";
            }

            else
            {
                reestrStatus.BackColor = Color.LightGreen;
                reestrStatus.Text = "Внесён в реестр";
            }

        }

        private void FillForm()
        {
            purchaseName.Text = purchase.purchaseName;
            SetCombobox(purchaseMethodID, purchase.purchaseMethodID);
            purchacePrice.Value = (decimal)purchase.purchacePrice;
            purchaseEisNum.Text = purchase.purchaseEisNum;
            SetDate(purchaseEisDate, purchase.purchaseEisDate);

            SetCombobox(employeReestID, purchase.employeReestID);

            SetDate(contractDateReal, purchase.contractDateReal);
            SetDate(reestrDateLast, purchase.reestrDateLast);

            contractPrice.Value = (decimal)purchase.contractPrice;
            reestrNumber.Text = purchase.reestrNumber;


            comments.Text = purchase.comments;
            if (purchase.commentsFontColor != 0)
            {
                comments.ForeColor = Color.FromArgb(purchase.commentsFontColor);

            }
            resultOfControl.Text = purchase.resultOfControl;
            if (purchase.resultOfControlColor != 0)
            {
                resultOfControl.ForeColor = Color.FromArgb(purchase.resultOfControlColor);

            }


            law.SelectedIndex = purchase.law;

            if (Program.user.roleID != 0)
            {
                //если пользователь не администратор - запретить редактирование закона
                law.Enabled = false;
                reestrStatus.Enabled = false;
            }

            withAZK.SelectedIndex = purchase.withAZK;

            SetControllButton();
            ReloadStatuses();
            SetCombobox(statusID, purchase.statusID);
            SetCombobox(protocolStatusID, purchase.protocolStatusID);
            SwitchColorMark();


            if (purchase.id > 0 && purchase.purchaseMethodID > 0)
            {
                purchaseMethodID.Enabled = false;
            }

            FillOrganisationName();
        }

        private void SwitchReestrStatus()
        {
            if (purchase.reestrStatus == 0)
                purchase.reestrStatus = 1;
            else purchase.reestrStatus = 0;

            creator.Add("reestrStatus", purchase.reestrStatus.ToString());

            SetControllButton();

        }

        private void SwitchColorMark()
        {
            colorMark.BackColor = Color.FromArgb(purchase.colorMark);
        }

        private void FillOrganisationName()
        {
            if (purchase.organizationID > 0)
            {
                Organisation org = Program.dataManager.GetOrganisation(purchase.organizationID.ToString());
                organizationID.Text = org.name;
            }
        }


        private void dateTime_ValueChanged(object sender, EventArgs e)
        {
            var picker = (DateTimePicker)sender;
            SetDate(picker, picker.Value);

            creator.Add(picker.Name, picker.Value.ToShortDateString());
        }

        private void textBox_ValueChanged(object sender, EventArgs e)
        {
            if (sender is TextBox)
            {
                var textBox = (TextBox)sender;
                creator.Add(textBox.Name, textBox.Text);
            }
            if (sender is RichTextBox)
            {
                var textBox = (RichTextBox)sender;
                creator.Add(textBox.Name, textBox.Text);
            }


        }

        private void comboBox_ValueChanged(object sender, EventArgs e)
        {

            var box = (ComboBox)sender;
            ComboBoxItem item = box.SelectedItem as ComboBoxItem;
            try
            {
                if (item != null)
                    creator.Add(box.Name, ((int)item.Value).ToString());
            }
            catch
            {
                MessageBox.Show(item.Value.GetType().ToString());
            }
        }

        private void numericUpDown_ValueChanges(object sender, EventArgs e)
        {
            var box = (NumericUpDown)sender;
            creator.Add(box.Name, box.Value.ToString());
        }




        private void buttonOK_Click(object sender, EventArgs e)
        {
            SendToServer();
            timer1.Start();     //закрыть форму через время 

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void SendToServer()
        {
            if (creator.IsNotEmpty())
            {
                if (purchase.id < 1)
                {
                    Program.bridge.SendMessage("NEWPURCHASE#" + creator.ToNew());
                }
                else
                {
                    Program.bridge.SendMessage("UPDATEPURCHASE#" + creator.ToUpdate());
                }
            }

            else
                Close();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void reestrStatus_Click(object sender, EventArgs e)
        {
            SwitchReestrStatus();
        }

        private void purchaseMethodID_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReloadStatuses();
        }

        private void colorMark_Click(object sender, EventArgs e)
        {
            colorDialog1.AllowFullOpen = false;
            colorDialog1.ShowHelp = true;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                int argb = colorDialog1.Color.ToArgb();
                purchase.colorMark = argb;
                creator.Add("colorMark", argb.ToString());
                SwitchColorMark();
            }
        }

        private void dateTimeClear_Click(object sender, EventArgs e)
        {
            string fieldName = ((Button)sender).Name.Replace("Clr", "");
            DateTimePicker picker = Controls[fieldName] as DateTimePicker;
            SetDate(picker, DateTime.MinValue);
            creator.Add(fieldName, DateTime.MinValue.ToShortDateString());

        }

        private void commentsFontSetting_Click(object sender, EventArgs e)
        {
            var result = colorDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                comments.ForeColor = colorDialog1.Color;
                creator.Add("commentsFontColor", colorDialog1.Color.ToArgb().ToString());
            }
        }

        private void resultOfControlFontColor_Click(object sender, EventArgs e)
        {
            var result = colorDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                resultOfControl.ForeColor = colorDialog1.Color;
                creator.Add("resultOfControlColor", colorDialog1.Color.ToArgb().ToString());
            }
        }

        private void organisationSelectButton_Click(object sender, EventArgs e)
        {
            var form = new OrganisationsDataBaseForm(false);
            var result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                Organisation org = form.returnedOrganisation;
                creator.Add("organizationID", org.id.ToString());
                organizationID.Text = org.name;
            }

        }

    }
}
