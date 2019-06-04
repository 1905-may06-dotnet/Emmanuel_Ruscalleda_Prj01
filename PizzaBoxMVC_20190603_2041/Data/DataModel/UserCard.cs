using System;
using System.Collections.Generic;

namespace Data.DataModel
{
    public partial class UserCard
    {
        public string Email { get; set; }
        public string CardNumber { get; set; }
        public string Cvv { get; set; }
        public string ValidThru { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }

        public virtual UserName EmailNavigation { get; set; }
    }
}
