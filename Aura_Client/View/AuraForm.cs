using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Aura_Client.Controller;
using Aura_Client.Model;

namespace Aura_Client.View
{
    //базовый класс для форм
    public partial class AuraForm : Form, IShowable
    {
        protected CommandStringCreator creator;

        public void OpenAuraForm()
        {
            Program.openedForms.Add(this);
        }

        public void CloseAuraForm()
        {
            Program.openedForms.Remove(this);
        }


        private void dateTime_ValueChanged(object sender, EventArgs e)
        {
            var picker = (DateTimePicker)sender;
            SetDate(picker, picker.Value);

            creator.Add(picker.Name, picker.Value.ToShortDateString());
        }

        private void textBox_ValueChanged(object sender, EventArgs e)
        {
            if (sender is TextBox)
            {
                var textBox = (TextBox)sender;
                creator.Add(textBox.Name, textBox.Text);
            }
            if (sender is RichTextBox)
            {
                var textBox = (RichTextBox)sender;
                creator.Add(textBox.Name, textBox.Text);
            }


        }

        private void comboBox_ValueChanged(object sender, EventArgs e)
        {
            var box = (ComboBox)sender;
            creator.Add(box.Name, box.SelectedIndex.ToString());
        }

        private void numericUpDown_ValueChanges(object sender, EventArgs e)
        {
            var box = (NumericUpDown)sender;
            creator.Add(box.Name, box.Value.ToString());
        }



        protected void SetDate(DateTimePicker picker, string date)
        {
            try
            {
                DateTime dateTime = Convert.ToDateTime(date);
                if (date == "" || dateTime == DateTime.MinValue)
                {
                    picker.Format = DateTimePickerFormat.Custom;
                    picker.CustomFormat = "''";
                }

                else
                {
                    picker.Format = DateTimePickerFormat.Short;
                    picker.Value = dateTime;
                }
            }

            catch (Exception ex)
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
                picker.Format = DateTimePickerFormat.Short;
                //  picker.Value = date;
            }
        }

        protected void SetCombobox(ComboBox box, int id)
        {
            //для случаев, когда в ComboBox элементы не по порядку, с разрывами
            //id элемента, например статуса
           // box.SelectedIndex = 0;

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



    }

    interface IShowable
    {
        void OpenAuraForm();
        void CloseAuraForm();
    }

}
