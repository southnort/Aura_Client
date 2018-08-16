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
    public partial class ReestrDataBaseForm : AuraForm
    {
        public ReestrDataBaseForm()
        {
            InitializeComponent();

            CreateTable();
            ReloadTable();
        }

        private void CreateTable()
        {
            dgv.Columns.Add("id", "id");
            dgv.Columns["id"].Width = 50;

            dgv.Columns.Add("organizationID", "Заказчик");
            dgv.Columns["organizationID"].Width = 150;

            dgv.Columns.Add("purchaseName", "Наименование закупки");
            dgv.Columns["purchaseName"].Width = 200;

            dgv.Columns.Add("colorMark", "Метка");
            dgv.Columns["colorMark"].Width = 45;

            dgv.Columns.Add("employeReestID", "Ответственный за реестр");
            dgv.Columns["employeReestID"].Width = 200;

            DataGridViewCheckBoxColumn checkColumn = new DataGridViewCheckBoxColumn();
            checkColumn.Name = "reestrStatus";
            checkColumn.HeaderText = "Внесено";
            dgv.Columns.Add(checkColumn);
            dgv.Columns["reestrStatus"].Width = 60;



        }

        private void ReloadTable()
        {
            ClearTable();
            FillTable(Program.dataManager.GetReestr());
        }

        private void ClearTable()
        {
            if (dgv.Rows.Count > 0)
            {
                dgv.Rows.Clear();
            }

        }

        private void FillTable(List<Purchase> purchases)
        {
            var users = Program.dataManager.GetUserNames();
            var orgs = Program.dataManager.GetAllOrganisations();

            foreach (var pur in purchases)
            {
                if (pur != null)
                {
                    int rowIndex = dgv.Rows.Add();
                    var newRow = dgv.Rows[rowIndex];

                    newRow.Cells["id"].Value = pur.id;

                    newRow.Cells["organizationID"].Value =
                               pur.organizationID == 0 ? "<не указано>" :
                               orgs[pur.organizationID - 1].name;

                    newRow.Cells["purchaseName"].Value = pur.purchaseName;

                    newRow.Cells["colorMark"].Style.BackColor = Color.FromArgb(pur.colorMark);

                    newRow.Cells["employeReestID"].Value =
                        users[pur.employeReestID.ToString()];

                    newRow.Cells["reestrStatus"].Value =
                        pur.reestrStatus == 1;

                }

            }
        

        }


        private string HandleDate(string input)
        {
            DateTime date = Convert.ToDateTime(input);
            if (date == DateTime.MinValue) return "< - >";

            else return date.ToShortDateString();
        }

        private void ShowPurchase(Purchase purchase)
        {
            //открыть форму просмотра закупки

            var form = new ReestrForm(purchase);
            var result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                ReloadTable();

            }

        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridView dg = (DataGridView)sender;
                var purchaseID = dg.Rows[e.RowIndex].Cells[0].Value.ToString();
                Purchase purchase = Program.dataManager.GetPurchase(purchaseID);
                ShowPurchase(purchase);
            }

        }

    }
}
