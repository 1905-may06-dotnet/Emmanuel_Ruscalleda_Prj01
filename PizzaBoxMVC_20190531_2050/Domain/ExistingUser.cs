//using System;
//using System.Collections.Generic;
//using System.Text;
//using Data.DataModel;
//using System.Linq;
//using Data;
//using System.Threading;



//namespace Domain
//{
//    public class ExistingUser
//    {

//        #region P0_SingIn
//        /*
//        public static List<string> SignIn()
//        {
//            DBContext PBContext = DbInstance.Instance;
//            List<string> output = new List<string>();
//            string emailInput = "";
//            string passwordInput = "";
//            bool exitWhile;

//            // ask for email 
//            do
//            {
//                exitWhile = true;
//                Console.Write("Email: \t");
//                emailInput = Console.ReadLine().Trim();

//                // check if input email is on database 
//                try
//                {
//                    var x = PBContext.UserName.Where<UserName>(u => u.Email == emailInput).First<UserName>();
//                    output.Add(x.Email);
//                    output.Add(x.FirstName);
//                }
//                catch
//                {
//                    if (emailInput.Equals("99"))
//                    {
//                        Environment.Exit(0);
//                    }
//                    Console.WriteLine("\n\n\nUser not found. Try again. \nTo exit enter [99]. \n\n\n");
//                    exitWhile = false;
//                }
//            } while (exitWhile == false);


//            // ask for password 
//            int passwordAttempts = 0;
//            do
//            {
//                exitWhile = true;
//                Console.Write("PizzaBox Password: \t");
//                passwordInput = Console.ReadLine().Trim();
//                // check if password match email  
//                try
//                {
//                    PBContext.UserAccess.Where<UserAccess>(u => u.Email == emailInput && u.Password == passwordInput).First<UserAccess>();
//                }
//                catch
//                {
//                    if (passwordInput.Equals("99"))
//                    {
//                        Environment.Exit(0);
//                    }
//                    Console.WriteLine("\n\n\nIncorrect password. Try again. \nTo exit enter [99]. \n\n\n");
//                    passwordAttempts = passwordAttempts + 1;
//                    if (passwordAttempts >= 3)
//                    {
//                        Console.WriteLine("Exceeded the allowed attempts.");
//                        Environment.Exit(0);
//                    }
//                    exitWhile = false;
//                }
//            } while (exitWhile == false);

//            Console.WriteLine("\n\n\nSign-In successful! \n\n\n");
//            Thread.Sleep(2000);


//            return output;

//        } // end of: SignIn method 
//        */
//        #endregion

//        /// <summary>
//        /// PRECONDITION: 
//        /// inputEmail is string with email format (i.e., includes '@' and '.')     |   
//        /// SUMMARY: 
//        /// This method check if inputEmail is on the database, and if inputPassword match with the corresponding password of inputEmail.   | 
//        /// POSTCONDITION:
//        /// Return outputBoolList[0] = isEmailOnDB, and outputBoolList[1] = isPasswordCorrect |
//        /// </summary> 
//        /// <param name="inputEmail"> Sign-In email </param>
//        /// <param name="inputPassword"> Sig-In password </param>
//        /// <returns>
//        /// </returns>

//        public static List<bool> SignIn(string inputEmail, string inputPassword)
//        {

//            DBContext PBContext = DbInstance.Instance;
//            List<bool> outputBoolList = new List<bool>();
//            bool isEmailOnDB;
//            bool isPasswordCorrect;

//            inputEmail = inputEmail.Trim();
//            inputPassword = inputPassword.Trim();

//            // check if inputEmail is on database 
//            UserName rowUserName = new UserName();
//            try
//            {
//                rowUserName = PBContext.UserName.FirstOrDefault(u => u.Email == inputEmail);
//            }
//            catch
//            {
//                rowUserName = null;
//            }

//            if (rowUserName != null)
//            {
//                isEmailOnDB = true;
//            }
//            else
//            {
//                isEmailOnDB = false;
//            }

//            // check if inputPassword match with inputEmail 
//            UserAccess rowUserAccess = new UserAccess();
//            if (isEmailOnDB == true)
//            {
//                try
//                {
//                    rowUserAccess = PBContext.UserAccess.FirstOrDefault(u => u.Email == inputEmail && u.Password == inputPassword);
//                }
//                catch
//                {
//                    rowUserAccess = null;
//                }

//                if (rowUserAccess != null)
//                {
//                    isPasswordCorrect = true;
//                }
//                else
//                {
//                    isPasswordCorrect = false;
//                }
//            }
//            else
//            {
//                isPasswordCorrect = false;
//            }

//            outputBoolList.Add(isEmailOnDB);
//            outputBoolList.Add(isPasswordCorrect);
//            return outputBoolList; 
                                 
//        } // end of: SignIn method 

//    } // end of: ExistingUser class 
//}
