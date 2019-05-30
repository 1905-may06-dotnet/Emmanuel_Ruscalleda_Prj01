using System;
using System.Collections.Generic;
using Data.DataModel;
using Data;
using System.Linq;
using System.Threading;
using System.Text;

namespace Domain
{
    public class NewUser
    {
        /*
        public static List<string> SignUp()
        {
            // NOTE TO-EDIT: check all input data is valid format and apply restrictions  

            DBContext PBContext = DbInstance.Instance;
            List<string> output = new List<string>();
            UserName newUserName = new UserName();
            UserAccess newUserAccess = new UserAccess();
            UserAddress newUserAddress = new UserAddress();
            UserCard newUserCard = new UserCard();


            string emailInput1 = "";
            string emailInput2 = "";
            bool exitWhile;

            // ask for new email 
            do
            {
                exitWhile = false;
                Console.Write("Email: \t");
                emailInput1 = Console.ReadLine();
                emailInput1 = emailInput1.Trim();
                emailInput2 = "";
                if (emailInput1.Equals("99") == false)
                {
                    Console.Write("Re-enter Email: \t");
                    emailInput2 = Console.ReadLine();
                    emailInput2 = emailInput2.Trim();
                }

                // check if email is not already in database 
                if (emailInput1.Equals(emailInput2) && emailInput1.Equals("") == false)
                {
                    exitWhile = false;
                    try
                    {
                        PBContext.UserName.Where<UserName>(u => u.Email == emailInput1).First<UserName>();
                    }
                    catch
                    {
                        // if error is catch then the input email is not in database 
                        exitWhile = true;
                        newUserName.Email = emailInput1;
                        newUserAccess.Email = emailInput1;
                        newUserAddress.Email = emailInput1;
                        newUserCard.Email = emailInput1;
                    }
                    finally
                    {
                        if (exitWhile == false)
                        {
                            Console.WriteLine("\n\n\nEmail entry is already in use. Try again. \nTo exit enter [99]. \n\n\n");
                        }
                    }
                }
                else if (emailInput1.Equals("99"))
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("\n\n\nEmails entry does not match or are empty. Try again. \nTo exit enter [99]. \n\n\n");
                    exitWhile = false;
                }
            } while (exitWhile == false);

            string passwordInput1 = "";
            string passwordInput2 = "";

            // ask for password
            do
            {
                exitWhile = false;
                Console.Write("Password: \t");
                passwordInput1 = Console.ReadLine();
                passwordInput1 = passwordInput1.Trim();
                passwordInput2 = "";
                if (passwordInput1.Equals("99") == false)
                {
                    Console.Write("Re-enter Password: \t");
                    passwordInput2 = Console.ReadLine();
                    passwordInput2 = passwordInput2.Trim();
                }

                // check passwords to be equal 
                if (passwordInput1.Equals(passwordInput2) && passwordInput1.Equals("") == false)
                {
                    newUserAccess.Password = passwordInput1;
                    exitWhile = true;
                }
                else if (passwordInput1.Equals("99"))
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("\n\n\nPasswords entry does not match or are empty. Try again. \nTo exit enter [99]. \n\n\n");
                    exitWhile = false;
                }
            } while (exitWhile == false);

            Console.Clear();

            bool needToEdit = false;
            do
            {

                Console.WriteLine("\n\nUser information.");

                #region NewUserInputs 

                Console.Write("First Name: \t");
                newUserName.FirstName = Console.ReadLine().Trim();

                Console.Write("Last Name: \t");
                newUserName.LastName = Console.ReadLine().Trim();

                Console.WriteLine("\n\nAt least one phone number is required.");

                Console.Write("\tPhone [xxx-xxx-xxxx]: \t");
                newUserName.Phone = Console.ReadLine().Trim();

                Console.WriteLine("\n\nAt least one full address is required.");
                newUserAddress.AddressCount = "1"; // new user -> first address 

                Console.Write("\tAddress 1: \t");
                newUserAddress.Address1 = Console.ReadLine().Trim();

                Console.Write("\tAddress 2 [optional]: \t");
                newUserAddress.Address2 = Console.ReadLine().Trim();

                Console.Write("\tCity: \t");
                newUserAddress.City = Console.ReadLine().Trim();

                Console.Write("\tState: \t");
                newUserAddress.State = Console.ReadLine().Trim();

                Console.Write("\tZip-code: \t");
                newUserAddress.Zipcode = Console.ReadLine().Trim();

                Console.Write("\tExtra details [optional]: \t");
                newUserAddress.AddressDetails = Console.ReadLine().Trim();

                Console.WriteLine("\n\nAt least one credit card is required.");

                Console.Write("\tCredit Card Number: \t");
                newUserCard.CardNumber = Console.ReadLine().Trim();

                Console.Write("\tCVV: \t");
                newUserCard.Cvv = Console.ReadLine().Trim();

                Console.Write("\tValid Thru [mm-yyyy]: \t");
                newUserCard.ValidThru = Console.ReadLine().Trim();

                Console.WriteLine("\n\nProvide the following information of the cardholder.");
                Console.WriteLine("\nAs appear on card: ");

                Console.Write("\tFirst Name: \t");
                newUserCard.FirstName = Console.ReadLine().Trim();

                Console.Write("\tLast Name: \t");
                newUserCard.LastName = Console.ReadLine().Trim();

                Console.WriteLine("\nBilling Address: ");

                Console.Write("\tAddress 1: \t");
                newUserCard.Address1 = Console.ReadLine().Trim();

                Console.Write("\tAddress 2 [optional]: \t");
                newUserCard.Address2 = Console.ReadLine().Trim();

                Console.Write("\tCity: \t");
                newUserCard.City = Console.ReadLine().Trim();

                Console.Write("\tState: \t");
                newUserCard.State = Console.ReadLine().Trim();

                Console.Write("\tZip-code: \t");
                newUserCard.Zipcode = Console.ReadLine().Trim();
                #endregion


                Console.WriteLine("\n\nConfirm that the above info is correct.");
                Console.WriteLine("[1] Correct \n[2] Edit \n[99] Exit application");
                // NOTE TO-EDIT: add a better confirmation message: clear screen and show all the data 
                string userInput;

                do
                {
                    exitWhile = false;
                    Console.Write("Choose an option: \t");
                    userInput = Console.ReadLine().Trim();

                    if ("1" == userInput)
                    {
                        exitWhile = true;
                        needToEdit = false;

                    }
                    else if ("2" == userInput)
                    {
                        exitWhile = true;
                        needToEdit = true;
                        Console.Clear();
                    }
                    else if ("99" == userInput)
                    {
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine($"\n\n\nInput not supported. Try again.\n\n\n");
                        exitWhile = false;
                    }
                } while (exitWhile == false);

            } while (needToEdit == true);

            // add values to output list and to database 
            output.Add(newUserName.Email);
            output.Add(newUserName.FirstName);
            PBContext.UserName.Add(newUserName);
            PBContext.UserAccess.Add(newUserAccess);
            PBContext.UserAddress.Add(newUserAddress);
            PBContext.UserCard.Add(newUserCard);
            PBContext.SaveChanges();

            Console.WriteLine("\n\n\nSign-Up successful! \n\n\n");
            Thread.Sleep(2000);

            return output;

        } // end of : SignUp method 

    */


    } // end of: NewUser class 
}
