using Aura.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Text;

namespace Aura_Client.View
{
    public partial class DayInCalendarFullForm : AuraForm
    {
        //Максимально подробная форма дня из календаря
        public DayInCalendarFullForm(DayInCalendar day) : base()
        {
            InitializeComponent();
            InitializeAuraForm();

            dateLabel.Text = day.date.ToShortDateString();
            RefreshTable(day);


        }

        private void RefreshTable(DayInCalendar day)
        {
            mainPanel.Controls.Clear();
            proceduresCountTextBox.Clear();

            //для подсчёта и отображения количества событий на дату
            Dictionary<string, int> countsOfProcedures  
                = new Dictionary<string, int>();

            foreach (var ev in day.events)
            {
                Button button = CreateButton(ev);
                if (countsOfProcedures.ContainsKey(ev.Value))
                    countsOfProcedures[ev.Value]++;
                else
                    countsOfProcedures.Add(ev.Value, 1);

                int x = 15;
                int y = (mainPanel.Controls.Count) * (button.Height + 5) + 5;
                button.Location = new Point(x, y);

                button.BackColor = GetProtocolStatusColor(ev.Key.protocolStatusID);

                mainPanel.Controls.Add(button);
            }

            RefreshCountText(countsOfProcedures);
        }

        private void RefreshCountText(Dictionary<string, int> countsOfProcedures)
        {
            StringBuilder sb = new StringBuilder();

            foreach (var pair in countsOfProcedures)
            {
                sb.Append(pair.Key);
                sb.Append(" - ");
                sb.Append(pair.Value);
                sb.Append("\n");
            }           

            proceduresCountTextBox.Text = sb.ToString();
        }

        private Button CreateButton(KeyValuePair<Purchase, string> eventOb)
        {
            int end = eventOb.Key.purchaseName.Length > 45 ? 45 
                : eventOb.Key.purchaseName.Length;
            string buttonText = eventOb.Key.purchaseName.Substring(0, end);


            Button button = new Button()
            {
                TextAlign = ContentAlignment.MiddleLeft,
                Size = new Size(284, 40),
                Text = buttonText + "\n" + eventOb.Value,
                Name = eventOb.Key.id.ToString(),

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
            PurchaseForm form = new PurchaseForm(pur);
            form.ShowDialog();
        }

        private void DayInCalendarFullForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult = DialogResult.Cancel;
            }
        }
    }
}
