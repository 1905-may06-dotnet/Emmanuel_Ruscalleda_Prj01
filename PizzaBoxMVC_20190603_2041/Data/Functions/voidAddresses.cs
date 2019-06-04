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
    public class Addresses
    {

        /// <summary>
        /// PRECONDITION: 
        /// inputEmail is from an existing user with at least one address | 
        /// SUMMARY: 
        /// This method returns a list with the addresses of a user. | 
        /// POSTCONDITION: 
        ///  n/a |
        /// </summary>
        /// <param name="inputEmail"> Email from an existing user. </param>
        /// <returns></returns>


        public static List<string> SelectAddress(string inputEmail)
        {
            DBContext PBContext = DbInstance.Instance;
            List<string> outputStrList = new List<string>();

            // get all the addresses from user inputEmail
            var addresses = PBContext.UserAddress.Where<UserAddress>(u => u.Email == inputEmail);
            string line1, line2, space, commaSpace, fullAddress;
            space = " ";
            commaSpace = ", ";

            foreach (var y in addresses)
            {
                line1 = y.Address1 + space + y.Address2;
                line1 = extraTrim.Replace(line1, " ");
                line2 = y.City + commaSpace + y.State + space + y.Zipcode;
                fullAddress = line1 + "\n" + line2;
                outputStrList.Add(fullAddress);
            }

            return outputStrList;

        } // end of: SelectAddress method 

        static readonly Regex extraTrim = new Regex(@"\s\s+"); // Regular expression that trims extra white spaces inside a string

    } // end of: Addresses class
}
