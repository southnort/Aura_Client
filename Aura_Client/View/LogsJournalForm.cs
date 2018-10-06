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
            headerTextBox.Text = item.LogObjectName;

            DataTable table = Program.dataManager.GetLogs(CreateQueryString(item));
        }

        private string CreateQueryString(ILoggable item)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT * FROM Logs WHERE tableName = '");
            if (item is Purchase) sb.Append("Purchases");
            else if (item is Organisation) sb.Append("Organisations");
            else if (item is ReportsList) sb.Append("Reports");
            else throw new Exception(ToString() + " error. " + item.GetType() + " is unknown type");

            sb.Append("' AND itemID = '");
            sb.Append(item.i
        }


        private void FillDataGrid(DataTable table)
        {

        }
   
    }
}
