namespace Aura_Client.View
{
    partial class PurchaseForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchaseForm));
            this.label1 = new System.Windows.Forms.Label();
            this.employeID = new System.Windows.Forms.ComboBox();
            this.organizationID = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.purchaseMethodID = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.statusID = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.purchaseEisNum = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.purchaseEisDate = new System.Windows.Forms.DateTimePicker();
            this.comments = new System.Windows.Forms.RichTextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.law = new System.Windows.Forms.ComboBox();
            this.purchacePrice = new System.Windows.Forms.NumericUpDown();
            this.withAZK = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.dateTimePicker5 = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.dateTimePicker6 = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.dateTimePicker7 = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.dateTimePicker8 = new System.Windows.Forms.DateTimePicker();
            this.label18 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.purchacePrice)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(426, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ответственный \r\nза разработку";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // employeID
            // 
            this.employeID.FormattingEnabled = true;
            this.employeID.Location = new System.Drawing.Point(521, 112);
            this.employeID.Name = "employeID";
            this.employeID.Size = new System.Drawing.Size(264, 21);
            this.employeID.TabIndex = 1;
            this.employeID.Text = "Иванов Петр";
            this.employeID.DropDownClosed += new System.EventHandler(this.comboBox_ValueChanged);
            // 
            // organizationID
            // 
            this.organizationID.FormattingEnabled = true;
            this.organizationID.Location = new System.Drawing.Point(145, 67);
            this.organizationID.Name = "organizationID";
            this.organizationID.Size = new System.Drawing.Size(335, 21);
            this.organizationID.TabIndex = 3;
            this.organizationID.Text = "ОГБУЗ Больница № 1";
            this.organizationID.DropDownClosed += new System.EventHandler(this.comboBox_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Организация-заказчик";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // purchaseMethodID
            // 
            this.purchaseMethodID.FormattingEnabled = true;
            this.purchaseMethodID.Location = new System.Drawing.Point(145, 109);
            this.purchaseMethodID.Name = "purchaseMethodID";
            this.purchaseMethodID.Size = new System.Drawing.Size(259, 21);
            this.purchaseMethodID.TabIndex = 5;
            this.purchaseMethodID.Text = "Электронный аукцион";
            this.purchaseMethodID.DropDownClosed += new System.EventHandler(this.comboBox_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Способ определения";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Наименование закупки";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // statusID
            // 
            this.statusID.FormattingEnabled = true;
            this.statusID.Location = new System.Drawing.Point(609, 17);
            this.statusID.Name = "statusID";
            this.statusID.Size = new System.Drawing.Size(176, 21);
            this.statusID.TabIndex = 9;
            this.statusID.Text = "Опубликована";
            this.statusID.DropDownClosed += new System.EventHandler(this.comboBox_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(518, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Статус закупки";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Сумма закупки";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // purchaseEisNum
            // 
            this.purchaseEisNum.Location = new System.Drawing.Point(145, 169);
            this.purchaseEisNum.Name = "purchaseEisNum";
            this.purchaseEisNum.Size = new System.Drawing.Size(158, 20);
            this.purchaseEisNum.TabIndex = 13;
            this.purchaseEisNum.Text = "0322300112718000150";
            this.purchaseEisNum.Leave += new System.EventHandler(this.textBox_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Извещение в ЕИС";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // purchaseEisDate
            // 
            this.purchaseEisDate.CustomFormat = "";
            this.purchaseEisDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.purchaseEisDate.Location = new System.Drawing.Point(309, 169);
            this.purchaseEisDate.Name = "purchaseEisDate";
            this.purchaseEisDate.Size = new System.Drawing.Size(95, 20);
            this.purchaseEisDate.TabIndex = 14;
            this.purchaseEisDate.ValueChanged += new System.EventHandler(this.dateTime_ValueChanged);
            // 
            // comments
            // 
            this.comments.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.comments.Location = new System.Drawing.Point(8, 416);
            this.comments.Name = "comments";
            this.comments.Size = new System.Drawing.Size(385, 91);
            this.comments.TabIndex = 42;
            this.comments.Text = "";
            this.comments.Leave += new System.EventHandler(this.textBox_ValueChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(5, 400);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(80, 13);
            this.label22.TabIndex = 43;
            this.label22.Text = "Комментарии:";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(262, 513);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(100, 44);
            this.buttonOK.TabIndex = 45;
            this.buttonOK.Text = "ОК";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(438, 513);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(100, 44);
            this.buttonCancel.TabIndex = 46;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // law
            // 
            this.law.FormattingEnabled = true;
            this.law.Location = new System.Drawing.Point(385, 11);
            this.law.Name = "law";
            this.law.Size = new System.Drawing.Size(95, 21);
            this.law.TabIndex = 47;
            this.law.Text = "223-ФЗ";
            this.law.Leave += new System.EventHandler(this.comboBox_ValueChanged);
            // 
            // purchacePrice
            // 
            this.purchacePrice.DecimalPlaces = 2;
            this.purchacePrice.Location = new System.Drawing.Point(145, 135);
            this.purchacePrice.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.purchacePrice.Name = "purchacePrice";
            this.purchacePrice.Size = new System.Drawing.Size(259, 20);
            this.purchacePrice.TabIndex = 48;
            this.purchacePrice.ThousandsSeparator = true;
            this.purchacePrice.Value = new decimal(new int[] {
            25668821,
            0,
            0,
            131072});
            this.purchacePrice.Leave += new System.EventHandler(this.numericUpDown_ValueChanges);
            // 
            // withAZK
            // 
            this.withAZK.FormattingEnabled = true;
            this.withAZK.Location = new System.Drawing.Point(385, 40);
            this.withAZK.Name = "withAZK";
            this.withAZK.Size = new System.Drawing.Size(95, 21);
            this.withAZK.TabIndex = 50;
            this.withAZK.Text = "С АЦК";
            this.withAZK.Leave += new System.EventHandler(this.comboBox_ValueChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(397, 400);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(113, 13);
            this.label16.TabIndex = 52;
            this.label16.Text = "Результат проверки:";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Location = new System.Drawing.Point(400, 416);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(385, 91);
            this.richTextBox1.TabIndex = 51;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox2.Location = new System.Drawing.Point(145, 12);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(234, 49);
            this.richTextBox2.TabIndex = 53;
            this.richTextBox2.Text = "Закупка меховых изделий";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(609, 67);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(176, 21);
            this.comboBox1.TabIndex = 55;
            this.comboBox1.Text = "<не указано>";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(500, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 13);
            this.label9.TabIndex = 54;
            this.label9.Text = "Статус протоколов";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(521, 154);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(264, 21);
            this.comboBox2.TabIndex = 57;
            this.comboBox2.Text = "Николаев Антон";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(428, 150);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 26);
            this.label10.TabIndex = 56;
            this.label10.Text = "Ответственный\r\nза размещение";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(135, 232);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 13);
            this.label8.TabIndex = 58;
            this.label8.Text = "Начало подачи заявок";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(262, 232);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(110, 20);
            this.dateTimePicker1.TabIndex = 59;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(544, 232);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(110, 20);
            this.dateTimePicker2.TabIndex = 61;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(399, 232);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(139, 13);
            this.label11.TabIndex = 60;
            this.label11.Text = "Окончание подачи заявок";
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.CustomFormat = "";
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker3.Location = new System.Drawing.Point(262, 280);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(110, 20);
            this.dateTimePicker3.TabIndex = 63;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(199, 280);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 13);
            this.label12.TabIndex = 62;
            this.label12.Text = "Вскрытие";
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.CustomFormat = "";
            this.dateTimePicker4.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker4.Location = new System.Drawing.Point(262, 306);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(110, 20);
            this.dateTimePicker4.TabIndex = 65;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(175, 306);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 13);
            this.label13.TabIndex = 64;
            this.label13.Text = "Рассмотрение";
            // 
            // dateTimePicker5
            // 
            this.dateTimePicker5.CustomFormat = "";
            this.dateTimePicker5.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker5.Location = new System.Drawing.Point(262, 332);
            this.dateTimePicker5.Name = "dateTimePicker5";
            this.dateTimePicker5.Size = new System.Drawing.Size(110, 20);
            this.dateTimePicker5.TabIndex = 67;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(211, 332);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(45, 13);
            this.label14.TabIndex = 66;
            this.label14.Text = "Оценка";
            // 
            // dateTimePicker6
            // 
            this.dateTimePicker6.CustomFormat = "";
            this.dateTimePicker6.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker6.Location = new System.Drawing.Point(544, 280);
            this.dateTimePicker6.Name = "dateTimePicker6";
            this.dateTimePicker6.Size = new System.Drawing.Size(110, 20);
            this.dateTimePicker6.TabIndex = 69;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(460, 280);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(78, 13);
            this.label15.TabIndex = 68;
            this.label15.Text = "Первые части";
            // 
            // dateTimePicker7
            // 
            this.dateTimePicker7.CustomFormat = "";
            this.dateTimePicker7.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker7.Location = new System.Drawing.Point(544, 306);
            this.dateTimePicker7.Name = "dateTimePicker7";
            this.dateTimePicker7.Size = new System.Drawing.Size(110, 20);
            this.dateTimePicker7.TabIndex = 71;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(462, 306);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(76, 13);
            this.label17.TabIndex = 70;
            this.label17.Text = "Вторые части";
            // 
            // dateTimePicker8
            // 
            this.dateTimePicker8.CustomFormat = "";
            this.dateTimePicker8.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker8.Location = new System.Drawing.Point(544, 332);
            this.dateTimePicker8.Name = "dateTimePicker8";
            this.dateTimePicker8.Size = new System.Drawing.Size(110, 20);
            this.dateTimePicker8.TabIndex = 73;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(432, 332);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(106, 13);
            this.label18.TabIndex = 72;
            this.label18.Text = "Подведение итогов";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGreen;
            this.button1.Location = new System.Drawing.Point(656, 513);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 44);
            this.button1.TabIndex = 75;
            this.button1.Text = "Проверено";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // PurchaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 569);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker8);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.dateTimePicker7);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.dateTimePicker6);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.dateTimePicker5);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.dateTimePicker4);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dateTimePicker3);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.withAZK);
            this.Controls.Add(this.purchacePrice);
            this.Controls.Add(this.law);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.comments);
            this.Controls.Add(this.purchaseEisDate);
            this.Controls.Add(this.purchaseEisNum);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.statusID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.purchaseMethodID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.organizationID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.employeID);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PurchaseForm";
            this.Text = "PurchaseForm";
            ((System.ComponentModel.ISupportInitialize)(this.purchacePrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox employeID;
        private System.Windows.Forms.ComboBox organizationID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox purchaseMethodID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox statusID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox purchaseEisNum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker purchaseEisDate;
        private System.Windows.Forms.RichTextBox comments;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox law;
        private System.Windows.Forms.NumericUpDown purchacePrice;
        private System.Windows.Forms.ComboBox withAZK;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dateTimePicker5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dateTimePicker6;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dateTimePicker7;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DateTimePicker dateTimePicker8;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button button1;
    }
}