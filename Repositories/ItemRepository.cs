using RestaurantApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RestaurantApp.Repositories
{
    public class ItemRepository
    {
        private RestaurantDBEntities objRestaurantDBEntities;
        public ItemRepository()
        {
            objRestaurantDBEntities = new RestaurantDBEntities();
        }
        public IEnumerable<SelectListItem> GetAllItems()
        {
            var objSelectListItems = new List<SelectListItem>();
            objSelectListItems = (from it in objRestaurantDBEntities.tbl_item
                                  select new SelectListItem()
                                  {
                                      Text = it.ItemName,
                                      Value = it.ItemId.ToString(),
                                      Selected = false
                                  }).ToList();
            return objSelectListItems;
        }
    }
}