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
                    Console.WriteLine("adding or not");
                    if (pur == null) return;

                    //проверяем закупку на необходимость добавления
                    if (VisiblePurchase(pur))
                    {

                        //object[] newRow = new object[7];

                        //newRow[0] = pur.id;
                        //newRow[1] = Catalog.purchasesNames[pur.purchaseMethodID];
                        //newRow[2] = pur.purchaseName;
                        //newRow[3] = Catalog.statusesNames[pur.statusID];
                        //newRow[4] = HandleDate(pur.purchaseEisDate);
                        //newRow[5] =  Program.dataManager.userNames[pur.employeID.ToString()];
                        //newRow[6] = pur.comments;

                        DataGridViewRow newRow = new DataGridViewRow();
                        var cell0 = new DataGridViewTextBoxCell();
                        cell0.Value = pur.id;
                        newRow.Cells.Add(cell0);

                        //var cell1 = new DataGridViewTextBoxCell();
                        //cell1.Value = Catalog.purchasesNames[pur.purchaseMethodID];
                        //newRow.Cells.Add(cell1);

                        var cell7 = new DataGridViewTextBoxCell();
                        cell7.Value = Catalog.laws[pur.law];
                        newRow.Cells.Add(cell7);


                        var cell2 = new DataGridViewTextBoxCell();
                        cell2.Value = pur.purchaseName;
                        newRow.Cells.Add(cell2);

                        var cell8 = new DataGridViewTextBoxCell();
                        cell8.Value = pur.withAZK == 1 ? "Без АЦК" : "В АЦК";
                        newRow.Cells.Add(cell8);

                        //var cell3 = new DataGridViewTextBoxCell();
                        //cell3.Value = Catalog.statusesNames[pur.statusID];
                        //newRow.Cells.Add(cell3);

                        var cell4 = new DataGridViewTextBoxCell();
                        cell4.Value = HandleDate(pur.purchaseEisDate);
                        newRow.Cells.Add(cell4);

                        var cell5 = new DataGridViewTextBoxCell();
                        cell5.Value = Program.dataManager.userNames[pur.employeID.ToString()];
                        newRow.Cells.Add(cell5);

                        var cell6 = new DataGridViewTextBoxCell();
                        cell6.Value = pur.comments;
                        newRow.Cells.Add(cell6);                        
                       
                        RecolorRow(newRow, pur.statusID);

                        dataGridView1.Rows.Add(newRow);

                    }
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
                case 5: color = Color.LightBlue; break;
                case 6: color = Color.Yellow; break;
                case 7: color = Color.LightPink; break;
                case 8: color = Color.Red; break;
            }

            //  row.Cells[5].Style.BackColor = color;

            DataGridViewRow tempRow = new DataGridViewRow();
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
