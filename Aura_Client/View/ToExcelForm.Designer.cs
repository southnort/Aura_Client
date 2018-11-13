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
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
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
            this.label1.ForeColor = System.Drawing.Color.SpringGreen;
            this.label1.Location = new System.Drawing.Point(0, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Куда сохранить файл\r\n";
            // 
            // browseeButton
            // 
            this.browseeButton.Location = new System.Drawing.Point(228, 28);
            this.browseeButton.Name = "browseeButton";
            this.browseeButton.Size = new System.Drawing.Size(75, 23);
            this.browseeButton.TabIndex = 2;
            this.browseeButton.Text = "Browsee...";
            this.browseeButton.UseVisualStyleBackColor = true;
            this.browseeButton.Click += new System.EventHandler(this.browseeButton_Click);
            // 
            // filePathTextBox
            // 
            this.filePathTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.filePathTextBox.ForeColor = System.Drawing.SystemColors.Window;
            this.filePathTextBox.Location = new System.Drawing.Point(3, 30);
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
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.clearQueryTextBoxButton);
            this.panel2.Controls.Add(this.sqlQueryTextBox);
            this.panel2.Controls.Add(this.sendSQLqueryButton);
            this.panel2.Location = new System.Drawing.Point(12, 160);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(977, 247);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.SpringGreen;
            this.label2.Location = new System.Drawing.Point(33, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "SQL-запрос в базу данных";
            // 
            // clearQueryTextBoxButton
            // 
            this.clearQueryTextBoxButton.Location = new System.Drawing.Point(11, 172);
            this.clearQueryTextBoxButton.Name = "clearQueryTextBoxButton";
            this.clearQueryTextBoxButton.Size = new System.Drawing.Size(104, 33);
            this.clearQueryTextBoxButton.TabIndex = 6;
            this.clearQueryTextBoxButton.Text = "clear";
            this.clearQueryTextBoxButton.UseVisualStyleBackColor = true;
            this.clearQueryTextBoxButton.Click += new System.EventHandler(this.clearQueryTextBoxButton_Click);
            // 
            // sqlQueryTextBox
            // 
            this.sqlQueryTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sqlQueryTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sqlQueryTextBox.ForeColor = System.Drawing.Color.SpringGreen;
            this.sqlQueryTextBox.Location = new System.Drawing.Point(3, 30);
            this.sqlQueryTextBox.Name = "sqlQueryTextBox";
            this.sqlQueryTextBox.Size = new System.Drawing.Size(525, 136);
            this.sqlQueryTextBox.TabIndex = 5;
            this.sqlQueryTextBox.Text = "SELECT * FROM Organisations";
            // 
            // sendSQLqueryButton
            // 
            this.sendSQLqueryButton.Location = new System.Drawing.Point(534, 50);
            this.sendSQLqueryButton.Name = "sendSQLqueryButton";
            this.sendSQLqueryButton.Size = new System.Drawing.Size(191, 77);
            this.sendSQLqueryButton.TabIndex = 4;
            this.sendSQLqueryButton.Text = "Запросить";
            this.sendSQLqueryButton.UseVisualStyleBackColor = true;
            this.sendSQLqueryButton.Click += new System.EventHandler(this.sendSQLqueryButton_Click);
            // 
            // ToExcelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
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
            this.panel2.PerformLayout();
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
    }
}