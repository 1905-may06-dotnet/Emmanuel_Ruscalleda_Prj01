using System;
using System.Collections.Generic;

namespace Data.DataModel
{
    public partial class UserAddress
    {
        public string Email { get; set; }
        public string AddressCount { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }
        public string AddressDetails { get; set; }

        public virtual UserName EmailNavigation { get; set; }
    }
}
