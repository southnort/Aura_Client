﻿using Aura.Model;
using Aura_Client.Model;
using System.Drawing;
using System.Windows.Forms;

namespace Aura_Client.View
{
    public partial class SettingsForm : AuraForm
    {
        public SettingsForm()
        {
            InitializeComponent();

            CreateStatusesColorTable();
            FillTableStatusesColor();

            CreateProtocolStatusesTable();
            FillProtocolStatusesColorTable();             

        }

        private void CreateStatusesColorTable()
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

        private void FillTableStatusesColor()
        {
            statusColorsDataGrd.Rows.Clear();


            int rowIndex = statusColorsDataGrd.Rows.Add();
            var newRow = statusColorsDataGrd.Rows[rowIndex];
            newRow.Cells["id"].Value = 0;
            newRow.Cells["nameOfStatus"].Value = Catalog.allStatuses[0];
            newRow.Cells["selectedColor"].Style.BackColor = GetStatusColor(0);

            rowIndex = statusColorsDataGrd.Rows.Add();
            newRow = statusColorsDataGrd.Rows[rowIndex];
            newRow.Cells["id"].Value = 1;
            newRow.Cells["nameOfStatus"].Value = Catalog.allStatuses[1];
            newRow.Cells["selectedColor"].Style.BackColor = GetStatusColor(1);


            for (int i = 1; i< CCatalog.allStages.Count;i++)
            {
                var status = CCatalog.allStages[i];

                rowIndex = statusColorsDataGrd.Rows.Add();
                newRow = statusColorsDataGrd.Rows[rowIndex];

                newRow.Cells["id"].Value = i+1;
                newRow.Cells["nameOfStatus"].Value = status;
                newRow.Cells["selectedColor"].Style.BackColor = GetStatusColor(i+1);
            }

            rowIndex = statusColorsDataGrd.Rows.Add();
            newRow = statusColorsDataGrd.Rows[rowIndex];
            newRow.Cells["id"].Value = 8;
            newRow.Cells["nameOfStatus"].Value = Catalog.allStatuses[2];
            newRow.Cells["selectedColor"].Style.BackColor = GetStatusColor(8);

            rowIndex = statusColorsDataGrd.Rows.Add();
            newRow = statusColorsDataGrd.Rows[rowIndex];
            newRow.Cells["id"].Value = 9;
            newRow.Cells["nameOfStatus"].Value = Catalog.allStatuses[3];
            newRow.Cells["selectedColor"].Style.BackColor = GetStatusColor(9);

        }


        private void CreateProtocolStatusesTable()
        {       
            protocolStatusColorsDataGrd.Columns.Add("id", "#");
            protocolStatusColorsDataGrd.Columns["id"].Width = 20;

            protocolStatusColorsDataGrd.Columns.Add("nameOfStatus", "Статус");
            protocolStatusColorsDataGrd.Columns["nameOfStatus"].Width = 130;

            DataGridViewButtonColumn selectedColorColumn = new DataGridViewButtonColumn();
            selectedColorColumn.Name = "selectedColor";
            selectedColorColumn.HeaderText = "Цвет";
            protocolStatusColorsDataGrd.Columns.Add(selectedColorColumn);
            protocolStatusColorsDataGrd.Columns["selectedColor"].Width = 50;
        }

        private void FillProtocolStatusesColorTable()
        {
            protocolStatusColorsDataGrd.Rows.Clear();

            for (int i = 0; i < Catalog.protocolStatuses.Count; i++)
            {
                var status = Catalog.protocolStatuses[i];

                int rowIndex = protocolStatusColorsDataGrd.Rows.Add();
                var newRow = protocolStatusColorsDataGrd.Rows[rowIndex];

                newRow.Cells["id"].Value = i;
                newRow.Cells["nameOfStatus"].Value = status;
                newRow.Cells["selectedColor"].Style.BackColor = GetProtocolStatusColor(i);
            }
        }



        private Color GetStatusColor(int indexOfStatus)
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

        private void statusColorsDataGrd_CellClick(object sender, DataGridViewCellEventArgs e)
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
                        Style.BackColor = GetStatusColor(index);
                }
                label1.Focus();
            }
        }

        private void protocolStatusColorsDataGrd_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridView dg = (DataGridView)sender;
                int index = (int)dg.Rows[e.RowIndex].Cells["id"].Value;

                colorDialog1.AllowFullOpen = true;
                colorDialog1.ShowHelp = true;
                if (colorDialog1.ShowDialog() == DialogResult.OK)
                {
                    int argb = colorDialog1.Color.ToArgb();
                    Properties.settings.Default.ProtocolStatus[index] = argb.ToString();
                    Properties.settings.Default.Save();
                    var row = dg.Rows[e.RowIndex].Cells["selectedColor"].
                        Style.BackColor = GetProtocolStatusColor(index);
                }
                label1.Focus();
            }
        }
    }
}
