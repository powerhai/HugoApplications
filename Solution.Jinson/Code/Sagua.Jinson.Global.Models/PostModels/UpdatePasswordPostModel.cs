using System;
using System.Collections.Generic;
using System.Text;
using Sagua.Global.Common;
using Sagua.Jinson.Global.Domain; 

namespace Sagua.Jinson.Global.Models.PostModels
{
    public class UpdatePasswordPostModel : BaseRestPostModel
    {
        public string UserName
        {
            get;
            set;
        }
        public string OldPassword
        {
            get;
            set;
        }

        public string NewPassword
        {
            get;
            set;
        }
    }
}
