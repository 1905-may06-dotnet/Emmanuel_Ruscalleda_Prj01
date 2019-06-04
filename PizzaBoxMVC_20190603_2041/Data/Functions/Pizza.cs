using System;
using System.Collections.Generic;
using System.Text;
using Data.DataModel;
using Data;
using System.Linq;
using System.Diagnostics;
using System.Threading;




namespace Data.Functions
{
    public class Pizza
    {

        // Abbreviations: t = topping, P = price
        string size, crust, t1, t2, t3, t4, t5;
        float sizeP, crustP, t1P, t2P, t3P, t4P, t5P;
        int qty;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="size"></param>
        /// <param name="crust"></param>
        /// <param name="t1"></param>
        /// <param name="t2"></param>
        /// <param name="t3"></param>
        /// <param name="t4"></param>
        /// <param name="t5"></param>
        /// <param name="sizeP"></param>
        /// <param name="crustP"></param>
        /// <param name="t1P"></param>
        /// <param name="t2P"></param>
        /// <param name="t3P"></param>
        /// <param name="t4P"></param>
        /// <param name="t5P"></param>
        /// <param name="qty"></param>
        public Pizza(int qty, string size, float sizeP, string crust, float crustP, string t1 = null, float t1P = 0.00F, string t2 = null, float t2P = 0.00F, string t3 = null, float t3P = 0.00F, string t4 = null, float t4P = 0.00F, string t5 = null, float t5P = 0.00F)
        {
            this.size = size;
            this.crust = crust;
            this.t1 = t1;
            this.t2 = t2;
            this.t3 = t3;
            this.t4 = t4;
            this.t5 = t5;

            this.sizeP = sizeP;
            this.crustP = crustP;
            this.t1P = t1P;
            this.t2P = t2P;
            this.t3P = t3P;
            this.t4P = t4P;
            this.t5P = t5P;

            this.qty = qty;
        } // end of: Pizza constructor 

        /// <summary>
        /// 
        /// </summary>
        /// <param name="inputPizza"></param>
        /// <returns></returns>
        public Tuple<List<string>, List<float>, int> MakeAPizza(Pizza inputPizza)
        {
            Tuple<List<string>, List<float>, int> outputPizza;
            List<string> pizzaSCT_Id = new List<string>();
            List<float> pizzaSCT_Price = new List<float>();
            int pizzaQty = 0;

            if (String.IsNullOrEmpty(inputPizza.size.Trim()) == false && String.IsNullOrEmpty(inputPizza.crust.Trim()) == false)
            {
                pizzaQty = inputPizza.qty;
                pizzaSCT_Id.Add(inputPizza.size.Trim());
                pizzaSCT_Price.Add(inputPizza.sizeP);
                pizzaSCT_Id.Add(inputPizza.crust.Trim());
                pizzaSCT_Price.Add(inputPizza.crustP);
            }

            List<string> tempToppingIdList = new List<string>();
            tempToppingIdList.Add(inputPizza.t1);
            tempToppingIdList.Add(inputPizza.t2);
            tempToppingIdList.Add(inputPizza.t3);
            tempToppingIdList.Add(inputPizza.t4);
            tempToppingIdList.Add(inputPizza.t5);

            List<float> tempToppingPriceList = new List<float>();
            tempToppingPriceList.Add(inputPizza.t1P);
            tempToppingPriceList.Add(inputPizza.t2P);
            tempToppingPriceList.Add(inputPizza.t3P);
            tempToppingPriceList.Add(inputPizza.t4P);
            tempToppingPriceList.Add(inputPizza.t5P);

            int tempCount = 0;
            foreach (string topping in tempToppingIdList)
            {
                if (String.IsNullOrEmpty(topping) == false)
                {
                    pizzaSCT_Id.Add(topping);
                    pizzaSCT_Price.Add(tempToppingPriceList[tempCount]);
                }
                tempCount = tempCount + 1;
            }

            outputPizza = new Tuple<List<string>, List<float>, int>(pizzaSCT_Id, pizzaSCT_Price, pizzaQty);
            return outputPizza;
        } // end of: MakeAPizza method 

    } // end of: Pizza class
}