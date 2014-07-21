using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sagua.Jinson.Shopper.Common;
using Sagua.Jinson.Shopper.Domain;

namespace Sagua.Jinson.Shopper.Models
{
    public class UiShop : ObservableObject
    {
        private string mTitle;
        private string mUrl;
        private ShopType mShopType;
        public string Title
        {
            get
            {
                return mTitle;
            }
            set
            {
                mTitle = value;
                OnPropertyChanged();
            }
        }

        public string Url
        {
            get
            {
                return mUrl;
            }
            set
            {
                mUrl = value;
                OnPropertyChanged();
            }
        }

        public ShopType ShopType
        {
            get
            {
                return mShopType;
            }
            set
            {
                mShopType = value;
                OnPropertyChanged();
            }
        }
    }
}
