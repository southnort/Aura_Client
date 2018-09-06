using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Aura.Model;

namespace Aura_Client.Model
{


    public class Calendar : Dictionary<DateTime, DayInCalendar>
    {
        //класс, описывающий календарь
        public void Add(Purchase purchase)
        {
            if (purchase == null) return;

            Add(purchase.purchaseEisDate, purchase);
            Add(purchase.bidsStartDate, purchase);
            Add(purchase.bidsEndDate, purchase);
            Add(purchase.bidsOpenDate, purchase);
            Add(purchase.bidsFirstPartDate, purchase);
            Add(purchase.auctionDate, purchase);
            Add(purchase.bidsSecondPartDate, purchase);
            Add(purchase.bidsFinishDate, purchase);

            Add(purchase.bidsReviewDate, purchase);
            Add(purchase.bidsRatingDate, purchase);

            Add(purchase.contractDatePlan, purchase);
            Add(purchase.contractDateLast, purchase);
            Add(purchase.contractDateReal, purchase);
            Add(purchase.reestrDateLast, purchase);
            
        }




        private void Add(DateTime date, Purchase purchase)
        {
            DateTime tempDateTime = new DateTime(date.Year, date.Month, date.Day);

            if (!ContainsKey(tempDateTime))
            {
                Add(tempDateTime, new DayInCalendar(tempDateTime));
            }
            
            this[tempDateTime].Add(purchase);

        }


    }



    public static class ExtensionsMethods
    {
        //статический класс для расширящих методов
        public static DateTime ToDateTime(this string str)
        {
            return Convert.ToDateTime(str);

        }
    }


}


