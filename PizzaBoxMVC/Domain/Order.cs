using System;
using System.Collections.Generic;
using System.Text;
using Data.DataModel;
using System.Linq;
using System.Threading;



namespace Domain
{
    public class Order
    {
        #region P0_MakeAnOrder
        /*
        public static List<object> MakeAnOrder()
        {
            const int qtyLimitPerOrder = 100;
            const double priceLimitPerOrder = 5000;

            List<object> output = new List<object>();
            int qtyInOrder = 0;
            double totalInOrder = 0;
            List<object> allLineItemsId = new List<object>();
            List<object> allLineItemsPrice = new List<object>();

            List<object> lineItem = new List<object>();
            List<int> qtyPerLine = new List<int>();
            List<int> linesPerOrder = new List<int>();
            List<string> headersList = new List<string> { "Size:", "Crust:", "Topping #1:", "Topping #2:", "Topping #3:", "Topping #4:", "Topping #5:" };
            int lineItemCount = 0;
            bool orderMore = true;

            bool exitInnerWhileLoop = false;
            bool inputIsNumeric = false;
            string userInput = "";
            int inputValue = 0;

            while (orderMore)
            {
                lineItemCount = lineItemCount + 1;

                lineItem = Pizza.MakeAPizza(ref qtyInOrder, ref totalInOrder, qtyLimitPerOrder, priceLimitPerOrder, headersList);
                allLineItemsId.Add(lineItem[0]);
                allLineItemsPrice.Add(lineItem[1]);
                qtyPerLine.Add((int)lineItem[2]);
                linesPerOrder.Add(lineItemCount);

                if ((qtyInOrder < qtyLimitPerOrder) && (totalInOrder < priceLimitPerOrder))
                {
                    double spendingBalance = priceLimitPerOrder - totalInOrder;
                    Console.WriteLine($"\n\n\nYou can order up to {qtyLimitPerOrder - qtyInOrder} new pizzas,");
                    Console.WriteLine($"or spend up to {spendingBalance.ToString("c2")} in this order.");

                    Console.WriteLine("\nWould you like to add more pizzas to this order? ");
                    Console.WriteLine("[1] Yes \n[2] No");

                    exitInnerWhileLoop = false;
                    inputIsNumeric = false;
                    userInput = "";
                    inputValue = 0;

                    do
                    {
                        Console.Write("\nAdd more: ");
                        userInput = Console.ReadLine();
                        inputIsNumeric = long.TryParse(userInput, out Int64 result);

                        if (inputIsNumeric)
                        {
                            inputValue = Convert.ToInt32(userInput);
                        }

                        if (inputIsNumeric && inputValue == 1)
                        {
                            exitInnerWhileLoop = true;
                            orderMore = true;
                        }
                        else if (inputIsNumeric && inputValue == 2)
                        {
                            exitInnerWhileLoop = true;
                            orderMore = false;
                        }
                        else
                        {
                            Console.WriteLine("Input not supported. Try again.");
                            exitInnerWhileLoop = false;
                        }

                    } while (exitInnerWhileLoop == false);

                }
                else
                {
                    orderMore = false;
                }

            }

            output.Add(headersList);
            output.Add(allLineItemsId);
            output.Add(allLineItemsPrice);
            output.Add(qtyPerLine);
            output.Add(linesPerOrder);

            return output;

        } // end of: MakeAnOrder method 
        */


        #endregion


        /// <summary>
        /// 
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static bool CanOrderMore(List<Tuple<List<string>, List<float>, int>> input)
        {
            const int qtyLimitPerOrder = 100;
            const double priceLimitPerOrder = 5000;


            int totalQtyInOrder = 0;
            float totalPriceInOrder = 0;

            bool isTotalQtyLessThanLimit = false;
            bool isTotalPriceLessThanLimit = false;
            bool canAddMoreToOrder = false;
            bool output;

            foreach (var line in input)
            {
                totalQtyInOrder = totalQtyInOrder + line.Item3;
                foreach (float itemPrice in line.Item2)
                {
                    totalPriceInOrder = totalPriceInOrder + (itemPrice * line.Item3);
                }
            }

            if (totalQtyInOrder < qtyLimitPerOrder)
            {
                isTotalQtyLessThanLimit = true;
            }

            if (totalPriceInOrder < priceLimitPerOrder)
            {
                isTotalPriceLessThanLimit = true;
            }

            if (isTotalQtyLessThanLimit == true && isTotalPriceLessThanLimit == true)
            {
                canAddMoreToOrder = true;
            }

            output = canAddMoreToOrder;
            return output;

        } // end of: CanOrderMore method 
    } // end of: Order class 
}
