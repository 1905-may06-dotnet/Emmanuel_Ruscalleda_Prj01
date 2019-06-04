using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class UserCardDomain
    {

        //Email
        //CardNumber      CVV         Valid Thru
        //First Name      Last Name
        //Address 1       Address 2   City        State   Zipcode   

        private string emailValue;
        private string cardNumberValue;
        private string cvvValue;
        private string validThruValue;
        private string firstNameValue;
        private string lastNameValue;
        private string address1Value;
        private string address2Value;
        private string cityValue;
        private string stateValue;
        private string zipcodeValue;

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
        public string CardNumber
        {
            get => cardNumberValue;
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("CardNumber cannot be empty");
                }
                cardNumberValue = value;
            }
        }
        public string CVV
        {
            get => cvvValue;
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("CVV cannot be empty");
                }
                cvvValue = value;
            }
        }
        public string ValidThru
        {
            get => validThruValue;
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("ValidThru cannot be empty");
                }
                validThruValue = value;
            }
        }
        public string FirstName
        {
            get => firstNameValue;
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("First name cannot be empty ");
                }
                firstNameValue = value;
            }
        }
        public string LastName
        {
            get => lastNameValue;
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Last name cannot be empty ");
                }
                lastNameValue = value;
            }
        }
        public string Address1
        {
            get => address1Value;
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Address1 cannot be empty ");
                }
                address1Value = value;
            }
        }
        public string Address2
        {
            get => address2Value;
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    address2Value = "";
                }
                address2Value = value;
            }
        }
        public string City
        {
            get => cityValue;
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("City cannot be empty ");
                }
                cityValue = value;
            }
        }
        public string State
        {
            get => stateValue;
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("State cannot be empty ");
                }
                stateValue = value;
            }
        }
        public string Zipcode
        {
            get => zipcodeValue;
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Zipcode cannot be empty ");
                }
                zipcodeValue = value;
            }
        }

    }
}
