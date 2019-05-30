using System;
using System.Collections.Generic;

namespace Data.DataModel
{
    public partial class PizzaCrust
    {
        public PizzaCrust()
        {
            OrderItem = new HashSet<OrderItem>();
        }

        public string CrustId { get; set; }
        public float SalesPrice { get; set; }

        public virtual ICollection<OrderItem> OrderItem { get; set; }
    }
}
