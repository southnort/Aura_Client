using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Aura.Model;

namespace Aura_Client.Model
{
    public static class CCatalog
    {
        public static List<PurchaseMethod> purchaseMethods;
        public static List<PurchaseStage> allStages;


        public static void LoadCatalog()
        {
            var stages = Program.dataManager.GetAllStages(true);
            var methods = Program.dataManager.GetAllMethods(true);
            var relationships = Program.dataManager.GetDataTable("SELECT * FROM Methods_Stages");

            foreach (System.Data.DataRow rel in relationships.Rows)
            {
                var m = int.Parse(rel[0].ToString());
                var s = int.Parse(rel[1].ToString());

                methods[m].purchaseStages.Add(s, stages[s].statusName);                
            }

            purchaseMethods = methods;
            allStages = stages;
        }
    }
}
