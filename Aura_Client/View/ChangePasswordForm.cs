using System;
using System.Windows.Forms;

namespace Aura_Client.View
{
    public partial class ChangePasswordForm : AuraForm
    {
        public ChangePasswordForm() : base()
        {
            InitializeComponent();

            userName.Text = Program.user.name;
        }

        private void ConfirmNewPassword()
        {
            Program.bridge.ChangePassword(Program.user.ID,
                newPasswordTextBox.Text);
        }

        private void saveNewPasswordButton_Click(object sender, EventArgs e)
        {
            string control = string.Empty;

            if (Program.bridge.TryLogin(Program.user.login,
                    currentPasswordTextBox.Text) != "LOGINSUCCESS")
                control += "Аутентификация не пройдена\n";

            if (currentPasswordTextBox.Text == string.Empty)
                control += "Заполните текущий пароль\n";
           
            if (newPasswordTextBox.Text == string.Empty)
                control += "Укажите новый пароль\n";

            if (newPasswordTextBox.Text != repeatNewpasswordTextBox.Text)
                control += "Значения в полях \"Новый пароль\" и \"Повторите новый пароль\" должны совпадать\n";



            if (control == string.Empty)
            {
                ConfirmNewPassword();
                MessageBox.Show("Пароль успешно изменён");
                DialogResult = DialogResult.OK;
            }

            else
            {
                MessageBox.Show(control, "Ошибка");
            }

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void ChangePasswordForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult = DialogResult.Cancel;
            }
        }
    }
}
