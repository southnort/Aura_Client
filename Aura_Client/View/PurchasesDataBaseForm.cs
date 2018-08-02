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
           
            ReloadTable(Program.dataManager.purchases);

        }

        private void ReloadTable(Dictionary<string, Purchase> purchases)
        {
            ClearTable();
            FillTable(purchases);
        }

        private void FillTable(Dictionary<string, Purchase> purchases)
        {
            if (purchases.Count > 0)
            {
                foreach (var item in purchases)
                {
                    var pur = item.Value;
                    if (pur == null) return;


                    object[] newRow = new object[7];
                    newRow[0] = pur.id;
                    newRow[1] = Catalog.purchasesNames[pur.purchaseMethodID];
                    newRow[2] = pur.purchaseName;
                    newRow[3] = Catalog.statusesNames[pur.statusID];
                    newRow[4] = HandleDate(pur.purchaseEisDate);
                    newRow[5] = Program.dataManager.userNames[pur.employeID.ToString()];
                    newRow[6] = pur.comments;


                    //object[] newRow = new object[]
                    //    {
                    //        pur.id,
                    //        Catalog.purchasesNames[pur.purchaseMethodID],
                    //        pur.purchaseName,
                    //        Catalog.statusesNames[pur.statusID],
                    //        HandleDate(pur.purchaseEisDate),
                    //        Program.dataManager.userNames[pur.employeID.ToString()],
                    //        pur.comments,

                    //    };


                    dataGridView1.Rows.Add(newRow);
                    



                }
            }
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
            //if (result == DialogResult.OK)
            //{
            //    adapter.AddUser(form.returnUser);
            //    ReloadTable(adapter.GetUsersInTable());

            //}

        }





        private void button1_Click(object sender, EventArgs e)
        {
            ShowPurchase(new Purchase());
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dg = (DataGridView)sender;
            var purchaseID = dg.Rows[e.RowIndex].Cells[0].Value.ToString();
            Purchase purchase = Program.dataManager.purchases[purchaseID];

            ShowPurchase(purchase);
        }
    }
}
