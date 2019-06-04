using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class UserAccessDomain
    {
        private string emailValue;
        private string passwordValue;

        public string Email
        {
            get => emailValue;
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Email cannot be empty ");
                }
                emailValue = value;
            }
        }

        public string Password
        {
            get => passwordValue;
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Password cannot be empty ");
                }
                passwordValue = value;
            }
        }
    }
}
