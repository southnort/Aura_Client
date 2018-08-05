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
    public partial class OrganisationsDataBaseForm : AuraForm
    {
        public OrganisationsDataBaseForm()
        {
            InitializeComponent();
            ReloadTable();

        }

        private void ReloadTable()
        {
            ClearTable();
            FillTable(Program.dataManager.GetAllOrganisations());

        }

        private void ClearTable()
        {
            if (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.Rows.Clear();
            }

        }

        private void FillTable(List<Organisation> organisations)
        {
            if (organisations.Count > 0)
            {
                foreach (var org in organisations)
                {
                    if (org == null) return;

                    object[] newRow = new object[4];
                    newRow[0] = org.id;
                    newRow[1] = org.name;
                    newRow[2] = org.inn;
                    newRow[3] = Catalog.laws[org.law];

                    dataGridView1.Rows.Add(newRow);

                }
            }
        }


        private void ShowOrganisation(Organisation org)
        {
            OrganisationForm form = new OrganisationForm(org);
            var result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                ReloadTable();

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShowOrganisation(new Organisation());

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridView dg = (DataGridView)sender;
                var ID = dg.Rows[e.RowIndex].Cells[0].Value.ToString();
                Organisation org = Program.dataManager.GetOrganisation(ID);
                ShowOrganisation(org);
            }

        }
    }
}
