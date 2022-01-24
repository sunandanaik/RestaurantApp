using RestaurantApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RestaurantApp.Repositories
{
    public class PaymentTypeRepository
    {
        private RestaurantDBEntities objRestaurantDBEntities;
        public PaymentTypeRepository()
        {
            objRestaurantDBEntities = new RestaurantDBEntities();
        }
        public IEnumerable<SelectListItem> GetAllPayments()
        {
            var objSelectListItems = new List<SelectListItem>();
            objSelectListItems = (from pt in objRestaurantDBEntities.tbl_paymenttype
                                  select new SelectListItem()
                                  {
                                      Text=pt.PaymentTypeName,
                                      Value=pt.PaymentTypeId.ToString(),
                                      Selected=true
                                  }).ToList();
            return objSelectListItems;
        }
    }
}