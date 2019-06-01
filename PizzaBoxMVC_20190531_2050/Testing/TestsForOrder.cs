//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using System.Collections.Generic;
//using Data;
//using Data.DataModel;
//using Domain;
//using System;
//using System.Text;
//using System.Linq;
//using System.Threading;


//namespace Testing
//{
//    [TestClass]
//    public class TestsForOrder
//    {

//        [TestMethod]
//        // Test case: totalQty < 100 and totalPrice < $5,000
//        public void TestOrder01()
//        {
//            // Arrange 
//            List<Tuple<List<string>, List<float>, int>> input = new List<Tuple<List<string>, List<float>, int>>();
//            #region InputData01
//            // ************************************************************** 
//            Tuple<List<string>, List<float>, int> Pizza1;
//            List<string> P1_Lables = new List<string>();
//            List<float> P1_Prices = new List<float>();
//            int P1_qty;
//            P1_Lables.Add("size");
//            P1_Lables.Add("crust");
//            P1_Prices.Add(1000.00F);
//            P1_Prices.Add(0.00F);
//            P1_qty = 1;
//            Pizza1 = new Tuple<List<string>, List<float>, int>(P1_Lables, P1_Prices, P1_qty);
//            // ************************************************************** 
//            Tuple<List<string>, List<float>, int> Pizza2;
//            List<string> P2_Lables = new List<string>();
//            List<float> P2_Prices = new List<float>();
//            int P2_qty;
//            P2_Lables.Add("size");
//            P2_Lables.Add("crust");
//            P2_Lables.Add("topping");
//            P2_Prices.Add(1000.00F);
//            P2_Prices.Add(0.00F);
//            P2_Prices.Add(0.00F);
//            P2_qty = 1;
//            Pizza2 = new Tuple<List<string>, List<float>, int>(P2_Lables, P2_Prices, P2_qty);
//            // ************************************************************** 
//            Tuple<List<string>, List<float>, int> Pizza3;
//            List<string> P3_Lables = new List<string>();
//            List<float> P3_Prices = new List<float>();
//            int P3_qty;
//            P3_Lables.Add("size");
//            P3_Lables.Add("crust");
//            P3_Lables.Add("topping");
//            P3_Prices.Add(1000.00F);
//            P3_Prices.Add(0.00F);
//            P3_Prices.Add(0.00F);
//            P3_qty = 1;
//            Pizza3 = new Tuple<List<string>, List<float>, int>(P3_Lables, P3_Prices, P3_qty);
//            // ************************************************************** 
//            #endregion
//            input.Add(Pizza1);
//            input.Add(Pizza2);
//            input.Add(Pizza3);
//            bool expected = true;
//            bool actual;
//            // Act 
//            actual = Order.CanOrderMore(input);
//            // Assert 
//            Assert.AreEqual(expected, actual);
//        }

//        [TestMethod]
//        // Test case: totalQty < 100 and totalPrice >= $5,000
//        public void TestOrder02()
//        {
//            // Arrange 
//            List<Tuple<List<string>, List<float>, int>> input = new List<Tuple<List<string>, List<float>, int>>();
//            #region InputData02
//            // ************************************************************** 
//            Tuple<List<string>, List<float>, int> Pizza1;
//            List<string> P1_Lables = new List<string>();
//            List<float> P1_Prices = new List<float>();
//            int P1_qty;
//            P1_Lables.Add("size");
//            P1_Lables.Add("crust");
//            P1_Prices.Add(1000.00F);
//            P1_Prices.Add(0.00F);
//            P1_qty = 3;
//            Pizza1 = new Tuple<List<string>, List<float>, int>(P1_Lables, P1_Prices, P1_qty);
//            // ************************************************************** 
//            Tuple<List<string>, List<float>, int> Pizza2;
//            List<string> P2_Lables = new List<string>();
//            List<float> P2_Prices = new List<float>();
//            int P2_qty;
//            P2_Lables.Add("size");
//            P2_Lables.Add("crust");
//            P2_Lables.Add("topping");
//            P2_Prices.Add(1000.00F);
//            P2_Prices.Add(0.00F);
//            P2_Prices.Add(0.00F);
//            P2_qty = 1;
//            Pizza2 = new Tuple<List<string>, List<float>, int>(P2_Lables, P2_Prices, P2_qty);
//            // ************************************************************** 
//            Tuple<List<string>, List<float>, int> Pizza3;
//            List<string> P3_Lables = new List<string>();
//            List<float> P3_Prices = new List<float>();
//            int P3_qty;
//            P3_Lables.Add("size");
//            P3_Lables.Add("crust");
//            P3_Lables.Add("topping");
//            P3_Prices.Add(1000.00F);
//            P3_Prices.Add(0.00F);
//            P3_Prices.Add(0.00F);
//            P3_qty = 1;
//            Pizza3 = new Tuple<List<string>, List<float>, int>(P3_Lables, P3_Prices, P3_qty);
//            // ************************************************************** 
//            #endregion
//            input.Add(Pizza1);
//            input.Add(Pizza2);
//            input.Add(Pizza3);
//            bool expected = false;
//            bool actual;
//            // Act 
//            actual = Order.CanOrderMore(input);
//            // Assert 
//            Assert.AreEqual(expected, actual);
//        }

//        [TestMethod]
//        // Test case: totalQty >= 100 and totalPrice < $5,000
//        public void TestOrder03()
//        {
//            // Arrange 
//            List<Tuple<List<string>, List<float>, int>> input = new List<Tuple<List<string>, List<float>, int>>();
//            #region InputData03
//            // ************************************************************** 
//            Tuple<List<string>, List<float>, int> Pizza1;
//            List<string> P1_Lables = new List<string>();
//            List<float> P1_Prices = new List<float>();
//            int P1_qty;
//            P1_Lables.Add("size");
//            P1_Lables.Add("crust");
//            P1_Prices.Add(1.00F);
//            P1_Prices.Add(0.00F);
//            P1_qty = 98;
//            Pizza1 = new Tuple<List<string>, List<float>, int>(P1_Lables, P1_Prices, P1_qty);
//            // ************************************************************** 
//            Tuple<List<string>, List<float>, int> Pizza2;
//            List<string> P2_Lables = new List<string>();
//            List<float> P2_Prices = new List<float>();
//            int P2_qty;
//            P2_Lables.Add("size");
//            P2_Lables.Add("crust");
//            P2_Lables.Add("topping");
//            P2_Prices.Add(1000.00F);
//            P2_Prices.Add(0.00F);
//            P2_Prices.Add(0.00F);
//            P2_qty = 1;
//            Pizza2 = new Tuple<List<string>, List<float>, int>(P2_Lables, P2_Prices, P2_qty);
//            // ************************************************************** 
//            Tuple<List<string>, List<float>, int> Pizza3;
//            List<string> P3_Lables = new List<string>();
//            List<float> P3_Prices = new List<float>();
//            int P3_qty;
//            P3_Lables.Add("size");
//            P3_Lables.Add("crust");
//            P3_Lables.Add("topping");
//            P3_Prices.Add(1000.00F);
//            P3_Prices.Add(0.00F);
//            P3_Prices.Add(0.00F);
//            P3_qty = 1;
//            Pizza3 = new Tuple<List<string>, List<float>, int>(P3_Lables, P3_Prices, P3_qty);
//            // ************************************************************** 
//            #endregion
//            input.Add(Pizza1);
//            input.Add(Pizza2);
//            input.Add(Pizza3);
//            bool expected = false;
//            bool actual;
//            // Act 
//            actual = Order.CanOrderMore(input);
//            // Assert 
//            Assert.AreEqual(expected, actual);
//        }

//        [TestMethod]
//        // Test case: totalQty >= 100 and totalPrice < $5,000
//        public void TestOrder04()
//        {
//            // Arrange 
//            List<Tuple<List<string>, List<float>, int>> input = new List<Tuple<List<string>, List<float>, int>>();
//            #region InputData04
//            // ************************************************************** 
//            Tuple<List<string>, List<float>, int> Pizza1;
//            List<string> P1_Lables = new List<string>();
//            List<float> P1_Prices = new List<float>();
//            int P1_qty;
//            P1_Lables.Add("size");
//            P1_Lables.Add("crust");
//            P1_Prices.Add(1000.00F);
//            P1_Prices.Add(0.00F);
//            P1_qty = 98;
//            Pizza1 = new Tuple<List<string>, List<float>, int>(P1_Lables, P1_Prices, P1_qty);
//            // ************************************************************** 
//            Tuple<List<string>, List<float>, int> Pizza2;
//            List<string> P2_Lables = new List<string>();
//            List<float> P2_Prices = new List<float>();
//            int P2_qty;
//            P2_Lables.Add("size");
//            P2_Lables.Add("crust");
//            P2_Lables.Add("topping");
//            P2_Prices.Add(1000.00F);
//            P2_Prices.Add(0.00F);
//            P2_Prices.Add(0.00F);
//            P2_qty = 1;
//            Pizza2 = new Tuple<List<string>, List<float>, int>(P2_Lables, P2_Prices, P2_qty);
//            // ************************************************************** 
//            Tuple<List<string>, List<float>, int> Pizza3;
//            List<string> P3_Lables = new List<string>();
//            List<float> P3_Prices = new List<float>();
//            int P3_qty;
//            P3_Lables.Add("size");
//            P3_Lables.Add("crust");
//            P3_Lables.Add("topping");
//            P3_Prices.Add(1000.00F);
//            P3_Prices.Add(0.00F);
//            P3_Prices.Add(0.00F);
//            P3_qty = 1;
//            Pizza3 = new Tuple<List<string>, List<float>, int>(P3_Lables, P3_Prices, P3_qty);
//            // ************************************************************** 
//            #endregion
//            input.Add(Pizza1);
//            input.Add(Pizza2);
//            input.Add(Pizza3);
//            bool expected = false;
//            bool actual;
//            // Act 
//            actual = Order.CanOrderMore(input);
//            // Assert 
//            Assert.AreEqual(expected, actual);
//        }

//    } // end of: TestsForOrder class 
//}
