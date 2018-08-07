using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aura_Client.Model
{
    class ComboBoxItem
    {
        //класс для вставки в элемент формы ComboBox
        //чтобы можно было работать с индексами не по порядку

        public string Text { get; set; }
        public object Value { get; set; }

        public override string ToString()
        {
            return Text;
        }

    }
}
