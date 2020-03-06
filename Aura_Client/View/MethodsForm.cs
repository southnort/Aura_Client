using Aura.Model;
using System.Drawing;
using System.Windows.Forms;

namespace Aura_Client.View
{
    public partial class MethodsForm : AuraForm
    {
        public MethodsForm()
        {
            InitializeComponent();

            CreateTable();
            FillTable();
        }

        private void CreateTable()
        {
            statusesDataGrid.Columns.Add("id", "#");
            statusesDataGrid.Columns["id"].Width = 20;

            statusesDataGrid.Columns.Add("name", "Название");
            statusesDataGrid.Columns["name"].Width = 130;

            statusesDataGrid.Columns.Add("isActual", "Акутальность");
            statusesDataGrid.Columns["isActual"].Width = 50;
        }

        private void ClearTable()
        {
            statusesDataGrid.Rows.Clear();
        }

        private void FillTable()
        {
            var source = Program.dataManager.GetAllMethods();

            foreach (var st in source)
            {
                if (st != null)
                {
                    int rowIndex = statusesDataGrid.Rows.Add();
                    var newRow = statusesDataGrid.Rows[rowIndex];
                    newRow.Cells["id"].Value = st.id;
                    newRow.Cells["name"].Value = st.name;
                    newRow.Cells["isActual"].Value = st.isActual;
                }
            }
        }

        private void ReloadTable()
        {
            ClearTable();
            FillTable();
        }

        private void ShowMethod(PurchaseMethod method)
        {
            MethodEditForm form = new MethodEditForm(method);
            Hide();
            var result = form.ShowDialog();
            Show();
            if (result == DialogResult.OK)
                ReloadTable();
        }


        private void button2_Click(object sender, System.EventArgs e)
        {
            StartLoading();
            ShowMethod(new PurchaseMethod());
            FinishLoading();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void statusesDataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                StartLoading();
                var dg = (DataGridView)sender;
                var itemID = dg.Rows[e.RowIndex].Cells["id"].Value.ToString();
                PurchaseMethod method = Program.dataManager.GetPurchaseMethod(itemID);
                ShowMethod(method);
                FinishLoading();

            }

        }
    }
}
