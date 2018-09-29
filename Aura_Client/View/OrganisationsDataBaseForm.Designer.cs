namespace Aura_Client.View
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
            this.number_Equal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.columnsOptionsButton = new System.Windows.Forms.Button();
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
            this.organisationsDataGridView = new System.Windows.Forms.DataGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.organisationsDataGridView)).BeginInit();
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
            this.panel3.Controls.Add(this.number_Equal);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.columnsOptionsButton);
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
            this.panel3.Size = new System.Drawing.Size(588, 78);
            this.panel3.TabIndex = 5;
            // 
            // number_Equal
            // 
            this.number_Equal.Location = new System.Drawing.Point(172, 52);
            this.number_Equal.Name = "number_Equal";
            this.number_Equal.Size = new System.Drawing.Size(124, 20);
            this.number_Equal.TabIndex = 18;
            this.number_Equal.KeyUp += new System.Windows.Forms.KeyEventHandler(this.anyKey_KeyUp);
            this.number_Equal.Leave += new System.EventHandler(this.textBox_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(148, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "№";
            // 
            // columnsOptionsButton
            // 
            this.columnsOptionsButton.BackgroundImage = global::Aura_Client.Properties.Resources.Settings_Icon;
            this.columnsOptionsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.columnsOptionsButton.Location = new System.Drawing.Point(3, 41);
            this.columnsOptionsButton.Name = "columnsOptionsButton";
            this.columnsOptionsButton.Size = new System.Drawing.Size(32, 32);
            this.columnsOptionsButton.TabIndex = 16;
            this.columnsOptionsButton.UseVisualStyleBackColor = true;
            this.columnsOptionsButton.Click += new System.EventHandler(this.columnsOptionsButton_Click);
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
            this.clearFilterButton.Location = new System.Drawing.Point(41, 3);
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
            this.refreshTableButton.Location = new System.Drawing.Point(3, 3);
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
            // organisationsDataGridView
            // 
            this.organisationsDataGridView.AllowUserToAddRows = false;
            this.organisationsDataGridView.AllowUserToOrderColumns = true;
            this.organisationsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.organisationsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.organisationsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.organisationsDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.organisationsDataGridView.Location = new System.Drawing.Point(12, 96);
            this.organisationsDataGridView.Name = "organisationsDataGridView";
            this.organisationsDataGridView.Size = new System.Drawing.Size(588, 356);
            this.organisationsDataGridView.TabIndex = 3;
            this.organisationsDataGridView.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.organisationsDataGridView.KeyUp += new System.Windows.Forms.KeyEventHandler(this.anyKey_KeyUp);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.Closing += new System.Windows.Forms.ToolStripDropDownClosingEventHandler(this.contextMenuStrip1_Closing);
            // 
            // OrganisationsDataBaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 531);
            this.Controls.Add(this.organisationsDataGridView);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OrganisationsDataBaseForm";
            this.Text = "Список организаций";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OrganisationsDataBaseForm_FormClosing);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.anyKey_KeyUp);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.organisationsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button addNewOrgButton;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView organisationsDataGridView;
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
        private System.Windows.Forms.Button columnsOptionsButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox number_Equal;
        private System.Windows.Forms.Label label5;
    }
}