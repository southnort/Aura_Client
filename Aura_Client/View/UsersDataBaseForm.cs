using Aura.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace Aura_Client.View
{
    public partial class UsersDataBaseForm : AuraForm
    {
        private List<User> users;

        public UsersDataBaseForm() : base()
        {
            InitializeComponent();

            users = (List<User>)Program.bridge.GetObject<List<User>>("ALLUSERS");
            ReloadTable();

        }
        
        private void ReloadTable()
        {
            ClearTable();
            FillTable(users);
        }

        private void FillTable(List<User> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                var row = list[i];
                object[] newRow = new object[]
                {
                    row.ID,
                    row.name,
                    row.login,
                    row.password,
                    row.roleID,

                };

                dataGridView1.Rows.Add(newRow);

            }
        }


        private void ClearTable()
        {
            if (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.Rows.Clear();
            }
        }


        private void ShowUser(User user)
        {
            //открыть форму просмотра юзера
            OpenUserForm form = new OpenUserForm(user);
            var result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                Program.bridge.SendUser(form.returnUser);
                timer1.Start();
            }

        }





        private void button1_Click(object sender, EventArgs e)
        {
            ShowUser(new User());
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridView dg = (DataGridView)sender;
                var userID = dg.Rows[e.RowIndex].Cells["id"].Value.ToString();
                User user = Program.dataManager.GetUser(userID);

                ShowUser(user);
            }
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ReloadTable();
        }

        private void UsersDataBaseForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                DialogResult = DialogResult.Cancel;
            }
        }
    }
}
