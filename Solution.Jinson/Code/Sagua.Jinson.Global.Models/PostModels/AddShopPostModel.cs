using System;
using System.Collections.Generic;
using System.Text;
using Sagua.Global.Common;
using Sagua.Jinson.Global.Domain; 

namespace Sagua.Jinson.Global.Models.PostModels
{
    public class AddShopPostModel : BaseRestPostModel
    {

        public string Title
        {
            get;
            set;
        }

        public string Url
        {
            get;
            set;
        }
        public ShopType ShopType
        {
            get;
            set;
        }
    }
}
