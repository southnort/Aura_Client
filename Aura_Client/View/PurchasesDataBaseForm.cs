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
    public partial class PurchasesDataBaseForm : AuraForm
    {

        public PurchasesDataBaseForm()
        {
            InitializeComponent();

            ReloadTable();

        }

        private void ReloadTable()
        {            
            ClearTable();
            FillTable(Program.dataManager.GetAllPurchases());
        }

        private void FillTable(List<Purchase> purchases)
        {
            if (purchases.Count > 0)
            {
                foreach (var pur in purchases)
                {
                    if (pur == null) return;

                    //проверяем закупку на необходимость добавления
                    if (!VisiblePurchase(pur)) return;

                    DataGridViewRow newRow = new DataGridViewRow();     
                    newRow.Cells[0].Value = pur.id;
                    newRow.Cells[1].Value = Catalog.purchasesNames[pur.purchaseMethodID];
                    newRow.Cells[2].Value = pur.purchaseName;
                    newRow.Cells[3].Value = Catalog.statusesNames[pur.statusID];
                    newRow.Cells[4].Value = HandleDate(pur.purchaseEisDate);
                    newRow.Cells[5].Value = Program.dataManager.userNames[pur.employeID.ToString()];
                    newRow.Cells[6].Value = pur.comments;

                    RecolorRow(newRow, pur.statusID);

                    dataGridView1.Rows.Add(newRow);

                }
            }
        }

        private bool VisiblePurchase(Purchase pur)
        {
            //проверка, должна ли закупка добавляться в список

            //проверяем права юзера
            //админы видят все закупки            
            if (Program.user.roleID == 0)
                return true;

            else
            {
                //юзеры должны видеть только закупки по их законам
                return Program.user.roleID == pur.law;
            }
            
        }

        private void RecolorRow(DataGridViewRow row, int statusID)
        {
            Color color = Color.White;
            switch (statusID)
            {
                case 5: color = Color.Blue; break;
                case 6: color = Color.Yellow; break;
                case 7: color = Color.Orange; break;
                case 8: color = Color.Red; break;
            }

          //  row.Cells[3].Style.BackColor = color;
            row.DefaultCellStyle.BackColor = color;
        }

        private string HandleDate(string input)
        {
            DateTime date = Convert.ToDateTime(input);
            if (date == DateTime.MinValue) return "< - >";

            else return date.ToShortDateString();
        }

        private void ClearTable()
        {
            if (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.Rows.Clear();
            }
        }


        private void ShowPurchase(Purchase purchase)
        {
            //открыть форму просмотра закупки

            PurchaseForm form = new PurchaseForm(purchase);
            var result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                ReloadTable();

            }

        }





        private void button1_Click(object sender, EventArgs e)
        {
            ShowPurchase(new Purchase());
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dg = (DataGridView)sender;
            var purchaseID = dg.Rows[e.RowIndex].Cells[0].Value.ToString();
            Purchase purchase = Program.dataManager.GetPurchase(purchaseID);
            ShowPurchase(purchase);

        }
        
    }
}
