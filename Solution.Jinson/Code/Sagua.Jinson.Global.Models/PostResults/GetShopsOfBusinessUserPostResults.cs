using System.Collections.Generic;
using Sagua.Global.Common;
using Sagua.Jinson.Global.Domain;

namespace Sagua.Jinson.Global.Models.PostResults
{
    public class GetShopsOfBusinessUserPostResults : BaseRestResult
    {
        public GetShopsOfBusinessUserPostResults ()
        {
            Shops = new List<Shop>();
        }
        public List<Shop> Shops
        {
            get;
            set;
        } 
        public class Shop
        {
            public long Id
            {
                get;
                set;
            }
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
}