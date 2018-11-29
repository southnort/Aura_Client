using Aura_Client.Controller;
using Aura_Client.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Aura_Client.View
{
    //базовый класс для форм
    public partial class AuraForm : Form, IShowable
    {
        public AuraForm()
        {
            KeyPreview = true;
            KeyUp += EscapeKeyPressed;
            InitializeRightMenuButtonMenu();

        }

        protected void InitializeAuraForm()
        {
            //вызов методов, общих для всех наследников AuraForm
            InitializeRightMenuButtonMenu();
        }

        protected CommandStringCreator creator;
        protected ContextMenuStrip rightMouseButtonMenu;

        public void OpenAuraForm()
        {
            Program.openedForms.Add(this);
        }

        public void CloseAuraForm()
        {
            Program.openedForms.Remove(this);
        }


        protected virtual void dateTime_ValueChanged(object sender, EventArgs e)
        {
            var picker = (DateTimePicker)sender;
            SetDate(picker, picker.Value);

            creator.AddChange(picker.Name, picker.Value.ToString("yyyy-MM-dd-HH-mm"));
        }

        protected virtual void textBox_ValueChanged(object sender, EventArgs e)
        {
            if (sender is TextBox)
            {
                var textBox = (TextBox)sender;
                creator.AddChange(textBox.Name, textBox.Text);
            }
            if (sender is RichTextBox)
            {
                var textBox = (RichTextBox)sender;
                creator.AddChange(textBox.Name, textBox.Text);
            }


        }

        protected virtual void comboBox_ValueChanged(object sender, EventArgs e)
        {
            var box = (ComboBox)sender;
            ComboBoxItem item = box.SelectedItem as ComboBoxItem;
            try
            {                
                if (item != null)
                    creator.AddChange(box.Name, ((int)item.Value).ToString());
            }
            catch
            {
                MessageBox.Show(item.Value.GetType().ToString());
            }
        }

        protected virtual void numericUpDown_ValueChanges(object sender, EventArgs e)
        {
            var box = (NumericUpDown)sender;
            creator.AddChange(box.Name, box.Value.ToString().Replace(",", "."));
        }


        protected virtual void EscapeKeyPressed(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult = DialogResult.Cancel;
            }
        }



        protected void SetDate(DateTimePicker picker, string date)
        {
            try
            {
                DateTime dateTime = Convert.ToDateTime(date);
                SetDate(picker, dateTime);
            }

            catch
            {
                picker.Format = DateTimePickerFormat.Custom;
                picker.CustomFormat = "''";

                MessageBox.Show("Error. Value \"" + date + "\" is not date");
            }
        }

        protected void SetDate(DateTimePicker picker, DateTime date)
        {
            if (date == DateTime.MinValue)
            {
                picker.Format = DateTimePickerFormat.Custom;
                picker.CustomFormat = "''";
            }

            else
            {
                picker.Format = DateTimePickerFormat.Custom;
                picker.CustomFormat = "dd.MM.yyyy   HH : mm";
                picker.Value = date;
            }
        }

        protected void LoadFromCopy()
        {
            foreach (var control in Controls)
            {
                if (control is TextBoxBase)
                    textBox_ValueChanged(control, EventArgs.Empty);

                if (control is ComboBox)
                    comboBox_ValueChanged(control, EventArgs.Empty);

                if (control is NumericUpDown)
                    numericUpDown_ValueChanges(control, EventArgs.Empty);

                if (control is DateTimePicker)
                {
                    if ((control as DateTimePicker).CustomFormat != "''")
                        dateTime_ValueChanged(control, EventArgs.Empty);

                }

            }

        }


        protected void SetCombobox(ComboBox box, int id)
        {           
            for (int i = 0; i < box.Items.Count; i++)
            {
                ComboBoxItem cbItem = box.Items[i] as ComboBoxItem;
                if (id.ToString() == cbItem.Value.ToString())
                {
                    box.SelectedIndex = i;
                    break;
                }
            }

        }

        protected void SetCombobox(ComboBox box, string id)
        {
            for (int i = 0; i < box.Items.Count; i++)
            {
                ComboBoxItem cbItem = box.Items[i] as ComboBoxItem;
                if (id == cbItem.Value.ToString())
                {
                    box.SelectedIndex = i;
                    break;
                }
            }
        }

        protected string ConvertDateToText(DateTime original)
        {
            if (original == DateTime.MinValue)
                return "";
            // else return original.ToShortDateString();
            else return original.ToString("dd.MM.yyyy   HH:mm");
        }

        protected string ConvertDateToShortText(DateTime original)
        {
            if (original == DateTime.MinValue)
                return "";

            else return original.ToString("dd.MM.yyyy");
        }


        protected void SetColumnOrder(DataGridView name)
        {
            if (!DataGridViewSetting.Default.ColumnOrder.ContainsKey(this.Name))
                return;

            List<ColumnOrderItem> columnOrders =
                DataGridViewSetting.Default.ColumnOrder[this.Name];

            if (columnOrders != null)
            {
                var sorted = columnOrders.OrderBy(i => i.DisplayIndex);
                foreach (var item in sorted)
                {
                    name.Columns[item.ColumnIndex].DisplayIndex = item.DisplayIndex;
                    name.Columns[item.ColumnIndex].Visible = item.Visible;
                    name.Columns[item.ColumnIndex].Width = item.Width;
                }
            }

        }

        protected void SaveColumnOrder(DataGridView name)
        {
            if (name.AllowUserToOrderColumns)
            {
                List<ColumnOrderItem> columnOrders = new List<ColumnOrderItem>();
                var columns = name.Columns;
                for (int i = 0; i < columns.Count; i++)
                {
                    columnOrders.Add(new ColumnOrderItem
                    {
                        ColumnIndex = i,
                        DisplayIndex = columns[i].DisplayIndex,
                        Visible = columns[i].Visible,
                        Width = columns[i].Width,

                    });
                }

                DataGridViewSetting.Default.ColumnOrder[this.Name] = columnOrders;
                DataGridViewSetting.Default.Save();

            }
        }


        protected Color GetProtocolStatusColor(int indexOfStatus)
        {
            if (Properties.settings.Default.ProtocolStatus.Count < indexOfStatus)
                return Color.White;

            else
            {
                var item = Properties.settings.Default.ProtocolStatus[indexOfStatus];
                int argb = int.Parse(item);
                return Color.FromArgb(argb);

            }
        }



        protected void InitializeRightMenuButtonMenu()
        {
            rightMouseButtonMenu = new ContextMenuStrip();
            ToolStripMenuItem copyMenuItem = new ToolStripMenuItem("Копировать");
            ToolStripMenuItem pasteMenuItem = new ToolStripMenuItem("Вставить");
            rightMouseButtonMenu.Items.AddRange(new[] { copyMenuItem, pasteMenuItem, });

            copyMenuItem.Click += copyMenuItem_Click;
            pasteMenuItem.Click += pasteMenuItem_Click;


            foreach (var item in Controls)
            {
                if (item is Panel)
                {
                    foreach (Control control in ((Panel)item).Controls)
                    {
                        control.ContextMenuStrip = rightMouseButtonMenu;
                    }
                }

                else
                {
                    ((Control)item).ContextMenuStrip = rightMouseButtonMenu;
                }
            }



            foreach (Control control in Controls)
            {
                control.ContextMenuStrip = rightMouseButtonMenu;
            }

        }

        private void copyMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveControl is TextBoxBase)
            {
                if (((TextBoxBase)ActiveControl).SelectedText != "")
                    Clipboard.SetText(((TextBoxBase)ActiveControl).SelectedText);
                else
                    Clipboard.Clear();
            }

            else if (ActiveControl is NumericUpDown)
            {
                Clipboard.SetText(((NumericUpDown)ActiveControl).Value.ToString());

            }

            else
            {
                if (ActiveControl.Text != "")
                    Clipboard.SetText(ActiveControl.Text);
                else
                    Clipboard.Clear();
            }


        }


        private void pasteMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveControl is TextBoxBase)
            {
                ((TextBoxBase)ActiveControl).Text = Clipboard.GetText();
            }

            else if (ActiveControl is NumericUpDown)
            {
                decimal value;
                string text = Clipboard.GetText();

                if (decimal.TryParse(text, out value))
                    ((NumericUpDown)ActiveControl).Value = value;
            }

            else if (ActiveControl is DateTimePicker)
            {
                ActiveControl.Text = Clipboard.GetText();
            }

        }



    }

    interface IShowable
    {
        void OpenAuraForm();
        void CloseAuraForm();
    }

}
