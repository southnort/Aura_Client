using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aura_Client.View
{
    public partial class ToExcelForm : AuraForm
    {

        private string filePath = Environment.GetFolderPath
            (Environment.SpecialFolder.Desktop) + @"\Аура отчет.xls";

        public ToExcelForm()
        {
            InitializeComponent();
        }

        private void ToExcelForm_Load(object sender, EventArgs e)
        {
            RefreshFilePathText();
            InitializeSaveFileDialog();
            

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

        private void button1_Click(object sender, EventArgs e)
        {
            string command = "SELECT * FROM Purchases";
            Program.dataManager.GetExcelFile(filePath, command);



        }
    }
}
