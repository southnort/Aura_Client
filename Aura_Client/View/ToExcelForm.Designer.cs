namespace Aura_Client.View
{
    partial class ToExcelForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToExcelForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.browseeButton = new System.Windows.Forms.Button();
            this.filePathTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.clearQueryTextBoxButton = new System.Windows.Forms.Button();
            this.sqlQueryTextBox = new System.Windows.Forms.RichTextBox();
            this.sendSQLqueryButton = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.sqlQuery = new System.Windows.Forms.TabPage();
            this.organisations = new System.Windows.Forms.TabPage();
            this.number_Equal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.inn = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.org_name = new System.Windows.Forms.TextBox();
            this.org_law = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.contractType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.purchases = new System.Windows.Forms.TabPage();
            this.purchaseEisNum = new System.Windows.Forms.TextBox();
            this.purchaseName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.purchaseMethodID = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.statusID = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.protocolStatusID = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.organizationID_Equal = new System.Windows.Forms.TextBox();
            this.organisationSelectButton = new System.Windows.Forms.Button();
            this.organisationInn = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.pur_clearFilterButton = new System.Windows.Forms.Button();
            this.org_clearFilterButton = new System.Windows.Forms.Button();
            this.org_columnsOptionsButton = new System.Windows.Forms.Button();
            this.pur_columnsOptionsButton = new System.Windows.Forms.Button();
            this.org_toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.org_sendRequestButton = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pur_toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.sqlQuery.SuspendLayout();
            this.organisations.SuspendLayout();
            this.purchases.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.browseeButton);
            this.panel1.Controls.Add(this.filePathTextBox);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(977, 142);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(14, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Куда сохранить файл\r\n";
            // 
            // browseeButton
            // 
            this.browseeButton.Location = new System.Drawing.Point(237, 63);
            this.browseeButton.Name = "browseeButton";
            this.browseeButton.Size = new System.Drawing.Size(75, 23);
            this.browseeButton.TabIndex = 2;
            this.browseeButton.Text = "Browsee...";
            this.browseeButton.UseVisualStyleBackColor = true;
            this.browseeButton.Click += new System.EventHandler(this.browseeButton_Click);
            // 
            // filePathTextBox
            // 
            this.filePathTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.filePathTextBox.ForeColor = System.Drawing.SystemColors.MenuText;
            this.filePathTextBox.Location = new System.Drawing.Point(12, 65);
            this.filePathTextBox.Name = "filePathTextBox";
            this.filePathTextBox.Size = new System.Drawing.Size(219, 20);
            this.filePathTextBox.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(694, -11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(357, 166);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Location = new System.Drawing.Point(12, 160);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(977, 247);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(6, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "SQL-запрос в базу данных";
            // 
            // clearQueryTextBoxButton
            // 
            this.clearQueryTextBoxButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.clearQueryTextBoxButton.BackColor = System.Drawing.Color.MistyRose;
            this.clearQueryTextBoxButton.Location = new System.Drawing.Point(6, 172);
            this.clearQueryTextBoxButton.Name = "clearQueryTextBoxButton";
            this.clearQueryTextBoxButton.Size = new System.Drawing.Size(104, 33);
            this.clearQueryTextBoxButton.TabIndex = 6;
            this.clearQueryTextBoxButton.Text = "Очистить";
            this.clearQueryTextBoxButton.UseVisualStyleBackColor = false;
            this.clearQueryTextBoxButton.Click += new System.EventHandler(this.clearQueryTextBoxButton_Click);
            // 
            // sqlQueryTextBox
            // 
            this.sqlQueryTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sqlQueryTextBox.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.sqlQueryTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sqlQueryTextBox.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.sqlQueryTextBox.Location = new System.Drawing.Point(6, 31);
            this.sqlQueryTextBox.Name = "sqlQueryTextBox";
            this.sqlQueryTextBox.Size = new System.Drawing.Size(951, 136);
            this.sqlQueryTextBox.TabIndex = 5;
            this.sqlQueryTextBox.Text = "SELECT * FROM Organisations";
            // 
            // sendSQLqueryButton
            // 
            this.sendSQLqueryButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.sendSQLqueryButton.BackColor = System.Drawing.Color.PaleTurquoise;
            this.sendSQLqueryButton.Location = new System.Drawing.Point(270, 173);
            this.sendSQLqueryButton.Name = "sendSQLqueryButton";
            this.sendSQLqueryButton.Size = new System.Drawing.Size(191, 32);
            this.sendSQLqueryButton.TabIndex = 4;
            this.sendSQLqueryButton.Text = "Направить запрос";
            this.sendSQLqueryButton.UseVisualStyleBackColor = false;
            this.sendSQLqueryButton.Click += new System.EventHandler(this.sendSQLqueryButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.organisations);
            this.tabControl1.Controls.Add(this.purchases);
            this.tabControl1.Controls.Add(this.sqlQuery);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(971, 241);
            this.tabControl1.TabIndex = 8;
            // 
            // sqlQuery
            // 
            this.sqlQuery.Controls.Add(this.sqlQueryTextBox);
            this.sqlQuery.Controls.Add(this.clearQueryTextBoxButton);
            this.sqlQuery.Controls.Add(this.sendSQLqueryButton);
            this.sqlQuery.Controls.Add(this.label2);
            this.sqlQuery.Location = new System.Drawing.Point(4, 22);
            this.sqlQuery.Name = "sqlQuery";
            this.sqlQuery.Padding = new System.Windows.Forms.Padding(3);
            this.sqlQuery.Size = new System.Drawing.Size(963, 215);
            this.sqlQuery.TabIndex = 0;
            this.sqlQuery.Text = "Прямой запрос";
            this.sqlQuery.UseVisualStyleBackColor = true;
            // 
            // organisations
            // 
            this.organisations.Controls.Add(this.org_sendRequestButton);
            this.organisations.Controls.Add(this.org_columnsOptionsButton);
            this.organisations.Controls.Add(this.org_clearFilterButton);
            this.organisations.Controls.Add(this.number_Equal);
            this.organisations.Controls.Add(this.label7);
            this.organisations.Controls.Add(this.label3);
            this.organisations.Controls.Add(this.label6);
            this.organisations.Controls.Add(this.inn);
            this.organisations.Controls.Add(this.contractType);
            this.organisations.Controls.Add(this.label4);
            this.organisations.Controls.Add(this.label5);
            this.organisations.Controls.Add(this.org_name);
            this.organisations.Controls.Add(this.org_law);
            this.organisations.Location = new System.Drawing.Point(4, 22);
            this.organisations.Name = "organisations";
            this.organisations.Padding = new System.Windows.Forms.Padding(3);
            this.organisations.Size = new System.Drawing.Size(963, 215);
            this.organisations.TabIndex = 1;
            this.organisations.Text = "Организации";
            this.organisations.UseVisualStyleBackColor = true;
            // 
            // number_Equal
            // 
            this.number_Equal.Location = new System.Drawing.Point(231, 74);
            this.number_Equal.Name = "number_Equal";
            this.number_Equal.Size = new System.Drawing.Size(124, 20);
            this.number_Equal.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(194, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "ИНН";
            // 
            // inn
            // 
            this.inn.Location = new System.Drawing.Point(231, 25);
            this.inn.Name = "inn";
            this.inn.Size = new System.Drawing.Size(124, 20);
            this.inn.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(142, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Наименование";
            // 
            // org_name
            // 
            this.org_name.Location = new System.Drawing.Point(231, 48);
            this.org_name.Name = "org_name";
            this.org_name.Size = new System.Drawing.Size(124, 20);
            this.org_name.TabIndex = 22;
            // 
            // org_law
            // 
            this.org_law.FormattingEnabled = true;
            this.org_law.Location = new System.Drawing.Point(415, 25);
            this.org_law.Name = "org_law";
            this.org_law.Size = new System.Drawing.Size(121, 21);
            this.org_law.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(371, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Закон";
            // 
            // contractType
            // 
            this.contractType.FormattingEnabled = true;
            this.contractType.Location = new System.Drawing.Point(415, 48);
            this.contractType.Name = "contractType";
            this.contractType.Size = new System.Drawing.Size(121, 21);
            this.contractType.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(383, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Тип";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(207, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "№";
            // 
            // purchases
            // 
            this.purchases.Controls.Add(this.button4);
            this.purchases.Controls.Add(this.pur_columnsOptionsButton);
            this.purchases.Controls.Add(this.pur_clearFilterButton);
            this.purchases.Controls.Add(this.label14);
            this.purchases.Controls.Add(this.purchaseEisNum);
            this.purchases.Controls.Add(this.organisationInn);
            this.purchases.Controls.Add(this.purchaseName);
            this.purchases.Controls.Add(this.organisationSelectButton);
            this.purchases.Controls.Add(this.label8);
            this.purchases.Controls.Add(this.organizationID_Equal);
            this.purchases.Controls.Add(this.label9);
            this.purchases.Controls.Add(this.label13);
            this.purchases.Controls.Add(this.purchaseMethodID);
            this.purchases.Controls.Add(this.label12);
            this.purchases.Controls.Add(this.label10);
            this.purchases.Controls.Add(this.statusID);
            this.purchases.Controls.Add(this.protocolStatusID);
            this.purchases.Controls.Add(this.label11);
            this.purchases.Location = new System.Drawing.Point(4, 22);
            this.purchases.Name = "purchases";
            this.purchases.Size = new System.Drawing.Size(963, 215);
            this.purchases.TabIndex = 2;
            this.purchases.Text = "Закупки";
            this.purchases.UseVisualStyleBackColor = true;
            // 
            // purchaseEisNum
            // 
            this.purchaseEisNum.Location = new System.Drawing.Point(193, 110);
            this.purchaseEisNum.Name = "purchaseEisNum";
            this.purchaseEisNum.Size = new System.Drawing.Size(181, 20);
            this.purchaseEisNum.TabIndex = 105;
            // 
            // purchaseName
            // 
            this.purchaseName.Location = new System.Drawing.Point(193, 57);
            this.purchaseName.Name = "purchaseName";
            this.purchaseName.Size = new System.Drawing.Size(181, 20);
            this.purchaseName.TabIndex = 97;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(60, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 13);
            this.label8.TabIndex = 98;
            this.label8.Text = "Наименование закупки";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(74, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 13);
            this.label9.TabIndex = 99;
            this.label9.Text = "Способ определения";
            // 
            // purchaseMethodID
            // 
            this.purchaseMethodID.FormattingEnabled = true;
            this.purchaseMethodID.Location = new System.Drawing.Point(193, 83);
            this.purchaseMethodID.Name = "purchaseMethodID";
            this.purchaseMethodID.Size = new System.Drawing.Size(181, 21);
            this.purchaseMethodID.TabIndex = 100;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(438, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 101;
            this.label10.Text = "Статус";
            // 
            // statusID
            // 
            this.statusID.FormattingEnabled = true;
            this.statusID.Location = new System.Drawing.Point(485, 58);
            this.statusID.Name = "statusID";
            this.statusID.Size = new System.Drawing.Size(181, 21);
            this.statusID.TabIndex = 102;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(382, 88);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 13);
            this.label11.TabIndex = 103;
            this.label11.Text = "Статус протокола";
            // 
            // protocolStatusID
            // 
            this.protocolStatusID.FormattingEnabled = true;
            this.protocolStatusID.Location = new System.Drawing.Point(485, 85);
            this.protocolStatusID.Name = "protocolStatusID";
            this.protocolStatusID.Size = new System.Drawing.Size(181, 21);
            this.protocolStatusID.TabIndex = 104;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(86, 113);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 13);
            this.label12.TabIndex = 106;
            this.label12.Text = "Номер извещения";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(672, 60);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 13);
            this.label13.TabIndex = 107;
            this.label13.Text = "Заказчик";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // organizationID_Equal
            // 
            this.organizationID_Equal.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.organizationID_Equal.Location = new System.Drawing.Point(733, 59);
            this.organizationID_Equal.Name = "organizationID_Equal";
            this.organizationID_Equal.ReadOnly = true;
            this.organizationID_Equal.Size = new System.Drawing.Size(160, 20);
            this.organizationID_Equal.TabIndex = 108;
            // 
            // organisationSelectButton
            // 
            this.organisationSelectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.organisationSelectButton.Location = new System.Drawing.Point(891, 59);
            this.organisationSelectButton.Name = "organisationSelectButton";
            this.organisationSelectButton.Size = new System.Drawing.Size(28, 20);
            this.organisationSelectButton.TabIndex = 109;
            this.organisationSelectButton.Text = "...";
            this.organisationSelectButton.UseVisualStyleBackColor = true;
            // 
            // organisationInn
            // 
            this.organisationInn.Location = new System.Drawing.Point(765, 86);
            this.organisationInn.Name = "organisationInn";
            this.organisationInn.Size = new System.Drawing.Size(154, 20);
            this.organisationInn.TabIndex = 110;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(672, 88);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(87, 13);
            this.label14.TabIndex = 111;
            this.label14.Text = "ИНН заказчика";
            // 
            // pur_clearFilterButton
            // 
            this.pur_clearFilterButton.BackgroundImage = global::Aura_Client.Properties.Resources.ClearFilter_Icon;
            this.pur_clearFilterButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pur_clearFilterButton.Location = new System.Drawing.Point(6, 6);
            this.pur_clearFilterButton.Name = "pur_clearFilterButton";
            this.pur_clearFilterButton.Size = new System.Drawing.Size(40, 40);
            this.pur_clearFilterButton.TabIndex = 97;
            this.pur_clearFilterButton.UseVisualStyleBackColor = true;
            // 
            // org_clearFilterButton
            // 
            this.org_clearFilterButton.BackgroundImage = global::Aura_Client.Properties.Resources.ClearFilter_Icon;
            this.org_clearFilterButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.org_clearFilterButton.Location = new System.Drawing.Point(6, 6);
            this.org_clearFilterButton.Name = "org_clearFilterButton";
            this.org_clearFilterButton.Size = new System.Drawing.Size(40, 40);
            this.org_clearFilterButton.TabIndex = 98;
            this.org_clearFilterButton.UseVisualStyleBackColor = true;
            // 
            // org_columnsOptionsButton
            // 
            this.org_columnsOptionsButton.BackgroundImage = global::Aura_Client.Properties.Resources.Settings_Icon;
            this.org_columnsOptionsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.org_columnsOptionsButton.Location = new System.Drawing.Point(52, 6);
            this.org_columnsOptionsButton.Name = "org_columnsOptionsButton";
            this.org_columnsOptionsButton.Size = new System.Drawing.Size(40, 40);
            this.org_columnsOptionsButton.TabIndex = 97;
            this.org_columnsOptionsButton.UseVisualStyleBackColor = true;
            // 
            // pur_columnsOptionsButton
            // 
            this.pur_columnsOptionsButton.BackgroundImage = global::Aura_Client.Properties.Resources.Settings_Icon;
            this.pur_columnsOptionsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pur_columnsOptionsButton.Location = new System.Drawing.Point(52, 6);
            this.pur_columnsOptionsButton.Name = "pur_columnsOptionsButton";
            this.pur_columnsOptionsButton.Size = new System.Drawing.Size(40, 40);
            this.pur_columnsOptionsButton.TabIndex = 112;
            this.pur_columnsOptionsButton.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // org_sendRequestButton
            // 
            this.org_sendRequestButton.Location = new System.Drawing.Point(230, 140);
            this.org_sendRequestButton.Name = "org_sendRequestButton";
            this.org_sendRequestButton.Size = new System.Drawing.Size(145, 48);
            this.org_sendRequestButton.TabIndex = 99;
            this.org_sendRequestButton.Text = "Направить запрос";
            this.org_sendRequestButton.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(230, 140);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(145, 48);
            this.button4.TabIndex = 100;
            this.button4.Text = "Направить запрос";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // ToExcelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1001, 419);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ToExcelForm";
            this.Text = "Конструктор отчетов - Beta";
            this.Load += new System.EventHandler(this.ToExcelForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.sqlQuery.ResumeLayout(false);
            this.sqlQuery.PerformLayout();
            this.organisations.ResumeLayout(false);
            this.organisations.PerformLayout();
            this.purchases.ResumeLayout(false);
            this.purchases.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button browseeButton;
        private System.Windows.Forms.TextBox filePathTextBox;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button sendSQLqueryButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button clearQueryTextBoxButton;
        private System.Windows.Forms.RichTextBox sqlQueryTextBox;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage sqlQuery;
        private System.Windows.Forms.TabPage organisations;
        private System.Windows.Forms.TextBox number_Equal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox inn;
        private System.Windows.Forms.ComboBox contractType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox org_name;
        private System.Windows.Forms.ComboBox org_law;
        private System.Windows.Forms.TabPage purchases;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox purchaseEisNum;
        private System.Windows.Forms.TextBox organisationInn;
        private System.Windows.Forms.TextBox purchaseName;
        private System.Windows.Forms.Button organisationSelectButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox organizationID_Equal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox purchaseMethodID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox statusID;
        private System.Windows.Forms.ComboBox protocolStatusID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button pur_clearFilterButton;
        private System.Windows.Forms.Button org_clearFilterButton;
        private System.Windows.Forms.Button org_columnsOptionsButton;
        private System.Windows.Forms.Button pur_columnsOptionsButton;
        private System.Windows.Forms.ToolTip org_toolTip;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button org_sendRequestButton;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ToolTip pur_toolTip;
    }
}