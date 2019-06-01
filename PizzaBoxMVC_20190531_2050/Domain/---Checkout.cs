using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading;

namespace Domain
{
    public class Checkout
    {
        /*
        public static void ConfirmOrder(string emailInput, int storeLocaiton, List<object> fullOrder)
        {
            DBContext PBContex = DbInstance.Instance;

            #region CrediCard_and_Address

            // NOTE TO-EDIT: add method to print full order 

            // select method of payment 
            string card = PaymentMethod.SelectCard(emailInput);

            // select deliver to address or pick up in store 
            string addressId = "";
            string userInput = "";
            bool exitWhile = false;

            Console.WriteLine("What will be the delivery method for this order?");
            Console.WriteLine("\n\n[1] pick up in store \n[2] deliver to address");
            do
            {
                Console.Write("\nChoose an option: \t");
                userInput = Console.ReadLine();

                if ("1" == userInput)
                {
                    addressId = "0";
                    exitWhile = true;
                }
                else if ("2" == userInput)
                {
                    // method to select address 
                    addressId = Addresses.SelectAddress(emailInput);
                    exitWhile = true;
                }
                else
                {
                    Console.WriteLine("Input not supported. Try again.");
                    exitWhile = false;
                }
            } while (exitWhile == false);

            #endregion

            #region ToDatabase
            // add order and pizzas to database 
            OrderItem newOrderItem = new OrderItem();
            OrderTopping newOrderTopping = new OrderTopping();
            OrderSummary newOrderSummary = new OrderSummary();
            OrderAddress newOrderAddress = new OrderAddress();

            // inptus to OrderSummary table 
            newOrderSummary.Email = emailInput;
            newOrderSummary.LocationId = storeLocaiton;
            if (addressId == "0")
            {
                newOrderSummary.DeliveryMode = "pick up";
            }
            // NOTE TO-EDIT: add better conditions for this else statement 
            else
            {
                newOrderSummary.DeliveryMode = "to address";
            }
            newOrderSummary.CardNumber = card;
            DateTime nowIs = DateTime.Now;
            newOrderSummary.Date = nowIs.ToString("yyyy-MM-dd");
            newOrderSummary.Time = nowIs.ToString("HH:mm:ss");
            PBContex.OrderSummary.Add(newOrderSummary);
            PBContex.SaveChanges(); // neet to be here to make sure orderId do not make a data collision 

            int orderId = PBContex.OrderSummary.Last<OrderSummary>().OrderId;

            // inputs to OrderAddress table, if is not pick-up in store 
            if (addressId != "0")
            {
                var y = PBContex.UserAddress.Where<UserAddress>(u => u.Email == emailInput && u.AddressCount == addressId).First<UserAddress>();
                newOrderAddress.OrderId = orderId;
                newOrderAddress.Address1 = y.Address1;
                newOrderAddress.Address2 = y.Address2;
                newOrderAddress.City = y.City;
                newOrderAddress.State = y.State;
                newOrderAddress.Zipcode = y.Zipcode;
                PBContex.OrderAddress.Add(newOrderAddress);
                // PBContex.SaveChanges();

                // NOTE TO-EDIT: add option to ask for phone number and delivery instructions 
            }


            List<string> ids;
            List<object> allLineItesmId = (List<object>)Convert.ChangeType(fullOrder[1], typeof(List<object>));
            int amountOfToppings;
            List<float> prices;
            List<object> allLineItesmPrice = (List<object>)Convert.ChangeType(fullOrder[2], typeof(List<object>));
            List<int> qtyPerLine = (List<int>)fullOrder[3];
            List<int> linesPerOrder = (List<int>)fullOrder[4];

            int lineItemCount, toppingCount;
            int forMax = linesPerOrder.Count;
            for (lineItemCount = 1; lineItemCount <= forMax; lineItemCount++)
            {
                // inputs to OrderItem table 
                ids = (List<string>)allLineItesmId[lineItemCount - 1];
                prices = (List<float>)allLineItesmPrice[lineItemCount - 1];
                newOrderItem.OrderId = orderId;
                newOrderItem.ItemCount = lineItemCount;
                newOrderItem.SizeId = ids[0];
                newOrderItem.SizePrice = prices[0];
                newOrderItem.CrustId = ids[1];
                newOrderItem.CrustPrice = prices[1];
                newOrderItem.Quantity = qtyPerLine[lineItemCount - 1];
                amountOfToppings = ids.Count - 2;

                PBContex.OrderItem.Add(newOrderItem);
                // PBContex.SaveChanges();

                for (toppingCount = 1; toppingCount <= amountOfToppings; toppingCount++)
                {
                    // inputs to OrdeTopping table 
                    newOrderTopping.OrderId = orderId;
                    newOrderTopping.ItemCount = newOrderItem.ItemCount;
                    newOrderTopping.ToppingCount = toppingCount;
                    newOrderTopping.ToppingId = ids[toppingCount + 1];
                    newOrderTopping.ToppingPrice = prices[toppingCount + 1];
                    PBContex.OrderTopping.Add(newOrderTopping);
                    // PBContex.SaveChanges();
                }

            }

            PBContex.SaveChanges();

            #endregion 

        } // end of: ConfirmOrder method
        */
    }// end of: Checkout class 
}
