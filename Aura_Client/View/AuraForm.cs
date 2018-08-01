using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aura_Client.View
{
    //базовый класс для форм
    public partial class AuraForm : Form, IShowable
    {
        public void OpenAuraForm()
        {
            Program.openedForms.Add(this);
        }

        public void CloseAuraForm()
        {
            Program.openedForms.Remove(this);
        }
    }

    interface IShowable
    {
        void OpenAuraForm();
        void CloseAuraForm();
    }

}
