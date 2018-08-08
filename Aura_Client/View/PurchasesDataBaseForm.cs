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

            CreateTable();
            ReloadTable();

        }

        private void CreateTable()
        {
            //программно создаем колонки в таблице
            dgv.Columns.Add("id", "id");
            dgv.Columns["id"].Width = 50;

            dgv.Columns.Add("organizationID", "Заказчик");
            dgv.Columns["organizationID"].Width = 150;

            dgv.Columns.Add("purchaseName", "Наименование закупки");
            dgv.Columns["purchaseName"].Width = 200;

            dgv.Columns.Add("purchaseMethodID", "Способ");
            dgv.Columns["purchaseMethodID"].Width = 150;

            dgv.Columns.Add("statusID", "Статус");
            dgv.Columns["statusID"].Width = 150;

            dgv.Columns.Add("protocolStatusID", "Статус протокола");
            dgv.Columns["protocolStatusID"].Width = 100;

            dgv.Columns.Add("purchacePrice", "Сумма закупки");
            dgv.Columns["purchacePrice"].Width = 100;

            dgv.Columns.Add("withAZK", "АЦК");
            dgv.Columns["withAZK"].Width = 50;

            dgv.Columns.Add("purchaseEisNum", "Реестровый №");
            dgv.Columns["purchaseEisNum"].Width = 100;

            dgv.Columns.Add("employeID", "Ответственный за размещение");
            dgv.Columns["employeID"].Width = 200;

            dgv.Columns.Add("employeDocumentationID", "Ответственный за подготовку");
            dgv.Columns["employeDocumentationID"].Width = 200;

            DataGridViewCheckBoxColumn checkColumn = new DataGridViewCheckBoxColumn();
            checkColumn.Name = "controlStatus";
            checkColumn.HeaderText = "Пров.";
            dgv.Columns.Add(checkColumn);
            dgv.Columns["controlStatus"].Width = 20;

            dgv.Columns.Add("resultOfControl", "Результаты проверки");
            dgv.Columns["resultOfControl"].Width = 200;



            

            //dgv.Columns.Add("comments", "Комментарии");
            //dgv.Columns["comments"].Width = 200;

            //dgv.Columns.Add("law", "Закон");
            //dgv.Columns["law"].Width = 50;
            

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
                    if (pur != null)
                    {
                        //проверяем закупку на необходимость добавления
                        if (VisiblePurchase(pur))
                        {
                            int rowIndex = dgv.Rows.Add();
                            var newRow = dgv.Rows[rowIndex];


                            newRow.Cells["id"].Value = pur.id;

                            newRow.Cells["employeID"].Value =
                                Program.dataManager.userNames[pur.employeID.ToString()];

                            newRow.Cells["organizationID"].Value =
                                Program.dataManager.GetAllOrganisations()[pur.organizationID].name;

                            newRow.Cells["purchaseMethodID"].Value =
                                Catalog.purchaseMethods[pur.purchaseMethodID].name;

                            newRow.Cells["purchaseName"].Value = pur.purchaseName;

                            newRow.Cells["statusID"].Value = Catalog.allStatuses[pur.statusID];

                            newRow.Cells["purchacePrice"].Value = pur.purchacePrice.ToString("### ### ### ### ###.##");

                            newRow.Cells["purchaseEisNum"].Value = pur.purchaseEisNum;

                            newRow.Cells["withAZK"].Value = pur.withAZK == 0 ? "С АЦК" : "БЕЗ АЦК";

                            newRow.Cells["employeDocumentationID"].Value =
                                Program.dataManager.userNames[pur.employeDocumentationID.ToString()];

                            newRow.Cells["resultOfControl"].Value = pur.resultOfControl;

                            newRow.Cells["protocolStatusID"].Value =
                                Catalog.protocolStatuses[pur.protocolStatusID];
                            Color color = Color.White;
                            switch (pur.protocolStatusID)
                            {
                                case 1: color = Color.DodgerBlue; break;
                                case 2: color = Color.Yellow; break;
                                case 3: color = Color.LightPink; break;
                                case 4: color = Color.LightCoral; break;
                                case 5: color = Color.LightGreen; break;
                            }
                            newRow.Cells["protocolStatusID"].Style.BackColor = color;
                            // newRow.DefaultCellStyle.BackColor = color;

                            newRow.Cells["controlStatus"].Value =
                                  pur.controlStatus == 1;


                        }


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
            if (dgv.Rows.Count > 0)
            {
                dgv.Rows.Clear();
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
