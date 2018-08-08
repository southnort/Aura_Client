using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Aura.Model;
using Aura_Client.Model;
using Aura_Client.Controller;

namespace Aura_Client.View
{
    public partial class PurchaseForm : AuraForm
    {
        private Purchase purchase;

        public PurchaseForm(Purchase purchase)
        {
            InitializeComponent();
            this.purchase = purchase;
            LoadCatalogs();
            creator = new CommandStringCreator("Purchases", purchase.id.ToString());

            if (purchase.id < 1)
            {
                //если закупка новая, она должна автоматически создаваться
                //для того закона, для которого создан пользователь
                purchase.law = Program.user.roleID;
                creator.Add("law", purchase.law.ToString());

            }

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

            //ответственный за разработку документации            
            foreach (var user in Program.dataManager.userNames)
            {
                ComboBoxItem item = new ComboBoxItem();
                item.Text = user.Value;
                item.Value = int.Parse(user.Key);

                employeDocumentationID.Items.Add(item);

            }

            //ответственный за размещение закупки            
            foreach (var user in Program.dataManager.userNames)
            {
                ComboBoxItem item = new ComboBoxItem();
                item.Text = user.Value;
                item.Value =int.Parse(user.Key);

                employeID.Items.Add(item);

            }

            //организации-заказчики  
            foreach (var org in Program.dataManager.GetAllOrganisations())
            {
                ComboBoxItem item = new ComboBoxItem();
                item.Text = org.name;
                item.Value = org.id;

                organizationID.Items.Add(item);
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
            employeDocumentationID.MouseWheel += new MouseEventHandler(comboBox_ValueChanged);
            employeID.MouseWheel += new MouseEventHandler(comboBox_ValueChanged);
            organizationID.MouseWheel += new MouseEventHandler(comboBox_ValueChanged);
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
            if (purchase.controlStatus == 0)
            {
                controlStatus.BackColor = Color.LightCoral;
                controlStatus.Text = "Проверить";
            }

            else
            {
                controlStatus.BackColor = Color.LightGreen;
                controlStatus.Text = "Проверено";
            }

        }

        private void FillForm()
        {
            purchaseName.Text = purchase.purchaseName;
            SetCombobox(purchaseMethodID, purchase.purchaseMethodID);
            purchacePrice.Value = (decimal)purchase.purchacePrice;
            purchaseEisNum.Text = purchase.purchaseEisNum;
            SetDate(purchaseEisDate, purchase.purchaseEisDate);

            SetCombobox(employeDocumentationID, purchase.employeDocumentationID);
            SetCombobox(employeID, purchase.employeID);
            SetCombobox(organizationID, purchase.organizationID);

            SetDate(bidsStartDate, purchase.bidsStartDate);
            SetDate(bidsEndDate, purchase.bidsEndDate);

            SetDate(bidsOpenDate, purchase.bidsOpenDate);
            SetDate(bidsReviewDate, purchase.auctionDate);
            SetDate(bidsRatingDate, purchase.bidsRatingDate);

            SetDate(bidsFirstPartDate, purchase.bidsFirstPartDate);
            SetDate(bidsSecondPartDate, purchase.bidsSecondPartDate);
            SetDate(bidsFinishDate, purchase.bidsFinishDate);

                       
            
            
            comments.Text = purchase.comments;
            resultOfControl.Text = purchase.resultOfControl;
            law.SelectedIndex = purchase.law;

            if (Program.user.roleID != 0)
            {
                //если пользователь не администратор - запретить редактирование закона
                law.Enabled = false;
                controlStatus.Enabled = false;
            }

            withAZK.SelectedIndex = purchase.withAZK;

            SetControllButton();
            ReloadStatuses();
            SetCombobox(statusID, purchase.statusID);
            SwitchColorMark();
        }

        private void SwitchControlStatus()
        {
            if (purchase.controlStatus == 0)
                purchase.controlStatus = 1;
            else purchase.controlStatus = 0;

            creator.Add("controlStatus", purchase.controlStatus.ToString());

            SetControllButton();

        }

        private void SwitchColorMark()
        {
            colorMark.BackColor = Color.FromArgb(purchase.colorMark);
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
            Close();
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

        private void controlStatus_Click(object sender, EventArgs e)
        {
            SwitchControlStatus();
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
    }

}
