using System;
using System.Collections.Generic;

namespace Data.DataModel
{
    public partial class OrderTopping
    {
        public int OrderId { get; set; }
        public int ItemCount { get; set; }
        public int ToppingCount { get; set; }
        public string ToppingId { get; set; }
        public float ToppingPrice { get; set; }

        public virtual OrderItem OrderItem { get; set; }
        public virtual PizzaTopping Topping { get; set; }
    }
}
