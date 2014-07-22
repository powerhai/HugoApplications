using System;
using System.Collections.Generic;
using System.Text;
using Sagua.Global.Common;
using Sagua.Jinson.Global.Domain; 

namespace Sagua.Jinson.Global.Models.PostModels
{
    public class DeleteShopPostModel : BaseRestPostModel
    {
        public long ShopId
        {
            get;
            set;
        }
        
    }
}
