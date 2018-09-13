using System;
using System.Drawing;
using System.Windows.Forms;

namespace Aura_Client.View
{
    public partial class LoginWindow : AuraForm
    {
        public LoginWindow() : base()
        {
            InitializeComponent();
            label3.Text = "\"Аура-Клиент\" приветствует Вас";
            label4.Text = "ver. " + Application.ProductVersion;

            savePasswordCheckBox.Checked = Properties.settings.Default.SavePassword;
            if (savePasswordCheckBox.Checked)
            {
                loginTextBox.Text = Properties.settings.Default.Login;
                passwordTextBox.Text = Properties.settings.Default.Password;
            }

        }

        private void tryLoginButton_Click(object sender, EventArgs e)
        {
            if (loginTextBox.Text != string.Empty && passwordTextBox.Text != string.Empty)
            {
                resultTextLabel.Text = "Соединяемся с сервером...";
                // Thread loginThread = new Thread(new ThreadStart(() =>
                //{
                string result = Program.bridge.TryLogin(loginTextBox.Text, passwordTextBox.Text);
                SetLoginResult(result);
                //}));

                // loginThread.Start();


            }


        }



        public void SetLoginResult(string result)
        {
            switch (result)
            {
                case "ERROR":
                    {
                        resultTextLabel.Text = "Ошибка соединения с сервером";
                        resultTextLabel.ForeColor = Color.Red;

                    }
                    break;

                case "LOGINFAILED":
                    {
                        ChangeLoginResultText("Неправильный логин или пароль", Color.Red);

                    }
                    break;

                case "LOGINSUCCESS":
                    {
                        ChangeLoginResultText("Аутентификация пройдена. Загрузка данных...", Color.Green);
                        Properties.settings.Default.Login = loginTextBox.Text;
                        if (savePasswordCheckBox.Checked)
                            Properties.settings.Default.Password = passwordTextBox.Text;
                        Properties.settings.Default.SavePassword = savePasswordCheckBox.Checked;

                        Properties.settings.Default.Save();
                        DialogResult = DialogResult.OK;
                    }
                    break;

                default:
                    {
                        ChangeLoginResultText("Неправильный запрос", Color.Red);

                    }
                    break;
            }

        }

        private void ChangeLoginResultText(string text, Color color)
        {
            resultTextLabel.Invoke(new Action(() =>
            {
                resultTextLabel.Text = text;
                resultTextLabel.ForeColor = color;
                if (color == Color.Green) Close();
            }));
        }

        private void anyKey_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                tryLoginButton_Click(sender, e);
            }

            if (e.KeyCode == Keys.Escape)
            {
                DialogResult = DialogResult.Cancel;
            }

        }

        private void LoginWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
