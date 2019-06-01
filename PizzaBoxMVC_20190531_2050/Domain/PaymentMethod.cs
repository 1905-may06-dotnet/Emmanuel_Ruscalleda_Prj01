//using System;
//using System.Collections.Generic;
//using System.Text;
//using Data;
//using Data.DataModel;
//using System.Linq;
//using System.Threading;

//namespace Domain
//{
//    public class PaymentMethod
//    {

//        #region P0_SelectCard

//        /*
//        public static string SelectCard(string inputEmail)
//        {
//            DBContext PBContext = DbInstance.Instance;
//            string output;
//            var allCards = PBContext.UserCard.Where<UserCard>(u => u.Email == inputEmail);
//            int cardsCount = allCards.Count();

//            Dictionary<int, string> cardsDictionary = new Dictionary<int, string>();
//            int tempCount = 0;
//            foreach (var card in allCards)
//            {
//                tempCount = tempCount + 1;
//                cardsDictionary.Add(tempCount, card.CardNumber);
//            }

//            Console.WriteLine("The following credit cards are available: \n\n");
//            string dictionaryPrint;
//            foreach (var card in cardsDictionary)
//            {
//                dictionaryPrint = "[" + card.Key + "]   " + card.Value;
//                Console.WriteLine(dictionaryPrint);
//            }

//            string userInput;
//            int inputValue = 0;
//            bool inputIsNumeric;
//            bool exitWhile = false;

//            do
//            {
//                Console.Write("\n\n\nChoose a credit card: \t");
//                userInput = Console.ReadLine().Trim();
//                inputIsNumeric = long.TryParse(userInput, out Int64 result);

//                if (inputIsNumeric)
//                {
//                    inputValue = Convert.ToInt32(userInput);
//                }


//                if (inputIsNumeric && (inputValue > 0) && (inputValue <= cardsCount))
//                {
//                    exitWhile = true;
//                }
//                else
//                {
//                    Console.WriteLine("Input not supported. Try again.");
//                    exitWhile = false;
//                }

//            } while (exitWhile == false);


//            // NOTE TO-EDIT: add a better confirmation message: clear screen and show selection 
//            // NOTE TO-EDIT: add option to add new credit card 
//            // NOTE TO-EDIT: add option to go back to other menu 


//            output = cardsDictionary[inputValue];


//            Console.WriteLine($"\n\n\nCredit Card {cardsDictionary[inputValue]} accepted.\n\n\n");
//            Thread.Sleep(2000);
//            Console.Clear();

//            return output;


//        } // end of: SelectCard method 

//    */

//        #endregion


//        /// <summary>
//        /// PRECONDITION: 
//        /// inputEmail is from an existing user with at least one credit card | 
//        /// SUMMARY: 
//        /// This method returns a list with the credit cards of a user. | 
//        /// POSTCONDITION: 
//        ///  n/a 
//        /// </summary>
//        /// <param name="inputEmail"> Email from an existing user. </param>
//        /// <returns></returns>
//        public static List<string> SelectCard(string inputEmail)
//        {
//            DBContext PBContext = DbInstance.Instance;
//            List<string> outputStrList = new List<string>();

//            // get all the cards from user inputEmail
//            var allCards = PBContext.UserCard.Where<UserCard>(u => u.Email == inputEmail);
//            foreach (var card in allCards)
//            {
//                outputStrList.Add(card.CardNumber);
//            }

//            return outputStrList;

//        } // end of: SelectCard method 

//    } // end of: PaymentMethod class
//}
