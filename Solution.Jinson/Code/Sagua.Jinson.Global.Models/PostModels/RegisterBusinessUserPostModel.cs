using System;
using System.Collections.Generic;
using System.Text;
using Sagua.Global.Common;

namespace Sagua.Jinson.Global.Models.PostModels
{
 

    public class RegisterBusinessUserPostModel : BaseRestPostModel 
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
