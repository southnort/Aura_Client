using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aura_Client.Model
{
    static public class Catalog
    {
        //класс-хранилище для списков в формах

        public static List<PurchaseMethod> purchaseMethods = new List<PurchaseMethod>()
        {
            //методы осуществления закупок
            //статусы закупок тоже здесь
            new EmptyPurchaseMethod(),
            new AloneProvider(),
            new DemandOfQuotation(),
            new DemandOfQuotationEF(),
            new Auction(),
            new Konkurs(),
            new KonkursEF(),

        };

        public static List<string> protocolStatuses = new List<string>()
        {
            //статусы протоколов
            "<не указано>",
            "0 заявок",
            "1 заявка",
            "2 и более заявок",
            "жду скан",
            "Протокол опубликован",

        };

        public static List<string> contractConditions = new List<string>
        {
            //состояние заключенного договора с заказчиком на обслуживание
            "<не указано>",
            "действует",
            "расторгнут",
            "без договора",
        
        };

        public static List<string> contractOriginalConditions = new List<string>
        {
            //есть ли оригинал договора на обслуживание с заказчиком, или только копия
            "<не указано>",
            "оригинал",
            "нет оригинала",
            "подписан ЭЦП",
            "без договора",

        };

        public static List<string> laws = new List<string>()
        {
            //названия законов
            "<не указано>",
            "44-ФЗ",
            "223-ФЗ",
            "44-ФЗ и 223-ФЗ",

        };
    }

}
