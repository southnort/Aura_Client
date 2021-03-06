﻿using Aura.Model;
using Aura_Client.Model;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Aura_Client.View
{
    public partial class ReestrForm : AuraForm
    {
        private Purchase purchase;

        public ReestrForm(Purchase purchase,bool copy = false) : base()
        {
            InitializeComponent();
            InitializeAuraForm();
            this.purchase = purchase;
            LoadCatalogs();
            creator = new Controller.CommandStringCreator("Purchases", purchase.id.ToString());

            if (purchase.id < 1)
            {
                //если закупка новая, она должна автоматически создаваться
                //для того закона, для которого создан пользователь
                purchase.law = Program.user.roleID;
                creator.AddChange("law", purchase.law.ToString());
                creator.AddChange("statusID", purchase.statusID.ToString());
                creator.AddChange("colorMark", purchase.colorMark.ToString());
                creator.AddChange("withoutPurchase", purchase.withoutPurchase.ToString());
                showLogsButton.Hide();

            }

            FillForm();

            if (copy)
            {
                LoadFromCopy();
                creator.AddChange("organizationID", purchase.organizationID.ToString());

            }

        }


        private void LoadCatalogs()
        {
            //заполнить справочники для выпадающих меню

            //способы определения поставщика
            for (int i = 0; i < CCatalog.purchaseMethods.Count; i++)
            {
                ComboBoxItem item = new ComboBoxItem();
                item.Text = CCatalog.purchaseMethods[i].name;
                item.Value = i;

                purchaseMethodID.Items.Add(item);

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
          //  SetCombobox(statusID, purchase.statusID);
         //   SetCombobox(protocolStatusID, purchase.protocolStatusID);
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

            creator.AddChange("reestrStatus", purchase.reestrStatus.ToString());

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


        protected override void dateTime_ValueChanged(object sender, EventArgs e)
        {
            base.dateTime_ValueChanged(sender, e);

            //var picker = (DateTimePicker)sender;
            //SetDate(picker, picker.Value.ToString("yyyy-MM-dd"));

            //creator.Add(picker.Name, picker.Value.ToString("yyyy-MM-dd"));
        }

        protected override void textBox_ValueChanged(object sender, EventArgs e)
        {
            base.textBox_ValueChanged(sender, e);

            //if (sender is TextBox)
            //{
            //    var textBox = (TextBox)sender;
            //    creator.Add(textBox.Name, textBox.Text);
            //}
            //if (sender is RichTextBox)
            //{
            //    var textBox = (RichTextBox)sender;
            //    creator.Add(textBox.Name, textBox.Text);
            //}


        }

        protected override void comboBox_ValueChanged(object sender, EventArgs e)
        {
            base.comboBox_ValueChanged(sender, e);

            //var box = (ComboBox)sender;
            //ComboBoxItem item = box.SelectedItem as ComboBoxItem;
            //try
            //{
            //    if (item != null)
            //        creator.Add(box.Name, ((int)item.Value).ToString());
            //}
            //catch
            //{
            //    MessageBox.Show(item.Value.GetType().ToString());
            //}
        }

        protected override void numericUpDown_ValueChanges(object sender, EventArgs e)
        {
            base.numericUpDown_ValueChanges(sender, e);

            //var box = (NumericUpDown)sender;
            //creator.Add(box.Name, box.Value.ToString());
        }

        private void dateTimeField_KeyUp(object sender, KeyEventArgs e)
        {
            base.dateTime_ValueChanged(sender, e);
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
            if (creator.ChangesIsNotEmpty())
            {
                if (purchase.id < 1)
                {
                    creator.AddChange("colorMark", purchase.colorMark.ToString());
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
       
        private void colorMark_Click(object sender, EventArgs e)
        {
            colorDialog1.AllowFullOpen = false;
            colorDialog1.ShowHelp = true;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                int argb = colorDialog1.Color.ToArgb();
                purchase.colorMark = argb;
                creator.AddChange("colorMark", argb.ToString());
                SwitchColorMark();
            }
        }

        private void dateTimeClear_Click(object sender, EventArgs e)
        {
            string fieldName = ((Button)sender).Name.Replace("Clr", "");
            DateTimePicker picker = Controls[fieldName] as DateTimePicker;
            SetDate(picker, DateTime.MinValue);
            creator.AddChange(fieldName, DateTime.MinValue.ToShortDateString());

        }

        private void commentsFontSetting_Click(object sender, EventArgs e)
        {
            var result = colorDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                comments.ForeColor = colorDialog1.Color;
                creator.AddChange("commentsFontColor", colorDialog1.Color.ToArgb().ToString());
            }
        }

        private void resultOfControlFontColor_Click(object sender, EventArgs e)
        {
            var result = colorDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                resultOfControl.ForeColor = colorDialog1.Color;
                creator.AddChange("resultOfControlColor", colorDialog1.Color.ToArgb().ToString());
            }
        }

        private void organisationSelectButton_Click(object sender, EventArgs e)
        {
            var form = new OrganisationsDataBaseForm(false);
            var result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                Organisation org = form.returnedOrganisation;
                creator.AddChange("organizationID", org.id.ToString());
                creator.AddChange("organisationInn", org.inn.ToString());
                organizationID.Text = org.name;
            }

        }

        private void ReestrForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult = DialogResult.Cancel;
            }
        }

        private void showLogsButton_Click(object sender, EventArgs e)
        {
            LogsJournalForm form = new LogsJournalForm(purchase);
            form.ShowDialog();
        }
    }
}
