//using System;
//using System.Collections.Generic;
//using System.Text;
//using Data.DataModel;
//using Data;
//using System.Linq;
//using System.Diagnostics;
//using System.Threading;




//namespace Domain
//{
//    public class Pizza
//    {
//        #region P0_MakeAPizza
//        /*
//        public static List<object> MakeAPizza(ref int qtyInOrder, ref double totalInOrder, int qtyLimitPerOrder, double priceLimitPerOrder, List<string> headersList)
//        {
//            ;
//            List<object> outputCollection = new List<object>();

//            DBContext PBContext = DbInstance.Instance;
//            int tempCount;
//            string dictionaryInputStr;
//            string strMenu = "\t\tMENU";

//            #region Dictionaries

//            var allSizes = PBContext.PizzaSize.OrderBy(u => u.Inches);
//            strMenu = strMenu + "\n\nSizes";
//            Dictionary<int, Tuple<string, double, double>> sizeDictionary = new Dictionary<int, Tuple<string, double, double>>();
//            dictionaryInputStr = "";
//            tempCount = 0;
//            foreach (var size in allSizes)
//            {
//                tempCount = tempCount + 1;
//                dictionaryInputStr = $"[{tempCount}]\t{size.SizeId}\t{size.Inches}-inches\t{size.SalesPrice.ToString("c2")}";
//                strMenu = strMenu + "\n" + dictionaryInputStr;
//                sizeDictionary.Add(tempCount, new Tuple<string, double, double>(size.SizeId, size.SalesPrice, size.ScalingFactor));
//            }

//            var allCrusts = PBContext.PizzaCrust.OrderBy(u => u.SalesPrice);
//            strMenu = strMenu + "\n\nCrust";
//            Dictionary<int, Tuple<string, double>> crustDictionary = new Dictionary<int, Tuple<string, double>>();
//            dictionaryInputStr = "";
//            tempCount = 0;
//            foreach (var crust in allCrusts)
//            {
//                tempCount = tempCount + 1;
//                dictionaryInputStr = $"[{tempCount}]\t{crust.CrustId}\t\t\t{crust.SalesPrice.ToString("c2")}";
//                strMenu = strMenu + "\n" + dictionaryInputStr;

//                crustDictionary.Add(tempCount, new Tuple<string, double>(crust.CrustId, crust.SalesPrice));
//            }

//            var allToppings = PBContext.PizzaTopping;
//            strMenu = strMenu + "\n\nToppings";
//            Dictionary<int, Tuple<string, double>> toppingDictionary = new Dictionary<int, Tuple<string, double>>();
//            dictionaryInputStr = "";
//            tempCount = 0;
//            foreach (var topping in allToppings)
//            {
//                tempCount = tempCount + 1;
//                if (topping.ToppingId.Length >= 8)
//                {
//                    dictionaryInputStr = $"[{tempCount}]\t{topping.ToppingId}\t\t{topping.SalesPrice.ToString("c2")}";
//                }
//                else
//                {
//                    dictionaryInputStr = $"[{tempCount}]\t{topping.ToppingId}\t\t\t{topping.SalesPrice.ToString("c2")}";
//                }
//                strMenu = strMenu + "\n" + dictionaryInputStr;

//                toppingDictionary.Add(tempCount, new Tuple<string, double>(topping.ToppingId, topping.SalesPrice));
//            }

//            strMenu = strMenu + "\n\n";

//            #endregion

//            List<string> pizzaSCT5_Id = new List<string>();
//            List<double> pizzaSCT5_Prices = new List<double>();

//            bool exitWhileFlag;
//            string userInput;
//            int toppingCount;
//            int lastKey;
//            bool inputIsNumeric;
//            int inputValue;


//            #region ChooseSize

//            Console.Clear();
//            Console.WriteLine(strMenu);
//            userInput = "";
//            lastKey = sizeDictionary.Keys.Last();
//            exitWhileFlag = false;
//            inputIsNumeric = false;
//            inputValue = 0;
//            do
//            {
//                Console.Write("\n\n\nChoose a Size: ");
//                userInput = Console.ReadLine();
//                userInput = userInput.Trim();
//                inputIsNumeric = long.TryParse(userInput, out Int64 result);

//                if (inputIsNumeric)
//                {
//                    inputValue = Convert.ToInt32(userInput);
//                }

//                if (inputIsNumeric && inputValue > 0 && inputValue <= lastKey)
//                {
//                    pizzaSCT5_Id.Add(sizeDictionary[inputValue].Item1);
//                    pizzaSCT5_Prices.Add(sizeDictionary[inputValue].Item2);
//                    exitWhileFlag = true;
//                }
//                else
//                {
//                    Console.WriteLine("Input not supported. Try again.");
//                    exitWhileFlag = false;
//                }

//            } while (exitWhileFlag == false);


//            #endregion


//            #region ChooseCrust

//            Console.Clear();
//            Console.WriteLine(strMenu);
//            Console.WriteLine("\n\nCurrent selections:");
//            PrintAll.PrintPizza(headersList, pizzaSCT5_Id, pizzaSCT5_Prices);
//            userInput = "";
//            lastKey = crustDictionary.Keys.Last();
//            exitWhileFlag = false;
//            inputIsNumeric = false;
//            inputValue = 0;
//            do
//            {
//                Console.Write("\n\n\nChoose a Crust: ");
//                userInput = Console.ReadLine();
//                userInput = userInput.Trim();
//                inputIsNumeric = long.TryParse(userInput, out Int64 result);

//                if (inputIsNumeric)
//                {
//                    inputValue = Convert.ToInt32(userInput);
//                }

//                if (inputIsNumeric && inputValue > 0 && inputValue <= lastKey)
//                {
//                    pizzaSCT5_Id.Add(crustDictionary[inputValue].Item1);
//                    pizzaSCT5_Prices.Add(crustDictionary[inputValue].Item2);
//                    exitWhileFlag = true;
//                }
//                else
//                {
//                    Console.WriteLine("Input not supported. Try again.");
//                    exitWhileFlag = false;
//                }

//            } while (exitWhileFlag == false);

//            #endregion


//            #region ChooseToppings

//            Console.Clear();
//            Console.WriteLine(strMenu);
//            Console.WriteLine("\n\nCurrent selections:");
//            PrintAll.PrintPizza(headersList, pizzaSCT5_Id, pizzaSCT5_Prices);
//            userInput = "";
//            lastKey = toppingDictionary.Keys.Last();
//            exitWhileFlag = false;
//            inputIsNumeric = false;
//            inputValue = 0;
//            toppingCount = 1;
//            Console.WriteLine("\n\nChoose up to 5 toppings. To finish choosing toppings enter [99].");
//            do
//            {
//                if (toppingCount <= 5)
//                {
//                    Console.Write($"Topping #{toppingCount}: ");
//                    userInput = Console.ReadLine();
//                    userInput = userInput.Trim();
//                    inputIsNumeric = long.TryParse(userInput, out Int64 result);

//                    if (inputIsNumeric)
//                    {
//                        inputValue = Convert.ToInt32(userInput);
//                    }

//                    if (inputIsNumeric && inputValue > 0 && inputValue <= lastKey)
//                    {
//                        pizzaSCT5_Id.Add(toppingDictionary[inputValue].Item1);
//                        pizzaSCT5_Prices.Add(toppingDictionary[inputValue].Item2);
//                    }
//                    else if (99 == inputValue)
//                    {
//                        exitWhileFlag = true;
//                    }
//                    else
//                    {
//                        Console.WriteLine("Input not supported. Try again.");
//                        toppingCount = toppingCount - 1;
//                        exitWhileFlag = false;
//                    }
//                    toppingCount = toppingCount + 1;
//                }
//                else
//                {
//                    exitWhileFlag = true;
//                }
//            } while (exitWhileFlag == false);

//            #endregion


//            #region QtyPerOrder 

//            Console.Clear();
//            Console.WriteLine("\n\nCurrent selections:");
//            PrintAll.PrintPizza(headersList, pizzaSCT5_Id, pizzaSCT5_Prices);
//            exitWhileFlag = false;
//            inputIsNumeric = false;
//            userInput = "";
//            inputValue = 0;
//            Console.WriteLine("You can order up to {0} of the above pizza.", qtyLimitPerOrder - qtyInOrder);

//            // NOTE TO-EDIT: need to add constraint with Price limit taking in consideration the price of the pizza in progress 

//            do
//            {
//                Console.Write("\nHow many do you want? ");
//                userInput = Console.ReadLine();
//                inputIsNumeric = long.TryParse(userInput, out Int64 result);

//                if (inputIsNumeric)
//                {
//                    inputValue = Convert.ToInt32(userInput);
//                }

//                if (inputIsNumeric && inputValue <= (qtyLimitPerOrder - qtyInOrder))
//                {
//                    qtyInOrder = qtyInOrder + inputValue;
//                    exitWhileFlag = true;
//                }
//                else
//                {
//                    Console.WriteLine("Input not supported. Try again.");
//                    exitWhileFlag = false;
//                }

//            } while (exitWhileFlag == false);

//            double subTotal2 = 0;
//            foreach (double x in pizzaSCT5_Prices)
//            {
//                subTotal2 = subTotal2 + x;
//            }
//            subTotal2 = subTotal2 * inputValue;
//            totalInOrder = subTotal2 + totalInOrder;


//            // NOTE TO-EDIT: make a printing method for this part, and call from MakeAnOrder (not from MakeAPizza) 
//            Console.Clear();
//            Console.WriteLine("\n\nFrom the last selection:");
//            PrintAll.PrintPizza(headersList, pizzaSCT5_Id, pizzaSCT5_Prices);
//            Console.WriteLine(String.Format("{0,-15}  {1,-15}  {2,3}", "Sub-Quantity", "", inputValue.ToString()));
//            Console.WriteLine(String.Format("{0,-15}  {1,-15}  {2,5}", "", "", "___________"));
//            Console.WriteLine(String.Format("{0,-15}  {1,-15}  {2,5}", "Sub-Total #2", "", subTotal2.ToString("c2")));
//            Console.WriteLine("");
//            Console.WriteLine(String.Format("{0,-15}  {1,-15}  {2,3}", "Total-Quantity", "", qtyInOrder.ToString()));
//            Console.WriteLine("");
//            Console.WriteLine(String.Format("{0,-15}  {1,-15}  {2,5}", "Total", "", totalInOrder.ToString("c2")));

//            #endregion


//            outputCollection.Add(pizzaSCT5_Id);
//            outputCollection.Add(pizzaSCT5_Prices);
//            outputCollection.Add(inputValue);

//            return outputCollection;


//        } // end of: MakeAPizza method
//    */
//        #endregion

//        // Tuple<List<string>, List<float>, int> Pizza1;
//        // Pizza1 = new Tuple<List<string>, List<float>, int>(P1_Lables, P1_Prices, P1_qty);



//        // Abbreviations: t = topping, P = price
//        string size, crust, t1, t2, t3, t4, t5;
//        float sizeP, crustP, t1P, t2P, t3P, t4P, t5P;
//        int qty;

//        /// <summary>
//        /// 
//        /// </summary>
//        /// <param name="size"></param>
//        /// <param name="crust"></param>
//        /// <param name="t1"></param>
//        /// <param name="t2"></param>
//        /// <param name="t3"></param>
//        /// <param name="t4"></param>
//        /// <param name="t5"></param>
//        /// <param name="sizeP"></param>
//        /// <param name="crustP"></param>
//        /// <param name="t1P"></param>
//        /// <param name="t2P"></param>
//        /// <param name="t3P"></param>
//        /// <param name="t4P"></param>
//        /// <param name="t5P"></param>
//        /// <param name="qty"></param>
//        public Pizza(int qty, string size, float sizeP, string crust, float crustP, string t1 = null, float t1P = 0.00F, string t2 = null, float t2P = 0.00F, string t3 = null, float t3P = 0.00F, string t4 = null, float t4P = 0.00F, string t5 = null, float t5P = 0.00F)
//        {
//            this.size = size;
//            this.crust = crust;
//            this.t1 = t1;
//            this.t2 = t2;
//            this.t3 = t3;
//            this.t4 = t4;
//            this.t5 = t5;

//            this.sizeP = sizeP;
//            this.crustP = crustP;
//            this.t1P = t1P;
//            this.t2P = t2P;
//            this.t3P = t3P;
//            this.t4P = t4P;
//            this.t5P = t5P;

//            this.qty = qty;
//        } // end of: Pizza constructor 

//        /// <summary>
//        /// 
//        /// </summary>
//        /// <param name="inputPizza"></param>
//        /// <returns></returns>
//        public Tuple<List<string>, List<float>, int> MakeAPizza(Pizza inputPizza)
//        {
//            Tuple<List<string>, List<float>, int> outputPizza;
//            List<string> pizzaSCT_Id = new List<string>();
//            List<float> pizzaSCT_Price = new List<float>();
//            int pizzaQty = 0;

//            if (String.IsNullOrEmpty(inputPizza.size.Trim()) == false && String.IsNullOrEmpty(inputPizza.crust.Trim()) == false)
//            {
//                pizzaQty = inputPizza.qty;
//                pizzaSCT_Id.Add(inputPizza.size.Trim());
//                pizzaSCT_Price.Add(inputPizza.sizeP);
//                pizzaSCT_Id.Add(inputPizza.crust.Trim());
//                pizzaSCT_Price.Add(inputPizza.crustP);
//            }

//            List<string> tempToppingIdList = new List<string>();
//            tempToppingIdList.Add(inputPizza.t1);
//            tempToppingIdList.Add(inputPizza.t2);
//            tempToppingIdList.Add(inputPizza.t3);
//            tempToppingIdList.Add(inputPizza.t4);
//            tempToppingIdList.Add(inputPizza.t5);

//            List<float> tempToppingPriceList = new List<float>();
//            tempToppingPriceList.Add(inputPizza.t1P);
//            tempToppingPriceList.Add(inputPizza.t2P);
//            tempToppingPriceList.Add(inputPizza.t3P);
//            tempToppingPriceList.Add(inputPizza.t4P);
//            tempToppingPriceList.Add(inputPizza.t5P);

//            int tempCount = 0;
//            foreach (string topping in tempToppingIdList)
//            {
//                if (String.IsNullOrEmpty(topping) == false)
//                {
//                    pizzaSCT_Id.Add(topping);
//                    pizzaSCT_Price.Add(tempToppingPriceList[tempCount]);
//                }
//                tempCount = tempCount + 1;
//            }

//            outputPizza = new Tuple<List<string>, List<float>, int>(pizzaSCT_Id, pizzaSCT_Price, pizzaQty);
//            return outputPizza;
//        } // end of: MakeAPizza method 

//    } // end of: Pizza class
//}