using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Aura.Model;

namespace Aura_Client.Model
{
    [Serializable]
    public class DayInCalendar
    {
        //класс описывающий один день из календаря. 
        //хранит в себе список закупок, для которых этот день важен 
        public DayInCalendar(DateTime date)
        {
            this.date = date;
        }


        public DateTime date { get; private set; }
        private List<Purchase> purchases = new List<Purchase>();

        public Dictionary<Purchase, string> events =
        new Dictionary<Purchase, string>(); //описание событий в этот день 


        public void Add(Purchase purchase)
        {
            //добавить новую закупку, если она еще не добавлена 
            if (!purchases.Contains(purchase))
            {
                purchases.Add(purchase);
                handlePurchase(purchase);
            }

        }

        private void handlePurchase(Purchase pur)
        {
            //метод проверяет, какое именно событие назначено на эту дату 
            // и добавляет соответствующее описание 
           
            string eventStr = "";
            
            if (date == pur.bidsStartDate)
                eventStr = "Начало подачи заявок";
            else if (date == pur.bidsEndDate)
                eventStr = "Окончание подачи заявок";

            else if (date == pur.bidsOpenDate)
                eventStr = "Вскрытие конвертов";
            else if (date == pur.bidsReviewDate)
                eventStr = "Рассмотрение";
            else if (date == pur.bidsRatingDate)
                eventStr = "Оценка";

            else if (date == pur.bidsFirstPartDate)
                eventStr = "Рассмотрение первых частей";
            else if (date == pur.bidsSecondPartDate)
                eventStr = "Рассмотрение вторых частей";
            else if (date == pur.bidsFinishDate)
                eventStr = "Дата подведения итогов";

            //else if (dateStr == pur.contractDateLast)
            //    eventStr = "Подписать контракт";
            //else if (dateStr == pur.reestrDateLast)
            //    eventStr = "Внести контракт в реестр";
            //else if (dateStr == pur.auctionDate)
            //    eventStr = "Аукцион";


            if (eventStr != "")
                events.Add(pur, eventStr);
           
        }



    }
}