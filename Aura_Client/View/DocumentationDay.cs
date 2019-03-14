using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Aura.Model;


namespace Aura_Client.View
{
    public partial class DocumentationDay : UserControl,IShowable
    {
        private List<DocumentationNode> nodes;
        private DateTime date;

        public DocumentationDay(DateTime dateTime, List<DocumentationNode> documentationNodes)
        {
            InitializeComponent();

            date = dateTime;
            nodes = documentationNodes;

            Fill();
           
        }

        private void Fill()
        {
            dateLabel.Text = date.Day.ToString();
            openButton.Text = "Записей - " + nodes.Count;
        }

                       

        public void OpenAuraForm()
        {
            Program.openedForms.Add(this);
        }

        public void CloseAuraForm()
        {
            Program.openedForms.Remove(this);
        }

        private void openButton_Click(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            DocumentationNode newNode = new DocumentationNode
            {
                nodeDate = date,
            };

            DocumentationNodeForm form = new DocumentationNodeForm(newNode);
            var result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                nodes.Add(newNode);
                Fill();
            }


        }
    }
}
