using System;
using System.Collections.Generic;

namespace Data.DataModel
{
    public partial class OrderItem
    {
        public OrderItem()
        {
            OrderTopping = new HashSet<OrderTopping>();
        }

        public int OrderId { get; set; }
        public int ItemCount { get; set; }
        public string SizeId { get; set; }
        public float SizePrice { get; set; }
        public string CrustId { get; set; }
        public float CrustPrice { get; set; }
        public int Quantity { get; set; }

        public virtual PizzaCrust Crust { get; set; }
        public virtual OrderSummary Order { get; set; }
        public virtual PizzaSize Size { get; set; }
        public virtual ICollection<OrderTopping> OrderTopping { get; set; }
    }
}
