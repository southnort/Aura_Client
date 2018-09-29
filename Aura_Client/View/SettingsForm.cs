using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Aura_Client.Model;
using System.Configuration;

namespace Aura_Client.View
{
    public partial class SettingsForm : AuraForm
    {
        public SettingsForm()
        {
            InitializeComponent();

            CreateTableColors();
            FillTableColors();

        }

        private void CreateTableColors()
        {
            statusColorsDataGrd.Columns.Add("id", "#");
            statusColorsDataGrd.Columns["id"].Width = 20;

            statusColorsDataGrd.Columns.Add("nameOfStatus", "Статус");
            statusColorsDataGrd.Columns["nameOfStatus"].Width = 130;

            DataGridViewButtonColumn selectedColorColumn = new DataGridViewButtonColumn();
            selectedColorColumn.Name = "selectedColor";
            selectedColorColumn.HeaderText = "Цвет";
            statusColorsDataGrd.Columns.Add(selectedColorColumn);
            statusColorsDataGrd.Columns["selectedColor"].Width = 50;
        
        }

        private void FillTableColors()
        {
            statusColorsDataGrd.Rows.Clear();

            for(int i = 0; i< Catalog.allStatuses.Count;i++)
            {
                var status = Catalog.allStatuses[i];

                int rowIndex = statusColorsDataGrd.Rows.Add();
                var newRow = statusColorsDataGrd.Rows[rowIndex];

                newRow.Cells["id"].Value = i;
                newRow.Cells["nameOfStatus"].Value = status;
                newRow.Cells["selectedColor"].Style.BackColor = GetColor(i);
            }
        }

        private Color GetColor(int indexOfStatus)
        {
            if (Properties.settings.Default.StatusColors.Count < indexOfStatus)
                return Color.White;

            else
            {
                var item = Properties.settings.Default.StatusColors[indexOfStatus];
                int argb = int.Parse(item);
                return Color.FromArgb(argb);

            }
        }

        private void statusColorsDataGrd_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridView dg = (DataGridView)sender;
                int index =(int) dg.Rows[e.RowIndex].Cells["id"].Value;

                colorDialog1.AllowFullOpen = true;
                colorDialog1.ShowHelp = true;
                if (colorDialog1.ShowDialog() == DialogResult.OK)
                {
                    int argb = colorDialog1.Color.ToArgb();
                    Properties.settings.Default.StatusColors[index] = argb.ToString();
                    Properties.settings.Default.Save();
                    var row = dg.Rows[e.RowIndex].Cells["selectedColor"].
                        Style.BackColor = GetColor(index);
                }
            }
        }
    }
}
