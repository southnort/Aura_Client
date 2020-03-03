namespace Aura_Client.View
{
    partial class StageEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StageEditForm));
            this.label1 = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveNewPasswordButton = new System.Windows.Forms.Button();
            this.stageName = new System.Windows.Forms.TextBox();
            this.isActual = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Название";
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cancelButton.Location = new System.Drawing.Point(291, 121);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 43);
            this.cancelButton.TabIndex = 9;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveNewPasswordButton
            // 
            this.saveNewPasswordButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.saveNewPasswordButton.Location = new System.Drawing.Point(116, 121);
            this.saveNewPasswordButton.Name = "saveNewPasswordButton";
            this.saveNewPasswordButton.Size = new System.Drawing.Size(75, 43);
            this.saveNewPasswordButton.TabIndex = 8;
            this.saveNewPasswordButton.Text = "ОК";
            this.saveNewPasswordButton.UseVisualStyleBackColor = true;
            this.saveNewPasswordButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // stageName
            // 
            this.stageName.Location = new System.Drawing.Point(152, 47);
            this.stageName.Name = "stageName";
            this.stageName.Size = new System.Drawing.Size(214, 20);
            this.stageName.TabIndex = 10;
            this.stageName.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // isActual
            // 
            this.isActual.FormattingEnabled = true;
            this.isActual.Items.AddRange(new object[] {
            "Неактуально",
            "Актуально"});
            this.isActual.Location = new System.Drawing.Point(152, 73);
            this.isActual.Name = "isActual";
            this.isActual.Size = new System.Drawing.Size(121, 21);
            this.isActual.TabIndex = 11;
            this.isActual.Leave += new System.EventHandler(this.isActual_Leave);
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // StageEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 176);
            this.Controls.Add(this.isActual);
            this.Controls.Add(this.stageName);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveNewPasswordButton);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StageEditForm";
            this.Text = "Редактирование этапа";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveNewPasswordButton;
        private System.Windows.Forms.TextBox stageName;
        private System.Windows.Forms.ComboBox isActual;
        private System.Windows.Forms.Timer timer1;
    }
}