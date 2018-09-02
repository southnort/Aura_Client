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
            creator = new Controller.CommandStringCreator("Organisations");
            ReloadTable();
            onlyShowing = onlyShow;

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

        private void ReloadTable()
        {
            ClearTable();
            FillTable(Program.dataManager.GetFilteredOrganisations(creator.ToFilterCommand()));

        }

        private void ClearTable()
        {
            if (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.Rows.Clear();
            }

        }

        private void FillTable(List<Organisation> organisations)
        {
            if (organisations != null && organisations.Count > 0)
            {
                foreach (var org in organisations)
                {
                    if (org == null) return;

                    object[] newRow = new object[4];
                    newRow[0] = org.id;
                    newRow[1] = org.name;
                    newRow[2] = org.inn;
                    newRow[3] = Catalog.laws[org.law];

                    dataGridView1.Rows.Add(newRow);

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







        private void textBox_ValueChanged(object sender, EventArgs e)
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

        private void comboBox_ValueChanged(object sender, EventArgs e)
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

        }

        private void deleteOrganisationButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
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
    }
}
