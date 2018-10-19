using Aura.Model;
using Aura_Client.Model;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace Aura_Client.View
{
    public partial class ReestrDataBaseForm : AuraForm
    {
        public ReestrDataBaseForm() : base()
        {
            InitializeComponent();
            InitializeAuraForm();

            LoadCatalogs();
            creator = new Controller.CommandStringCreator("Purchases");
            RefreshCreator();
            CreateTable();
            InitContextMenuStrip();
            ReloadTable();
        }

        private void CreateTable()
        {
            //программно создаем колонки в таблице
            reestrDataGridView.Columns.Add("id", "id");
            reestrDataGridView.Columns["id"].Width = 50;

            reestrDataGridView.Columns.Add("employeID", "Ответственный за размещение");
            reestrDataGridView.Columns["employeID"].Width = 200;

            reestrDataGridView.Columns.Add("organizationID", "Заказчик");
            reestrDataGridView.Columns["organizationID"].Width = 150;

            reestrDataGridView.Columns.Add("purchaseMethodID", "Способ");
            reestrDataGridView.Columns["purchaseMethodID"].Width = 150;

            reestrDataGridView.Columns.Add("purchaseName", "Наименование закупки");
            reestrDataGridView.Columns["purchaseName"].Width = 200;

            reestrDataGridView.Columns.Add("statusID", "Статус");
            reestrDataGridView.Columns["statusID"].Width = 150;

            reestrDataGridView.Columns.Add("purchacePrice", "Сумма закупки");
            reestrDataGridView.Columns["purchacePrice"].Width = 100;

            reestrDataGridView.Columns.Add("purchaseEisNum", "Реестровый №");
            reestrDataGridView.Columns["purchaseEisNum"].Width = 100;

            reestrDataGridView.Columns.Add("purchaseEisDate", "Дата публикации извещения");
            reestrDataGridView.Columns["purchaseEisDate"].Width = 100;

            reestrDataGridView.Columns.Add("bidsStartDate", "Начало подачи заявок");
            reestrDataGridView.Columns["bidsStartDate"].Width = 100;

            reestrDataGridView.Columns.Add("bidsEndDate", "Окончание подачи заявок");
            reestrDataGridView.Columns["bidsEndDate"].Width = 100;

            reestrDataGridView.Columns.Add("bidsOpenDate", "Дата вскрытия конвертов");
            reestrDataGridView.Columns["bidsOpenDate"].Width = 100;

            reestrDataGridView.Columns.Add("bidsFirstPartDate", "Рассмотрение первых частей");
            reestrDataGridView.Columns["bidsFirstPartDate"].Width = 100;

            reestrDataGridView.Columns.Add("auctionDate", "Дата аукциона");
            reestrDataGridView.Columns["auctionDate"].Width = 100;

            reestrDataGridView.Columns.Add("bidsSecondPartDate", "Рассмотрение вторых частей");
            reestrDataGridView.Columns["bidsSecondPartDate"].Width = 100;

            reestrDataGridView.Columns.Add("bidsFinishDate", "Дата подведения итогов");
            reestrDataGridView.Columns["bidsFinishDate"].Width = 100;

            reestrDataGridView.Columns.Add("contractPrice", "Сумма договора");
            reestrDataGridView.Columns["contractPrice"].Width = 100;

            reestrDataGridView.Columns.Add("contractDateReal", "Дата подписания");
            reestrDataGridView.Columns["contractDateReal"].Width = 100;

            reestrDataGridView.Columns.Add("reestrDateLast", "Дата внесения в реестр");
            reestrDataGridView.Columns["reestrDateLast"].Width = 100;

            reestrDataGridView.Columns.Add("reestrNumber", "Реестровый номер договора");
            reestrDataGridView.Columns["reestrNumber"].Width = 100;

            reestrDataGridView.Columns.Add("comments", "Комментарии");
            reestrDataGridView.Columns["comments"].Width = 100;

            reestrDataGridView.Columns.Add("law", "Закон");
            reestrDataGridView.Columns["law"].Width = 50;

            reestrDataGridView.Columns.Add("withAZK", "АЦК");
            reestrDataGridView.Columns["withAZK"].Width = 50;

            reestrDataGridView.Columns.Add("employeDocumentationID", "Ответственный за документацию");
            reestrDataGridView.Columns["employeDocumentationID"].Width = 200;

            reestrDataGridView.Columns.Add("resultOfControl", "Результаты проверки");
            reestrDataGridView.Columns["resultOfControl"].Width = 200;

            reestrDataGridView.Columns.Add("protocolStatusID", "Статус протокола");
            reestrDataGridView.Columns["protocolStatusID"].Width = 100;

            reestrDataGridView.Columns.Add("bidsReviewDate", "Дата рассмотрения заявок");
            reestrDataGridView.Columns["bidsReviewDate"].Width = 100;

            reestrDataGridView.Columns.Add("bidsRatingDate", "Дата оценки заявок");
            reestrDataGridView.Columns["bidsRatingDate"].Width = 100;

            DataGridViewCheckBoxColumn checkColumn = new DataGridViewCheckBoxColumn();
            checkColumn.Name = "controlStatus";
            checkColumn.HeaderText = "Пров.";
            reestrDataGridView.Columns.Add(checkColumn);
            reestrDataGridView.Columns["controlStatus"].Width = 20;

            reestrDataGridView.Columns.Add("colorMark", "Метка");
            reestrDataGridView.Columns["colorMark"].Width = 45;

            reestrDataGridView.Columns.Add("employeReestID", "Ответственный за реестр");
            reestrDataGridView.Columns["employeReestID"].Width = 100;

            checkColumn = new DataGridViewCheckBoxColumn();
            checkColumn.Name = "reestrStatus";
            checkColumn.HeaderText = "Внесено";
            reestrDataGridView.Columns.Add(checkColumn);
            reestrDataGridView.Columns["reestrStatus"].Width = 60;



            SetColumnOrder(reestrDataGridView);

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

            ////статусы протоколов
            //for (int i = 0; i < Catalog.protocolStatuses.Count; i++)
            //{
            //    ComboBoxItem item = new ComboBoxItem();
            //    item.Text = Catalog.protocolStatuses[i];
            //    item.Value = i;

            //    protocolStatusID.Items.Add(item);

            //}

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


            //purchaseMethodID.MouseWheel += new MouseEventHandler(comboBox_ValueChanged);
            //statusID.MouseWheel += new MouseEventHandler(comboBox_ValueChanged);
            //protocolStatusID.MouseWheel += new MouseEventHandler(comboBox_ValueChanged);
            //employeDocumentationID.MouseWheel += new MouseEventHandler(comboBox_ValueChanged);
            //employeID.MouseWheel += new MouseEventHandler(comboBox_ValueChanged);
            //law.MouseWheel += new MouseEventHandler(comboBox_ValueChanged);
            //withAZK.MouseWheel += new MouseEventHandler(comboBox_ValueChanged);

        }

        private void RefreshCreator()
        {
            //при открытии окна или при сбросе фильтрации нужно добавлять в фильтрацию статус закупки
            creator.AddFilter("statusID_Min", "8");
        }



        private void InitToolTips()
        {
            toolTip1.SetToolTip(refreshButton, "Обновить");
            toolTip1.SetToolTip(columnsOptionsButton, "Настроить список");
            toolTip1.SetToolTip(clearFilterButton, "Очистить фильтра");

        }

        private void InitContextMenuStrip()
        {
            foreach (ToolStripMenuItem item in contextMenuStrip1.Items)
            {
                item.Click -= MenuItemOnClick;
            }

            contextMenuStrip1.Items.Clear();

            foreach (DataGridViewColumn column in reestrDataGridView.Columns)
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

            reestrDataGridView.Columns[target.Name].Visible = target.Checked;
        }




        private void ReloadTable()
        {
            ClearTable();
            FillTable(Program.dataManager.GetReestr(creator.ToFilterCommand()));
        }

        private void ClearTable()
        {
            if (reestrDataGridView.Rows.Count > 0)
            {
                reestrDataGridView.Rows.Clear();
            }

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
                        int rowIndex = reestrDataGridView.Rows.Add();
                        var newRow = reestrDataGridView.Rows[rowIndex];


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

        private void columnsOptionsButton_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show();
        }

        private void ReestrDataBaseForm_Load(object sender, EventArgs e)
        {
            InitToolTips();
        }

        private void ReestrDataBaseForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveColumnOrder(reestrDataGridView);
        }

        private void clearFilterButton_Click(object sender, EventArgs e)
        {
            purchaseName.Clear();
            purchaseMethodID.SelectedIndex = 0;
            reestrNumber.Clear();
            purchaseEisNum.Clear();
            organizationID_Equal.Clear();
            organisationInn.Clear();

            creator.ClearFilters();
            RefreshCreator();
        }

        private void addNewPurchaseButton_Click(object sender, EventArgs e)
        {
            ShowPurchase(
                new Purchase
                {
                    purchaseMethodID = 1,
                    statusID = 8,
                    withoutPurchase = 1,

                }
                );

        }

        private void contextMenuStrip1_Closing(object sender, ToolStripDropDownClosingEventArgs e)
        {
            if (e.CloseReason == ToolStripDropDownCloseReason.ItemClicked)
                e.Cancel = true;
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            ReloadTable();
        }

        private void ReestrDataBaseForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                label1.Focus();
                ReloadTable();
            }

            if (e.KeyCode == Keys.Escape)
            {
                DialogResult = DialogResult.Cancel;
            }
        }

        private void organisationSelectButton_Click(object sender, EventArgs e)
        {
            var form = new OrganisationsDataBaseForm(false);
            var result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                Organisation org = form.returnedOrganisation;
                creator.AddFilter("organizationID_Equal", org.id.ToString());
                organizationID_Equal.Text = org.name;
            }
        }
    }
}
