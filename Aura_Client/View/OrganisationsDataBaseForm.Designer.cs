﻿namespace Aura_Client.View
{
    partial class OrganisationsDataBaseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrganisationsDataBaseForm));
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.contractType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.law = new System.Windows.Forms.ComboBox();
            this.name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.inn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.clearFilterButton = new System.Windows.Forms.Button();
            this.refreshTableButton = new System.Windows.Forms.Button();
            this.addNewOrgButton = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.deleteOrganisationButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 55);
            this.button1.TabIndex = 0;
            this.button1.Text = "Создать пользователя";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(0, 210);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 61);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, -222);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(776, 49);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.contractType);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.law);
            this.panel3.Controls.Add(this.name);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.inn);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.clearFilterButton);
            this.panel3.Controls.Add(this.refreshTableButton);
            this.panel3.Controls.Add(this.panel1);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(588, 56);
            this.panel3.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(324, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Тип";
            // 
            // contractType
            // 
            this.contractType.FormattingEnabled = true;
            this.contractType.Location = new System.Drawing.Point(356, 26);
            this.contractType.Name = "contractType";
            this.contractType.Size = new System.Drawing.Size(121, 21);
            this.contractType.TabIndex = 14;
            this.contractType.KeyUp += new System.Windows.Forms.KeyEventHandler(this.anyKey_KeyUp);
            this.contractType.Leave += new System.EventHandler(this.comboBox_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(312, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Закон";
            // 
            // law
            // 
            this.law.FormattingEnabled = true;
            this.law.Location = new System.Drawing.Point(356, 3);
            this.law.Name = "law";
            this.law.Size = new System.Drawing.Size(121, 21);
            this.law.TabIndex = 12;
            this.law.KeyUp += new System.Windows.Forms.KeyEventHandler(this.anyKey_KeyUp);
            this.law.Leave += new System.EventHandler(this.comboBox_ValueChanged);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(172, 26);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(124, 20);
            this.name.TabIndex = 10;
            this.name.KeyUp += new System.Windows.Forms.KeyEventHandler(this.anyKey_KeyUp);
            this.name.Leave += new System.EventHandler(this.textBox_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Наименование";
            // 
            // inn
            // 
            this.inn.Location = new System.Drawing.Point(172, 3);
            this.inn.Name = "inn";
            this.inn.Size = new System.Drawing.Size(124, 20);
            this.inn.TabIndex = 8;
            this.inn.KeyUp += new System.Windows.Forms.KeyEventHandler(this.anyKey_KeyUp);
            this.inn.Leave += new System.EventHandler(this.textBox_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "ИНН";
            // 
            // clearFilterButton
            // 
            this.clearFilterButton.BackgroundImage = global::Aura_Client.Properties.Resources.ClearFilter_Icon;
            this.clearFilterButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.clearFilterButton.Location = new System.Drawing.Point(41, 9);
            this.clearFilterButton.Name = "clearFilterButton";
            this.clearFilterButton.Size = new System.Drawing.Size(32, 32);
            this.clearFilterButton.TabIndex = 6;
            this.clearFilterButton.UseVisualStyleBackColor = true;
            this.clearFilterButton.Click += new System.EventHandler(this.clearFilterButton_Click);
            // 
            // refreshTableButton
            // 
            this.refreshTableButton.BackgroundImage = global::Aura_Client.Properties.Resources.Refresh_Icon;
            this.refreshTableButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.refreshTableButton.Location = new System.Drawing.Point(3, 9);
            this.refreshTableButton.Name = "refreshTableButton";
            this.refreshTableButton.Size = new System.Drawing.Size(32, 32);
            this.refreshTableButton.TabIndex = 5;
            this.refreshTableButton.UseVisualStyleBackColor = true;
            this.refreshTableButton.Click += new System.EventHandler(this.refreshTableButton_Click);
            // 
            // addNewOrgButton
            // 
            this.addNewOrgButton.Location = new System.Drawing.Point(3, 3);
            this.addNewOrgButton.Name = "addNewOrgButton";
            this.addNewOrgButton.Size = new System.Drawing.Size(162, 55);
            this.addNewOrgButton.TabIndex = 0;
            this.addNewOrgButton.Text = "Добавить организацию";
            this.addNewOrgButton.UseVisualStyleBackColor = true;
            this.addNewOrgButton.Click += new System.EventHandler(this.addNewOrgButton_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.deleteOrganisationButton);
            this.panel4.Controls.Add(this.addNewOrgButton);
            this.panel4.Location = new System.Drawing.Point(12, 458);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(588, 61);
            this.panel4.TabIndex = 3;
            // 
            // deleteOrganisationButton
            // 
            this.deleteOrganisationButton.Location = new System.Drawing.Point(423, 6);
            this.deleteOrganisationButton.Name = "deleteOrganisationButton";
            this.deleteOrganisationButton.Size = new System.Drawing.Size(162, 55);
            this.deleteOrganisationButton.TabIndex = 1;
            this.deleteOrganisationButton.Text = "Удалить организацию";
            this.deleteOrganisationButton.UseVisualStyleBackColor = true;
            this.deleteOrganisationButton.Click += new System.EventHandler(this.deleteOrganisationButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(12, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(588, 378);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.anyKey_KeyUp);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.Width = 35;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Наименование";
            this.Column2.Name = "Column2";
            this.Column2.Width = 300;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "ИНН";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Закон";
            this.Column4.Name = "Column4";
            // 
            // OrganisationsDataBaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 531);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OrganisationsDataBaseForm";
            this.Text = "Список организаций";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.anyKey_KeyUp);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button addNewOrgButton;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button refreshTableButton;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button clearFilterButton;
        private System.Windows.Forms.Button deleteOrganisationButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox contractType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox law;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}