using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Aura_Client.Controller;

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
                int result = NetworkBridge.TryLogin(loginTextBox.Text, passwordTextBox.Text);


                switch (result)
                {
                    case -1:
                        {
                            resultTextLabel.Text = "Ошибка соединения с сервером";
                            resultTextLabel.ForeColor = Color.Red;

                        }
                        break;

                    case 0:
                        {
                            resultTextLabel.Text = "Неправильный логин или пароль";
                            resultTextLabel.ForeColor = Color.Red;
                        }
                        break;

                    default:
                        {
                            resultTextLabel.Text = "Аутентификация пройдена";
                            resultTextLabel.ForeColor = Color.Green;
                            Close();
                        }
                        break;
                }


            }
        }
    }
}
