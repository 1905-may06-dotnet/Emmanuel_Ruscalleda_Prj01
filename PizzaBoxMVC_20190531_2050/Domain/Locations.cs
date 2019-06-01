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
//    public class Locations
//    {
//        #region P0_SelectLocation 
//        /*
//        public static int SelectLocation()
//        {
//            DBContext PBContext = DbInstance.Instance;
//            var allLocations = PBContext.LocationInfo;
//            int maxID = PBContext.LocationInfo.Max<LocationInfo>(p => p.LocationId);
//            string fullAddress;
//            int output = 0;

//            Console.WriteLine("The following locations are available: \n\n");

//            foreach (var y in allLocations)
//            {
//                fullAddress = "[" + y.LocationId + "]" + "\t" + y.Name + "\n\t" + y.Address1 + " " + y.Address2 + "\n\t" + y.City + " " + y.State + " " + y.Zipcode + "\n\t" + y.Phone + "\n\n";
//                Console.WriteLine(fullAddress);
//            }

//            string userInput;
//            int inputValue = 0;
//            bool inputIsNumeric;
//            bool exitWhile = false;

//            do
//            {
//                Console.Write("\n\n\nChoose a location: ");
//                userInput = Console.ReadLine().Trim();
//                inputIsNumeric = long.TryParse(userInput, out Int64 result);

//                if (inputIsNumeric)
//                {
//                    inputValue = Convert.ToInt32(userInput);
//                }


//                if (inputIsNumeric && (inputValue > 0) && (inputValue <= maxID))
//                {
//                    exitWhile = true;
//                    output = inputValue;
//                }
//                else if ("99" == userInput)
//                {
//                    Environment.Exit(0);
//                }
//                else
//                {
//                    Console.WriteLine("Input not supported. Try again. To exit application [99]");
//                    exitWhile = false;
//                }

//            } while (exitWhile == false);


//            // NOTE TO-EDIT: add a better confirmation message: clear screen and show selection 
//            Console.WriteLine($"\n\n\nLocation [{inputValue}] accepted.\n\n\n");
//            Thread.Sleep(2000);
//            Console.Clear();

//            return output;

//        } // end of: SelectLocation method 

//        */

//        #endregion

//        /// <summary>
//        /// PRECONDITION: 
//        /// n/a | 
//        /// SUMMARY: 
//        /// This method returns a list with the address of all locations. | 
//        /// POSTCONDITION: 
//        ///  n/a |
//        /// </summary>
//        /// <returns></returns>

//        public static List<string> AllAddresses()
//        {
//            DBContext PBContext = DbInstance.Instance;
//            List<string> outputStrList = new List<string>();

//            // get all locations 
//            var allLocations = PBContext.LocationInfo;
//            string name, line1, line2, space, commaSpace, fullAddress;
//            space = " ";
//            commaSpace = ", ";

//            foreach (var y in allLocations)
//            {
//                name = y.Name;
//                line1 = y.Address1 + space + y.Address2;
//                line1 = extraTrim.Replace(line1, " ");
//                line2 = y.City + commaSpace + y.State + space + y.Zipcode;
//                fullAddress = name + "\n" + line1 + "\n" + line2;
//                outputStrList.Add(fullAddress);
//            }

//            return outputStrList;

//        } // end of: AllAddresses method 

//        static readonly Regex extraTrim = new Regex(@"\s\s+"); // Regular expression that trims extra white spaces inside a string

//    } // end of: Locations class
//}
