namespace Aura_Client.View
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.protocolStatusColorsDataGrd = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.statusColorsDataGrd = new System.Windows.Forms.DataGridView();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.protocolStatusColorsDataGrd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusColorsDataGrd)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.protocolStatusColorsDataGrd);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.statusColorsDataGrd);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 426);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(306, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Цвет статуса протокола";
            // 
            // protocolStatusColorsDataGrd
            // 
            this.protocolStatusColorsDataGrd.AllowUserToAddRows = false;
            this.protocolStatusColorsDataGrd.AllowUserToDeleteRows = false;
            this.protocolStatusColorsDataGrd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.protocolStatusColorsDataGrd.BackgroundColor = System.Drawing.SystemColors.Control;
            this.protocolStatusColorsDataGrd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.protocolStatusColorsDataGrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.protocolStatusColorsDataGrd.Location = new System.Drawing.Point(293, 20);
            this.protocolStatusColorsDataGrd.Name = "protocolStatusColorsDataGrd";
            this.protocolStatusColorsDataGrd.Size = new System.Drawing.Size(255, 322);
            this.protocolStatusColorsDataGrd.TabIndex = 2;
            this.protocolStatusColorsDataGrd.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.protocolStatusColorsDataGrd_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(19, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Цвет статуса закупки";
            // 
            // statusColorsDataGrd
            // 
            this.statusColorsDataGrd.AllowUserToAddRows = false;
            this.statusColorsDataGrd.AllowUserToDeleteRows = false;
            this.statusColorsDataGrd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statusColorsDataGrd.BackgroundColor = System.Drawing.SystemColors.Control;
            this.statusColorsDataGrd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.statusColorsDataGrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.statusColorsDataGrd.Location = new System.Drawing.Point(3, 20);
            this.statusColorsDataGrd.Name = "statusColorsDataGrd";
            this.statusColorsDataGrd.Size = new System.Drawing.Size(255, 322);
            this.statusColorsDataGrd.TabIndex = 0;
            this.statusColorsDataGrd.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.statusColorsDataGrd_CellClick);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsForm";
            this.Text = "Настройки";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.protocolStatusColorsDataGrd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusColorsDataGrd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView statusColorsDataGrd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView protocolStatusColorsDataGrd;
    }
}