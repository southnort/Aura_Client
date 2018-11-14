using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Aura_Client.View
{
    public partial class ToExcelForm : AuraForm
    {

        private string filePath = Environment.GetFolderPath
            (Environment.SpecialFolder.Desktop) + @"\Aura Organisations.xls";
        

        public ToExcelForm()
        {
            InitializeComponent();
        }

        private void ToExcelForm_Load(object sender, EventArgs e)
        {
            RefreshFilePathText();
            InitializeSaveFileDialog();
            sqlQueryTextBox.Text = "SELECT * FROM Organisations";

        }

        private void InitializeSaveFileDialog()
        {
            saveFileDialog1.Filter = "Excel (*.xls)|*.xls|All files (*.*)|*.*";
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
                    Program.dataManager.GetExcelFile(filePath, command);
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

        private void anyKey_KeyUp(object sender, KeyEventArgs e)
        {

        }
    }
}
