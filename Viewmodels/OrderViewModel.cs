using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestaurantApp.Viewmodels
{
    public class OrderViewModel
    {
        public int OrderId { get; set; }
        public string OrderNumber { get; set; }
        public Nullable<System.DateTime> OrderDate { get; set; }
        public Nullable<int> CustomerId { get; set; }
        public Nullable<int> PaymentTypeId { get; set; }
        public Nullable<decimal> FinalTotal { get; set; }
        public IEnumerable<OrderDetailViewModel> ListOfOrderDetailViewModel { get; set; }
    }
}