using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Aura.Model;
using Aura_Client.Model;

namespace Aura_Client.View
{
    public partial class ToExcelForm : AuraForm
    {
        //основное окно формы, и общие элементы
        private string filePath = Environment.GetFolderPath
            (Environment.SpecialFolder.Desktop) + @"\Aura export.xlsx";
        

        public ToExcelForm()
        {
            InitializeComponent();
        }

        private void ToExcelForm_Load(object sender, EventArgs e)
        {           
            RefreshFilePathText();
            creator = new Controller.CommandStringCreator();
            InitToolTips();
            LoadCatalogs();
            InitOrgContextMenuStrip();
            InitPurContextMenuStrip();
            InitializeSaveFileDialog();
            sqlQueryTextBox.Text = "SELECT * FROM Organisations";
            ClearOrgsPanel();
            ClearPurPanel();

        }

        private void InitToolTips()
        {
            toolTip1.SetToolTip(org_clearFilterButton, "Сбросить настройки");
            toolTip1.SetToolTip(org_columnsOptionsButton, "Настроить поля для вывода");
            toolTip1.SetToolTip(pur_clearFilterButton, "Сбросить настройки");
            toolTip1.SetToolTip(pur_columnsOptionsButton, "Настроить поля для вывода");
        }

        private void LoadCatalogs()
        {
            foreach (var item in Catalog.laws)
            {
                law.Items.Add(item);
                
            }

            foreach (var item in Catalog.contractTypes)
            {
                contractType.Items.Add(item);
            }


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

        }

        private void InitializeSaveFileDialog()
        {
            saveFileDialog1.Filter = "Таблица (*.xlsx)|*.xlsx|All files (*.*)|*.*";
        }


        private void RefreshFilePathText()
        {
            filePathTextBox.Text = filePath;
        }

        private void browseeButton_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = filePath;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filePath = saveFileDialog1.FileName;
                RefreshFilePathText();
            }
        }


        protected override void textBox_ValueChanged(object sender, EventArgs e)
        {
            var textBox = (TextBoxBase)sender;
            string name = textBox.Name.Replace("org_", "").Replace("pur_", "");
            creator.AddFilter(name, textBox.Text);

        }

        protected override void comboBox_ValueChanged(object sender, EventArgs e)
        {
            var box = (ComboBox)sender;
            string name = box.Name.Replace("org_", "").Replace("pur_", "");
            creator.AddFilter(name, box.SelectedIndex.ToString());

        }


        private void FieldOnClick(object sender, EventArgs eventArgs)
        {
            //добавить / убрать поле в таблицу на вывод
            var target = (ToolStripMenuItem)sender;

            if (target.Checked)
            {
                creator.RemoveField(target.Name);
            }

            else
            {
                creator.AddField(target.Name);
            }

            target.Checked = !target.Checked;



        }

        private void RefreshContextMenuStrip(ContextMenuStrip strip)
        {
            foreach (ToolStripMenuItem item in strip.Items)
                item.Checked = false;
        }

        private void ClearCreator()
        {
            creator.ClearFields();
            creator.ClearFilters();
        }

        private void tabControl1_TabIndexChanged(object sender, EventArgs e)
        {
            ClearOrgsPanel();
            ClearPurPanel();
        }

        private void contextMenuStrip_Closing(object sender, ToolStripDropDownClosingEventArgs e)
        {
            if (e.CloseReason == ToolStripDropDownCloseReason.ItemClicked)
                e.Cancel = true;
        }


        private void SendRequest(string sqlCommand, string filePath)
        {
            try
            {
                string message = Program.dataManager.GetExcelFile
                     (filePath, sqlCommand);

                MessageBox.Show(message);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при создании отчета",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        //окно выгрузки по SQL-запросу
        private void clearQueryTextBoxButton_Click(object sender, EventArgs e)
        {
            sqlQueryTextBox.Text = "";
        }

        private void sendSQLqueryButton_Click(object sender, EventArgs e)
        {
            if (sqlQueryTextBox.Text != string.Empty)
            {
                string command = sqlQueryTextBox.Text;

                string controlResult;

                if (CorrectQuery(command, out controlResult))
                {
                    SendRequest(command, filePath);
                }

                else
                {
                    MessageBox.Show(controlResult, "Некорректный запрос",
                        MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
        }

        private bool CorrectQuery(string query, out string result)
        {
            string text = query.ToUpper();

            List<string> wrongWords = new List<string>()
            {
                "CREATE ",
                "ALTER ",
                "DROP ",
                "INSERT ",
                "UPDATE ",
                "DELETE ",
                "VACUUM ",
                "REINDEX ",
                "SET ",

            };

            foreach (var str in wrongWords)
            {
                if (text.Contains(str))
                {
                    result = "Нельзя использовать команду " + str;
                    return false;
                }
            }

            if (!text.Contains("SELECT "))
            {
                result = "Должна быть использована команда SELECT";
                return false;
            }

            result = "OK";
            return true;
        }

        


        //окно выгрузки организаций
        private void InitOrgContextMenuStrip()
        {
            //создаём временную таблицу 
            //(код скопирован из формы БД организаций, лень его переписывать)
            DataGridView organisationsDataGridView = new DataGridView();
            Controls.Add(organisationsDataGridView);

            #region CreateTempTable
            organisationsDataGridView.Columns.Add("id", "id");
            organisationsDataGridView.Columns["id"].Width = 50;

            organisationsDataGridView.Columns.Add("number", "№");
            organisationsDataGridView.Columns["number"].Width = 30;

            organisationsDataGridView.Columns.Add("name", "Наименование");
            organisationsDataGridView.Columns["name"].Width = 250;

            organisationsDataGridView.Columns.Add("inn", "ИНН");
            organisationsDataGridView.Columns["inn"].Width = 150;

            organisationsDataGridView.Columns.Add("phoneNumber", "Телефон");
            organisationsDataGridView.Columns["phoneNumber"].Width = 100;

            organisationsDataGridView.Columns.Add("contactName", "Контактное лицо");
            organisationsDataGridView.Columns["contactName"].Width = 150;

            organisationsDataGridView.Columns.Add("email", "email");
            organisationsDataGridView.Columns["email"].Width = 150;

            organisationsDataGridView.Columns.Add("originalID", "Оригинал");
            organisationsDataGridView.Columns["originalID"].Width = 100;

            organisationsDataGridView.Columns.Add("contractNumber", "Номер договора");
            organisationsDataGridView.Columns["contractNumber"].Width = 150;

            organisationsDataGridView.Columns.Add("contractStart", "Срок с");
            organisationsDataGridView.Columns["contractStart"].Width = 100;

            organisationsDataGridView.Columns.Add("contractEnd", "Срок по");
            organisationsDataGridView.Columns["contractEnd"].Width = 100;

            organisationsDataGridView.Columns.Add("comments", "Комментарии");
            organisationsDataGridView.Columns["comments"].Width = 200;

            organisationsDataGridView.Columns.Add("contractCondition", "Состояние");
            organisationsDataGridView.Columns["contractCondition"].Width = 100;

            organisationsDataGridView.Columns.Add("law", "Закон");
            organisationsDataGridView.Columns["law"].Width = 50;

            organisationsDataGridView.Columns.Add("contractType", "Тип");
            organisationsDataGridView.Columns["contractType"].Width = 100;
            #endregion

            //из временной таблицы переносим названия полей в contextMenuStrip
            foreach (ToolStripMenuItem item in org_contextMenuStrip.Items)
            {
                item.Click -= FieldOnClick;
            }

            org_contextMenuStrip.Items.Clear();

            foreach (DataGridViewColumn column in organisationsDataGridView.Columns)
            {
                var item = new ToolStripMenuItem()
                {
                    Checked = false,
                    Text = column.HeaderText,
                    Name = column.Name,
                };

                item.Click += FieldOnClick;
                org_contextMenuStrip.Items.Add(item);

            }

            //удаляем теперь уже ненужную таблицу
            Controls.Remove(organisationsDataGridView);

        }        
       
        private void org_sendRequestButton_Click(object sender, EventArgs e)
        {
            creator.SetTableName("Organisations");
            // MessageBox.Show(creator.ToFilterCommand());
            SendRequest(creator.ToFilterCommand(), filePath);
        }

        private void ClearOrgsPanel()
        {
            ClearCreator();

            inn.Clear();
            org_name.Clear();
            law.SelectedIndex = 0;
            contractType.SelectedIndex = 0;
            number_Equal.Clear();

            RefreshContextMenuStrip(org_contextMenuStrip);
        }


        private void org_clearFilterButton_Click(object sender, EventArgs e)
        {
            ClearOrgsPanel();
        }

        private void org_columnsOptionsButton_Click(object sender, EventArgs e)
        {
            org_contextMenuStrip.Show();
        }

        


        //окно выгрузки закупок
        private void InitPurContextMenuStrip()
        {
            //создаём временную таблицу 
            //(код скопирован из формы БД закупок, лень его переписывать)
            DataGridView purchasesDataGridView = new DataGridView();
            Controls.Add(purchasesDataGridView);

            #region CreatingTable
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

            #endregion

            //из временной таблицы переносим названия полей в contextMenuStrip
            foreach (ToolStripItem item in pur_contextMenuStrip.Items)
            {
                item.Click -= FieldOnClick;
            }

            pur_contextMenuStrip.Items.Clear();

            foreach (DataGridViewColumn column in purchasesDataGridView.Columns)
            {
                var item = new ToolStripMenuItem()
                {
                    Checked = false,
                    Text = column.HeaderText,
                    Name = column.Name,
                };

                item.Click += FieldOnClick;
                pur_contextMenuStrip.Items.Add(item);

            }

            //удаляем теперь уже ненужную таблицу
            Controls.Remove(purchasesDataGridView);


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

        private void pur_sendRequestButton_Click(object sender, EventArgs e)
        {
            creator.SetTableName("Purchases");
            // MessageBox.Show(creator.ToFilterCommand());
            SendRequest(creator.ToFilterCommand(), filePath);
        }

        private void ClearPurPanel()
        {
            ClearCreator();

            purchaseName.Clear();
            purchaseMethodID.SelectedIndex = 0;
            purchaseEisNum.Clear();
            statusID.SelectedIndex = 0;
            protocolStatusID.SelectedIndex = 0;
            organizationID_Equal.Clear();
            organisationInn.Clear();

            RefreshContextMenuStrip(pur_contextMenuStrip);

        }

      
        private void pur_clearFilterButton_Click(object sender, EventArgs e)
        {
            ClearPurPanel();
        }

        private void pur_columnsOptionsButton_Click(object sender, EventArgs e)
        {
            pur_contextMenuStrip.Show();
        }

        private void filePathTextBox_TextChanged(object sender, EventArgs e)
        {
            filePath = filePathTextBox.Text;
        }
    }


}
