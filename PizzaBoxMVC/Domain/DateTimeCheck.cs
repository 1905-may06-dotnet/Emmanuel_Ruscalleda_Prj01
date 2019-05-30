using System;
using System.Collections.Generic;
using System.Text;
using Data.DataModel;
using Data;
using System.Linq;


namespace Domain
{
    public class DateTimeCheck
    {

        #region P0_CheckIfCanOrder

        /*
        public static bool CheckIfCanOrder(string emailInput, int selectedLocation)
        {
            const int hoursConstraintsBetweenOrders = 2;
            const int daysConstraintsBetweenOrders = 1;
            bool canMakeAnOrder = false; // output 

            DBContext PBContex = DbInstance.Instance;
            try
            {
                var x = PBContex.OrderSummary.Where<OrderSummary>(u => u.Email == emailInput).Last<OrderSummary>();
                var y = PBContex.LocationInfo.Where<LocationInfo>(u => u.LocationId == selectedLocation).First<LocationInfo>();
                int lastLocaiton = x.LocationId;
                string lastOrderDate = x.Date;
                string lastOrderTime = x.Time;
                string fullAddress = "\t" + y.Name + "\n\t" + y.Address1 + " " + y.Address2 + "\n\t" + y.City + " " + y.State + " " + y.Zipcode;

                DateTime nowIs = DateTime.Now;
                string lastOrderDateTimeStr = lastOrderDate + " " + lastOrderTime;
                DateTime lastOrderDateTime = Convert.ToDateTime(lastOrderDateTimeStr);
                DateTime lastOrderDateTimePlus2hr = lastOrderDateTime.AddHours(hoursConstraintsBetweenOrders);
                DateTime lastOrderDateTimePlus1day = lastOrderDateTime.AddDays(daysConstraintsBetweenOrders);
                int compareDate = DateTime.Compare(nowIs, lastOrderDateTimePlus1day); // compareDate = 1 if nowIs > lastOrderDateTimePlus1day
                int compareTime = DateTime.Compare(nowIs, lastOrderDateTimePlus2hr); // compareTime = 1 if nowIs > lastOrderDateTimePlus2hr

                if (selectedLocation == lastLocaiton)
                {
                    if (compareDate == 1 && compareTime == 1)
                    {
                        canMakeAnOrder = true;
                    }
                    else
                    {
                        Console.WriteLine($"Your last order was on {lastOrderDateTime.ToString("   MMM dd, yyyy   hh:mm tt")}.");
                        Console.WriteLine("You have to wait at least 1-day to order from ");
                        Console.WriteLine($"\n{fullAddress}\n");
                        if (compareTime != 1)
                        {
                            Console.WriteLine("and you have to wait at least 2-hrs after your last order to order from any other store.");
                        }
                        Console.WriteLine($"You can order again from the selected location on {lastOrderDateTimePlus1day.ToString("MMM dd, yyyy")}.");
                        if (compareTime == 1)
                        {
                            Console.WriteLine("You can order from any other store right now.");
                        }
                    }
                }
                else
                {
                    // selectedLocation is not the same as lastLocation 
                    if (compareTime == 1)
                    {
                        canMakeAnOrder = true;
                    }
                    else
                    {
                        Console.WriteLine($"Your last order was on {lastOrderDateTime.ToString("   MMM dd, yyyy   hh:mm tt")}.");
                        Console.WriteLine("You have to wait at least 2-hrs after your last order.");
                        Console.WriteLine($"You can order again after {lastOrderDateTimePlus2hr.ToString("hh:mm tt")}.");
                    }
                }
            }
            catch
            {
                canMakeAnOrder = true;
            }

            return canMakeAnOrder;

        } // end of: CheckIfCanOrder method 
        */

        #endregion



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
