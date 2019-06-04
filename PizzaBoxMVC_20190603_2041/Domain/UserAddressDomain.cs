using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class UserAddressDomain
    {
       
        private string emailValue;
        private string addressCountValue;
        private string address1Value;
        private string address2Value;
        private string cityValue;
        private string stateValue;
        private string zipcodeValue;
        private string addressDetailsValue;

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
        public string AddressCount
        {
            get => addressCountValue;
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("AddressCount cannot be empty ");
                }
                addressCountValue = value;
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
        public string AddressDetails
        {
            get => addressDetailsValue;
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    addressDetailsValue = ""; 
                }
                addressDetailsValue = value;
            }
        }

    }
}
