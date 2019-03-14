using Aura.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aura_Client.View
{
    public partial class DocumentationDayFullForm : AuraForm
    {
        private ComboBox currentComboBox = null;

        //Максимально подробная форма дня из календаря
        public DocumentationDayFullForm(DateTime dateTime) : base()
        {
            InitializeComponent();
            InitializeAuraForm();

            dateLabel.Text = dateTime.ToShortDateString();

            CreateTable();
            ReloadTable(dateTime);

        }


        private void CreateTable()
        {
            dayInCalendarDataGridView.Columns.Add("id", "id");
            dayInCalendarDataGridView.Columns["id"].Width = 50;

            dayInCalendarDataGridView.Columns.Add("text","Содержание");
            dayInCalendarDataGridView.Columns["text"].Width = 400;
        }

      
       
       
        private void ReloadTable(DateTime dateTime)
        {
            ClearTable();
            FillTable(dateTime);
        }

        private void ClearTable()
        {
            if (dayInCalendarDataGridView.Rows.Count > 0)
            {
                dayInCalendarDataGridView.Rows.Clear();
            }
        }

        private void FillTable(DateTime date)
        {
            var documentations = Program.dataManager.GetDocumentation(date);


            if (documentations.Count > 0)
            {                    
                foreach (var item in documentations)
                {        
                    int rowIndex = dayInCalendarDataGridView.Rows.Add();
                    var newRow = dayInCalendarDataGridView.Rows[rowIndex];

                    newRow.Cells["id"].Value = item.id;
                    newRow.Cells["text"].Value = item.text;   
                }
              
            }
        }
        

        private void DayInCalendarFullForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult = DialogResult.Cancel;
            }
        }

        private void contextMenuStrip1_Closing(object sender, 
            ToolStripDropDownClosingEventArgs e)
        {
            if (e.CloseReason == ToolStripDropDownCloseReason.ItemClicked)
                e.Cancel = true;
        }

        private void dayInCalendarDataGridView_EditingControlShowing(object sender, 
            DataGridViewEditingControlShowingEventArgs e)
        {
            currentComboBox = e.Control as ComboBox;
        }

        private void dayInCalendarDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (currentComboBox != null)
                dayInCalendarDataGridView[e.ColumnIndex, e.RowIndex].Tag
                    = currentComboBox.SelectedIndex;

            
        }

        private void columnsOptionsButton_Click(object sender, EventArgs e)
        {            
            contextMenuStrip1.Show(Cursor.Position);
        }


        private void dayInCalendarDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (e.RowIndex >= 0)
            {
                if (senderGrid.CurrentCell.OwningColumn.Name == "ProtocolStatus")
                    ClickOnPrototolStatusButton();

                if (senderGrid.CurrentCell.OwningColumn.Name == "BidsCountIndex")
                    ClickOnBidsCountButton();

            }
        }

        private void ClickOnPrototolStatusButton()
        {            
            contextMenuStrip2.Show(Cursor.Position);
        }

        private void ClickOnBidsCountButton()
        {
            contextMenuStrip3.Show(Cursor.Position);
        }


        private void SwitchProtocolStatusOfPurchase(string purchaseID, string newStatusID)
        {
            Program.bridge.SwitchProtocolStatusOfPurchase(purchaseID, newStatusID);

        }

        private void ChangeBidsCount(string purchaseID, string newBidsCountID)
        {
            Program.bridge.ChangeBidsCountInPurchase(purchaseID, newBidsCountID);
        }

        private void dayInCalendarDataGridView_CellDoubleClick
            (object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var dg = (DataGridView)sender;
                var purchaseID = dg.Rows[e.RowIndex].Cells["id"].Value.ToString();
                Purchase purchase = Program.dataManager.GetPurchase(purchaseID);
                ShowPurchase(purchase);

            }
        }

        private void ShowPurchase(Purchase purchase)
        {
            PurchaseForm form = new PurchaseForm(purchase);
            var result = form.ShowDialog();            

        }
    }
}
