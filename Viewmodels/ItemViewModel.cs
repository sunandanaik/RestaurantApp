using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestaurantApp.Viewmodels
{
    public class ItemViewModel
    {
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public Nullable<decimal> ItemPrice { get; set; }
    }
}