using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class LocationInfo
    {
        private int locaitonId;
        private string name;
        private string address1;
        private string address2;
        private string city;
        private string state;
        private string zipcode;
        private string phone;

        public int LocationId
        {
            get => locaitonId;
            set
            {
                locaitonId = value;
            }

        }

        public string Name
        {
            get => name;
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be empty ");
                }
                name = value;
            }
        }

        public string Address1
        {
            get => address1;
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Address1 cannot be empty ");
                }
                address1 = value;
            }
        }

        public string Address2
        {
            get => address2;
            set
            {
               
                address2 = value;
            }
        }

        public string City
        {
            get => city;
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("City cannot be empty ");
                }
                city = value;
            }
        }

        public string State
        {
            get => state;
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("State cannot be empty ");
                }
                name = state;
            }
        }

        public string Zipcode
        {
            get => zipcode;
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Zipcode cannot be empty ");
                }
                zipcode = value;
            }
        }

        public string Phone
        {
            get => phone;
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Phone cannot be empty ");
                }
                phone = value;
            }
        }

    }
}
