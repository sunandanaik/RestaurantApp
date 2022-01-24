using RestaurantApp.Models;
using RestaurantApp.Viewmodels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestaurantApp.Repositories
{
    public class OrderRepository
    {
        private RestaurantDBEntities objRestaurantDBEntities;
        public OrderRepository()
        {
            objRestaurantDBEntities = new RestaurantDBEntities();
        }

        public bool AddOrder(OrderViewModel ovm)
        {
            tbl_order obj = new tbl_order();
            obj.CustomerId = ovm.CustomerId;
            obj.FinalTotal = ovm.FinalTotal;
            obj.OrderDate = DateTime.Now;
            obj.OrderNumber = String.Format("{0:ddmmyyyyyhhmmss}", DateTime.Now);
            obj.PaymentTypeId = ovm.PaymentTypeId;
            objRestaurantDBEntities.tbl_order.Add(obj);
            objRestaurantDBEntities.SaveChanges();

            int orderid = obj.OrderId;
            foreach(var item in ovm.ListOfOrderDetailViewModel)
            {
                tbl_orderdetail od = new tbl_orderdetail();
                od.OrderId = orderid;
                od.Discount = item.Discount;
                od.ItemId = item.ItemId;
                od.Total = item.Total;
                od.UnitPrice = item.UnitPrice;
                od.Quantity = item.Quantity;
                objRestaurantDBEntities.tbl_orderdetail.Add(od);
                objRestaurantDBEntities.SaveChanges();

                tbl_transaction tr = new tbl_transaction();
                tr.ItemId = item.ItemId;
                tr.Quantity = (-1)*item.Quantity;
                tr.TransactionDate = DateTime.Now;
                tr.TypeId = 4;
                objRestaurantDBEntities.tbl_transaction.Add(tr);
                objRestaurantDBEntities.SaveChanges();

            }
            return true;

        }
    }
}