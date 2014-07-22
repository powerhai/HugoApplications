using System;
using System.Collections.Generic;
using System.Text;
using Sagua.Global.Common;

namespace Sagua.Jinson.Global.Models.PostModels
{
    public class LoginPostModel : BaseRestPostModel
    {
        public string UserName
        {
            get;
            set;
        }
        public string Password
        {
            get;
            set;
        }
    }
}
