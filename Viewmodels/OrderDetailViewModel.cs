using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestaurantApp.Viewmodels
{
    public class OrderDetailViewModel
    {
        public int OrderDetailId { get; set; }
        public Nullable<decimal> Quantity { get; set; }
        public Nullable<int> ItemId { get; set; }
        public Nullable<decimal> UnitPrice { get; set; }
        public Nullable<decimal> Discount { get; set; }
        public Nullable<decimal> Total { get; set; }
    }
}