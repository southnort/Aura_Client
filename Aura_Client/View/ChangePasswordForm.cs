﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aura_Client.View
{
    public partial class ChangePasswordForm : Form
    {
        public ChangePasswordForm()
        {
            InitializeComponent();
        }

        private void saveNewPasswordButton_Click(object sender, EventArgs e)
        {
            string control = string.Empty;

            if (currentPasswordTextBox.Text == string.Empty)
                control += "Заполните текущий пароль\n";

            if (Program.user.password != currentPasswordTextBox.Text)
                control += "Текущий пароль указан неверно\n";

            if (newPasswordTextBox.Text == string.Empty)
                control += "Укажите новый пароль\n";

            if (newPasswordTextBox.Text != repeatNewpasswordTextBox.Text)
                control += " Значения в полях \"Новый пароль\" и \"Повторите новый пароль\" должны совпадать\n";


        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
