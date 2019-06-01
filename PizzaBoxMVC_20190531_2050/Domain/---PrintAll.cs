using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class PrintAll
    {
        public static void PrintPizza(List<string> headerList, List<string> itemList, List<double> priceList)
        {
            int listLength = itemList.Count;

            double subTotal = 0;
            for (int i = 0; i < listLength; i++)
            {
                Console.WriteLine(String.Format("{0,-15}  {1,-15}  {2,5}", headerList[i], itemList[i], priceList[i].ToString("c2")));
                subTotal = subTotal + priceList[i];
            }
            Console.WriteLine(String.Format("{0,-15}  {1,-15}  {2,5}", "", "", "___________"));
            Console.WriteLine(String.Format("{0,-15}  {1,-15}  {2,5}", "Sub-Total #1", "", subTotal.ToString("c2")));
        } // end of: PrintPizza method
    } // end of: PrintAll class
}
