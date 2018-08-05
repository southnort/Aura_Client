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

            foreach (var item in Program.dataManager.userNames)
            {
                employeID.Items.Add(item.Value);
            }

            foreach (var item in Catalog.organisationsNames)
            {
                organizationID.Items.Add(item);
            }

            purchaseMethodID.MouseWheel += new MouseEventHandler(comboBox_ValueChanged);
            statusID.MouseWheel += new MouseEventHandler(comboBox_ValueChanged);
            employeID.MouseWheel += new MouseEventHandler(comboBox_ValueChanged);
            organizationID.MouseWheel += new MouseEventHandler(comboBox_ValueChanged);

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

            comments.Text = purchase.comments;

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
            creator.Add(box.Name, box.SelectedIndex.ToString());
        }



        private void buttonOK_Click(object sender, EventArgs e)
        {
            SendToServer();
            timer1.Start();          
            
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
    }

}
