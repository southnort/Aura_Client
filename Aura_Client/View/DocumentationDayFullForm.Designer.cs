namespace Aura_Client.View
{
    partial class DocumentationDayFullForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DocumentationDayFullForm));
            this.dateLabel = new System.Windows.Forms.Label();
            this.dayInCalendarDataGridView = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addNewNodeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dayInCalendarDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateLabel.Location = new System.Drawing.Point(12, 9);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(150, 31);
            this.dateLabel.TabIndex = 1;
            this.dateLabel.Text = "09.08.2018";
            // 
            // dayInCalendarDataGridView
            // 
            this.dayInCalendarDataGridView.AllowUserToAddRows = false;
            this.dayInCalendarDataGridView.AllowUserToOrderColumns = true;
            this.dayInCalendarDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dayInCalendarDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dayInCalendarDataGridView.Location = new System.Drawing.Point(12, 43);
            this.dayInCalendarDataGridView.Name = "dayInCalendarDataGridView";
            this.dayInCalendarDataGridView.Size = new System.Drawing.Size(416, 457);
            this.dayInCalendarDataGridView.TabIndex = 3;
            this.dayInCalendarDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dayInCalendarDataGridView_CellDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.Name = "contextMenuStrip3";
            this.contextMenuStrip3.Size = new System.Drawing.Size(61, 4);
            // 
            // addNewNodeButton
            // 
            this.addNewNodeButton.Location = new System.Drawing.Point(12, 506);
            this.addNewNodeButton.Name = "addNewNodeButton";
            this.addNewNodeButton.Size = new System.Drawing.Size(132, 43);
            this.addNewNodeButton.TabIndex = 4;
            this.addNewNodeButton.Text = "Добавить";
            this.addNewNodeButton.UseVisualStyleBackColor = true;
            this.addNewNodeButton.Click += new System.EventHandler(this.addNewNodeButton_Click);
            // 
            // DocumentationDayFullForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 561);
            this.Controls.Add(this.addNewNodeButton);
            this.Controls.Add(this.dayInCalendarDataGridView);
            this.Controls.Add(this.dateLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DocumentationDayFullForm";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.DayInCalendarFullForm_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.dayInCalendarDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.DataGridView dayInCalendarDataGridView;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip3;
        private System.Windows.Forms.Button addNewNodeButton;
    }
}