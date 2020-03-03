using Aura.Model;
using System.Drawing;
using System.Windows.Forms;

namespace Aura_Client.View
{
    public partial class StagesForm : AuraForm
    {
        public StagesForm()
        {
            InitializeComponent();

            CreateTable();
            FillTable();
        }

        private void CreateTable()
        {
            statusesDataGrid.Columns.Add("id", "#");
            statusesDataGrid.Columns["id"].Width = 20;

            statusesDataGrid.Columns.Add("stageName", "Статус");
            statusesDataGrid.Columns["stageName"].Width = 130;

            statusesDataGrid.Columns.Add("isActual", "Акутальность");
            statusesDataGrid.Columns["isActual"].Width = 50;
        }

        private void ClearTable()
        {
            statusesDataGrid.Rows.Clear();
        }

        private void FillTable()
        {
            var source = Program.dataManager.GetAllStages();

            foreach (var st in source)
            {
                if (st != null)
                {
                    int rowIndex = statusesDataGrid.Rows.Add();
                    var newRow = statusesDataGrid.Rows[rowIndex];
                    newRow.Cells["id"].Value = st.id;
                    newRow.Cells["stageName"].Value = st.statusName;
                    newRow.Cells["isActual"].Value = st.isActual;
                }
            }
        }

        private void ReloadTable()
        {
            ClearTable();
            FillTable();
        }

        private void ShowStatus(PurchaseStage stage)
        {
            StageEditForm form = new StageEditForm(stage);
            Hide();
            var result = form.ShowDialog();
            Show();
            if (result == DialogResult.OK)
                ReloadTable();
        }


        private void button2_Click(object sender, System.EventArgs e)
        {
            StartLoading();
            ShowStatus(new PurchaseStage());
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
                PurchaseStage status = Program.dataManager.GetPurchaseStage(itemID);
                ShowStatus(status);
                FinishLoading();

            }

        }
    }
}
