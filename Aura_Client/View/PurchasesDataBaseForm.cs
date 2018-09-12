using Aura.Model;
using Aura_Client.Model;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Aura_Client.View
{
    public partial class PurchasesDataBaseForm : AuraForm
    {

        public PurchasesDataBaseForm() : base()
        {
            InitializeComponent();

            LoadCatalogs();
            creator = new Controller.CommandStringCreator("Purchases");
            CreateTable();
            InitContextMenuStrip();
            ReloadTable();

        }


        private void LoadCatalogs()
        {
            //заполнить справочники для выпадающих меню

            //способы определения поставщика
            for (int i = 0; i < Catalog.purchaseMethods.Count; i++)
            {
                ComboBoxItem item = new ComboBoxItem();
                item.Text = Catalog.purchaseMethods[i].name;
                item.Value = i;

                purchaseMethodID.Items.Add(item);

            }

            //статусы протоколов
            for (int i = 0; i < Catalog.protocolStatuses.Count; i++)
            {
                ComboBoxItem item = new ComboBoxItem();
                item.Text = Catalog.protocolStatuses[i];
                item.Value = i;

                protocolStatusID.Items.Add(item);

            }


            //статусы закупки
            for (int i = 0; i < Catalog.allStatuses.Count; i++)
            {
                ComboBoxItem item = new ComboBoxItem();
                item.Text = Catalog.allStatuses[i];
                item.Value = i;

                statusID.Items.Add(item);
            }

            ////ответственный за разработку документации            
            ////foreach (var user in Program.dataManager.GetUserNames())
            //{
            //    ComboBoxItem item = new ComboBoxItem();
            //    item.Text = user.Value;
            //    item.Value = int.Parse(user.Key);

            //    employeDocumentationID.Items.Add(item);

            //}

            ////ответственный за размещение закупки            
            //foreach (var user in Program.dataManager.GetUserNames())
            //{
            //    ComboBoxItem item = new ComboBoxItem();
            //    item.Text = user.Value;
            //    item.Value = int.Parse(user.Key);

            //    employeID.Items.Add(item);

            //}

            ////закон, по которой проводится закупка
            //for (int i = 0; i < 3; i++)
            //{
            //    law.Items.Add(new ComboBoxItem() { Text = Catalog.laws[i], Value = i });
            //}

            ////с АЦК или без неё

            //withAZK.Items.Add(new ComboBoxItem() { Text = "С АЦК", Value = 0, });
            //withAZK.Items.Add(new ComboBoxItem() { Text = "БЕЗ АЦК", Value = 1, });


            purchaseMethodID.MouseWheel += new MouseEventHandler(comboBox_ValueChanged);
            statusID.MouseWheel += new MouseEventHandler(comboBox_ValueChanged);
            protocolStatusID.MouseWheel += new MouseEventHandler(comboBox_ValueChanged);
            //employeDocumentationID.MouseWheel += new MouseEventHandler(comboBox_ValueChanged);
            //employeID.MouseWheel += new MouseEventHandler(comboBox_ValueChanged);
            //law.MouseWheel += new MouseEventHandler(comboBox_ValueChanged);
            //withAZK.MouseWheel += new MouseEventHandler(comboBox_ValueChanged);

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



            SetColumnOrder(purchasesDataGridView);

        }

        private void ReloadTable()
        {
            ClearTable();
            FillTable(Program.dataManager.GetFilteredPurchases(creator.ToFilterCommand()));
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
                                orgs.SingleOrDefault(o => o.id == pur.organizationID).name;

                            newRow.Cells["purchaseMethodID"].Value =
                                Catalog.purchaseMethods[pur.purchaseMethodID].name;

                            newRow.Cells["purchaseName"].Value = pur.purchaseName;

                            newRow.Cells["statusID"].Value = Catalog.allStatuses[pur.statusID];

                            newRow.Cells["purchacePrice"].Value = pur.purchacePrice.ToString("### ### ### ### ###.##");

                            newRow.Cells["purchaseEisNum"].Value = pur.purchaseEisNum;

                            newRow.Cells["purchaseEisDate"].Value = ConvertDateToText(pur.purchaseEisDate);

                            newRow.Cells["bidsStartDate"].Value = ConvertDateToText(pur.bidsStartDate);

                            newRow.Cells["bidsEndDate"].Value = ConvertDateToText(pur.bidsEndDate);

                            newRow.Cells["bidsOpenDate"].Value = ConvertDateToText(pur.bidsOpenDate);

                            newRow.Cells["bidsFirstPartDate"].Value = ConvertDateToText(pur.bidsFirstPartDate);

                            newRow.Cells["auctionDate"].Value = ConvertDateToText(pur.auctionDate);

                            newRow.Cells["bidsSecondPartDate"].Value = ConvertDateToText(pur.bidsSecondPartDate);

                            newRow.Cells["bidsFinishDate"].Value = ConvertDateToText(pur.bidsFinishDate);

                            newRow.Cells["contractPrice"].Value = pur.contractPrice.ToString("### ### ### ### ### ### ###.##");

                            newRow.Cells["contractDateReal"].Value = ConvertDateToText(pur.contractDateReal);

                            newRow.Cells["reestrDateLast"].Value = ConvertDateToText(pur.reestrDateLast);

                            newRow.Cells["reestrNumber"].Value = pur.reestrNumber;

                            newRow.Cells["comments"].Value = pur.comments;

                            switch (pur.law)
                            {
                                case 1: newRow.Cells["law"].Value = "44 ФЗ"; break;
                                case 2: newRow.Cells["law"].Value = "223 ФЗ"; break;
                                default: newRow.Cells["law"].Value = ""; break;
                            }

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

                            newRow.Cells["bidsReviewDate"].Value = ConvertDateToText(pur.bidsReviewDate);

                            newRow.Cells["bidsRatingDate"].Value = ConvertDateToText(pur.bidsRatingDate);

                            newRow.Cells["controlStatus"].Value =
                                  pur.controlStatus == 1;

                            newRow.Cells["colorMark"].Style.BackColor = Color.FromArgb(pur.colorMark);

                            newRow.Cells["employeReestID"].Value = users[pur.employeReestID.ToString()];

                            newRow.Cells["reestrStatus"].Value =
                                pur.reestrStatus == 1;

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


        private void InitToolTips()
        {
            toolTip1.SetToolTip(refreshButton, "Обновить");
            toolTip1.SetToolTip(columnsOptionsButton, "Настроить список");
            toolTip1.SetToolTip(clearFilterButton, "Очистить фильтр");

        }

        private void InitContextMenuStrip()
        {
            foreach (ToolStripMenuItem item in contextMenuStrip1.Items)
            {
                item.Click -= MenuItemOnClick;
            }

            contextMenuStrip1.Items.Clear();

            foreach (DataGridViewColumn column in purchasesDataGridView.Columns)
            {
                var item = new ToolStripMenuItem()
                {
                    Checked = column.Visible,
                    Text = column.HeaderText,
                    Name = column.Name,
                };

                item.Click += MenuItemOnClick;
                contextMenuStrip1.Items.Add(item);

            }


        }

        private void MenuItemOnClick(object sender, EventArgs eventArgs)
        {
            var target = (ToolStripMenuItem)sender;

            target.Checked = !target.Checked;

            purchasesDataGridView.Columns[target.Name].Visible = target.Checked;
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


        protected override void textBox_ValueChanged(object sender, EventArgs e)
        {
            if (sender is TextBox)
            {
                var textBox = (TextBox)sender;
                creator.AddFilter(textBox.Name, textBox.Text);
            }

            if (sender is RichTextBox)
            {
                var textBox = (RichTextBox)sender;
                creator.Add(textBox.Name, textBox.Text);
            }

        }

        protected override void comboBox_ValueChanged(object sender, EventArgs e)
        {
            var box = (ComboBox)sender;
            creator.AddFilter(box.Name, box.SelectedIndex.ToString());
        }

        private void anyKey_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ReloadTable();
            }

        }


        private void PurchasesDataBaseForm_Load(object sender, EventArgs e)
        {
            InitToolTips();
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
                var purchaseID = dg.Rows[e.RowIndex].Cells["id"].Value.ToString();
                Purchase purchase = Program.dataManager.GetPurchase(purchaseID);
                ShowPurchase(purchase);
            }

        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            ReloadTable();
        }

        private void PurchasesDataBaseForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveColumnOrder(purchasesDataGridView);
        }

        private void columnsOptionsButton_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show();
        }

        private void deletePurchaseButton_Click(object sender, EventArgs e)
        {
            if (purchasesDataGridView.CurrentRow != null)
            {
                string id = purchasesDataGridView.CurrentRow.Cells["id"].Value.ToString();
                Purchase pur = Program.dataManager.GetPurchase(id);

                string text = "Вы действительно хотите удалить закупку\n" + pur.purchaseName + "?";
                DialogResult dialogResult = MessageBox.Show(text,
                    "Подтвердите удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    Program.dataManager.DeletePurchase(id);
                    ReloadTable();

                }
            }


        }

        private void clearFilterButton_Click(object sender, EventArgs e)
        {
            purchaseName.Clear();
            purchaseMethodID.SelectedIndex = 0;
            purchaseEisNum.Clear();
            statusID.SelectedIndex = 0;
            protocolStatusID.SelectedIndex = 0;

            creator.ClearFilters();
            
        }

        private void contextMenuStrip1_Closing(object sender, ToolStripDropDownClosingEventArgs e)
        {
            if (e.CloseReason == ToolStripDropDownCloseReason.ItemClicked)
                e.Cancel = true;
        }
    }
}
