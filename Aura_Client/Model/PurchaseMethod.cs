using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aura_Client.Model
{
    public abstract class PurchaseMethod
    {
        //класс, описывающий метод закупки
        protected static List<string> allStatuses = new List<string>()
        {
            "<не указано>",         //0
            "Опубликована",         //1

            "Вскрытие конвертов",   //2
            "Рассмотрение",         //3
            "Оценка",               //4

            "Первые части",         //5
            "Вторые части",         //6
            "Подведение итогов",    //7

            "Завершена",            //8       

        };

        protected List<int> statusIndexes;        //статусы, доступные для данной процедуры

        public string name { get; protected set; }
        public Dictionary<int, string> purchaseStatuses;
       
        protected void CreateDictionary()
        {
            //добавляем в словарь все доступные статусы по указанным индексам
            purchaseStatuses = new Dictionary<int, string>();
            foreach (var item in statusIndexes)
            {
                if (allStatuses.Count < item)
                {
                    purchaseStatuses.Add(item, allStatuses[item]);
                }

            }

        }


    }

    public class EmptyPurchaseMethod : PurchaseMethod
    {
        //пустой метод определения поставщика
        public EmptyPurchaseMethod()
        {
            name = "<не указано>";
            statusIndexes = new List<int>() { 0, };
            CreateDictionary();
        }

    }

    public class AloneProvider : PurchaseMethod
    {
        //Единственный поставщик
        public AloneProvider()
        {
            name = "Единственный поставщик";
            statusIndexes = new List<int>()
            {
                0, 1, 8,
            };
            CreateDictionary();
        }
    }


    public class DemandOfQuotation : PurchaseMethod
    {
        //запрос котировок
        public DemandOfQuotation()
        {
            name = "Запрос котировок";
            statusIndexes = new List<int>()
            {
                0, 1, 2, 3, 4, 8,
            };
            CreateDictionary();
        }
    }

    public class DemandOfQuotationEF : PurchaseMethod
    {
        //запрос котировок в электронной форме
        public DemandOfQuotationEF()
        {
            name = "Запрос котировок в ЭФ";
            statusIndexes = new List<int>()
            {
                0, 1, 2, 3, 4, 8,
            };
            CreateDictionary();
        }
    }


    public class Auction:PurchaseMethod
    {
        //Электронный аукцион
        public Auction()
        {
            name = "Электронный аукцион";
            statusIndexes = new List<int>()
            {
                0, 1, 5, 6, 7, 8,
            };
            CreateDictionary();
        }
    }


    public class Konkurs : PurchaseMethod
    {
        //Обычный конкурс
        public Konkurs()
        {
            name = "Конкурс в ЭФ";
            statusIndexes = new List<int>()
            {
                0, 1, 2, 3, 4, 8,
            };
            CreateDictionary();
        }
    }

    public class KonkursEF : PurchaseMethod
    {
        //Конкурс в электронной форме
        public KonkursEF()
        {
            name = "Конкурс в электронной форме";
            statusIndexes = new List<int>()
            {
                0, 1, 2, 3, 4, 8,
            };
            CreateDictionary();
        }
    }


}
