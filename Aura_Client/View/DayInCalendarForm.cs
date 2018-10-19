using Aura.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Aura_Client.View
{
    public partial class DayInCalendarForm : UserControl, IShowable
    {
        private DayInCalendar dayInCalendar;


        public DayInCalendarForm(DayInCalendar day)
        {
            InitializeComponent();                

            dateLabel.Text = day.date.Day.ToString();

            lowerLabel.Hide();

            //добавить кнопки закупок, если на этот день что-то назначено
            foreach (var pair in day.events)
            {
                Button btn;
                if (panel1.Controls.Count == 0)
                {
                    btn = CreateButton(pair);
                    panel1.Controls.Add(btn);
                    btn.Location = new Point(0, 0);
                }
                else if (panel1.Controls.Count == 1)
                {
                    btn = CreateButton(pair);
                    panel1.Controls.Add(btn);
                    btn.Location = new Point(0, 50);
                }
                else
                {
                    lowerLabel.Show();
                    lowerLabel.Text = "...и еще " + (day.events.Count - 2);
                    break;

                }

                dayInCalendar = day;

            }

            if (day.date.DayOfWeek == DayOfWeek.Sunday ||
                day.date.DayOfWeek == DayOfWeek.Saturday)
            {
                BackColor = Color.MistyRose;
            }

            if (day.date == DateTime.Today)
            {
                BackColor = Color.LightYellow;
            }


        }

        private Button CreateButton(KeyValuePair<Purchase, string> pair)
        {
            int end = pair.Key.purchaseName.Length > 25 ? 25 : pair.Key.purchaseName.Length;
            string buttonText = pair.Key.purchaseName.Substring(0, end);

            Button button = new Button()
            {
                TextAlign = ContentAlignment.MiddleLeft,
                Text = buttonText + "\n" +
                pair.Value,
                Size = new Size(167, 43),
                Name = pair.Key.id.ToString(),

            };

            button.Click += Button_Click;

            return button;

        }

        private void Button_Click(object sender, EventArgs e)
        {
            var id = ((Button)sender).Name;
            Purchase pur = Program.dataManager.GetPurchase(id);
            OpenPurchase(pur);

        }


        private void OpenPurchase(Purchase pur)
        {
            PurchaseForm purchaseForm = new PurchaseForm(pur);
            purchaseForm.ShowDialog();
        }




        public void OpenAuraForm()
        {
            Program.openedForms.Add(this);
        }

        public void CloseAuraForm()
        {
            Program.openedForms.Remove(this);
        }

        private void lowerLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DayInCalendarFullForm form = new DayInCalendarFullForm(dayInCalendar);
            form.ShowDialog();

        }
    }


}