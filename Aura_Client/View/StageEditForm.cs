using Aura.Model;
using Aura_Client.Controller;
using Aura_Client.Model;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Aura_Client.View
{
    public partial class StageEditForm : AuraForm
    {
        private PurchaseStage _stage;
        public StageEditForm(PurchaseStage stage) : base()
        {
            InitializeComponent();
            InitializeAuraForm();
            _stage = stage;

            creator = new CommandStringCreator("Stages", stage.id.ToString());

            if (stage.id < 1)
                stage.isActual = 1;

            else
            {
                stageName.Text = stage.statusName;
            }

            isActual.SelectedIndex = stage.isActual;
            creator.AddChange(isActual.Name, isActual.SelectedIndex.ToString());

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
            if (creator.ChangesIsNotEmpty())
            {
                Program.bridge.SendMessage("EXECUTECOMMAND#" +
                    (_stage.id < 1 ?
                    creator.ToNew() :
                    creator.ToUpdate()));

                saveNewPasswordButton.Enabled = false;
                cancelButton.Enabled = false;
                timer1.Start();
            }

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
