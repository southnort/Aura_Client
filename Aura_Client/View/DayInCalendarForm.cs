using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Aura.Model;
using Aura_Client.Model;

namespace Aura_Client.View
{
    public partial class DayInCalendarForm : UserControl, IShowable
    {
        public DayInCalendarForm(Aura_Client.Model.DayInCalendar dayInCalendar)
        {
            InitializeComponent();

            dateLabel.Text = dayInCalendar.date.Day.ToString();

            lowerLabel.Text = "Добавить";

            //добавить кнопки закупок, если на этот день что-то назначено
            foreach (var pair in dayInCalendar.events)
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
                    lowerLabel.Text = "...и еще " + (dayInCalendar.events.Count - 2);
                    break;

                }

            }

            if (dayInCalendar.date.DayOfWeek == DayOfWeek.Sunday ||
                dayInCalendar.date.DayOfWeek == DayOfWeek.Saturday)
            {
                BackColor = Color.MistyRose;
            }

        }

        private Button CreateButton(KeyValuePair<Purchase, string> pair)
        {
            Button button = new Button()
            {
                TextAlign = ContentAlignment.MiddleLeft,
                Text = pair.Key.purchaseName + "\n" +
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


    }


}