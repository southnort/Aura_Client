﻿using Aura.Model;
using Aura_Client.Controller;
using Aura_Client.Model;
using System;
using System.Data;
using System.Windows.Forms;
using System.Text;

namespace Aura_Client.View
{
    public partial class OrganisationForm : AuraForm
    {
        private Organisation organisation;



        public OrganisationForm(Organisation organisation) : base()
        {
            InitializeComponent();
            InitializeAuraForm();

            this.organisation = organisation;
            LoadCatalogs();
            creator = new CommandStringCreator("Organisations", organisation.id.ToString());
            Fill(organisation);
            FillTable(organisation);
            
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

            foreach (var item in Catalog.laws)
            {
                law.Items.Add(item);
            }

            foreach (var item in Catalog.contractTypes)
            {
                contractType.Items.Add(item);
            }
        }

        private void Fill(Organisation org)
        {
            name.Text = org.name;
            inn.Text = org.inn;
            contactName.Text = org.contactName;
            phoneNumber.Text = org.phoneNumber;
            email.Text = org.email;
            //contractNumber.Text = org.contractNumber;
            //SetDate(contractStart, org.contractStart);
            //SetDate(contractEnd, org.contractEnd);
            contractCondition.SelectedIndex = org.contractCondition;
            originalID.SelectedIndex = org.originalID;
            law.SelectedIndex = org.law;
            contractType.SelectedIndex = org.contractType;
            comments.Text = org.comments;
            number.Text = org.number;

            if (org.id < 1)
            {
                addNewContractButton.Hide();
                removeContractButton.Hide();
                showLogsButton.Hide();
            }
        }

        private void FillTable(Organisation org)
        {
            contractsDataGridView.Rows.Clear();
            string str = "SELECT * FROM Contracts WHERE organisationID = '" + org.id + "'";
            DataTable table = Program.dataManager.GetDataTable(str);

            foreach (DataRow tableRow in table.Rows)
            {
                Contract contract = new Contract(tableRow);
                AddContractToTable(contract);
            }
        }

        private void AddContractToTable(Contract contract)
        {
            int index = contractsDataGridView.Rows.Add();
            var row = contractsDataGridView.Rows[index];

            row.Cells["id"].Value = contract.id;
            row.Cells["contractNumber"].Value = contract.contractNumber;

            row.Cells["contractStart"].Value = ConvertDateToShortText(contract.contractStart);
            row.Cells["contractEnd"].Value = ConvertDateToShortText(contract.contractEnd);

        }


        protected override void dateTime_ValueChanged(object sender, EventArgs e)
        {
            var picker = (DateTimePicker)sender;
            SetDate(picker, picker.Value.ToString("yyyy-MM-dd"));

            creator.AddChange(picker.Name, picker.Value.ToString("yyyy-MM-dd"));
        }

        protected override void textBox_ValueChanged(object sender, EventArgs e)
        {
            if (sender is TextBox)
            {
                var textBox = (TextBox)sender;
                creator.AddChange(textBox.Name, textBox.Text);
            }
            if (sender is RichTextBox)
            {
                var textBox = (RichTextBox)sender;
                creator.AddChange(textBox.Name, textBox.Text);
            }


        }

        protected override void comboBox_ValueChanged(object sender, EventArgs e)
        {
            var box = (ComboBox)sender;
            creator.AddChange(box.Name, box.SelectedIndex.ToString());
        }



        private void OpenContract(Contract contract)
        {
            ContractForm form = new ContractForm(contract);
            var result = form.ShowDialog();

            if (result == DialogResult.OK)
            {
               // UpdateContract();
                AddContractToTable(form.contract);
            }

        }

        private void UpdateContract()
        {
            //взять последние реквизиты договора из таблицы договоров
            //и заменить эти данные в карточке организации

            DataTable dataTable = Program.dataManager.GetDataTable
                ("SELECT * FROM Contracts WHERE organisationID = '" + organisation.id + "'");
            if (dataTable != null)
            {
                Contract contract = new Contract(dataTable.Rows[dataTable.Rows.Count - 1]);

                StringBuilder sb = new StringBuilder();
                sb.Append("UPDATE Organisations SET ");
                sb.Append("contractNumber = '");
                sb.Append(contract.contractNumber);
                sb.Append("', contractStart = '");
                sb.Append(contract.contractStart.ToString("yyyy-MM-dd"));
                sb.Append("', contractEnd = '");
                sb.Append(contract.contractEnd.ToString("yyyy-MM-dd"));
                sb.Append("' WHERE id = '");
                sb.Append(contract.organisationID);
                sb.Append("'");

                Program.bridge.SendMessage("EXECUTECOMMAND#" + sb.ToString());
            }

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
                if (organisation.id < 1)
                {
                    Program.bridge.SendMessage("NEWORGANISATION#" + creator.ToNew());
                }

                else
                {
                    Program.bridge.SendMessage("UPDATEORGANISATION#" + creator.ToUpdate());
                }
            }

            else
                Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            SendToServer();
            timer2.Stop();
        }

        private void addNewContractButton_Click(object sender, EventArgs e)
        {
            Contract contract = new Contract { organisationID = organisation.id };
            OpenContract(contract);
        }

        private void removeContractButton_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = contractsDataGridView.CurrentRow;

            if (row != null)
            {
                string id = row.Cells["id"].Value.ToString();
                string text = "Вы действительно хотите удалить данные договора № " +
                  row.Cells["contractNumber"].Value.ToString() + "?" +
                    "\nЗаказчик - " + organisation.name;
                DialogResult dialogResult = MessageBox.Show(text,
                    "Подтвердите удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    Program.dataManager.DeleteContract(id);
                    creator.AddChange("contractNumber", "");
                    creator.AddChange("contractStart", DateTime.MinValue.ToString());
                    creator.AddChange("contractEnd", DateTime.MinValue.ToString());
                    timer2.Start();                    
                    
                    contractsDataGridView.Rows.Remove(row);

                }

            }

        }

        private void contractsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridView dg = (DataGridView)sender;
                var contractID = dg.Rows[e.RowIndex].Cells["id"].Value.ToString();
                Contract contract = Program.dataManager.GetContract(contractID);

                OpenContract(contract);
            }

        }

        private void showLogsButton_Click(object sender, EventArgs e)
        {
            LogsJournalForm form = new LogsJournalForm(organisation);
            form.ShowDialog();
        }
    }
}
