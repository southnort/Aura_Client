using System;
using System.Windows.Forms;
using Aura.Model;

namespace Aura_Client.View
{
    public partial class ContractForm : AuraForm
    {
        private Contract contract;

        public ContractForm(Contract contract)
        {
            InitializeComponent();
            creator = new Controller.CommandStringCreator("Contracts", contract.id.ToString());
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
            if (creator.IsNotEmpty())
            {
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
            DialogResult = DialogResult.OK;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
