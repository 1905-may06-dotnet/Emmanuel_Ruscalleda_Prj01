using System;
using System.Collections.Generic;

namespace Data.DataModel
{
    public partial class OrderSummary
    {
        public OrderSummary()
        {
            OrderItem = new HashSet<OrderItem>();
        }

        public int OrderId { get; set; }
        public string Email { get; set; }
        public int LocationId { get; set; }
        public string DeliveryMode { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string CardNumber { get; set; }

        public virtual UserName EmailNavigation { get; set; }
        public virtual LocationInfo Location { get; set; }
        public virtual OrderAddress OrderAddress { get; set; }
        public virtual ICollection<OrderItem> OrderItem { get; set; }
    }
}
