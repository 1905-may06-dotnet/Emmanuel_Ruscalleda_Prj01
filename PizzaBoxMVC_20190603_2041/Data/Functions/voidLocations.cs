using System;
using System.Collections.Generic;
using System.Text;
using Data;
using Data.DataModel;
using System.Linq;
using System.Text.RegularExpressions;

using System.Threading;



namespace Data.Functions
{
    public class Locations
    {
        /// <summary>
        /// PRECONDITION: 
        /// n/a | 
        /// SUMMARY: 
        /// This method returns a list with the address of all locations. | 
        /// POSTCONDITION: 
        ///  n/a |
        /// </summary>
        /// <returns></returns>

        public static List<string> AllAddresses()
        {
            DBContext PBContext = DbInstance.Instance;
            List<string> outputStrList = new List<string>();

            // get all locations 
            var allLocations = PBContext.LocationInfo;
            string name, line1, line2, space, commaSpace, fullAddress;
            space = " ";
            commaSpace = ", ";

            foreach (var y in allLocations)
            {
                name = y.Name;
                line1 = y.Address1 + space + y.Address2;
                line1 = extraTrim.Replace(line1, " ");
                line2 = y.City + commaSpace + y.State + space + y.Zipcode;
                fullAddress = name + "\n" + line1 + "\n" + line2;
                outputStrList.Add(fullAddress);
            }

            return outputStrList;

        } // end of: AllAddresses method 

        static readonly Regex extraTrim = new Regex(@"\s\s+"); // Regular expression that trims extra white spaces inside a string

    } // end of: Locations class
}
