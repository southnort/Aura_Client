namespace Aura_Client.View
{
    partial class ReestrDataBaseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReestrDataBaseForm));
            this.reestrDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.clearFilterButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.reestrNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.purchaseEisNum = new System.Windows.Forms.TextBox();
            this.purchaseMethodID = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.purchaseName = new System.Windows.Forms.TextBox();
            this.columnsOptionsButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addNewPurchaseButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.reestrDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // reestrDataGridView
            // 
            this.reestrDataGridView.AllowUserToAddRows = false;
            this.reestrDataGridView.AllowUserToDeleteRows = false;
            this.reestrDataGridView.AllowUserToOrderColumns = true;
            this.reestrDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reestrDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.reestrDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reestrDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.reestrDataGridView.Location = new System.Drawing.Point(12, 105);
            this.reestrDataGridView.Name = "reestrDataGridView";
            this.reestrDataGridView.ReadOnly = true;
            this.reestrDataGridView.Size = new System.Drawing.Size(1342, 333);
            this.reestrDataGridView.TabIndex = 0;
            this.reestrDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.clearFilterButton);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.reestrNumber);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.purchaseEisNum);
            this.panel1.Controls.Add(this.purchaseMethodID);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.purchaseName);
            this.panel1.Controls.Add(this.columnsOptionsButton);
            this.panel1.Controls.Add(this.refreshButton);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1342, 87);
            this.panel1.TabIndex = 1;
            // 
            // clearFilterButton
            // 
            this.clearFilterButton.BackgroundImage = global::Aura_Client.Properties.Resources.ClearFilter_Icon;
            this.clearFilterButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.clearFilterButton.Location = new System.Drawing.Point(41, 3);
            this.clearFilterButton.Name = "clearFilterButton";
            this.clearFilterButton.Size = new System.Drawing.Size(32, 32);
            this.clearFilterButton.TabIndex = 21;
            this.clearFilterButton.UseVisualStyleBackColor = true;
            this.clearFilterButton.Click += new System.EventHandler(this.clearFilterButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(466, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Реестровый номер";
            // 
            // reestrNumber
            // 
            this.reestrNumber.Location = new System.Drawing.Point(576, 3);
            this.reestrNumber.Name = "reestrNumber";
            this.reestrNumber.Size = new System.Drawing.Size(181, 20);
            this.reestrNumber.TabIndex = 19;
            this.reestrNumber.KeyUp += new System.Windows.Forms.KeyEventHandler(this.anyKey_KeyUp);
            this.reestrNumber.Leave += new System.EventHandler(this.textBox_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(160, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Номер извещения";
            // 
            // purchaseEisNum
            // 
            this.purchaseEisNum.Location = new System.Drawing.Point(267, 56);
            this.purchaseEisNum.Name = "purchaseEisNum";
            this.purchaseEisNum.Size = new System.Drawing.Size(181, 20);
            this.purchaseEisNum.TabIndex = 17;
            this.purchaseEisNum.KeyUp += new System.Windows.Forms.KeyEventHandler(this.anyKey_KeyUp);
            this.purchaseEisNum.Leave += new System.EventHandler(this.textBox_ValueChanged);
            // 
            // purchaseMethodID
            // 
            this.purchaseMethodID.FormattingEnabled = true;
            this.purchaseMethodID.Location = new System.Drawing.Point(267, 29);
            this.purchaseMethodID.Name = "purchaseMethodID";
            this.purchaseMethodID.Size = new System.Drawing.Size(181, 21);
            this.purchaseMethodID.TabIndex = 16;
            this.purchaseMethodID.KeyUp += new System.Windows.Forms.KeyEventHandler(this.anyKey_KeyUp);
            this.purchaseMethodID.Leave += new System.EventHandler(this.comboBox_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Способ определения";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Наименование закупки";
            // 
            // purchaseName
            // 
            this.purchaseName.Location = new System.Drawing.Point(267, 3);
            this.purchaseName.Name = "purchaseName";
            this.purchaseName.Size = new System.Drawing.Size(181, 20);
            this.purchaseName.TabIndex = 13;
            this.purchaseName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.anyKey_KeyUp);
            this.purchaseName.Leave += new System.EventHandler(this.textBox_ValueChanged);
            // 
            // columnsOptionsButton
            // 
            this.columnsOptionsButton.BackgroundImage = global::Aura_Client.Properties.Resources.Settings_Icon;
            this.columnsOptionsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.columnsOptionsButton.Location = new System.Drawing.Point(3, 41);
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
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.addNewPurchaseButton);
            this.panel2.Location = new System.Drawing.Point(12, 444);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1342, 61);
            this.panel2.TabIndex = 2;
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
            // 
            // addNewPurchaseButton
            // 
            this.addNewPurchaseButton.Location = new System.Drawing.Point(3, 3);
            this.addNewPurchaseButton.Name = "addNewPurchaseButton";
            this.addNewPurchaseButton.Size = new System.Drawing.Size(162, 55);
            this.addNewPurchaseButton.TabIndex = 1;
            this.addNewPurchaseButton.Text = "Добавить информацию о договоре";
            this.addNewPurchaseButton.UseVisualStyleBackColor = true;
            this.addNewPurchaseButton.Click += new System.EventHandler(this.addNewPurchaseButton_Click);
            // 
            // ReestrDataBaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 517);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.reestrDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReestrDataBaseForm";
            this.Text = "Реестр договоров";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ReestrDataBaseForm_FormClosing);
            this.Load += new System.EventHandler(this.ReestrDataBaseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reestrDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView reestrDataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button columnsOptionsButton;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox reestrNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox purchaseEisNum;
        private System.Windows.Forms.ComboBox purchaseMethodID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox purchaseName;
        private System.Windows.Forms.Button clearFilterButton;
        private System.Windows.Forms.Button addNewPurchaseButton;
    }
}