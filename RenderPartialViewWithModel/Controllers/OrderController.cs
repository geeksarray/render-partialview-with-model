using RenderPartialViewWithModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RenderPartialViewWithModel.Controllers
{
    public class OrderController : Controller
    {
        //
        // GET: /Order/

        public ActionResult Index()
        {
            List<OrderLineItem> orderDetails = new List<OrderLineItem> {                 
                    new OrderLineItem () {  ProductID = 1, ProductName = "Tea", Qty=10, Price= "10.50", Discount="0.0" },
                    new OrderLineItem () {  ProductID = 2, ProductName = "Tofu", Qty=2, Price= "7.00", Discount="0.50" },
                    new OrderLineItem () {  ProductID = 3, ProductName = "Aniseed Syrup", Qty=4, Price= "15.00", Discount="0.0" },
                    new OrderLineItem () {  ProductID = 4, ProductName = "Mango", Qty=1, Price= "25.00", Discount="1.0" },
                    new OrderLineItem () {  ProductID = 5, ProductName = "Honey bottle", Qty=1, Price= "18.00", Discount="1.0" },
            };


            Order order = new Order();
            order.OrderID = 10269;
            order.Customer = "WHITC";
            order.OrderDate = new DateTime(2015, 7, 4).ToShortDateString();
            order.ShipCity = "Seattle";
            order.items = orderDetails;
            return View(order);
        }


        public ActionResult GetOrder()
        {
            Order order = new Order();
            order.OrderID = 10269;
            order.Customer = "WHITC";
            order.OrderDate = new DateTime(2015, 7, 4).ToShortDateString();
            order.ShipCity = "Seattle";            
            return View(order);
        }

        [ChildActionOnly]
        public PartialViewResult GetOrderLineItems(int orderId)
        {
            //get orders as per orderid... here for simplicity I am returning hardcoded OrderLineItems

            IEnumerable<OrderLineItem> orderItems = new List<OrderLineItem> {                 
                    new OrderLineItem () {  ProductID = 1, ProductName = "Tea", Qty=10, Price= "10.50", Discount="0.0" },
                    new OrderLineItem () {  ProductID = 2, ProductName = "Tofu", Qty=2, Price= "7.00", Discount="0.50" },
                    new OrderLineItem () {  ProductID = 3, ProductName = "Aniseed Syrup", Qty=4, Price= "15.00", Discount="0.0" },
                    new OrderLineItem () {  ProductID = 4, ProductName = "Mango", Qty=1, Price= "25.00", Discount="1.0" },
                    new OrderLineItem () {  ProductID = 5, ProductName = "Honey bottle", Qty=1, Price= "18.00", Discount="1.0" },
            };
            return PartialView("_orderDetailsWithModel", orderItems);
        }

    }
}
