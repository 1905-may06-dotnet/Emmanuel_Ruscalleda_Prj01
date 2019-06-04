using System;
using System.Collections.Generic;
using System.Text;
using Data.DataModel;
using System.Linq;
using System.Threading;



namespace Data.Functions
{
    public class Order
    {

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
