using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Aura.Model;
using Aura_Client.Model;

namespace Aura_Client.View
{
    public partial class OrganisationsDataBaseForm : AuraForm
    {
        public Organisation returnedOrganisation;
        private bool onlyShowing;       //режим отображения таблицы. 
                                        //Если true - клик по организации открывает её
                                        //Если false - клик по организации возвращает её ИД


        public OrganisationsDataBaseForm(bool onlyShow = true)
        {
            InitializeComponent();

            LoadCatalogs();
            CreateTable();
            InitToolTips();
            InitContextMenuStrip();
            creator = new Controller.CommandStringCreator("Organisations");
            ReloadTable();
            onlyShowing = onlyShow;

        }

        private void CreateTable()
        {
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



            SetColumnOrder(organisationsDataGridView);

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
        }

        private void InitToolTips()
        {
            toolTip1.SetToolTip(refreshTableButton, "Обновить");
            toolTip1.SetToolTip(clearFilterButton, "Очистить фильтр");
            toolTip1.SetToolTip(columnsOptionsButton, "Настроить список");

        }

        private void InitContextMenuStrip()
        {
            foreach (ToolStripMenuItem item in contextMenuStrip1.Items)
            {
                item.Click -= MenuItemOnClick;
            }

            contextMenuStrip1.Items.Clear();

            foreach (DataGridViewColumn column in organisationsDataGridView.Columns)
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

            organisationsDataGridView.Columns[target.Name].Visible = target.Checked;
        }

        private void ReloadTable()
        {
            ClearTable();
            FillTable(Program.dataManager.GetFilteredOrganisations(creator.ToFilterCommand()));

        }

        private void ClearTable()
        {
            if (organisationsDataGridView.Rows.Count > 0)
            {
                organisationsDataGridView.Rows.Clear();
            }

        }

        private void FillTable(List<Organisation> organisations)
        {
            if (organisations != null && organisations.Count > 0)
            {
                foreach (var org in organisations)
                {
                    if (org != null)
                    {
                        int rowIndex = organisationsDataGridView.Rows.Add();
                        var newRow = organisationsDataGridView.Rows[rowIndex];

                        var table = Program.dataManager.GetDataTable
                            ("SELECT * FROM contracts where organisationID = " +
                            org.id + " ORDER BY id DESC LIMIT 1");

                        if (table.Rows.Count > 0)
                        {
                            Contract contract = new Contract(table.Rows[table.Rows.Count - 1]);

                            newRow.Cells["contractNumber"].Value = contract.contractNumber;
                            newRow.Cells["contractStart"].Value =
                                ConvertDateToShortText(contract.contractStart);
                            newRow.Cells["contractEnd"].Value =
                                ConvertDateToShortText(contract.contractEnd);
                        }
                        

                        //Contract contract = Program.dataManager.GetValue<Contract>
                        //    ("SELECT * FROM contracts where organisationID = " +
                        //    org.id + " ORDER BY id DESC LIMIT 1");

                        newRow.Cells["id"].Value = org.id;
                        newRow.Cells["number"].Value = org.number;
                        newRow.Cells["name"].Value = org.name;
                        newRow.Cells["inn"].Value = org.inn;
                        newRow.Cells["phoneNumber"].Value = org.phoneNumber;
                        newRow.Cells["contactName"].Value = org.contactName;
                        newRow.Cells["email"].Value = org.email;

                        newRow.Cells["originalID"].Value =
                            Catalog.contractOriginalConditions[org.originalID];
                        

                        newRow.Cells["comments"].Value = org.comments;
                        newRow.Cells["contractCondition"].Value =
                            Catalog.contractConditions[org.contractCondition];
                        newRow.Cells["law"].Value = Catalog.laws[org.law];
                        newRow.Cells["contractType"].Value =
                            Catalog.contractTypes[org.contractType];
                    }
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




        private void addNewOrgButton_Click(object sender, EventArgs e)
        {
            ShowOrganisation(new Organisation());

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridView dg = (DataGridView)sender;
                var ID = dg.Rows[e.RowIndex].Cells[0].Value.ToString();
                if (ID != "0")
                {
                    Organisation org = Program.dataManager.GetOrganisation(ID);

                    if (onlyShowing)
                    {
                        ShowOrganisation(org);
                    }
                    else
                    {
                        returnedOrganisation = org;
                        DialogResult = DialogResult.OK;
                    }
                }


            }

        }

        private void clearFilterButton_Click(object sender, EventArgs e)
        {
            //сбросить фильтр
            inn.Clear();
            name.Clear();
            law.SelectedIndex = 0;
            contractType.SelectedIndex = 0;
            number_Equal.Clear();

            creator.ClearFilters();
            ReloadTable();
        }

        private void refreshTableButton_Click(object sender, EventArgs e)
        {
            ReloadTable();
        }

        private void anyKey_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ReloadTable();
            }

            if (e.KeyCode == Keys.Escape)
            {
                DialogResult = DialogResult.Cancel;
            }

        }

        private void deleteOrganisationButton_Click(object sender, EventArgs e)
        {
            if (organisationsDataGridView.CurrentRow != null)
            {
                string id = organisationsDataGridView.CurrentRow.Cells[0].Value.ToString();
                Organisation org = Program.dataManager.GetOrganisation(id);

                string text = "Вы действительно хотите удалить организацию\n" + org.name + "?";

                DialogResult dialogResult = MessageBox.Show(text,
                    "Подтвердите удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    Program.dataManager.DeleteOrganisation(id);
                    ReloadTable();

                }
            }

        }

        private void OrganisationsDataBaseForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveColumnOrder(organisationsDataGridView);
        }

        private void columnsOptionsButton_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show();
        }

        private void contextMenuStrip1_Closing(object sender, ToolStripDropDownClosingEventArgs e)
        {
            if (e.CloseReason == ToolStripDropDownCloseReason.ItemClicked)
                e.Cancel = true;
        }
    }
}
