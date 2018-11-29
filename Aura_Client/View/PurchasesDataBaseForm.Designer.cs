namespace Aura_Client.View
{
    partial class PurchasesDataBaseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchasesDataBaseForm));
            this.purchasesDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.showNotActualCheckBox = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.organisationInn = new System.Windows.Forms.TextBox();
            this.organisationSelectButton = new System.Windows.Forms.Button();
            this.clearFilterButton = new System.Windows.Forms.Button();
            this.organizationID_Equal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.purchaseEisNum = new System.Windows.Forms.TextBox();
            this.protocolStatusID = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.statusID = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.purchaseMethodID = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.purchaseName = new System.Windows.Forms.TextBox();
            this.columnsOptionsButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.copyPurchaseButton = new System.Windows.Forms.Button();
            this.deletePurchaseButton = new System.Windows.Forms.Button();
            this.addNewPurchaseButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.purchasesDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // purchasesDataGridView
            // 
            this.purchasesDataGridView.AllowUserToAddRows = false;
            this.purchasesDataGridView.AllowUserToDeleteRows = false;
            this.purchasesDataGridView.AllowUserToOrderColumns = true;
            this.purchasesDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.purchasesDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.purchasesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.purchasesDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.purchasesDataGridView.Location = new System.Drawing.Point(12, 107);
            this.purchasesDataGridView.Name = "purchasesDataGridView";
            this.purchasesDataGridView.ReadOnly = true;
            this.purchasesDataGridView.Size = new System.Drawing.Size(1064, 322);
            this.purchasesDataGridView.TabIndex = 0;
            this.purchasesDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.showNotActualCheckBox);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.organisationInn);
            this.panel1.Controls.Add(this.organisationSelectButton);
            this.panel1.Controls.Add(this.clearFilterButton);
            this.panel1.Controls.Add(this.organizationID_Equal);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.purchaseEisNum);
            this.panel1.Controls.Add(this.protocolStatusID);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.statusID);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.purchaseMethodID);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.purchaseName);
            this.panel1.Controls.Add(this.columnsOptionsButton);
            this.panel1.Controls.Add(this.refreshButton);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1064, 89);
            this.panel1.TabIndex = 1;
            // 
            // showNotActualCheckBox
            // 
            this.showNotActualCheckBox.AutoSize = true;
            this.showNotActualCheckBox.Location = new System.Drawing.Point(404, 58);
            this.showNotActualCheckBox.Name = "showNotActualCheckBox";
            this.showNotActualCheckBox.Size = new System.Drawing.Size(208, 17);
            this.showNotActualCheckBox.TabIndex = 97;
            this.showNotActualCheckBox.Text = "Показывать неактуальные закупки";
            this.showNotActualCheckBox.UseVisualStyleBackColor = true;
            this.showNotActualCheckBox.CheckedChanged += new System.EventHandler(this.showNotActualCheckBox_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(691, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 96;
            this.label7.Text = "ИНН заказчика";
            // 
            // organisationInn
            // 
            this.organisationInn.Location = new System.Drawing.Point(784, 31);
            this.organisationInn.Name = "organisationInn";
            this.organisationInn.Size = new System.Drawing.Size(154, 20);
            this.organisationInn.TabIndex = 95;
            this.organisationInn.KeyUp += new System.Windows.Forms.KeyEventHandler(this.anyKey_KeyUp);
            this.organisationInn.Leave += new System.EventHandler(this.textBox_ValueChanged);
            // 
            // organisationSelectButton
            // 
            this.organisationSelectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.organisationSelectButton.Location = new System.Drawing.Point(910, 4);
            this.organisationSelectButton.Name = "organisationSelectButton";
            this.organisationSelectButton.Size = new System.Drawing.Size(28, 20);
            this.organisationSelectButton.TabIndex = 94;
            this.organisationSelectButton.Text = "...";
            this.organisationSelectButton.UseVisualStyleBackColor = true;
            this.organisationSelectButton.Click += new System.EventHandler(this.organisationSelectButton_Click);
            // 
            // clearFilterButton
            // 
            this.clearFilterButton.BackgroundImage = global::Aura_Client.Properties.Resources.ClearFilter_Icon;
            this.clearFilterButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.clearFilterButton.Location = new System.Drawing.Point(41, 3);
            this.clearFilterButton.Name = "clearFilterButton";
            this.clearFilterButton.Size = new System.Drawing.Size(32, 32);
            this.clearFilterButton.TabIndex = 13;
            this.clearFilterButton.UseVisualStyleBackColor = true;
            this.clearFilterButton.Click += new System.EventHandler(this.clearFilterButton_Click);
            // 
            // organizationID_Equal
            // 
            this.organizationID_Equal.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.organizationID_Equal.Location = new System.Drawing.Point(752, 4);
            this.organizationID_Equal.Name = "organizationID_Equal";
            this.organizationID_Equal.ReadOnly = true;
            this.organizationID_Equal.Size = new System.Drawing.Size(160, 20);
            this.organizationID_Equal.TabIndex = 93;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(691, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 92;
            this.label6.Text = "Заказчик";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(105, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Номер извещения";
            // 
            // purchaseEisNum
            // 
            this.purchaseEisNum.Location = new System.Drawing.Point(212, 55);
            this.purchaseEisNum.Name = "purchaseEisNum";
            this.purchaseEisNum.Size = new System.Drawing.Size(181, 20);
            this.purchaseEisNum.TabIndex = 11;
            this.purchaseEisNum.KeyUp += new System.Windows.Forms.KeyEventHandler(this.anyKey_KeyUp);
            this.purchaseEisNum.Leave += new System.EventHandler(this.textBox_ValueChanged);
            // 
            // protocolStatusID
            // 
            this.protocolStatusID.FormattingEnabled = true;
            this.protocolStatusID.Location = new System.Drawing.Point(504, 30);
            this.protocolStatusID.Name = "protocolStatusID";
            this.protocolStatusID.Size = new System.Drawing.Size(181, 21);
            this.protocolStatusID.TabIndex = 10;
            this.protocolStatusID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.anyKey_KeyUp);
            this.protocolStatusID.Leave += new System.EventHandler(this.comboBox_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(401, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Статус протокола";
            // 
            // statusID
            // 
            this.statusID.FormattingEnabled = true;
            this.statusID.Location = new System.Drawing.Point(504, 3);
            this.statusID.Name = "statusID";
            this.statusID.Size = new System.Drawing.Size(181, 21);
            this.statusID.TabIndex = 8;
            this.statusID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.anyKey_KeyUp);
            this.statusID.Leave += new System.EventHandler(this.comboBox_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(457, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Статус";
            // 
            // purchaseMethodID
            // 
            this.purchaseMethodID.FormattingEnabled = true;
            this.purchaseMethodID.Location = new System.Drawing.Point(212, 28);
            this.purchaseMethodID.Name = "purchaseMethodID";
            this.purchaseMethodID.Size = new System.Drawing.Size(181, 21);
            this.purchaseMethodID.TabIndex = 6;
            this.purchaseMethodID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.anyKey_KeyUp);
            this.purchaseMethodID.Leave += new System.EventHandler(this.comboBox_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Способ определения";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Наименование закупки";
            // 
            // purchaseName
            // 
            this.purchaseName.Location = new System.Drawing.Point(212, 2);
            this.purchaseName.Name = "purchaseName";
            this.purchaseName.Size = new System.Drawing.Size(181, 20);
            this.purchaseName.TabIndex = 2;
            this.purchaseName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.anyKey_KeyUp);
            this.purchaseName.Leave += new System.EventHandler(this.textBox_ValueChanged);
            // 
            // columnsOptionsButton
            // 
            this.columnsOptionsButton.BackgroundImage = global::Aura_Client.Properties.Resources.Settings_Icon;
            this.columnsOptionsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.columnsOptionsButton.Location = new System.Drawing.Point(3, 40);
            this.columnsOptionsButton.Name = "columnsOptionsButton";
            this.columnsOptionsButton.Size = new System.Drawing.Size(32, 32);
            this.columnsOptionsButton.TabIndex = 1;
            this.columnsOptionsButton.UseVisualStyleBackColor = true;
            this.columnsOptionsButton.Click += new System.EventHandler(this.columnsOptionsButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.BackgroundImage = global::Aura_Client.Properties.Resources.Refresh_Icon;
            this.refreshButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.refreshButton.Location = new System.Drawing.Point(3, 3);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(32, 32);
            this.refreshButton.TabIndex = 0;
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.copyPurchaseButton);
            this.panel2.Controls.Add(this.deletePurchaseButton);
            this.panel2.Controls.Add(this.addNewPurchaseButton);
            this.panel2.Location = new System.Drawing.Point(12, 435);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1064, 61);
            this.panel2.TabIndex = 2;
            // 
            // copyPurchaseButton
            // 
            this.copyPurchaseButton.BackgroundImage = global::Aura_Client.Properties.Resources.copyPurchaseIcon;
            this.copyPurchaseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.copyPurchaseButton.Location = new System.Drawing.Point(64, 3);
            this.copyPurchaseButton.Name = "copyPurchaseButton";
            this.copyPurchaseButton.Size = new System.Drawing.Size(55, 55);
            this.copyPurchaseButton.TabIndex = 2;
            this.copyPurchaseButton.UseVisualStyleBackColor = true;
            this.copyPurchaseButton.Click += new System.EventHandler(this.copyPurchaseButton_Click);
            // 
            // deletePurchaseButton
            // 
            this.deletePurchaseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.deletePurchaseButton.BackgroundImage = global::Aura_Client.Properties.Resources.delete;
            this.deletePurchaseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.deletePurchaseButton.Location = new System.Drawing.Point(1006, 3);
            this.deletePurchaseButton.Name = "deletePurchaseButton";
            this.deletePurchaseButton.Size = new System.Drawing.Size(55, 55);
            this.deletePurchaseButton.TabIndex = 1;
            this.deletePurchaseButton.UseVisualStyleBackColor = true;
            this.deletePurchaseButton.Click += new System.EventHandler(this.deletePurchaseButton_Click);
            // 
            // addNewPurchaseButton
            // 
            this.addNewPurchaseButton.BackgroundImage = global::Aura_Client.Properties.Resources.addNewPurchaseIcon;
            this.addNewPurchaseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addNewPurchaseButton.Location = new System.Drawing.Point(3, 3);
            this.addNewPurchaseButton.Name = "addNewPurchaseButton";
            this.addNewPurchaseButton.Size = new System.Drawing.Size(55, 55);
            this.addNewPurchaseButton.TabIndex = 0;
            this.addNewPurchaseButton.UseVisualStyleBackColor = true;
            this.addNewPurchaseButton.Click += new System.EventHandler(this.addNewPurchaseButton_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 200;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.Closing += new System.Windows.Forms.ToolStripDropDownClosingEventHandler(this.contextMenuStrip1_Closing);
            // 
            // PurchasesDataBaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 508);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.purchasesDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PurchasesDataBaseForm";
            this.Text = "Все закупки";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PurchasesDataBaseForm_FormClosing);
            this.Load += new System.EventHandler(this.PurchasesDataBaseForm_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PurchasesDataBaseForm_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.purchasesDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView purchasesDataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button addNewPurchaseButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button columnsOptionsButton;
        private System.Windows.Forms.Button deletePurchaseButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox purchaseEisNum;
        private System.Windows.Forms.ComboBox protocolStatusID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox statusID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox purchaseMethodID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox purchaseName;
        private System.Windows.Forms.Button clearFilterButton;
        private System.Windows.Forms.Button organisationSelectButton;
        private System.Windows.Forms.TextBox organizationID_Equal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox organisationInn;
        private System.Windows.Forms.Button copyPurchaseButton;
        private System.Windows.Forms.CheckBox showNotActualCheckBox;
    }
}