using System;
using System.Windows.Forms;

namespace Aura_Client.View
{
    public partial class MainForm : AuraForm
    {
        public MainForm()
        {
            InitializeComponent();
            InitializeAuraForm();
            Text = "Aura " + Application.ProductVersion;

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
            purchasesDataBaseForm.ShowDialog();

        }

        private void OpenCalendar()
        {
            var purchasesCalendarForm = new PurchasesCalendarForm();
            purchasesCalendarForm.ShowDialog();
        }

        private void usersButton_Click(object sender, EventArgs e)
        {
            UsersDataBaseForm usersDataBaseForm = new UsersDataBaseForm();
            usersDataBaseForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OrganisationsDataBaseForm form = new OrganisationsDataBaseForm();
            form.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReestrDataBaseForm form = new ReestrDataBaseForm();
            form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ReportsDataBaseForm form = new ReportsDataBaseForm();
            form.ShowDialog();
        }

        private void switchUserButton_Click(object sender, EventArgs e)
        {
            Program.user.ID = -1;
            LoginWindow window = new LoginWindow();
            if (window.ShowDialog() != DialogResult.OK)
            {              
                Environment.Exit(0);
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
            ChangePasswordForm form = new ChangePasswordForm();
            form.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (Program.user.ID < 1)
            {
                DialogResult result = new LoginWindow().ShowDialog();
                if (result != DialogResult.OK)
                {
                    Environment.Exit(0);
                }
            }


            userNameLabel.Text = "Пользователь: " + Program.user.name;

            //если пользователь не имеет полномочий администратора, убрать кнопку "Пользователи"
            if (Program.user.roleID != 0)
                usersButton.Hide();            
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr;
            dr = MessageBox.Show("Действительно выйти?", "Выход", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (dr == DialogResult.OK)
            {
                Environment.Exit(0);
            }
            else e.Cancel = true;
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            SettingsForm form = new SettingsForm();
            if (form.ShowDialog() == DialogResult.OK)
            {

            }            
        }
    }
}
