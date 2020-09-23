using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RenderPartialViewWithModel.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        public string Customer { get; set; }
        public string OrderDate { get; set; }
        public string ShipCity { get; set; }
        public IEnumerable<OrderLineItem> items { get; set; }
    }
}