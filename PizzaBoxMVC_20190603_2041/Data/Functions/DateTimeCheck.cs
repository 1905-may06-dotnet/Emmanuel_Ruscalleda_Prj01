using System;
using System.Collections.Generic;
using System.Text;
using Data.DataModel;
using Data;
using System.Linq;


namespace Data.Functions
{
    public class DateTimeCheck
    {


        /// <summary>
        /// PRECONDITION: 
        /// inputEmail is from an existing user | 
        /// SUMMARY: 
        /// This method checks if an order can be placed based on the selected location, the location of the previous order, and the date and time constraints. |
        /// POSTCONDITION: 
        ///  Return bool canOrderInSelectedLocation, and string canOrderInOtherLocation with one of {yes, no, unknown} |
        /// </summary>
        /// <param name="inputEmail"> Email from an existing user. </param>
        /// <param name="selectedLocationId"> Location ID from a location. </param>
        /// <returns></returns>
        public static Tuple<bool, string> CheckIfCanOrder(string inputEmail, int selectedLocationId)
        {
            const int hoursConstraintsBetweenOrders = 2;
            const int daysConstraintsBetweenLocationOrders = 1;
            DBContext PBContex = DbInstance.Instance;
            Tuple<bool, string> output;
            OrderSummary lastOrder = new OrderSummary();

            bool canOrderInSelectedLocation = false;
            string canOrderInOtherLocation = "";

            try
            {
                // get the last order from a user inputEmail 
                lastOrder = PBContex.OrderSummary.Where<OrderSummary>(u => u.Email == inputEmail).Last<OrderSummary>();
                int lastLocaitonId = lastOrder.LocationId;
                string lastOrderDate = lastOrder.Date;
                string lastOrderTime = lastOrder.Time;

                DateTime nowIs = DateTime.Now;
                string lastOrderDateTimeStr = lastOrderDate + " " + lastOrderTime;
                DateTime lastOrderDateTime = Convert.ToDateTime(lastOrderDateTimeStr);
                DateTime lastOrderDateTimePlus2hr = lastOrderDateTime.AddHours(hoursConstraintsBetweenOrders);
                DateTime lastOrderDateTimePlus1day = lastOrderDateTime.AddDays(daysConstraintsBetweenLocationOrders);
                int compareDate = DateTime.Compare(nowIs, lastOrderDateTimePlus1day); // compareDate = 1 if nowIs > lastOrderDateTimePlus1day
                int compareTime = DateTime.Compare(nowIs, lastOrderDateTimePlus2hr); // compareTime = 1 if nowIs > lastOrderDateTimePlus2hr

                if (selectedLocationId == lastLocaitonId) // last order location is same as curren order selected location 
                {
                    if (compareDate == 1) // last order is over 1 day ago 
                    {
                        canOrderInSelectedLocation = true;
                        canOrderInOtherLocation = "yes";
                    }
                    else if (compareDate != 1 && compareTime == 1) // last order is same day, but over 2 hrs ago  
                    {
                        canOrderInSelectedLocation = false;
                        canOrderInOtherLocation = "yes";
                    }

                    else if (compareDate != 1 && compareTime != 1) // last order is less than 2 hrs before now 
                    {
                        canOrderInSelectedLocation = false;
                        canOrderInOtherLocation = "no";
                    }
                    else
                    {
                        // do nothing, there is no other case 
                    }
                }
                else if (selectedLocationId != lastLocaitonId) // last order location is different than curren order selected location 
                {
                    if (compareDate == 1) // last order is over 1 day ago  
                    {
                        canOrderInSelectedLocation = true;
                        canOrderInOtherLocation = "yes";
                    }
                    else if (compareDate != 1 && compareTime == 1) // last order is same day, but over 2 hrs ago 
                    {
                        canOrderInSelectedLocation = true;
                        canOrderInOtherLocation = "unknow";
                    }
                    else if (compareDate != 1 && compareTime != 1) // last order is less than 2 hrs before now 
                    {
                        canOrderInSelectedLocation = false;
                        canOrderInOtherLocation = "no";
                    }
                    else
                    {
                        // do nothing, there is no other case 
                    }
                }
                else
                {
                    // do nothing, there is no other case 
                }
            }
            catch
            {
                // there is no lastOrder, i.e., this user has zero orders 
                canOrderInSelectedLocation = true;
                canOrderInOtherLocation = "yes";
            }

            output = new Tuple<bool, string>(canOrderInSelectedLocation, canOrderInOtherLocation);
            return output;

        } // end of: CheckIfCanOrder method 

    } // end of: DateTimeCheck class
}
