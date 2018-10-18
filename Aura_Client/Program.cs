using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aura.Model;
using Aura_Client.Model;
using Aura_Client.View;
using Aura_Client.Network;
using System.Windows.Forms;
using System.Configuration;


namespace Aura_Client
{
    class Program
    {
        public static User user = new User();
        public static NetworkBridge bridge;
        public static List<IShowable> openedForms = new List<IShowable>();
        public static DataManager dataManager;

        [STAThread]
        static void Main()
        {
            user.ID = -1;
            SetSettingsSetting();
            StartProgram();
            Application.Run(new MainForm());
            Environment.Exit(0);

            // LoginWindow loginWindow = new LoginWindow();
            //var result =  loginWindow.ShowDialog();

            //if (result == System.Windows.Forms.DialogResult.OK)
            //{
            //    var users = bridge.GetObject<Dictionary<string, string>>("USERNAMES");
            //    var purchases = bridge.GetObject<List<Purchase>>("ALLPURCHASES");
            //    var organisations = bridge.GetObject<List<Organisation>>("ALLORGANISATIONS");

            //    MainForm mainForm = new MainForm();
            //    mainForm.ShowDialog();
            //}

        }

        static void StartProgram()
        {
            bridge = new NetworkBridge();
            dataManager = new DataManager();

        }

        static void SetSettingsSetting()
        {
            if (Properties.settings.Default.UpgradeRequired)
            {
                DataGridViewSetting.Default.Upgrade();
                Properties.settings.Default.Upgrade();
                Properties.settings.Default.UpgradeRequired = false;
                Properties.settings.Default.Save();

            }

            
        }


    }

}
