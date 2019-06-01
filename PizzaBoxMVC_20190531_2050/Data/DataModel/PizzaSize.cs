using System;
using System.Collections.Generic;

namespace Data.DataModel
{
    public partial class PizzaSize
    {
        public PizzaSize()
        {
            OrderItem = new HashSet<OrderItem>();
        }

        public string SizeId { get; set; }
        public float SalesPrice { get; set; }
        public float ScalingFactor { get; set; }
        public float Inches { get; set; }

        public virtual ICollection<OrderItem> OrderItem { get; set; }
    }
}
