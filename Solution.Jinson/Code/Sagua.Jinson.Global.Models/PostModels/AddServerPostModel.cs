using System;
using System.Collections.Generic;
using System.Text;
using Sagua.Global.Common;
using Sagua.Jinson.Global.Domain; 

namespace Sagua.Jinson.Global.Models.PostModels
{
    public class AddServerPostModel : BaseRestPostModel
    {
        public string Url
        {
            get;
            set;
        }

        public bool IsOpenning
        {
            get;
            set;
        }
        
    }
}
