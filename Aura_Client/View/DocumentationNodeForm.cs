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

        }

        private void Fill()
        {
            nodeDate.Value = documentationNode.nodeDate;
            text.Text = documentationNode.text;
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
            timer1.Start();
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
