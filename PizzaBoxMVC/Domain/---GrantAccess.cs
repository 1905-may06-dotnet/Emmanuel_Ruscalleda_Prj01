// Domain or Business layer 
// classes and logics will be here 
using System;
using System.Collections.Generic;
using Data.DataModel;
using Data;
using Domain;
using System.Linq;
using System.Diagnostics;
using System.Threading;





namespace Domain
{
    public class GrantAccess
    {

        /*
        public static string Welcome()
        {

            DBContext PBContext = DbInstance.Instance;
            List<string> results = new List<string>();
            string output;
            bool loginsuccessful = true;
            do
            {
                Console.WriteLine("Welcome to PizzaBox!");
                Console.WriteLine("[1] SIGN IN \n[2] new user \n[99] close application");
                Console.Write("Choose between the above options: \t");
                string userInput = Console.ReadLine().Trim();

                // existing user - sign in 
                if ("1" == userInput)
                {
                    //results = ExistingUser.SignIn();
                }
                // new user - sign up 
                else if ("2" == userInput)
                {
                    results = NewUser.SignUp();
                }
                else if ("99" == userInput)
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine($"\n\n\nInput not supported. Try again.\n\n\n");
                    loginsuccessful = false;
                }
            } while (false == loginsuccessful);

            Console.Clear();
            string userEmail = results[0];
            string userFirstName = results[1];
            Console.WriteLine($"Welcome {userFirstName}! \nUsername: {userEmail}\n");
            output = userEmail;

            return userEmail;

        } // end of: Welcome method 
        */
    } // end of: GrantAccess class 
}