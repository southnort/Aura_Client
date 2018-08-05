namespace Aura_Client.View
{
    partial class OrganisationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrganisationForm));
            this.name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inn = new System.Windows.Forms.TextBox();
            this.contactName = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.phoneNumber = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.RichTextBox();
            this.comments = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.contractNumber = new System.Windows.Forms.TextBox();
            this.contractStart = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.contractEnd = new System.Windows.Forms.DateTimePicker();
            this.originalID = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.contractCondition = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.law = new System.Windows.Forms.ComboBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name.Location = new System.Drawing.Point(140, 30);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(213, 15);
            this.name.TabIndex = 0;
            this.name.Leave += new System.EventHandler(this.textBox_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(62, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(96, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "ИНН";
            // 
            // inn
            // 
            this.inn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inn.Location = new System.Drawing.Point(140, 52);
            this.inn.Name = "inn";
            this.inn.Size = new System.Drawing.Size(213, 15);
            this.inn.TabIndex = 2;
            this.inn.Leave += new System.EventHandler(this.textBox_ValueChanged);
            // 
            // contactName
            // 
            this.contactName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.contactName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contactName.Location = new System.Drawing.Point(140, 103);
            this.contactName.Name = "contactName";
            this.contactName.Size = new System.Drawing.Size(213, 52);
            this.contactName.TabIndex = 4;
            this.contactName.Text = "\n";
            this.contactName.Leave += new System.EventHandler(this.textBox_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(10, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Контактные лица";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(56, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Телефоны";
            // 
            // phoneNumber
            // 
            this.phoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.phoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneNumber.Location = new System.Drawing.Point(140, 161);
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.Size = new System.Drawing.Size(213, 52);
            this.phoneNumber.TabIndex = 6;
            this.phoneNumber.Text = "";
            this.phoneNumber.Leave += new System.EventHandler(this.textBox_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(87, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "E-mail";
            // 
            // email
            // 
            this.email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.email.Location = new System.Drawing.Point(140, 219);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(213, 52);
            this.email.TabIndex = 8;
            this.email.Text = "";
            this.email.Leave += new System.EventHandler(this.textBox_ValueChanged);
            // 
            // comments
            // 
            this.comments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.comments.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comments.Location = new System.Drawing.Point(140, 313);
            this.comments.Name = "comments";
            this.comments.Size = new System.Drawing.Size(676, 86);
            this.comments.TabIndex = 10;
            this.comments.Text = "";
            this.comments.Leave += new System.EventHandler(this.textBox_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(36, 313);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Комментарии";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(481, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(116, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "Номер договора";
            // 
            // contractNumber
            // 
            this.contractNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.contractNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contractNumber.Location = new System.Drawing.Point(603, 31);
            this.contractNumber.Name = "contractNumber";
            this.contractNumber.Size = new System.Drawing.Size(213, 15);
            this.contractNumber.TabIndex = 12;
            this.contractNumber.Leave += new System.EventHandler(this.textBox_ValueChanged);
            // 
            // contractStart
            // 
            this.contractStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contractStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.contractStart.Location = new System.Drawing.Point(603, 56);
            this.contractStart.Name = "contractStart";
            this.contractStart.Size = new System.Drawing.Size(88, 22);
            this.contractStart.TabIndex = 14;
            this.contractStart.CloseUp += new System.EventHandler(this.dateTime_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(509, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "Действует с";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(698, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 16);
            this.label9.TabIndex = 17;
            this.label9.Text = "по";
            // 
            // contractEnd
            // 
            this.contractEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contractEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.contractEnd.Location = new System.Drawing.Point(728, 56);
            this.contractEnd.Name = "contractEnd";
            this.contractEnd.Size = new System.Drawing.Size(88, 22);
            this.contractEnd.TabIndex = 16;
            this.contractEnd.CloseUp += new System.EventHandler(this.dateTime_ValueChanged);
            // 
            // originalID
            // 
            this.originalID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.originalID.FormattingEnabled = true;
            this.originalID.Location = new System.Drawing.Point(603, 180);
            this.originalID.Name = "originalID";
            this.originalID.Size = new System.Drawing.Size(121, 24);
            this.originalID.TabIndex = 18;
            this.originalID.Leave += new System.EventHandler(this.comboBox_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(525, 181);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 16);
            this.label10.TabIndex = 19;
            this.label10.Text = "Оригинал";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(518, 151);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 16);
            this.label11.TabIndex = 21;
            this.label11.Text = "Состояние";
            // 
            // contractCondition
            // 
            this.contractCondition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contractCondition.FormattingEnabled = true;
            this.contractCondition.Location = new System.Drawing.Point(603, 150);
            this.contractCondition.Name = "contractCondition";
            this.contractCondition.Size = new System.Drawing.Size(121, 24);
            this.contractCondition.TabIndex = 20;
            this.contractCondition.Leave += new System.EventHandler(this.comboBox_ValueChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(523, 118);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 16);
            this.label12.TabIndex = 23;
            this.label12.Text = "44 или 223";
            // 
            // law
            // 
            this.law.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.law.FormattingEnabled = true;
            this.law.Location = new System.Drawing.Point(603, 118);
            this.law.Name = "law";
            this.law.Size = new System.Drawing.Size(121, 24);
            this.law.TabIndex = 22;
            this.law.Leave += new System.EventHandler(this.comboBox_ValueChanged);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(204, 405);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(111, 49);
            this.buttonOK.TabIndex = 24;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(555, 405);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(111, 49);
            this.buttonCancel.TabIndex = 25;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // OrganisationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 466);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.law);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.contractCondition);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.originalID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.contractEnd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.contractStart);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.contractNumber);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comments);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.email);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.phoneNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.contactName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OrganisationForm";
            this.Text = "OrganisationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inn;
        private System.Windows.Forms.RichTextBox contactName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox phoneNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox email;
        private System.Windows.Forms.RichTextBox comments;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox contractNumber;
        private System.Windows.Forms.DateTimePicker contractStart;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker contractEnd;
        private System.Windows.Forms.ComboBox originalID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox contractCondition;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox law;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Timer timer1;
    }
}