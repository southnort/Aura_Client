using System;
using System.Windows.Forms;
using System.Text;
using Aura.Model;

namespace Aura_Client.View
{
    public partial class ContractForm : AuraForm
    {
        private Contract contract;

        public ContractForm(Contract contract) : base()
        {
            InitializeComponent();
            creator = new Controller.CommandStringCreator("Contracts", contract.id.ToString());
            creator.Add("organisationID", contract.organisationID.ToString());
            this.contract = contract;
            Fill(contract);
        }

        private void Fill(Contract contract)
        {
            contractNumber.Text = contract.contractNumber;
            SetDate(contractStart, contract.contractStart);
            SetDate(contractEnd, contract.contractEnd);

        }

        private void SendToServer()
        {
            //отправить на сервер в БД новые данные
            if (creator.IsNotEmpty())
            {
               // UpdateOrganisation();

                if (contract.id < 1)
                {
                    Program.bridge.SendMessage("EXECUTECOMMAND#" + creator.ToNew());
                }

                else
                {
                    Program.bridge.SendMessage("EXECUTECOMMAND#" + creator.ToUpdate());
                }
            }
        }

        private void UpdateOrganisation()
        {
            //при редактировании данных договора - обновить эти данные в карточке оргнизации
            StringBuilder sb = new StringBuilder();
            sb.Append("UPDATE Organisations SET ");
            sb.Append("contractNumber = '");
            sb.Append(contractNumber.Text);
            sb.Append("', contractStart = '");
            sb.Append(contractStart.Value.ToString("yyyy-MM-dd"));
            sb.Append("', contractEnd = '");
            sb.Append(contractEnd.Value.ToString("yyyy-MM-dd"));
            sb.Append("' WHERE id = '");
            sb.Append(contract.organisationID);
            sb.Append("'");

            Program.bridge.SendMessage("EXECUTECOMMAND#" + sb.ToString());

        }



        protected override void dateTime_ValueChanged(object sender, EventArgs e)
        {
            base.dateTime_ValueChanged(sender, e);
        }

        protected override void textBox_ValueChanged(object sender, EventArgs e)
        {
            base.textBox_ValueChanged(sender, e);
        }

        private void dateTimeField_KeyUp(object sender, KeyEventArgs e)
        {
            base.dateTime_ValueChanged(sender, e);
        }



        private void okButton_Click(object sender, EventArgs e)
        {
            SendToServer();
            okButton.Enabled = false;
            cancelButton.Enabled = false;
            timer1.Start();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void ContractForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult = DialogResult.Cancel;
            }
        }
    }
}
