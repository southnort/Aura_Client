using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aura_Client.Model
{
    class User
    {
        //класс, описывающий пользователя системы
        public int ID;                   //ИД пользователя в системе
        public string name;                 //отображаемое в системе имя
        public int roleID;                  //ИД роли пользователя в системе (Админ, размещающий, проверяющий итд)   

    }
}
