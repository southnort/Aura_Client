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
            this.employeDocumentationID = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.purchaseMethodID = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.statusID = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.purchaseEisNum = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
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
            this.protocolStatusID = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.employeID = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.bidsStartDate = new System.Windows.Forms.DateTimePicker();
            this.bidsEndDate = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.bidsOpenDate = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.bidsReviewDate = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.bidsRatingDate = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.bidsFirstPartDate = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.bidsSecondPartDate = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.bidsFinishDate = new System.Windows.Forms.DateTimePicker();
            this.label18 = new System.Windows.Forms.Label();
            this.controlStatus = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorMark = new System.Windows.Forms.Button();
            this.purchaseEisDateClr = new System.Windows.Forms.Button();
            this.bidsStartDateClr = new System.Windows.Forms.Button();
            this.bidsOpenDateClr = new System.Windows.Forms.Button();
            this.bidsReviewDateClr = new System.Windows.Forms.Button();
            this.bidsRatingDateClr = new System.Windows.Forms.Button();
            this.bidsEndDateClr = new System.Windows.Forms.Button();
            this.bidsFirstPartDateClr = new System.Windows.Forms.Button();
            this.bidsSecondPartDateClr = new System.Windows.Forms.Button();
            this.bidsFinishDateClr = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.commentsFontSetting = new System.Windows.Forms.Button();
            this.resultOfControlFontColor = new System.Windows.Forms.Button();
            this.organizationID = new System.Windows.Forms.TextBox();
            this.organisationSelectButton = new System.Windows.Forms.Button();
            this.auctionDateClr = new System.Windows.Forms.Button();
            this.auctionDate = new System.Windows.Forms.DateTimePicker();
            this.label20 = new System.Windows.Forms.Label();
            this.showLogsButton = new System.Windows.Forms.Button();
            this.purchaseEisDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.purchacePrice)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(449, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ответственный \r\nза разработку";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // employeDocumentationID
            // 
            this.employeDocumentationID.FormattingEnabled = true;
            this.employeDocumentationID.Location = new System.Drawing.Point(544, 112);
            this.employeDocumentationID.Name = "employeDocumentationID";
            this.employeDocumentationID.Size = new System.Drawing.Size(241, 21);
            this.employeDocumentationID.TabIndex = 1;
            this.employeDocumentationID.Text = "Иванов Петр";
            this.employeDocumentationID.DropDownClosed += new System.EventHandler(this.comboBox_ValueChanged);
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
            this.purchaseEisNum.Size = new System.Drawing.Size(162, 20);
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
            this.law.Location = new System.Drawing.Point(402, 11);
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
            this.purchacePrice.Leave += new System.EventHandler(this.numericUpDown_ValueChanges);
            // 
            // withAZK
            // 
            this.withAZK.FormattingEnabled = true;
            this.withAZK.Location = new System.Drawing.Point(402, 56);
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
            this.purchaseName.Size = new System.Drawing.Size(251, 65);
            this.purchaseName.TabIndex = 53;
            this.purchaseName.Text = "Закупка меховых изделий";
            this.purchaseName.Leave += new System.EventHandler(this.textBox_ValueChanged);
            // 
            // protocolStatusID
            // 
            this.protocolStatusID.FormattingEnabled = true;
            this.protocolStatusID.Location = new System.Drawing.Point(609, 67);
            this.protocolStatusID.Name = "protocolStatusID";
            this.protocolStatusID.Size = new System.Drawing.Size(176, 21);
            this.protocolStatusID.TabIndex = 55;
            this.protocolStatusID.Text = "<не указано>";
            this.protocolStatusID.DropDownClosed += new System.EventHandler(this.comboBox_ValueChanged);
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
            // employeID
            // 
            this.employeID.FormattingEnabled = true;
            this.employeID.Location = new System.Drawing.Point(544, 154);
            this.employeID.Name = "employeID";
            this.employeID.Size = new System.Drawing.Size(241, 21);
            this.employeID.TabIndex = 57;
            this.employeID.Text = "Николаев Антон";
            this.employeID.DropDownClosed += new System.EventHandler(this.comboBox_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(451, 149);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 26);
            this.label10.TabIndex = 56;
            this.label10.Text = "Ответственный\r\nза размещение";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(43, 223);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 13);
            this.label8.TabIndex = 58;
            this.label8.Text = "Начало подачи заявок";
            // 
            // bidsStartDate
            // 
            this.bidsStartDate.CustomFormat = "";
            this.bidsStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.bidsStartDate.Location = new System.Drawing.Point(170, 223);
            this.bidsStartDate.Name = "bidsStartDate";
            this.bidsStartDate.Size = new System.Drawing.Size(139, 20);
            this.bidsStartDate.TabIndex = 59;
            this.bidsStartDate.CloseUp += new System.EventHandler(this.dateTime_ValueChanged);
            this.bidsStartDate.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dateTimeField_KeyUp);
            // 
            // bidsEndDate
            // 
            this.bidsEndDate.CustomFormat = "";
            this.bidsEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.bidsEndDate.Location = new System.Drawing.Point(503, 223);
            this.bidsEndDate.Name = "bidsEndDate";
            this.bidsEndDate.Size = new System.Drawing.Size(152, 20);
            this.bidsEndDate.TabIndex = 61;
            this.bidsEndDate.CloseUp += new System.EventHandler(this.dateTime_ValueChanged);
            this.bidsEndDate.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dateTimeField_KeyUp);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(358, 223);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(139, 13);
            this.label11.TabIndex = 60;
            this.label11.Text = "Окончание подачи заявок";
            // 
            // bidsOpenDate
            // 
            this.bidsOpenDate.CustomFormat = "";
            this.bidsOpenDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.bidsOpenDate.Location = new System.Drawing.Point(170, 261);
            this.bidsOpenDate.Name = "bidsOpenDate";
            this.bidsOpenDate.Size = new System.Drawing.Size(139, 20);
            this.bidsOpenDate.TabIndex = 63;
            this.bidsOpenDate.CloseUp += new System.EventHandler(this.dateTime_ValueChanged);
            this.bidsOpenDate.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dateTimeField_KeyUp);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(107, 261);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 13);
            this.label12.TabIndex = 62;
            this.label12.Text = "Вскрытие";
            // 
            // bidsReviewDate
            // 
            this.bidsReviewDate.CustomFormat = "";
            this.bidsReviewDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.bidsReviewDate.Location = new System.Drawing.Point(170, 287);
            this.bidsReviewDate.Name = "bidsReviewDate";
            this.bidsReviewDate.Size = new System.Drawing.Size(139, 20);
            this.bidsReviewDate.TabIndex = 65;
            this.bidsReviewDate.CloseUp += new System.EventHandler(this.dateTime_ValueChanged);
            this.bidsReviewDate.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dateTimeField_KeyUp);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(83, 287);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 13);
            this.label13.TabIndex = 64;
            this.label13.Text = "Рассмотрение";
            // 
            // bidsRatingDate
            // 
            this.bidsRatingDate.CustomFormat = "";
            this.bidsRatingDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.bidsRatingDate.Location = new System.Drawing.Point(170, 313);
            this.bidsRatingDate.Name = "bidsRatingDate";
            this.bidsRatingDate.Size = new System.Drawing.Size(139, 20);
            this.bidsRatingDate.TabIndex = 67;
            this.bidsRatingDate.CloseUp += new System.EventHandler(this.dateTime_ValueChanged);
            this.bidsRatingDate.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dateTimeField_KeyUp);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(119, 313);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(45, 13);
            this.label14.TabIndex = 66;
            this.label14.Text = "Оценка";
            // 
            // bidsFirstPartDate
            // 
            this.bidsFirstPartDate.CustomFormat = "";
            this.bidsFirstPartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.bidsFirstPartDate.Location = new System.Drawing.Point(503, 261);
            this.bidsFirstPartDate.Name = "bidsFirstPartDate";
            this.bidsFirstPartDate.Size = new System.Drawing.Size(152, 20);
            this.bidsFirstPartDate.TabIndex = 69;
            this.bidsFirstPartDate.CloseUp += new System.EventHandler(this.dateTime_ValueChanged);
            this.bidsFirstPartDate.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dateTimeField_KeyUp);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(419, 261);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(78, 13);
            this.label15.TabIndex = 68;
            this.label15.Text = "Первые части";
            // 
            // bidsSecondPartDate
            // 
            this.bidsSecondPartDate.CustomFormat = "";
            this.bidsSecondPartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.bidsSecondPartDate.Location = new System.Drawing.Point(503, 313);
            this.bidsSecondPartDate.Name = "bidsSecondPartDate";
            this.bidsSecondPartDate.Size = new System.Drawing.Size(152, 20);
            this.bidsSecondPartDate.TabIndex = 71;
            this.bidsSecondPartDate.CloseUp += new System.EventHandler(this.dateTime_ValueChanged);
            this.bidsSecondPartDate.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dateTimeField_KeyUp);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(421, 313);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(76, 13);
            this.label17.TabIndex = 70;
            this.label17.Text = "Вторые части";
            // 
            // bidsFinishDate
            // 
            this.bidsFinishDate.CustomFormat = "";
            this.bidsFinishDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.bidsFinishDate.Location = new System.Drawing.Point(503, 339);
            this.bidsFinishDate.Name = "bidsFinishDate";
            this.bidsFinishDate.Size = new System.Drawing.Size(152, 20);
            this.bidsFinishDate.TabIndex = 73;
            this.bidsFinishDate.CloseUp += new System.EventHandler(this.dateTime_ValueChanged);
            this.bidsFinishDate.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dateTimeField_KeyUp);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(391, 339);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(106, 13);
            this.label18.TabIndex = 72;
            this.label18.Text = "Подведение итогов";
            // 
            // controlStatus
            // 
            this.controlStatus.BackColor = System.Drawing.Color.LightCoral;
            this.controlStatus.Location = new System.Drawing.Point(656, 513);
            this.controlStatus.Name = "controlStatus";
            this.controlStatus.Size = new System.Drawing.Size(129, 44);
            this.controlStatus.TabIndex = 75;
            this.controlStatus.Text = "Проверить";
            this.controlStatus.UseVisualStyleBackColor = false;
            this.controlStatus.Click += new System.EventHandler(this.controlStatus_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(652, 195);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(39, 13);
            this.label19.TabIndex = 77;
            this.label19.Text = "Метка";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // colorMark
            // 
            this.colorMark.Location = new System.Drawing.Point(697, 188);
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
            // bidsStartDateClr
            // 
            this.bidsStartDateClr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bidsStartDateClr.Location = new System.Drawing.Point(312, 223);
            this.bidsStartDateClr.Margin = new System.Windows.Forms.Padding(0);
            this.bidsStartDateClr.Name = "bidsStartDateClr";
            this.bidsStartDateClr.Size = new System.Drawing.Size(20, 20);
            this.bidsStartDateClr.TabIndex = 80;
            this.bidsStartDateClr.Text = "Х";
            this.bidsStartDateClr.UseVisualStyleBackColor = true;
            this.bidsStartDateClr.Click += new System.EventHandler(this.dateTimeClear_Click);
            // 
            // bidsOpenDateClr
            // 
            this.bidsOpenDateClr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bidsOpenDateClr.Location = new System.Drawing.Point(312, 261);
            this.bidsOpenDateClr.Margin = new System.Windows.Forms.Padding(0);
            this.bidsOpenDateClr.Name = "bidsOpenDateClr";
            this.bidsOpenDateClr.Size = new System.Drawing.Size(20, 20);
            this.bidsOpenDateClr.TabIndex = 81;
            this.bidsOpenDateClr.Text = "Х";
            this.bidsOpenDateClr.UseVisualStyleBackColor = true;
            this.bidsOpenDateClr.Click += new System.EventHandler(this.dateTimeClear_Click);
            // 
            // bidsReviewDateClr
            // 
            this.bidsReviewDateClr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bidsReviewDateClr.Location = new System.Drawing.Point(312, 287);
            this.bidsReviewDateClr.Margin = new System.Windows.Forms.Padding(0);
            this.bidsReviewDateClr.Name = "bidsReviewDateClr";
            this.bidsReviewDateClr.Size = new System.Drawing.Size(20, 20);
            this.bidsReviewDateClr.TabIndex = 82;
            this.bidsReviewDateClr.Text = "Х";
            this.bidsReviewDateClr.UseVisualStyleBackColor = true;
            this.bidsReviewDateClr.Click += new System.EventHandler(this.dateTimeClear_Click);
            // 
            // bidsRatingDateClr
            // 
            this.bidsRatingDateClr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bidsRatingDateClr.Location = new System.Drawing.Point(312, 313);
            this.bidsRatingDateClr.Margin = new System.Windows.Forms.Padding(0);
            this.bidsRatingDateClr.Name = "bidsRatingDateClr";
            this.bidsRatingDateClr.Size = new System.Drawing.Size(20, 20);
            this.bidsRatingDateClr.TabIndex = 83;
            this.bidsRatingDateClr.Text = "Х";
            this.bidsRatingDateClr.UseVisualStyleBackColor = true;
            this.bidsRatingDateClr.Click += new System.EventHandler(this.dateTimeClear_Click);
            // 
            // bidsEndDateClr
            // 
            this.bidsEndDateClr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bidsEndDateClr.Location = new System.Drawing.Point(658, 223);
            this.bidsEndDateClr.Margin = new System.Windows.Forms.Padding(0);
            this.bidsEndDateClr.Name = "bidsEndDateClr";
            this.bidsEndDateClr.Size = new System.Drawing.Size(20, 20);
            this.bidsEndDateClr.TabIndex = 84;
            this.bidsEndDateClr.Text = "Х";
            this.bidsEndDateClr.UseVisualStyleBackColor = true;
            this.bidsEndDateClr.Click += new System.EventHandler(this.dateTimeClear_Click);
            // 
            // bidsFirstPartDateClr
            // 
            this.bidsFirstPartDateClr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bidsFirstPartDateClr.Location = new System.Drawing.Point(658, 261);
            this.bidsFirstPartDateClr.Margin = new System.Windows.Forms.Padding(0);
            this.bidsFirstPartDateClr.Name = "bidsFirstPartDateClr";
            this.bidsFirstPartDateClr.Size = new System.Drawing.Size(20, 20);
            this.bidsFirstPartDateClr.TabIndex = 85;
            this.bidsFirstPartDateClr.Text = "Х";
            this.bidsFirstPartDateClr.UseVisualStyleBackColor = true;
            this.bidsFirstPartDateClr.Click += new System.EventHandler(this.dateTimeClear_Click);
            // 
            // bidsSecondPartDateClr
            // 
            this.bidsSecondPartDateClr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bidsSecondPartDateClr.Location = new System.Drawing.Point(658, 313);
            this.bidsSecondPartDateClr.Margin = new System.Windows.Forms.Padding(0);
            this.bidsSecondPartDateClr.Name = "bidsSecondPartDateClr";
            this.bidsSecondPartDateClr.Size = new System.Drawing.Size(20, 20);
            this.bidsSecondPartDateClr.TabIndex = 86;
            this.bidsSecondPartDateClr.Text = "Х";
            this.bidsSecondPartDateClr.UseVisualStyleBackColor = true;
            this.bidsSecondPartDateClr.Click += new System.EventHandler(this.dateTimeClear_Click);
            // 
            // bidsFinishDateClr
            // 
            this.bidsFinishDateClr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bidsFinishDateClr.Location = new System.Drawing.Point(658, 339);
            this.bidsFinishDateClr.Margin = new System.Windows.Forms.Padding(0);
            this.bidsFinishDateClr.Name = "bidsFinishDateClr";
            this.bidsFinishDateClr.Size = new System.Drawing.Size(20, 20);
            this.bidsFinishDateClr.TabIndex = 87;
            this.bidsFinishDateClr.Text = "Х";
            this.bidsFinishDateClr.UseVisualStyleBackColor = true;
            this.bidsFinishDateClr.Click += new System.EventHandler(this.dateTimeClear_Click);
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
            this.organizationID.Size = new System.Drawing.Size(330, 20);
            this.organizationID.TabIndex = 90;
            this.organizationID.DoubleClick += new System.EventHandler(this.organisationSelectButton_Click);
            // 
            // organisationSelectButton
            // 
            this.organisationSelectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.organisationSelectButton.Location = new System.Drawing.Point(469, 82);
            this.organisationSelectButton.Name = "organisationSelectButton";
            this.organisationSelectButton.Size = new System.Drawing.Size(28, 20);
            this.organisationSelectButton.TabIndex = 91;
            this.organisationSelectButton.Text = "...";
            this.organisationSelectButton.UseVisualStyleBackColor = true;
            this.organisationSelectButton.Click += new System.EventHandler(this.organisationSelectButton_Click);
            // 
            // auctionDateClr
            // 
            this.auctionDateClr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.auctionDateClr.Location = new System.Drawing.Point(658, 287);
            this.auctionDateClr.Margin = new System.Windows.Forms.Padding(0);
            this.auctionDateClr.Name = "auctionDateClr";
            this.auctionDateClr.Size = new System.Drawing.Size(20, 20);
            this.auctionDateClr.TabIndex = 94;
            this.auctionDateClr.Text = "Х";
            this.auctionDateClr.UseVisualStyleBackColor = true;
            this.auctionDateClr.Click += new System.EventHandler(this.dateTimeClear_Click);
            // 
            // auctionDate
            // 
            this.auctionDate.CustomFormat = "";
            this.auctionDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.auctionDate.Location = new System.Drawing.Point(503, 287);
            this.auctionDate.Name = "auctionDate";
            this.auctionDate.Size = new System.Drawing.Size(152, 20);
            this.auctionDate.TabIndex = 93;
            this.auctionDate.CloseUp += new System.EventHandler(this.dateTime_ValueChanged);
            this.auctionDate.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dateTimeField_KeyUp);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(414, 287);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(83, 13);
            this.label20.TabIndex = 92;
            this.label20.Text = "Дата аукциона";
            // 
            // showLogsButton
            // 
            this.showLogsButton.Location = new System.Drawing.Point(8, 534);
            this.showLogsButton.Name = "showLogsButton";
            this.showLogsButton.Size = new System.Drawing.Size(122, 23);
            this.showLogsButton.TabIndex = 95;
            this.showLogsButton.Text = "Журнал обработки";
            this.showLogsButton.UseVisualStyleBackColor = true;
            this.showLogsButton.Click += new System.EventHandler(this.showLogsButton_Click);
            // 
            // purchaseEisDate
            // 
            this.purchaseEisDate.CustomFormat = "";
            this.purchaseEisDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.purchaseEisDate.Location = new System.Drawing.Point(313, 166);
            this.purchaseEisDate.Name = "purchaseEisDate";
            this.purchaseEisDate.Size = new System.Drawing.Size(81, 20);
            this.purchaseEisDate.TabIndex = 14;
            this.purchaseEisDate.Value = new System.DateTime(2019, 12, 25, 23, 59, 59, 0);
            this.purchaseEisDate.CloseUp += new System.EventHandler(this.dateTime_ValueChanged);
            this.purchaseEisDate.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dateTimeField_KeyUp);
            // 
            // PurchaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 569);
            this.Controls.Add(this.showLogsButton);
            this.Controls.Add(this.auctionDateClr);
            this.Controls.Add(this.auctionDate);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.organisationSelectButton);
            this.Controls.Add(this.organizationID);
            this.Controls.Add(this.resultOfControlFontColor);
            this.Controls.Add(this.commentsFontSetting);
            this.Controls.Add(this.bidsFinishDateClr);
            this.Controls.Add(this.bidsSecondPartDateClr);
            this.Controls.Add(this.bidsFirstPartDateClr);
            this.Controls.Add(this.bidsEndDateClr);
            this.Controls.Add(this.bidsRatingDateClr);
            this.Controls.Add(this.bidsReviewDateClr);
            this.Controls.Add(this.bidsOpenDateClr);
            this.Controls.Add(this.bidsStartDateClr);
            this.Controls.Add(this.purchaseEisDateClr);
            this.Controls.Add(this.colorMark);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.controlStatus);
            this.Controls.Add(this.bidsFinishDate);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.bidsSecondPartDate);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.bidsFirstPartDate);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.bidsRatingDate);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.bidsReviewDate);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.bidsOpenDate);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.bidsEndDate);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.bidsStartDate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.employeID);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.protocolStatusID);
            this.Controls.Add(this.label9);
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
            this.Controls.Add(this.employeDocumentationID);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PurchaseForm";
            this.Text = "Закупка";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PurchaseForm_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.purchacePrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox employeDocumentationID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox purchaseMethodID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox statusID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox purchaseEisNum;
        private System.Windows.Forms.Label label7;
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
        private System.Windows.Forms.ComboBox protocolStatusID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox employeID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker bidsStartDate;
        private System.Windows.Forms.DateTimePicker bidsEndDate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker bidsOpenDate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker bidsReviewDate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker bidsRatingDate;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker bidsFirstPartDate;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker bidsSecondPartDate;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DateTimePicker bidsFinishDate;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button controlStatus;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button colorMark;
        private System.Windows.Forms.Button purchaseEisDateClr;
        private System.Windows.Forms.Button bidsStartDateClr;
        private System.Windows.Forms.Button bidsOpenDateClr;
        private System.Windows.Forms.Button bidsReviewDateClr;
        private System.Windows.Forms.Button bidsRatingDateClr;
        private System.Windows.Forms.Button bidsEndDateClr;
        private System.Windows.Forms.Button bidsFirstPartDateClr;
        private System.Windows.Forms.Button bidsSecondPartDateClr;
        private System.Windows.Forms.Button bidsFinishDateClr;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Button commentsFontSetting;
        private System.Windows.Forms.Button resultOfControlFontColor;
        private System.Windows.Forms.TextBox organizationID;
        private System.Windows.Forms.Button organisationSelectButton;
        private System.Windows.Forms.Button auctionDateClr;
        private System.Windows.Forms.DateTimePicker auctionDate;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button showLogsButton;
        private System.Windows.Forms.DateTimePicker purchaseEisDate;
    }
}