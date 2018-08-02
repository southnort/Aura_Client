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
            FillForm();
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
                Program.bridge.SendMessage("NEWPURCHASE#" + GetCommandForCreatingNewPurchase());
            }
        }

        private string GetCommandForCreatingNewPurchase()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("INSERT INTO Purchases ('employeID', 'organizationID', 'purchaseMethodID', 'purchaseName', ");
            sb.Append("'statusID', 'purchacePrice', 'purchaseEisNum', 'purchaseEisDate', 'bidsStartDate', ");
            sb.Append("'bidsEndDate', 'bidsOpenDate', 'bidsFirstPartDate', 'auctionDate', 'bidsSecondPartDate', ");
            sb.Append("'bidsFinishDate', 'contractPrice', 'contractDatePlan', 'contractDateLast', ");
            sb.Append("'contractDateReal', 'reestrDateLast', 'reestrNumber', 'comments') values ('");

            sb.Append(purchase.employeID);
            sb.Append("', '");
            sb.Append(purchase.organizationID);
            sb.Append("', '");
            sb.Append(purchase.purchaseMethodID);
            sb.Append("', '");
            sb.Append(purchase.purchaseName);
            sb.Append("', '");
            sb.Append(purchase.statusID);
            sb.Append("', '");
            sb.Append(purchase.purchacePrice);
            sb.Append("', '");
            sb.Append(purchase.purchaseEisNum);
            sb.Append("', '");
            sb.Append(purchase.purchaseEisDate);
            sb.Append("', '");
            sb.Append(purchase.bidsStartDate);
            sb.Append("', '");
            sb.Append(purchase.bidsEndDate);
            sb.Append("', '");
            sb.Append(purchase.bidsOpenDate);
            sb.Append("', '");
            sb.Append(purchase.bidsFirstPartDate);
            sb.Append("', '");
            sb.Append(purchase.auctionDate);
            sb.Append("', '");
            sb.Append(purchase.bidsSecondPartDate);
            sb.Append("', '");
            sb.Append(purchase.bidsFinishDate);
            sb.Append("', '");
            sb.Append(purchase.contractPrice);
            sb.Append("', '");
            sb.Append(purchase.contractDatePlan);
            sb.Append("', '");
            sb.Append(purchase.contractDateLast);
            sb.Append("', '");
            sb.Append(purchase.contractDateReal);
            sb.Append("', '");
            sb.Append(purchase.reestrDateLast);
            sb.Append("', '");
            sb.Append(purchase.reestrNumber);
            sb.Append("', '");
            sb.Append(purchase.comments);
            sb.Append("')");

            return sb.ToString();
        }

    }

}
