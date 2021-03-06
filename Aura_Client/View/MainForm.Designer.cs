﻿namespace Aura_Client.View
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.adminPanel = new System.Windows.Forms.Panel();
            this.methodsButton = new System.Windows.Forms.Button();
            this.statusesButton = new System.Windows.Forms.Button();
            this.usersButton = new System.Windows.Forms.Button();
            this.settingsButton = new System.Windows.Forms.Button();
            this.switchUserButton = new System.Windows.Forms.Button();
            this.changePasswordButton = new System.Windows.Forms.Button();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.documentationButton = new System.Windows.Forms.Button();
            this.toExcelButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.calendarButton = new System.Windows.Forms.Button();
            this.purchasesListButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.adminPanel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.adminPanel);
            this.panel1.Controls.Add(this.settingsButton);
            this.panel1.Controls.Add(this.switchUserButton);
            this.panel1.Controls.Add(this.changePasswordButton);
            this.panel1.Controls.Add(this.userNameLabel);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(795, 101);
            this.panel1.TabIndex = 1;
            // 
            // adminPanel
            // 
            this.adminPanel.Controls.Add(this.methodsButton);
            this.adminPanel.Controls.Add(this.statusesButton);
            this.adminPanel.Controls.Add(this.usersButton);
            this.adminPanel.Location = new System.Drawing.Point(496, 3);
            this.adminPanel.Name = "adminPanel";
            this.adminPanel.Size = new System.Drawing.Size(296, 95);
            this.adminPanel.TabIndex = 6;
            // 
            // methodsButton
            // 
            this.methodsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.methodsButton.Location = new System.Drawing.Point(149, 28);
            this.methodsButton.Name = "methodsButton";
            this.methodsButton.Size = new System.Drawing.Size(140, 32);
            this.methodsButton.TabIndex = 4;
            this.methodsButton.Text = "Способы закупок";
            this.methodsButton.UseVisualStyleBackColor = true;
            this.methodsButton.Click += new System.EventHandler(this.methodsButton_Click);
            // 
            // statusesButton
            // 
            this.statusesButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.statusesButton.Location = new System.Drawing.Point(3, 63);
            this.statusesButton.Name = "statusesButton";
            this.statusesButton.Size = new System.Drawing.Size(140, 32);
            this.statusesButton.TabIndex = 3;
            this.statusesButton.Text = "Этапы закупок";
            this.statusesButton.UseVisualStyleBackColor = true;
            this.statusesButton.Click += new System.EventHandler(this.statusesButton_Click);
            // 
            // usersButton
            // 
            this.usersButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.usersButton.Location = new System.Drawing.Point(3, 28);
            this.usersButton.Name = "usersButton";
            this.usersButton.Size = new System.Drawing.Size(140, 32);
            this.usersButton.TabIndex = 2;
            this.usersButton.Text = "Пользователи";
            this.usersButton.UseVisualStyleBackColor = true;
            this.usersButton.Click += new System.EventHandler(this.usersButton_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsButton.Location = new System.Drawing.Point(153, 31);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(140, 32);
            this.settingsButton.TabIndex = 5;
            this.settingsButton.Text = "Настройки";
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // switchUserButton
            // 
            this.switchUserButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.switchUserButton.Location = new System.Drawing.Point(7, 31);
            this.switchUserButton.Name = "switchUserButton";
            this.switchUserButton.Size = new System.Drawing.Size(140, 32);
            this.switchUserButton.TabIndex = 4;
            this.switchUserButton.Text = "Выйти";
            this.switchUserButton.UseVisualStyleBackColor = true;
            this.switchUserButton.Click += new System.EventHandler(this.switchUserButton_Click);
            // 
            // changePasswordButton
            // 
            this.changePasswordButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.changePasswordButton.Location = new System.Drawing.Point(7, 66);
            this.changePasswordButton.Name = "changePasswordButton";
            this.changePasswordButton.Size = new System.Drawing.Size(140, 32);
            this.changePasswordButton.TabIndex = 3;
            this.changePasswordButton.Text = "Сменить пароль";
            this.changePasswordButton.UseVisualStyleBackColor = true;
            this.changePasswordButton.Click += new System.EventHandler(this.changePasswordButton_Click);
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userNameLabel.Location = new System.Drawing.Point(3, 0);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(268, 20);
            this.userNameLabel.TabIndex = 0;
            this.userNameLabel.Text = "Ошибка. Необходимо перезайти...";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Location = new System.Drawing.Point(12, 351);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(795, 101);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.documentationButton);
            this.panel3.Controls.Add(this.toExcelButton);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.calendarButton);
            this.panel3.Controls.Add(this.purchasesListButton);
            this.panel3.Location = new System.Drawing.Point(12, 119);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(795, 226);
            this.panel3.TabIndex = 3;
            // 
            // documentationButton
            // 
            this.documentationButton.Location = new System.Drawing.Point(400, 144);
            this.documentationButton.Name = "documentationButton";
            this.documentationButton.Size = new System.Drawing.Size(140, 57);
            this.documentationButton.TabIndex = 5;
            this.documentationButton.Text = " Документация";
            this.documentationButton.UseVisualStyleBackColor = true;
            this.documentationButton.Click += new System.EventHandler(this.documentationButton_Click);
            // 
            // toExcelButton
            // 
            this.toExcelButton.BackgroundImage = global::Aura_Client.Properties.Resources.excelIcon;
            this.toExcelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toExcelButton.Location = new System.Drawing.Point(692, 80);
            this.toExcelButton.Name = "toExcelButton";
            this.toExcelButton.Size = new System.Drawing.Size(55, 55);
            this.toExcelButton.TabIndex = 4;
            this.toExcelButton.UseVisualStyleBackColor = true;
            this.toExcelButton.Click += new System.EventHandler(this.toExcelButton_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(546, 79);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 57);
            this.button3.TabIndex = 4;
            this.button3.Text = "Отчеты заказчиков";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(546, 16);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 57);
            this.button2.TabIndex = 3;
            this.button2.Text = "Реестр договоров";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 57);
            this.button1.TabIndex = 2;
            this.button1.Text = "Список организаций";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // calendarButton
            // 
            this.calendarButton.Location = new System.Drawing.Point(400, 79);
            this.calendarButton.Name = "calendarButton";
            this.calendarButton.Size = new System.Drawing.Size(140, 57);
            this.calendarButton.TabIndex = 1;
            this.calendarButton.Text = "Календарь закупок";
            this.calendarButton.UseVisualStyleBackColor = true;
            this.calendarButton.Click += new System.EventHandler(this.calendarButton_Click);
            // 
            // purchasesListButton
            // 
            this.purchasesListButton.Location = new System.Drawing.Point(400, 16);
            this.purchasesListButton.Name = "purchasesListButton";
            this.purchasesListButton.Size = new System.Drawing.Size(140, 57);
            this.purchasesListButton.TabIndex = 0;
            this.purchasesListButton.Text = "Список закупок";
            this.purchasesListButton.UseVisualStyleBackColor = true;
            this.purchasesListButton.Click += new System.EventHandler(this.purchasesListButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 464);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Aura";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.adminPanel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button calendarButton;
        private System.Windows.Forms.Button purchasesListButton;
        private System.Windows.Forms.Button usersButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button switchUserButton;
        private System.Windows.Forms.Button changePasswordButton;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button toExcelButton;
        private System.Windows.Forms.Button documentationButton;
        private System.Windows.Forms.Panel adminPanel;
        private System.Windows.Forms.Button methodsButton;
        private System.Windows.Forms.Button statusesButton;
    }
}