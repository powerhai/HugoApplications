using System;
using System.Collections.Generic;
using System.Text;
using Sagua.Global.Common;
using Sagua.Jinson.Global.Domain; 

namespace Sagua.Jinson.Global.Models.PostModels
{
    public class GetUserInfoPostModel : BaseRestPostModel
    {
        public string UserName
        {
            get;
            set;
        }
        
    }
}
