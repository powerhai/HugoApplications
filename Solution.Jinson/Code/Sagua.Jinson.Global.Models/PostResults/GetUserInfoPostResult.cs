using System;
using System.Collections.Generic;
using System.Text;
using Sagua.Global.Common;

namespace Sagua.Jinson.Global.Models.PostResults
{
    public class GetUserInfoPostResult : BaseRestResult
    {
        public string QQ
        {
            get;
            set;
        }
        public string Mail
        {
            get;
            set;
        }
        public string Tel
        {
            get;
            set;
        }
    }
}
