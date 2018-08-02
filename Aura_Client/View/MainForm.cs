using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Aura_Client.View;

namespace Aura_Client.View
{
    public partial class MainForm : AuraForm
    {
        public MainForm()
        {
            InitializeComponent();

            userNameLabel.Text = "Пользователь: " + Program.user.name;
        }

        private void purchasesListButton_Click(object sender, EventArgs e)
        {
            OpenPurchasesList();
        }

        private void calendarButton_Click(object sender, EventArgs e)
        {
            OpenCalendar();
        }

        private void OpenPurchasesList()
        {
            var purchasesDataBaseForm = 
                new PurchasesDataBaseForm();
            purchasesDataBaseForm.Show();

        }

        private void OpenCalendar()
        {
            var purchasesCalendarForm = new PurchasesCalendarForm();
            purchasesCalendarForm.Show();
        }
    }
}
