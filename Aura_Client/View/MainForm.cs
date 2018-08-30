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

            //если пользователь не имеет полномочий администратора, убрать кнопку "Пользователи"
            if (Program.user.roleID != 0)
                usersButton.Hide();     
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

        private void usersButton_Click(object sender, EventArgs e)
        {
            UsersDataBaseForm usersDataBaseForm = new UsersDataBaseForm();
            usersDataBaseForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OrganisationsDataBaseForm form = new OrganisationsDataBaseForm();
            form.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReestrDataBaseForm form = new ReestrDataBaseForm();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ReportsDataBaseForm form = new ReportsDataBaseForm();
            form.Show();
        }

        private void switchUserButton_Click(object sender, EventArgs e)
        {
            Program.user.ID = -1;
            LoginWindow window = new LoginWindow();
            if (window.ShowDialog() != DialogResult.OK)
            {
                Application.Exit();
            }
            else
            {
                userNameLabel.Text = "Пользователь: " + Program.user.name;
                if (Program.user.roleID != 0)
                    usersButton.Hide();
            }
        }

        private void changePasswordButton_Click(object sender, EventArgs e)
        {

        }


    }
}
