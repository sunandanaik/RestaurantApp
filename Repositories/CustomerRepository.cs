using RestaurantApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RestaurantApp.Repositories
{
    public class CustomerRepository
    {
        private RestaurantDBEntities objRestaurantDBEntities;
        public CustomerRepository()
        {
            objRestaurantDBEntities = new RestaurantDBEntities();
        }
        public IEnumerable<SelectListItem> GetAllCustomers()
        {
            var objSelectListItems = new List<SelectListItem>();
            objSelectListItems = (from c in objRestaurantDBEntities.tbl_customer
                                  select new SelectListItem()
                                  {
                                      Text = c.CustomerName,
                                      Value = c.CustomerId.ToString(),
                                      Selected = true
                                  }).ToList();
            return objSelectListItems;
        }
    }
}