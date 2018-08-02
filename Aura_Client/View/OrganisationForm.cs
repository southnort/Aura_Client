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
    public partial class OrganisationForm : AuraForm
    {
        public OrganisationForm(Organisation organisation)
        {
            InitializeComponent();
        }

        private void LoadCatalogs()
        {
            foreach (var item in Catalog.contractConditions)
            {
                contractCondition.Items.Add(item);
            }

            foreach (var item in Catalog.contractOriginalConditions)
            {
                originalID.Items.Add(item);
            }
        }

        private void Fill(Organisation org)
        {
            name.Text = org.name;
            inn.Text = org.inn;
            contactName.Text = org.contactName;
            phoneNumber.Text = org.phoneNumber;
            email.Text = org.email;
            contractNumber.Text = org.contractNumber;
            SetDate(contractStart, org.contractStart);
            SetDate(contractEnd, org.contractEnd);
            contractCondition.SelectedIndex = org.contractCondition;
            originalID.SelectedIndex = org.originalID;

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
    }
}
