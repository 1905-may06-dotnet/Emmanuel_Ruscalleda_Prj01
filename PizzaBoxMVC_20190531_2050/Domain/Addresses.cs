//using System;
//using System.Collections.Generic;
//using System.Text;
//using Data;
//using Data.DataModel;
//using System.Linq;
//using System.Text.RegularExpressions;
//using System.Threading;

//namespace Domain
//{
//    public class Addresses
//    {

//        #region PO_SelectAddress
//        /*
//        public static string SelectAddress(string inputEmail)
//        {
//            DBContext PBContext = DbInstance.Instance;
//            string output = "";
//            var allAddresses = PBContext.UserAddress.Where<UserAddress>(u => u.Email == inputEmail);
//            int addreCount = allAddresses.Count();
//            string fullAddress = "";

//            Console.WriteLine("\n\nThe following addresses are available: ");
//            foreach (var y in allAddresses)
//            {
//                fullAddress = "\n[" + y.AddressCount + "]" + "\t" + y.Address1 + " " + y.Address2 + "\n\t" + y.City + " " + y.State + " " + y.Zipcode + "\n\n";
//                Console.WriteLine(fullAddress);
//            }

//            string userInput;
//            int inputValue = 0;
//            bool inputIsNumeric;
//            bool exitWhile = false;

//            do
//            {
//                Console.Write("\n\n\nChoose an address: ");
//                userInput = Console.ReadLine().Trim();
//                inputIsNumeric = long.TryParse(userInput, out Int64 result);

//                if (inputIsNumeric)
//                {
//                    inputValue = Convert.ToInt32(userInput);
//                }

//                if (inputIsNumeric && (inputValue > 0) && (inputValue <= addreCount))
//                {
//                    exitWhile = true;
//                    output = userInput;
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

//            Console.WriteLine($"\n\n\nAddress [{output}] accepted.\n\n\n");
//            Thread.Sleep(2000);
//            Console.Clear();

//            return output;

//        } // end of: SelectAddress method 
//        */
//        #endregion






//        /// <summary>
//        /// PRECONDITION: 
//        /// inputEmail is from an existing user with at least one address | 
//        /// SUMMARY: 
//        /// This method returns a list with the addresses of a user. | 
//        /// POSTCONDITION: 
//        ///  n/a |
//        /// </summary>
//        /// <param name="inputEmail"> Email from an existing user. </param>
//        /// <returns></returns>


//        public static List<string> SelectAddress(string inputEmail)
//        {
//            DBContext PBContext = DbInstance.Instance;
//            List<string> outputStrList = new List<string>();

//            // get all the addresses from user inputEmail
//            var addresses = PBContext.UserAddress.Where<UserAddress>(u => u.Email == inputEmail);
//            string line1, line2, space, commaSpace, fullAddress;
//            space = " ";
//            commaSpace = ", ";

//            foreach (var y in addresses)
//            {
//                line1 = y.Address1 + space + y.Address2;
//                line1 = extraTrim.Replace(line1, " ");
//                line2 = y.City + commaSpace + y.State + space + y.Zipcode;
//                fullAddress = line1 + "\n" + line2;
//                outputStrList.Add(fullAddress);
//            }

//            return outputStrList;

//        } // end of: SelectAddress method 

//        static readonly Regex extraTrim = new Regex(@"\s\s+"); // Regular expression that trims extra white spaces inside a string

//    } // end of: Addresses class
//}
