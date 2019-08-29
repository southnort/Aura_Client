using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Aura.Model;


namespace Aura_Client.View
{
    public partial class DocumentationNodeForm : AuraForm
    {
        private DocumentationNode documentationNode;

        public DocumentationNodeForm(DocumentationNode node)
        {
            InitializeComponent();
            InitializeAuraForm();
            documentationNode = node;
            creator = new Controller.CommandStringCreator("Documentation", node.id.ToString());

            Fill();

            text.Focus();

        }

        private void Fill()
        {
            nodeDate.Value = documentationNode.nodeDate;
            text.Text = documentationNode.text;
            if (documentationNode.id < 1) deleteButton.Enabled = false;
        }


        protected override void dateTime_ValueChanged(object sender, EventArgs e)
        {
            base.dateTime_ValueChanged(sender, e);
        }

        protected override void textBox_ValueChanged(object sender, EventArgs e)
        {
            base.textBox_ValueChanged(sender, e);
        }




        private void okButton_Click(object sender, EventArgs e)
        {
            SendToserver();
            DialogResult = DialogResult.OK;

        }

        private void SendToserver()
        {
            if (creator.ChangesIsNotEmpty())
            {
                if (documentationNode.id < 1)
                {
                    Program.bridge.SendMessage("EXECUTECOMMAND#" + creator.ToNew());
                }
                else
                {
                    Program.bridge.SendMessage("EXECUTECOMMAND#" + creator.ToUpdate());
                }
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Вы действительно хотите удалить этот пункт?",
                "Требуется подтверждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
                ConfirmDelete();
        }

        private void ConfirmDelete()
        {
            string command = "EXECUTECOMMAND#DELETE FROM Documentation WHERE id =" + documentationNode.id;
            Program.bridge.SendMessage(command);
            DialogResult = DialogResult.OK;
        }
    }
}
