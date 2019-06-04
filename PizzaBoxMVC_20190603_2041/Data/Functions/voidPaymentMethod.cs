using System;
using System.Collections.Generic;
using System.Text;
using Data;
using Data.DataModel;
using System.Linq;
using System.Threading;

namespace Data.Functions
{
    public class PaymentMethod
    {


        /// <summary>
        /// PRECONDITION: 
        /// inputEmail is from an existing user with at least one credit card | 
        /// SUMMARY: 
        /// This method returns a list with the credit cards of a user. | 
        /// POSTCONDITION: 
        ///  n/a 
        /// </summary>
        /// <param name="inputEmail"> Email from an existing user. </param>
        /// <returns></returns>
        public static List<string> SelectCard(string inputEmail)
        {
            DBContext PBContext = DbInstance.Instance;
            List<string> outputStrList = new List<string>();

            // get all the cards from user inputEmail
            var allCards = PBContext.UserCard.Where<UserCard>(u => u.Email == inputEmail);
            foreach (var card in allCards)
            {
                outputStrList.Add(card.CardNumber);
            }

            return outputStrList;

        } // end of: SelectCard method 

    } // end of: PaymentMethod class
}
