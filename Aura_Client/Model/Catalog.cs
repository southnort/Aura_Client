using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aura_Client.Model
{
    static public class Catalog
    {
        //класс-хранилище для списков в формах
        public static List<string> purchasesNames = new List<string>()
        {
            "<не указано>",
            "Единственный поставщик",
            "Запрос котировок",
            "Запрос котировок в ЭФ",
            "Электронный аукцион",
            "Конкурс",
            "Конкурс в ЭФ",
            
        };

        public static List<string> statusesNames = new List<string>()
        {
            "<не указано>",            
            "Проверка",
            "На доработку",
            "Опубликовано",
            "Протоколы",
            "0 заявок",
            "1 заявка",
            "2 и более заявок",
            "жду скан",
            "Протокол опубликован",
            "Договор заключен",
            "Договор внесен в реестр",            

        };

        public static List<string> organisationsNames = new List<string>()
        {
            "<не указано>",
            "Тестовый заказчик 1",
            "Тестовый заказчик 2",
            "Тестовый заказчик 3",

        };


        public static List<string> contractConditions = new List<string>
        {
            "<не указано>",
            "действует",
            "расторгнут",
            "без договора",
        
        };

        public static List<string> contractOriginalConditions = new List<string>
        {
            "<не указано>",
            "оригинал",
            "нет оригинала",
            "подписан ЭЦП",
            "без договора",

        };

        public static List<string> laws = new List<string>()
        {
            "<не указано>",
            "44-ФЗ",
            "223-ФЗ",
            "44-ФЗ и 223-ФЗ",

        };
    }
}
