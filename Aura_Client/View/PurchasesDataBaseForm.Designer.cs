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
            this.resreshButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.addNewPurchaseButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
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
            this.purchasesDataGridView.Location = new System.Drawing.Point(12, 67);
            this.purchasesDataGridView.Name = "purchasesDataGridView";
            this.purchasesDataGridView.ReadOnly = true;
            this.purchasesDataGridView.Size = new System.Drawing.Size(1064, 362);
            this.purchasesDataGridView.TabIndex = 0;
            this.purchasesDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.resreshButton);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1064, 49);
            this.panel1.TabIndex = 1;
            // 
            // resreshButton
            // 
            this.resreshButton.BackgroundImage = global::Aura_Client.Properties.Resources.Без_названия;
            this.resreshButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.resreshButton.Location = new System.Drawing.Point(3, 3);
            this.resreshButton.Name = "resreshButton";
            this.resreshButton.Size = new System.Drawing.Size(32, 32);
            this.resreshButton.TabIndex = 0;
            this.resreshButton.UseVisualStyleBackColor = true;
            this.resreshButton.Click += new System.EventHandler(this.resreshButton_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.addNewPurchaseButton);
            this.panel2.Location = new System.Drawing.Point(12, 435);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1064, 61);
            this.panel2.TabIndex = 2;
            // 
            // addNewPurchaseButton
            // 
            this.addNewPurchaseButton.Location = new System.Drawing.Point(3, 3);
            this.addNewPurchaseButton.Name = "addNewPurchaseButton";
            this.addNewPurchaseButton.Size = new System.Drawing.Size(162, 55);
            this.addNewPurchaseButton.TabIndex = 0;
            this.addNewPurchaseButton.Text = "Добавить закупку";
            this.addNewPurchaseButton.UseVisualStyleBackColor = true;
            this.addNewPurchaseButton.Click += new System.EventHandler(this.addNewPurchaseButton_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 200;
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
            ((System.ComponentModel.ISupportInitialize)(this.purchasesDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView purchasesDataGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button addNewPurchaseButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button resreshButton;
    }
}