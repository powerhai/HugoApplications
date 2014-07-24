using System;
using System.Collections.Generic;
using System.Text;
using Sagua.Global.Common;
using Sagua.Jinson.Global.Domain; 

namespace Sagua.Jinson.Global.Models.PostModels
{
    public class UpdateUserInfoPostModel : BaseRestPostModel
    {
        public string UserName
        {
            get;
            set;
        }
        public string QQ
        {
            get;
            set;
        }
        public string Tel
        {
            get;
            set;
        }
        public string Mail
        {
            get;
            set;
        }
        
    }
}
