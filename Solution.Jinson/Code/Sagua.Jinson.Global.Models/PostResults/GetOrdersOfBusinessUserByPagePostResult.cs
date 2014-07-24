using System;
using System.Collections.Generic;
using System.Text;
using Sagua.Global.Common;

namespace Sagua.Jinson.Global.Models.PostResults
{
    public class GetOrdersOfBusinessUserByPagePostResult : BaseRestResult
    {
        public bool IsOver
        {
            get;
            set;
        }
        public GetOrdersOfBusinessUserByPagePostResult ()
        {
            Orders = new List<Order>();
        }
        public List<Order> Orders
        {
            get;
            set;
        }
        public class Order
        { 
            public long OrderId
            {
                get;
                set;
            }

            public DateTime BuyTime
            {
                get;
                set;
            }
            public DateTime PayTime
            {
                get;
                set;
            }

            public string Buyer
            {
                get;
                set;
            }

            public string BuyerAccount
            {
                get;
                set;
            }

            public Decimal Price
            {
                get;
                set;
            }
        }
    }
}
