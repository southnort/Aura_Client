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
            this.originalID = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.contractCondition = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.law = new System.Windows.Forms.ComboBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label13 = new System.Windows.Forms.Label();
            this.contractType = new System.Windows.Forms.ComboBox();
            this.contractsDataGridView = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contractNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contractStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contractEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.removeContractButton = new System.Windows.Forms.Button();
            this.addNewContractButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.number = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.contractsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name.Location = new System.Drawing.Point(140, 37);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(213, 22);
            this.name.TabIndex = 0;
            this.name.Leave += new System.EventHandler(this.textBox_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(60, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(96, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "ИНН";
            // 
            // inn
            // 
            this.inn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inn.Location = new System.Drawing.Point(140, 65);
            this.inn.Name = "inn";
            this.inn.Size = new System.Drawing.Size(213, 22);
            this.inn.TabIndex = 2;
            this.inn.Leave += new System.EventHandler(this.textBox_ValueChanged);
            // 
            // contactName
            // 
            this.contactName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            this.phoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            this.email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            this.comments.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comments.Location = new System.Drawing.Point(140, 313);
            this.comments.Name = "comments";
            this.comments.Size = new System.Drawing.Size(711, 86);
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
            // originalID
            // 
            this.originalID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.originalID.FormattingEnabled = true;
            this.originalID.Location = new System.Drawing.Point(464, 166);
            this.originalID.Name = "originalID";
            this.originalID.Size = new System.Drawing.Size(121, 24);
            this.originalID.TabIndex = 18;
            this.originalID.Leave += new System.EventHandler(this.comboBox_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(386, 167);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 16);
            this.label10.TabIndex = 19;
            this.label10.Text = "Оригинал";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(379, 137);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 16);
            this.label11.TabIndex = 21;
            this.label11.Text = "Состояние";
            // 
            // contractCondition
            // 
            this.contractCondition.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contractCondition.FormattingEnabled = true;
            this.contractCondition.Location = new System.Drawing.Point(464, 136);
            this.contractCondition.Name = "contractCondition";
            this.contractCondition.Size = new System.Drawing.Size(121, 24);
            this.contractCondition.TabIndex = 20;
            this.contractCondition.Leave += new System.EventHandler(this.comboBox_ValueChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(384, 104);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 16);
            this.label12.TabIndex = 23;
            this.label12.Text = "44 или 223";
            // 
            // law
            // 
            this.law.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.law.FormattingEnabled = true;
            this.law.Location = new System.Drawing.Point(464, 104);
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
            this.timer1.Interval = 250;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(360, 199);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(98, 16);
            this.label13.TabIndex = 27;
            this.label13.Text = "Тип договора";
            // 
            // contractType
            // 
            this.contractType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contractType.FormattingEnabled = true;
            this.contractType.Location = new System.Drawing.Point(464, 196);
            this.contractType.Name = "contractType";
            this.contractType.Size = new System.Drawing.Size(121, 24);
            this.contractType.TabIndex = 26;
            this.contractType.Leave += new System.EventHandler(this.comboBox_ValueChanged);
            // 
            // contractsDataGridView
            // 
            this.contractsDataGridView.AllowUserToAddRows = false;
            this.contractsDataGridView.AllowUserToDeleteRows = false;
            this.contractsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contractsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.contractNumber,
            this.contractStart,
            this.contractEnd});
            this.contractsDataGridView.Location = new System.Drawing.Point(591, 52);
            this.contractsDataGridView.Name = "contractsDataGridView";
            this.contractsDataGridView.ReadOnly = true;
            this.contractsDataGridView.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.contractsDataGridView.RowTemplate.Height = 35;
            this.contractsDataGridView.Size = new System.Drawing.Size(260, 219);
            this.contractsDataGridView.TabIndex = 29;
            this.contractsDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.contractsDataGridView_CellContentClick);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // contractNumber
            // 
            this.contractNumber.HeaderText = "Номер";
            this.contractNumber.Name = "contractNumber";
            this.contractNumber.ReadOnly = true;
            this.contractNumber.Width = 70;
            // 
            // contractStart
            // 
            this.contractStart.HeaderText = "Срок с";
            this.contractStart.Name = "contractStart";
            this.contractStart.ReadOnly = true;
            this.contractStart.Width = 70;
            // 
            // contractEnd
            // 
            this.contractEnd.HeaderText = "Срок по";
            this.contractEnd.Name = "contractEnd";
            this.contractEnd.ReadOnly = true;
            this.contractEnd.Width = 70;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(588, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Заключенные договоры";
            // 
            // removeContractButton
            // 
            this.removeContractButton.BackgroundImage = global::Aura_Client.Properties.Resources.Remove_Icon;
            this.removeContractButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.removeContractButton.Location = new System.Drawing.Point(622, 275);
            this.removeContractButton.Name = "removeContractButton";
            this.removeContractButton.Size = new System.Drawing.Size(25, 25);
            this.removeContractButton.TabIndex = 32;
            this.removeContractButton.UseVisualStyleBackColor = true;
            this.removeContractButton.Click += new System.EventHandler(this.removeContractButton_Click);
            // 
            // addNewContractButton
            // 
            this.addNewContractButton.BackgroundImage = global::Aura_Client.Properties.Resources.AddNew_Icon;
            this.addNewContractButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.addNewContractButton.Location = new System.Drawing.Point(591, 275);
            this.addNewContractButton.Name = "addNewContractButton";
            this.addNewContractButton.Size = new System.Drawing.Size(25, 25);
            this.addNewContractButton.TabIndex = 31;
            this.addNewContractButton.UseVisualStyleBackColor = true;
            this.addNewContractButton.Click += new System.EventHandler(this.addNewContractButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(112, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 16);
            this.label8.TabIndex = 34;
            this.label8.Text = "№";
            // 
            // number
            // 
            this.number.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.number.Location = new System.Drawing.Point(140, 9);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(74, 22);
            this.number.TabIndex = 33;
            this.number.Leave += new System.EventHandler(this.textBox_ValueChanged);
            // 
            // OrganisationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 466);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.number);
            this.Controls.Add(this.removeContractButton);
            this.Controls.Add(this.addNewContractButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.contractsDataGridView);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.contractType);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.law);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.contractCondition);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.originalID);
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
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OrganisationForm";
            this.Text = "Редактирование данных организации";
            ((System.ComponentModel.ISupportInitialize)(this.contractsDataGridView)).EndInit();
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
        private System.Windows.Forms.ComboBox originalID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox contractCondition;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox law;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox contractType;
        private System.Windows.Forms.DataGridView contractsDataGridView;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn contractNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn contractStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn contractEnd;
        private System.Windows.Forms.Button addNewContractButton;
        private System.Windows.Forms.Button removeContractButton;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox number;
    }
}