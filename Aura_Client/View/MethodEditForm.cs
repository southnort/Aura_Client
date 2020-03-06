using Aura.Model;
using Aura_Client.Controller;
using Aura_Client.Model;
using System;
using System.Data;
using System.Windows.Forms;
using System.Text;
using System.Collections.Generic;


namespace Aura_Client.View
{
    public partial class MethodEditForm : AuraForm
    {
        private PurchaseMethod method;
        private Dictionary<string, string> stagesIds;

        public MethodEditForm(PurchaseMethod _method)
        {
            StartLoading();
            InitializeComponent();
            InitializeAuraForm();

            creator = new CommandStringCreator("Methods", _method.id.ToString());

            method = _method;
            if (method.id < 1)
                method.isActual = 1;

            FillFields();
            FillStages();


            FinishLoading();
        }

        private void FillFields()
        {
            name.Text = method.name;
            isActual.SelectedIndex = method.isActual;
            creator.AddChange(isActual.Name, isActual.SelectedIndex.ToString());
        }

        private void FillStages()
        {
            var stages = Program.dataManager.GetAllStages(true);
            string query = $"SELECT stage_id FROM Methods_Stages WHERE method_id = '{method.id}'";
            var table = Program.dataManager.GetDataTable(query);
            stagesIds = new Dictionary<string, string>();
            foreach (DataRow row in table.Rows)
                stagesIds.Add(row[0].ToString(), row[0].ToString());

            for (int i = 0; i < stages.Count; i++)
            {
                var stageBox = new CheckBox();
                stageBox.Text = stages[i].statusName;
                stageBox.Name = stages[i].id.ToString();
                stageBox.CheckedChanged += clickOnCheckBox;
                if (stagesIds.ContainsKey(stages[i].id.ToString()))
                    stageBox.Checked = true;
                stagesPanel.Controls.Add(stageBox);
                int x = (i % 3) * 130 + 3;
                int y = (i / 3) * 20 + 3;
                stageBox.Location = new System.Drawing.Point(x, y);
            }

        }

        private void clickOnCheckBox(object sender, EventArgs e)
        {
            var box = sender as CheckBox;
            if (box.Checked)
            {
                if (!stagesIds.ContainsKey(box.Name))
                    stagesIds.Add(box.Name, box.Name);
            }

            else
            {
                stagesIds.Remove(box.Name);
            }
        }









        private void textBox1_Leave(object sender, EventArgs e)
        {
            base.textBox_ValueChanged(sender, e);
        }

        private void isActual_Leave(object sender, EventArgs e)
        {
            var box = (ComboBox)sender;
            var item = box.SelectedIndex;
            creator.AddChange(box.Name, item.ToString());
        }



        private void okButton_Click(object sender, EventArgs e)
        {
            StartLoading();
            StringBuilder sb = new StringBuilder();
            sb.Append("EXECUTECOMMAND#");
            sb.Append("BEGIN TRANSACTION;");
            //проверяем изменения самого метода
            if (creator.ChangesIsNotEmpty())
            {
                if (method.id < 1) sb.Append(creator.ToNew());
                else sb.Append(creator.ToUpdate());
                sb.Append(";");
            }

            //удаляем связи
            if (method.id > 0)
            {
                sb.Append($" DELETE FROM Methods_Stages WHERE method_id = '{method.id}';");
            }

            //добавляем новые связи
            if (stagesIds.Count > 0)
            {
                sb.Append(" INSERT INTO Methods_Stages ('method_id', 'stage_id') VALUES ");

                foreach (var id in stagesIds)
                {
                    sb.Append("(");
                    sb.Append(method.id < 1 ?
                        "(SELECT MAX(id) FROM Methods)"
                        : method.id.ToString());
                    sb.Append($", {id.Key}),");
                }
                sb.Length--;
            }

            sb.Append("; COMMIT;");
            Program.bridge.SendMessage(sb.ToString());
            saveNewPasswordButton.Enabled = false;
            cancelButton.Enabled = false;
            timer1.Start();
            FinishLoading();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }


    }
}
