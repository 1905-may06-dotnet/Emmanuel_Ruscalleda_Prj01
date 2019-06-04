using System;
using System.Collections.Generic;
using System.Text;
using Data.DataModel;
using System.Linq;
using Data;
using System.Threading;



namespace Data.Functions
{
    public class ExistingUser
    {

        /// <summary>
        /// PRECONDITION: 
        /// inputEmail is string with email format (i.e., includes '@' and '.')     |   
        /// SUMMARY: 
        /// This method check if inputEmail is on the database, and if inputPassword match with the corresponding password of inputEmail.   | 
        /// POSTCONDITION:
        /// Return outputBoolList[0] = isEmailOnDB, and outputBoolList[1] = isPasswordCorrect |
        /// </summary> 
        /// <param name="inputEmail"> Sign-In email </param>
        /// <param name="inputPassword"> Sig-In password </param>
        /// <returns>
        /// </returns>

        public static List<bool> SignIn(string inputEmail, string inputPassword)
        {

            DBContext PBContext = DbInstance.Instance;
            List<bool> outputBoolList = new List<bool>();
            bool isEmailOnDB;
            bool isPasswordCorrect;

            inputEmail = inputEmail.Trim();
            inputPassword = inputPassword.Trim();

            // check if inputEmail is on database 
            UserName rowUserName = new UserName();
            try
            {
                rowUserName = PBContext.UserName.FirstOrDefault(u => u.Email == inputEmail); 
            }
            catch
            {
                rowUserName = null;
            }

            if (rowUserName != null)
            {
                isEmailOnDB = true;
            }
            else
            {
                isEmailOnDB = false;
            }

            // check if inputPassword match with inputEmail 
            UserAccess rowUserAccess = new UserAccess();
            if (isEmailOnDB == true)
            {
                try
                {
                    rowUserAccess = PBContext.UserAccess.FirstOrDefault(u => u.Email == inputEmail && u.Password == inputPassword); // <--- TO EDIT: Is case insensitve 
                }
                catch
                {
                    rowUserAccess = null;
                }

                if (rowUserAccess != null)
                {
                    isPasswordCorrect = true;
                }
                else
                {
                    isPasswordCorrect = false;
                }
            }
            else
            {
                isPasswordCorrect = false;
            }

            outputBoolList.Add(isEmailOnDB);
            outputBoolList.Add(isPasswordCorrect);
            return outputBoolList;

        } // end of: SignIn method 

    } // end of: ExistingUser class 
}
