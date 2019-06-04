using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Text;

namespace Domain
{
    public class UserNameDomain
    {

        private string email;
        private string firstName;
        private string lastName;
        private string phone;


        public string Email
        {
            get => email;
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Email cannot be empty ");
                }
                email = value;
            }
        }


        public string FirstName
        {
            get => firstName;
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("First name cannot be empty ");
                }
                firstName = value;
            }
        }

        public string LastName
        {
            get => lastName;
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Last name cannot be empty ");
                }
                lastName = value;
            }
        }


        public string Phone
        {
            get => phone;
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    phone = "";
                }
                phone = value;
            }
        }


    } // end of: NewUser class 
}
