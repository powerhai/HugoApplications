using System;
using System.ComponentModel.DataAnnotations;

namespace Sagua.Jinson.Server.DB.Models
{
    public class Order
    {
        [Key]
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