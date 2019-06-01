using System;
using System.Collections.Generic;

namespace Data.DataModel
{
    public partial class UserName
    {
        public UserName()
        {
            OrderSummary = new HashSet<OrderSummary>();
            UserAddress = new HashSet<UserAddress>();
            UserCard = new HashSet<UserCard>();
        }

        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }

        public virtual UserAccess UserAccess { get; set; }
        public virtual ICollection<OrderSummary> OrderSummary { get; set; }
        public virtual ICollection<UserAddress> UserAddress { get; set; }
        public virtual ICollection<UserCard> UserCard { get; set; }
    }
}
