namespace Aura_Client.View
{
    partial class MethodEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MethodEditForm));
            this.label1 = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveNewPasswordButton = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.TextBox();
            this.isActual = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.stagesPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Название";
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cancelButton.Location = new System.Drawing.Point(327, 302);
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
            this.saveNewPasswordButton.Location = new System.Drawing.Point(152, 302);
            this.saveNewPasswordButton.Name = "saveNewPasswordButton";
            this.saveNewPasswordButton.Size = new System.Drawing.Size(75, 43);
            this.saveNewPasswordButton.TabIndex = 8;
            this.saveNewPasswordButton.Text = "ОК";
            this.saveNewPasswordButton.UseVisualStyleBackColor = true;
            this.saveNewPasswordButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(152, 25);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(214, 20);
            this.name.TabIndex = 10;
            this.name.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // isActual
            // 
            this.isActual.FormattingEnabled = true;
            this.isActual.Items.AddRange(new object[] {
            "Неактуально",
            "Актуально"});
            this.isActual.Location = new System.Drawing.Point(152, 51);
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
            // stagesPanel
            // 
            this.stagesPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stagesPanel.Location = new System.Drawing.Point(41, 122);
            this.stagesPanel.Name = "stagesPanel";
            this.stagesPanel.Size = new System.Drawing.Size(416, 174);
            this.stagesPanel.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Доступные этапы закупки";
            // 
            // MethodEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 357);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.stagesPanel);
            this.Controls.Add(this.isActual);
            this.Controls.Add(this.name);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveNewPasswordButton);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MethodEditForm";
            this.Text = "Способ осуществления закупки";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveNewPasswordButton;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.ComboBox isActual;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel stagesPanel;
        private System.Windows.Forms.Label label2;
    }
}