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
        private CommandStringCreator creator;


        public PurchaseForm(Purchase purchase)
        {
            InitializeComponent();
            this.purchase = purchase;
            LoadCatalogs();
            FillForm();

            creator = new CommandStringCreator("Purchases", purchase.id.ToString());
        }

        private void LoadCatalogs()
        {
            //заполнить справочники для выпадающих меню
            foreach (var item in Catalog.purchasesNames)
            {
                purchaseMethodID.Items.Add(item);
            }

            foreach (var item in Catalog.statusesNames)
            {
                statusID.Items.Add(item);
            }

            employeID.Items.Add("<не указано>");
            foreach (var item in Program.dataManager.userNames)
            {
                employeID.Items.Add(item.Value);
            }

            foreach (var item in Catalog.organisationsNames)
            {
                organizationID.Items.Add(item);
            }

        }

        private void FillForm()
        {
            purchaseName.Text = purchase.purchaseName;
            purchaseMethodID.SelectedIndex = purchase.purchaseMethodID;
            purchacePrice.Text = purchase.purchacePrice.ToString("### ### ### ### ###.##");
            purchaseEisNum.Text = purchase.purchaseEisNum;
            SetDate(purchaseEisDate, purchase.purchaseEisDate);

            statusID.SelectedIndex = purchase.statusID;
            employeID.SelectedIndex = purchase.employeID;
            organizationID.SelectedIndex = purchase.organizationID;

            SetDate(bidsStartDate, purchase.bidsStartDate);
            SetDate(bidsEndDate, purchase.bidsEndDate);
            SetDate(bidsOpenDate, purchase.bidsOpenDate);
            SetDate(bidsFinishDate, purchase.bidsFinishDate);

            SetDate(bidsFirstPartDate, purchase.bidsFirstPartDate);
            SetDate(auctionDate, purchase.auctionDate);
            SetDate(bidsSecondPartDate, purchase.bidsSecondPartDate);

            SetDate(contractDatePlan, purchase.contractDatePlan);
            SetDate(contractDateLast, purchase.contractDateLast);
            SetDate(reestrDateLast, purchase.reestrDateLast);

            reestrNumber.Text = purchase.reestrNumber;
            contractPrice.Text = purchase.contractPrice.ToString("### ### ### ### ###.##");
            SetDate(contractDateReal, purchase.contractDateReal);

        }

        private void SetDate(DateTimePicker picker, string date)
        {
            DateTime dateTime = Convert.ToDateTime(date);
            if (dateTime == DateTime.MinValue)
            {
                picker.Format = DateTimePickerFormat.Custom;
                picker.CustomFormat = "''";
            }

            else
            {
                picker.Format = DateTimePickerFormat.Short;
                picker.Value = dateTime;
            }
        }

        private void SetDate(DateTimePicker picker, DateTime date)
        {
            if (date == DateTime.MinValue)
            {
                picker.Format = DateTimePickerFormat.Custom;
                picker.CustomFormat = "''";
            }

            else
            {
                picker.Format = DateTimePickerFormat.Short;
                //  picker.Value = date;
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
            var textBox = (TextBox)sender;
            creator.Add(textBox.Name, textBox.Text);
        }

        private void comboBox_ValueChanged(object sender, EventArgs e)
        {
            var box = (ComboBox)sender;
            creator.Add(box.Name, box.Text);
        }




        private void buttonOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            SendToServer();
            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void SendToServer()
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




       
    }

}
