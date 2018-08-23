﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Aura.Model;
using Aura_Client.Model;

namespace Aura_Client.View
{
    public partial class ReportsDataBaseForm : AuraForm
    {
        private string month;   //выбранный месяц для отчета
        private string year;    //выбранный год для отчёта
        private string monthYear { get { return " " + month + "." + year + ","; } }

        private List<Organisation> organisations;
        private List<Report> reports;

        private Color readyColor = Color.PaleGreen;     //цвет кнопки для сделанного отчета
        private Color notReadyColor = Color.LightGray;       //цвет кнопки для несделанного отчета


        public ReportsDataBaseForm()
        {
            InitializeComponent();
            creator = new Controller.CommandStringCreator("Reports", "");

            month = DateTime.Now.Month.ToString();
            year = DateTime.Now.Year.ToString();

            //TODO запрашивать отфильтрованные организации, а не всё
            organisations = Program.dataManager.GetAllOrganisations();
            reports = Program.dataManager.GetAllReports();

            LoadCatalogs();

            SetCombobox(monthComboBox, month);
            SetCombobox(yearComboBox, year);

            ReloadTable();
        }

        private void LoadCatalogs()
        {
            monthComboBox.Items.Clear();

            monthComboBox.Items.Add(new ComboBoxItem { Text = "Январь", Value = "1" });
            monthComboBox.Items.Add(new ComboBoxItem { Text = "Февраль", Value = "2" });
            monthComboBox.Items.Add(new ComboBoxItem { Text = "Март", Value = "3" });

            monthComboBox.Items.Add(new ComboBoxItem { Text = "Апрель", Value = "4" });
            monthComboBox.Items.Add(new ComboBoxItem { Text = "Май", Value = "5" });
            monthComboBox.Items.Add(new ComboBoxItem { Text = "Июнь", Value = "6" });

            monthComboBox.Items.Add(new ComboBoxItem { Text = "Июль", Value = "7" });
            monthComboBox.Items.Add(new ComboBoxItem { Text = "Август", Value = "8" });
            monthComboBox.Items.Add(new ComboBoxItem { Text = "Сентярь", Value = "9" });

            monthComboBox.Items.Add(new ComboBoxItem { Text = "Октябрь", Value = "10" });
            monthComboBox.Items.Add(new ComboBoxItem { Text = "Ноябрь", Value = "11" });
            monthComboBox.Items.Add(new ComboBoxItem { Text = "Декабрь", Value = "12" });



            yearComboBox.Items.Clear();

            yearComboBox.Items.Add(new ComboBoxItem { Text = "2017", Value = "2017" });
            yearComboBox.Items.Add(new ComboBoxItem { Text = "2018", Value = "2018" });
            yearComboBox.Items.Add(new ComboBoxItem { Text = "2019", Value = "2019" });
            yearComboBox.Items.Add(new ComboBoxItem { Text = "2020", Value = "2020" });
            yearComboBox.Items.Add(new ComboBoxItem { Text = "2021", Value = "2021" });
            yearComboBox.Items.Add(new ComboBoxItem { Text = "2022", Value = "2022" });

        }

        private void ReloadTable()
        {
            ClearTable();
            FillTable();
        }

        private void ClearTable()
        {
            if (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.Rows.Clear();
            }
        }

        private void FillTable()
        {
            foreach (var org in organisations)
            {
                if (org != null)
                {
                    int rowIndex = dataGridView1.Rows.Add();
                    var newRow = dataGridView1.Rows[rowIndex];

                    var report = reports.SingleOrDefault(rep => rep.organisationID == org.id);

                    newRow.Cells["organisationID"].Value = org.id;
                    newRow.Cells["inn"].Value = org.inn;
                    newRow.Cells["name"].Value = org.name;


                }

            }

            RecolorTable();

        }

        private void SwitchDate()
        {
            month = (monthComboBox.SelectedIndex + 1).ToString();
            year = yearComboBox.SelectedItem.ToString();

            RecolorTable();

        }

        private void RecolorTable()
        {
            for (int i = 1; i < dataGridView1.Rows.Count; i++)
            {
                var row = dataGridView1.Rows[i];
                int orgID = (int)row.Cells["organisationID"].Value;
                var report = reports.SingleOrDefault(rep => rep.organisationID == orgID);

                if (report != null && report.commonPurchasesContractsReport.Contains(monthYear))
                {
                    row.Cells["commonPurchasesContractsReport"].Style.BackColor = readyColor;
                }
                else
                {
                    row.Cells["commonPurchasesContractsReport"].Style.BackColor = notReadyColor;
                }


                if (report != null && report.singleSupplierContractsReport.Contains(monthYear))
                {
                    row.Cells["singleSupplierContractsReport"].Style.BackColor = readyColor;
                }
                else
                {
                    row.Cells["singleSupplierContractsReport"].Style.BackColor = notReadyColor;
                }


                if (report != null && report.failedPurchasesContractsReport.Contains(monthYear))
                {
                    row.Cells["failedPurchasesContractsReport"].Style.BackColor = readyColor;
                }
                else
                {
                    row.Cells["failedPurchasesContractsReport"].Style.BackColor = notReadyColor;
                }

            }

        }


        private void AddValue(int orgID, string fieldName, string fieldValue)
        {
            //обработка действия "Отчет готов"
            Report report = reports.SingleOrDefault(org => org.organisationID == orgID);

            if (report == null)
                report = new Report();

            report.organisationID = orgID;
            switch (fieldName)
            {
                case "commonPurchasesContractsReport":
                    report.commonPurchasesContractsReport += fieldValue;
                    break;
                case "singleSupplierContractsReport":
                    report.singleSupplierContractsReport += fieldValue;
                    break;
                case "failedPurchasesContractsReport":
                    report.failedPurchasesContractsReport += fieldValue;
                    break;

                default:
                    MessageBox.Show("Error with adding report: " + orgID + " " + fieldName + " " + fieldValue,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error); break;

            }

            Program.bridge.SendUpdateReport(report);
            if (!reports.Contains(report))
                reports.Add(report);

            
        }

        private void RemoveValue(int orgID, string fieldName, string fieldValue)
        {
            //обработка действия "Отчет не готов"
            Report report = reports.SingleOrDefault(org => org.organisationID == orgID);
            if (report == null)
                return;

            report.organisationID = orgID;
            switch (fieldName)
            {
                case "commonPurchasesContractsReport":
                    if (report.commonPurchasesContractsReport.Contains(fieldValue))
                        report.commonPurchasesContractsReport =
                            report.commonPurchasesContractsReport.Replace(fieldValue, "");
                    break;


                case "singleSupplierContractsReport":
                    if (report.singleSupplierContractsReport.Contains(fieldValue))
                        report.singleSupplierContractsReport =
                            report.singleSupplierContractsReport.Replace(fieldValue, "");
                    break;


                case "failedPurchasesContractsReport":
                    if (report.failedPurchasesContractsReport.Contains(fieldValue))
                        report.failedPurchasesContractsReport =
                            report.failedPurchasesContractsReport.Replace(fieldValue, "");
                    break;


                default:
                    MessageBox.Show("Error with adding report: " + orgID + " " + fieldName + " " + fieldValue,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error); break;

            }

            Program.bridge.SendUpdateReport(report);
            if (!reports.Contains(report))
                reports.Add(report);




        }



        private void prevMonthButton_Click(object sender, EventArgs e)
        {
            if (monthComboBox.SelectedIndex == 0)
            {
                if (yearComboBox.SelectedIndex != 0)
                {
                    monthComboBox.SelectedIndex = monthComboBox.Items.Count - 1;
                    yearComboBox.SelectedIndex--;
                }
            }

            else
            {
                monthComboBox.SelectedIndex--;
            }

            SwitchDate();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (monthComboBox.SelectedIndex == monthComboBox.Items.Count - 1)
            {
                if (yearComboBox.SelectedIndex != yearComboBox.Items.Count - 1)
                {
                    monthComboBox.SelectedIndex = 0;
                    yearComboBox.SelectedIndex++;
                }
            }

            else
            {
                monthComboBox.SelectedIndex++;
            }

            SwitchDate();

        }

        private void monthComboBox_Leave(object sender, EventArgs e)
        {
            SwitchDate();
        }

        private void yearComboBox_Leave(object sender, EventArgs e)
        {
            SwitchDate();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (e.RowIndex >= 0 && senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                int orgID = (int) dataGridView1.CurrentRow.Cells[0].Value;
                string fieldName = senderGrid.Columns[e.ColumnIndex].Name;
                string fieldValue = monthYear;

                var cell = dataGridView1.CurrentCell as DataGridViewButtonCell;
                if (cell.Style.BackColor == readyColor)
                {
                    RemoveValue(orgID, fieldName, fieldValue);
                    cell.Style.BackColor = notReadyColor;
                }


                else
                {
                    AddValue(orgID, fieldName, fieldValue);
                    cell.Style.BackColor = readyColor;
                }


            }
        }
    }

}