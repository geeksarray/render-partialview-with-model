using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RenderPartialViewWithModel.Models
{
    public class OrderLineItem
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int Qty { get; set; }
        public string Price { get; set; }
        public string Discount { get; set; }
    }
}