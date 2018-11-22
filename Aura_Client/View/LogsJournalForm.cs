using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Aura.Model;

namespace Aura_Client.View
{
    public partial class LogsJournalForm : AuraForm
    {
        public LogsJournalForm(ILoggable item)
        {
            InitializeComponent();
            InitializeAuraForm();

            headerTextBox.Text = item.LogObjectName;
            DataTable table = Program.dataManager.GetLogs(item.GetSqlStringForLog());

            FillDataGrid(table);
        }
               


        private void FillDataGrid(DataTable table)
        {
            var users = Program.dataManager.GetUserNames();

            if (table != null & table.Rows.Count > 0)
            {
                foreach (var tableRow in table.Rows)
                {
                    LogNode node = new LogNode((DataRow)tableRow);

                    int rowIndex = dataGridView1.Rows.Add();
                    var newRow = dataGridView1.Rows[rowIndex];
                                       
                    newRow.Cells["userID"].Value =
                        users[node.userID.ToString()];

                    newRow.Cells["date"].Value =
                        node.date;

                    newRow.Cells["time"].Value =
                        node.time;

                    newRow.Cells["message"].Value =
                        node.message;

                    newRow.Cells["dataBaseQuery"].Value =
                        node.dataBaseQuery;

                }
            }

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
