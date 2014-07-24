using System;
using Sagua.Global.Common;

namespace Sagua.Jinson.Shopper.Models
{
    public class UiOrder : ObservableObject
    {
        private DateTime mBuyTime;
        private DateTime mPayTime;
        private string mBuyer;
        private string mBuyerAccount;
        private decimal mPrice;
        public long Id
        {
            get;
            set;
        }

        public DateTime BuyTime
        {
            get
            {
                return mBuyTime;
            }
            set
            {
                mBuyTime = value;
                OnPropertyChanged();
            }
        }
        public DateTime PayTime
        {
            get
            {
                return mPayTime;
            }
            set
            {
                mPayTime = value;
                OnPropertyChanged();
            }
        }

        public string Buyer
        {
            get
            {
                return mBuyer;
            }
            set
            {
                mBuyer = value;
                OnPropertyChanged();
            }
        }

        public string BuyerAccount
        {
            get
            {
                return mBuyerAccount;
            }
            set
            {
                mBuyerAccount = value;
                OnPropertyChanged();
            }
        }

        public Decimal Price
        {
            get
            {
                return mPrice;
            }
            set
            {
                mPrice = value;
                OnPropertyChanged();
            }
        }
    }
}