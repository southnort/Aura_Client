using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Aura.Model;


namespace Aura_Client.View
{
    public partial class UsersDataBaseForm : Form
    {
        private List<User> users;

        public UsersDataBaseForm()
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
                ReloadTable();
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
                int userID = (int)dg.Rows[e.RowIndex].Cells[0].Value - 1;
                User user = users[userID];

                ShowUser(user);

            }
        }
    }
}
