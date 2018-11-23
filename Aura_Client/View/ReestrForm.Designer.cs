namespace Aura_Client.View
{
    partial class ReestrForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReestrForm));
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
            this.resultOfControl = new System.Windows.Forms.RichTextBox();
            this.purchaseName = new System.Windows.Forms.RichTextBox();
            this.employeReestID = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.reestrStatus = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorMark = new System.Windows.Forms.Button();
            this.purchaseEisDateClr = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.commentsFontSetting = new System.Windows.Forms.Button();
            this.resultOfControlFontColor = new System.Windows.Forms.Button();
            this.organizationID = new System.Windows.Forms.TextBox();
            this.organisationSelectButton = new System.Windows.Forms.Button();
            this.contractPrice = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.reestrNumber = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.contractDateRealClr = new System.Windows.Forms.Button();
            this.contractDateReal = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.reestrDateLastClr = new System.Windows.Forms.Button();
            this.reestrDateLast = new System.Windows.Forms.DateTimePicker();
            this.showLogsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.purchacePrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 86);
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
            this.purchaseMethodID.Size = new System.Drawing.Size(272, 21);
            this.purchaseMethodID.TabIndex = 5;
            this.purchaseMethodID.Text = "Электронный аукцион";
            this.purchaseMethodID.SelectedIndexChanged += new System.EventHandler(this.purchaseMethodID_SelectedIndexChanged);
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
            this.purchaseEisNum.Location = new System.Drawing.Point(145, 166);
            this.purchaseEisNum.Name = "purchaseEisNum";
            this.purchaseEisNum.Size = new System.Drawing.Size(163, 20);
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
            this.purchaseEisDate.Location = new System.Drawing.Point(314, 166);
            this.purchaseEisDate.Name = "purchaseEisDate";
            this.purchaseEisDate.Size = new System.Drawing.Size(80, 20);
            this.purchaseEisDate.TabIndex = 14;
            this.purchaseEisDate.CloseUp += new System.EventHandler(this.dateTime_ValueChanged);
            this.purchaseEisDate.ValueChanged += new System.EventHandler(this.dateTime_ValueChanged);
            this.purchaseEisDate.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dateTimeField_KeyUp);
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
            this.law.Location = new System.Drawing.Point(400, 11);
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
            this.purchacePrice.Size = new System.Drawing.Size(272, 20);
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
            this.withAZK.Location = new System.Drawing.Point(400, 56);
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
            // resultOfControl
            // 
            this.resultOfControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.resultOfControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultOfControl.Location = new System.Drawing.Point(400, 416);
            this.resultOfControl.Name = "resultOfControl";
            this.resultOfControl.Size = new System.Drawing.Size(385, 91);
            this.resultOfControl.TabIndex = 51;
            this.resultOfControl.Text = "";
            this.resultOfControl.Leave += new System.EventHandler(this.textBox_ValueChanged);
            // 
            // purchaseName
            // 
            this.purchaseName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.purchaseName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.purchaseName.Location = new System.Drawing.Point(145, 12);
            this.purchaseName.Name = "purchaseName";
            this.purchaseName.Size = new System.Drawing.Size(249, 65);
            this.purchaseName.TabIndex = 53;
            this.purchaseName.Text = "Закупка меховых изделий";
            this.purchaseName.Leave += new System.EventHandler(this.textBox_ValueChanged);
            // 
            // employeReestID
            // 
            this.employeReestID.FormattingEnabled = true;
            this.employeReestID.Location = new System.Drawing.Point(544, 121);
            this.employeReestID.Name = "employeReestID";
            this.employeReestID.Size = new System.Drawing.Size(241, 21);
            this.employeReestID.TabIndex = 57;
            this.employeReestID.Text = "Николаев Антон";
            this.employeReestID.DropDownClosed += new System.EventHandler(this.comboBox_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(451, 116);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 26);
            this.label10.TabIndex = 56;
            this.label10.Text = "Ответственный\r\nза реестр";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // reestrStatus
            // 
            this.reestrStatus.BackColor = System.Drawing.Color.LightCoral;
            this.reestrStatus.Location = new System.Drawing.Point(656, 513);
            this.reestrStatus.Name = "reestrStatus";
            this.reestrStatus.Size = new System.Drawing.Size(129, 52);
            this.reestrStatus.TabIndex = 75;
            this.reestrStatus.Text = "Отметить после внесения";
            this.reestrStatus.UseVisualStyleBackColor = false;
            this.reestrStatus.Click += new System.EventHandler(this.reestrStatus_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(652, 173);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(39, 13);
            this.label19.TabIndex = 77;
            this.label19.Text = "Метка";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // colorMark
            // 
            this.colorMark.Location = new System.Drawing.Point(697, 166);
            this.colorMark.Name = "colorMark";
            this.colorMark.Size = new System.Drawing.Size(88, 40);
            this.colorMark.TabIndex = 78;
            this.colorMark.UseVisualStyleBackColor = true;
            this.colorMark.Click += new System.EventHandler(this.colorMark_Click);
            // 
            // purchaseEisDateClr
            // 
            this.purchaseEisDateClr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.purchaseEisDateClr.Location = new System.Drawing.Point(397, 166);
            this.purchaseEisDateClr.Margin = new System.Windows.Forms.Padding(0);
            this.purchaseEisDateClr.Name = "purchaseEisDateClr";
            this.purchaseEisDateClr.Size = new System.Drawing.Size(20, 20);
            this.purchaseEisDateClr.TabIndex = 79;
            this.purchaseEisDateClr.Text = "Х";
            this.purchaseEisDateClr.UseVisualStyleBackColor = true;
            this.purchaseEisDateClr.Click += new System.EventHandler(this.dateTimeClear_Click);
            // 
            // commentsFontSetting
            // 
            this.commentsFontSetting.Location = new System.Drawing.Point(91, 390);
            this.commentsFontSetting.Name = "commentsFontSetting";
            this.commentsFontSetting.Size = new System.Drawing.Size(100, 23);
            this.commentsFontSetting.TabIndex = 88;
            this.commentsFontSetting.Text = "Цвет шрифта";
            this.commentsFontSetting.UseVisualStyleBackColor = true;
            this.commentsFontSetting.Click += new System.EventHandler(this.commentsFontSetting_Click);
            // 
            // resultOfControlFontColor
            // 
            this.resultOfControlFontColor.Location = new System.Drawing.Point(516, 390);
            this.resultOfControlFontColor.Name = "resultOfControlFontColor";
            this.resultOfControlFontColor.Size = new System.Drawing.Size(100, 23);
            this.resultOfControlFontColor.TabIndex = 89;
            this.resultOfControlFontColor.Text = "Цвет шрифта";
            this.resultOfControlFontColor.UseVisualStyleBackColor = true;
            this.resultOfControlFontColor.Click += new System.EventHandler(this.resultOfControlFontColor_Click);
            // 
            // organizationID
            // 
            this.organizationID.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.organizationID.Location = new System.Drawing.Point(145, 83);
            this.organizationID.Name = "organizationID";
            this.organizationID.ReadOnly = true;
            this.organizationID.Size = new System.Drawing.Size(326, 20);
            this.organizationID.TabIndex = 90;
            this.organizationID.DoubleClick += new System.EventHandler(this.organisationSelectButton_Click);
            // 
            // organisationSelectButton
            // 
            this.organisationSelectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.organisationSelectButton.Location = new System.Drawing.Point(467, 82);
            this.organisationSelectButton.Name = "organisationSelectButton";
            this.organisationSelectButton.Size = new System.Drawing.Size(28, 20);
            this.organisationSelectButton.TabIndex = 91;
            this.organisationSelectButton.Text = "...";
            this.organisationSelectButton.UseVisualStyleBackColor = true;
            this.organisationSelectButton.Click += new System.EventHandler(this.organisationSelectButton_Click);
            // 
            // contractPrice
            // 
            this.contractPrice.DecimalPlaces = 2;
            this.contractPrice.Location = new System.Drawing.Point(223, 265);
            this.contractPrice.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.contractPrice.Name = "contractPrice";
            this.contractPrice.Size = new System.Drawing.Size(150, 20);
            this.contractPrice.TabIndex = 93;
            this.contractPrice.ThousandsSeparator = true;
            this.contractPrice.Value = new decimal(new int[] {
            25668821,
            0,
            0,
            131072});
            this.contractPrice.Leave += new System.EventHandler(this.numericUpDown_ValueChanges);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 92;
            this.label1.Text = "Сумма договора";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // reestrNumber
            // 
            this.reestrNumber.Location = new System.Drawing.Point(516, 266);
            this.reestrNumber.Name = "reestrNumber";
            this.reestrNumber.Size = new System.Drawing.Size(169, 20);
            this.reestrNumber.TabIndex = 95;
            this.reestrNumber.Text = "0322300112718000150";
            this.reestrNumber.Leave += new System.EventHandler(this.textBox_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(406, 269);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 13);
            this.label8.TabIndex = 94;
            this.label8.Text = "Реестровый номер";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // contractDateRealClr
            // 
            this.contractDateRealClr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contractDateRealClr.Location = new System.Drawing.Point(353, 288);
            this.contractDateRealClr.Margin = new System.Windows.Forms.Padding(0);
            this.contractDateRealClr.Name = "contractDateRealClr";
            this.contractDateRealClr.Size = new System.Drawing.Size(20, 20);
            this.contractDateRealClr.TabIndex = 97;
            this.contractDateRealClr.Text = "Х";
            this.contractDateRealClr.UseVisualStyleBackColor = true;
            this.contractDateRealClr.Click += new System.EventHandler(this.dateTimeClear_Click);
            // 
            // contractDateReal
            // 
            this.contractDateReal.CustomFormat = "";
            this.contractDateReal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.contractDateReal.Location = new System.Drawing.Point(255, 288);
            this.contractDateReal.Name = "contractDateReal";
            this.contractDateReal.Size = new System.Drawing.Size(95, 20);
            this.contractDateReal.TabIndex = 96;
            this.contractDateReal.CloseUp += new System.EventHandler(this.dateTime_ValueChanged);
            this.contractDateReal.ValueChanged += new System.EventHandler(this.dateTime_ValueChanged);
            this.contractDateReal.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dateTimeField_KeyUp);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(153, 292);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 13);
            this.label11.TabIndex = 98;
            this.label11.Text = "Дата подписания";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(429, 294);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(131, 13);
            this.label12.TabIndex = 101;
            this.label12.Text = "Дата внесения в реестр";
            // 
            // reestrDateLastClr
            // 
            this.reestrDateLastClr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reestrDateLastClr.Location = new System.Drawing.Point(665, 290);
            this.reestrDateLastClr.Margin = new System.Windows.Forms.Padding(0);
            this.reestrDateLastClr.Name = "reestrDateLastClr";
            this.reestrDateLastClr.Size = new System.Drawing.Size(20, 20);
            this.reestrDateLastClr.TabIndex = 100;
            this.reestrDateLastClr.Text = "Х";
            this.reestrDateLastClr.UseVisualStyleBackColor = true;
            this.reestrDateLastClr.Click += new System.EventHandler(this.dateTimeClear_Click);
            // 
            // reestrDateLast
            // 
            this.reestrDateLast.CustomFormat = "";
            this.reestrDateLast.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.reestrDateLast.Location = new System.Drawing.Point(567, 290);
            this.reestrDateLast.Name = "reestrDateLast";
            this.reestrDateLast.Size = new System.Drawing.Size(95, 20);
            this.reestrDateLast.TabIndex = 99;
            this.reestrDateLast.CloseUp += new System.EventHandler(this.dateTime_ValueChanged);
            this.reestrDateLast.ValueChanged += new System.EventHandler(this.dateTime_ValueChanged);
            this.reestrDateLast.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dateTimeField_KeyUp);
            // 
            // showLogsButton
            // 
            this.showLogsButton.Location = new System.Drawing.Point(8, 542);
            this.showLogsButton.Name = "showLogsButton";
            this.showLogsButton.Size = new System.Drawing.Size(122, 23);
            this.showLogsButton.TabIndex = 102;
            this.showLogsButton.Text = "Журнал обработки";
            this.showLogsButton.UseVisualStyleBackColor = true;
            this.showLogsButton.Click += new System.EventHandler(this.showLogsButton_Click);
            // 
            // ReestrForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 569);
            this.Controls.Add(this.showLogsButton);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.reestrDateLastClr);
            this.Controls.Add(this.reestrDateLast);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.contractDateRealClr);
            this.Controls.Add(this.contractDateReal);
            this.Controls.Add(this.reestrNumber);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.contractPrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.organisationSelectButton);
            this.Controls.Add(this.organizationID);
            this.Controls.Add(this.resultOfControlFontColor);
            this.Controls.Add(this.commentsFontSetting);
            this.Controls.Add(this.purchaseEisDateClr);
            this.Controls.Add(this.colorMark);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.reestrStatus);
            this.Controls.Add(this.employeReestID);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.purchaseName);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.resultOfControl);
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
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReestrForm";
            this.Text = "Договор в реестре";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ReestrForm_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.purchacePrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
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
        private System.Windows.Forms.RichTextBox resultOfControl;
        private System.Windows.Forms.RichTextBox purchaseName;
        private System.Windows.Forms.ComboBox employeReestID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button reestrStatus;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button colorMark;
        private System.Windows.Forms.Button purchaseEisDateClr;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Button commentsFontSetting;
        private System.Windows.Forms.Button resultOfControlFontColor;
        private System.Windows.Forms.TextBox organizationID;
        private System.Windows.Forms.Button organisationSelectButton;
        private System.Windows.Forms.NumericUpDown contractPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox reestrNumber;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button contractDateRealClr;
        private System.Windows.Forms.DateTimePicker contractDateReal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button reestrDateLastClr;
        private System.Windows.Forms.DateTimePicker reestrDateLast;
        private System.Windows.Forms.Button showLogsButton;
    }
}