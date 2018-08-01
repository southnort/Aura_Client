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
    public partial class LoginWindow : Form
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void tryLoginButton_Click(object sender, EventArgs e)
        {
            if (loginTextBox.Text != string.Empty && passwordTextBox.Text != string.Empty)
            {
              SetLoginResult(Program.bridge.TryLogin(loginTextBox.Text, passwordTextBox.Text));

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
                        Close();
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
                if(color == Color.Green) Close();
            }));
        }
    }
}
