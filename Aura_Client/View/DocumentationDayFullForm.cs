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
        public DocumentationDayFullForm(DayInCalendar day) : base()
        {            
                InitializeComponent();
                InitializeAuraForm();

                dateLabel.Text = day.date.ToShortDateString();
               
                CreateTable();
                InitContextMenuStrip();
                ReloadTable(day);   

        }


        private void CreateTable()
        {
            dayInCalendarDataGridView.Columns.Add("id", "id");
            dayInCalendarDataGridView.Columns["id"].Width = 50;

            dayInCalendarDataGridView.Columns.Add("purchaseName", "Наименование закупки");
            dayInCalendarDataGridView.Columns["purchaseName"].Width = 200;

            dayInCalendarDataGridView.Columns.Add("organizationID", "Заказчик");
            dayInCalendarDataGridView.Columns["organizationID"].Width = 150;

            dayInCalendarDataGridView.Columns.Add("purchaseMethodID", "Способ");
            dayInCalendarDataGridView.Columns["purchaseMethodID"].Width = 150;

            dayInCalendarDataGridView.Columns.Add("eventName", "Событие");
            dayInCalendarDataGridView.Columns["eventName"].Width = 150;

            dayInCalendarDataGridView.Columns.Add("statusID", "Статус");
            dayInCalendarDataGridView.Columns["statusID"].Width = 150;

            dayInCalendarDataGridView.Columns.Add("stageID", "Этап");
            dayInCalendarDataGridView.Columns["stageID"].Width = 150;            

            DataGridViewButtonColumn bidsCountColumn = new DataGridViewButtonColumn();
            bidsCountColumn.Name = "BidsCountIndex";
            bidsCountColumn.HeaderText = "Количество заявок";
            dayInCalendarDataGridView.Columns.Add(bidsCountColumn);
            dayInCalendarDataGridView.Columns["BidsCountIndex"].Width = 150;

            DataGridViewButtonColumn protocolStatusColumn = new DataGridViewButtonColumn();
            protocolStatusColumn.Name = "ProtocolStatus";
            protocolStatusColumn.HeaderText = "Статус протокола";
            dayInCalendarDataGridView.Columns.Add(protocolStatusColumn);
            dayInCalendarDataGridView.Columns["ProtocolStatus"].Width = 150;  

        }

        private void InitContextMenuStrip()
        {
            foreach (ToolStripMenuItem item in contextMenuStrip1.Items)
            {
                item.Click -= MenuItemOnClick;
            }

            contextMenuStrip1.Items.Clear();

            foreach (DataGridViewColumn column in dayInCalendarDataGridView.Columns)
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



            foreach (ToolStripMenuItem item in contextMenuStrip2.Items)
            {
                item.Click -= ProtocolStatusMenuItemClick;
            }

            contextMenuStrip2.Items.Clear();

            for (int i = 0; i < Catalog.protocolStatuses.Count; i++)
            {
                var item = new ToolStripMenuItem()
                {
                    Checked = false,
                    Text = Catalog.protocolStatuses[i],
                    Name = i.ToString(),
                };

                item.Click += ProtocolStatusMenuItemClick;
                contextMenuStrip2.Items.Add(item);
            }



            foreach (ToolStripMenuItem item in contextMenuStrip3.Items)
            {
                item.Click -= BidsCountMenuItemClick;
            }

            contextMenuStrip3.Items.Clear();

            for (int i = 0; i < Catalog.countOfBidsTexts.Count; i++)
            {
                var item = new ToolStripMenuItem()
                {
                    Checked = false,
                    Text = Catalog.countOfBidsTexts[i],
                    Name = i.ToString(),
                };

                item.Click += BidsCountMenuItemClick;
                contextMenuStrip3.Items.Add(item);
            }
            


        }

        private void MenuItemOnClick(object sender, EventArgs eventArgs)
        {
            var target = (ToolStripMenuItem)sender;

            target.Checked = !target.Checked;

            dayInCalendarDataGridView.Columns[target.Name].Visible = target.Checked;
        }

        private void ProtocolStatusMenuItemClick(object sender, EventArgs eventArgs)
        {
            var target = sender as ToolStripMenuItem;
            string text = target.Text;
            string newStatusID = target.Name;

            string purID = dayInCalendarDataGridView.CurrentRow.Cells["id"].Value.ToString();

            SwitchProtocolStatusOfPurchase(purID, newStatusID);
              
            dayInCalendarDataGridView.CurrentCell.Value = text;

        }

        private void BidsCountMenuItemClick(object sender, EventArgs eventArgs)
        {
            var target = sender as ToolStripMenuItem;
            string text = target.Text;
            string newBidsCountID = target.Name;

            string purID = dayInCalendarDataGridView.CurrentRow.Cells["id"].Value.ToString();

            ChangeBidsCount(purID, newBidsCountID);

            dayInCalendarDataGridView.CurrentCell.Value = text;

        }

        private void ReloadTable(DayInCalendar day)
        {
            CleatTable();
            FillTable(day);
        }

        private void CleatTable()
        {
            if (dayInCalendarDataGridView.Rows.Count > 0)
            {
                dayInCalendarDataGridView.Rows.Clear();
            }
        }

        private void FillTable(DayInCalendar day)
        {
            if (day.events.Count > 0)
            {
                //для подсчёта и отображения количества событий на дату
                Dictionary<string, int> countsOfProcedures
                    = new Dictionary<string, int>();

                var orgs = Program.dataManager.GetAllOrganisations();

                foreach (var ev in day.events)
                {
                    if (countsOfProcedures.ContainsKey(ev.Value))
                        countsOfProcedures[ev.Value]++;
                    else
                        countsOfProcedures.Add(ev.Value, 1);


                    int rowIndex = dayInCalendarDataGridView.Rows.Add();
                    var newRow = dayInCalendarDataGridView.Rows[rowIndex];

                    newRow.Cells["id"].Value = ev.Key.id;

                    newRow.Cells["purchaseName"].Value = ev.Key.purchaseName;

                    Organisation org = orgs.SingleOrDefault(o => o.id == ev.Key.organizationID);
                    if (org == null || org.id < 1)
                        newRow.Cells["organizationID"].Value = "<не указано>";
                    else
                        newRow.Cells["organizationID"].Value = org.name;

                    newRow.Cells["purchaseMethodID"].Value =
                                Catalog.purchaseMethods[ev.Key.purchaseMethodID].name;

                    newRow.Cells["eventName"].Value = ev.Value;

                    newRow.Cells["statusID"].Value = Catalog.allStatuses[ev.Key.statusID];

                    newRow.Cells["stageID"].Value = Catalog.allStages[ev.Key.stageID];

                    var countOfBidsCell = newRow.Cells["BidsCountIndex"] as DataGridViewButtonCell;
                    countOfBidsCell.Value = Catalog.countOfBidsTexts[ev.Key.BidsCountIndex];

                    var protocolStatusCell = newRow.Cells["ProtocolStatus"] as DataGridViewButtonCell;
                    protocolStatusCell.Value = Catalog.protocolStatuses[ev.Key.ProtocolStatus];
                                       
                }

                RefreshCountText(countsOfProcedures);


            }


        }

        private void RefreshCountText(Dictionary<string, int> countsOfProcedures)
        {
            StringBuilder sb = new StringBuilder();

            foreach (var pair in countsOfProcedures)
            {
                sb.Append(pair.Key);
                sb.Append(" - ");
                sb.Append(pair.Value);
                sb.Append("\n");
            }

           // proceduresCountTextBox.Text = sb.ToString();
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
