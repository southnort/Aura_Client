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
            purchasesDataGridView.Columns.Add("id", "id");
            purchasesDataGridView.Columns["id"].Width = 50;

            purchasesDataGridView.Columns.Add("employeID", "Ответственный за размещение");
            purchasesDataGridView.Columns["employeID"].Width = 200;

            purchasesDataGridView.Columns.Add("organizationID", "Заказчик");
            purchasesDataGridView.Columns["organizationID"].Width = 150;

            purchasesDataGridView.Columns.Add("purchaseMethodID", "Способ");
            purchasesDataGridView.Columns["purchaseMethodID"].Width = 150;

            purchasesDataGridView.Columns.Add("purchaseName", "Наименование закупки");
            purchasesDataGridView.Columns["purchaseName"].Width = 200;

            purchasesDataGridView.Columns.Add("statusID", "Статус");
            purchasesDataGridView.Columns["statusID"].Width = 150;

            purchasesDataGridView.Columns.Add("purchacePrice", "Сумма закупки");
            purchasesDataGridView.Columns["purchacePrice"].Width = 100;

            purchasesDataGridView.Columns.Add("purchaseEisNum", "Реестровый №");
            purchasesDataGridView.Columns["purchaseEisNum"].Width = 100;

            purchasesDataGridView.Columns.Add("purchaseEisDate", "Дата публикации извещения");
            purchasesDataGridView.Columns["purchaseEisDate"].Width = 100;

            purchasesDataGridView.Columns.Add("bidsStartDate", "Начало подачи заявок");
            purchasesDataGridView.Columns["bidsStartDate"].Width = 100;

            purchasesDataGridView.Columns.Add("bidsEndDate", "Окончание подачи заявок");
            purchasesDataGridView.Columns["bidsEndDate"].Width = 100;

            purchasesDataGridView.Columns.Add("bidsOpenDate", "Дата вскрытия конвертов");
            purchasesDataGridView.Columns["bidsOpenDate"].Width = 100;

            purchasesDataGridView.Columns.Add("bidsFirstPartDate", "Рассмотрение первых частей");
            purchasesDataGridView.Columns["bidsFirstPartDate"].Width = 100;

            purchasesDataGridView.Columns.Add("auctionDate", "Дата аукциона");
            purchasesDataGridView.Columns["auctionDate"].Width = 100;

            purchasesDataGridView.Columns.Add("bidsSecondPartDate", "Рассмотрение вторых частей");
            purchasesDataGridView.Columns["bidsSecondPartDate"].Width = 100;

            purchasesDataGridView.Columns.Add("bidsFinishDate", "Дата подведения итогов");
            purchasesDataGridView.Columns["bidsFinishDate"].Width = 100;

            purchasesDataGridView.Columns.Add("contractPrice", "Сумма договора");
            purchasesDataGridView.Columns["contractPrice"].Width = 100;

            purchasesDataGridView.Columns.Add("contractDateReal", "Дата подписания");
            purchasesDataGridView.Columns["contractDateReal"].Width = 100;

            purchasesDataGridView.Columns.Add("reestrDateLast", "Дата внесения в реестр");
            purchasesDataGridView.Columns["reestrDateLast"].Width = 100;

            purchasesDataGridView.Columns.Add("reestrNumber", "Реестровый номер договора");
            purchasesDataGridView.Columns["reestrNumber"].Width = 100;

            purchasesDataGridView.Columns.Add("comments", "Комментарии");
            purchasesDataGridView.Columns["comments"].Width = 100;

            purchasesDataGridView.Columns.Add("law", "Закон");
            purchasesDataGridView.Columns["law"].Width = 50;

            purchasesDataGridView.Columns.Add("withAZK", "АЦК");
            purchasesDataGridView.Columns["withAZK"].Width = 50;

            purchasesDataGridView.Columns.Add("employeDocumentationID", "Ответственный за документацию");
            purchasesDataGridView.Columns["employeDocumentationID"].Width = 200;

            purchasesDataGridView.Columns.Add("resultOfControl", "Результаты проверки");
            purchasesDataGridView.Columns["resultOfControl"].Width = 200;

            purchasesDataGridView.Columns.Add("protocolStatusID", "Статус протокола");
            purchasesDataGridView.Columns["protocolStatusID"].Width = 100;

            purchasesDataGridView.Columns.Add("bidsReviewDate", "Дата рассмотрения заявок");
            purchasesDataGridView.Columns["bidsReviewDate"].Width = 100;

            purchasesDataGridView.Columns.Add("bidsRatingDate", "Дата оценки заявок");
            purchasesDataGridView.Columns["bidsRatingDate"].Width = 100;

            DataGridViewCheckBoxColumn checkColumn = new DataGridViewCheckBoxColumn();
            checkColumn.Name = "controlStatus";
            checkColumn.HeaderText = "Пров.";
            purchasesDataGridView.Columns.Add(checkColumn);
            purchasesDataGridView.Columns["controlStatus"].Width = 20;

            purchasesDataGridView.Columns.Add("colorMark", "Метка");
            purchasesDataGridView.Columns["colorMark"].Width = 45;

            purchasesDataGridView.Columns.Add("employeReestID", "Ответственный за реестр");
            purchasesDataGridView.Columns["employeReestID"].Width = 100;

            checkColumn = new DataGridViewCheckBoxColumn();
            checkColumn.Name = "reestrStatus";
            checkColumn.HeaderText = "Внесено";
            purchasesDataGridView.Columns.Add(checkColumn);
            purchasesDataGridView.Columns["reestrStatus"].Width = 60;


        }

        private void ReloadTable()
        {
            ClearTable();
            FillTable(Program.dataManager.GetAllPurchases());
        }

        private void FillTable(List<Purchase> purchases)
        {
            var users = Program.dataManager.GetUserNames();
            var orgs = Program.dataManager.GetAllOrganisations();

            if (purchases.Count > 0)
            {
                foreach (var pur in purchases)
                {
                    if (pur != null)
                    {
                        //проверяем закупку на необходимость добавления
                        if (VisiblePurchase(pur))
                        {
                            int rowIndex = purchasesDataGridView.Rows.Add();
                            var newRow = purchasesDataGridView.Rows[rowIndex];


                            newRow.Cells["id"].Value = pur.id;

                            newRow.Cells["employeID"].Value =
                                users[pur.employeID.ToString()];


                            newRow.Cells["organizationID"].Value =
                                pur.organizationID == 0 ? "<не указано>" :
                                orgs[pur.organizationID - 1].name;

                            newRow.Cells["purchaseMethodID"].Value =
                                Catalog.purchaseMethods[pur.purchaseMethodID].name;

                            newRow.Cells["purchaseName"].Value = pur.purchaseName;

                            newRow.Cells["statusID"].Value = Catalog.allStatuses[pur.statusID];

                            newRow.Cells["purchacePrice"].Value = pur.purchacePrice.ToString("### ### ### ### ###.##");

                            newRow.Cells["purchaseEisNum"].Value = pur.purchaseEisNum;

                            newRow.Cells["withAZK"].Value = pur.withAZK == 0 ? "С АЦК" : "БЕЗ АЦК";

                            newRow.Cells["employeDocumentationID"].Value =
                                users[pur.employeDocumentationID.ToString()];

                            newRow.Cells["resultOfControl"].Value = pur.resultOfControl;
                            if (pur.resultOfControlColor != 0)
                            {
                                newRow.Cells["resultOfControl"].Style.ForeColor =
                                    Color.FromArgb(pur.resultOfControlColor);
                            }

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

                            newRow.Cells["colorMark"].Style.BackColor = Color.FromArgb(pur.colorMark);

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
            if (purchasesDataGridView.Rows.Count > 0)
            {
                purchasesDataGridView.Rows.Clear();
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





        private void addNewPurchaseButton_Click(object sender, EventArgs e)
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

        private void resreshButton_Click(object sender, EventArgs e)
        {
            ReloadTable();
        }
    }
}
