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
        private DateTime _dateTime;

        //Максимально подробная форма дня из календаря
        public DocumentationDayFullForm(DateTime dateTime) : base()
        {
            InitializeComponent();
            InitializeAuraForm();

            dateLabel.Text = dateTime.ToShortDateString();

            _dateTime = dateTime;

            CreateTable();
            ReloadTable(_dateTime);

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
                
                    
        
       

        private void dayInCalendarDataGridView_CellDoubleClick
            (object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var dg = (DataGridView)sender;
                var documentationId = dg.Rows[e.RowIndex].Cells["id"].Value.ToString();

                DocumentationNode node = Program.dataManager.GetDocumentationNode(documentationId);
                ShowDocumentationNode(node);               

            }
        }

        private void ShowDocumentationNode(DocumentationNode node)
        {
            DocumentationNodeForm form = new DocumentationNodeForm(node);
            var result = form.ShowDialog();

            ReloadTable(_dateTime);
        }

        private void addNewNodeButton_Click(object sender, EventArgs e)
        {
            DocumentationNode newNode = new DocumentationNode
            {
                nodeDate = _dateTime,
            };

            DocumentationNodeForm form = new DocumentationNodeForm(newNode);
            var result = form.ShowDialog();

            if (result == DialogResult.OK)
                FillTable(_dateTime);
        }
    }
}
