using System;
using System.Collections.Generic;
using System.Text;
using Sagua.Global.Common;

namespace Sagua.Jinson.Global.Models.PostResults
{
    public class AddServerPostResult : BaseRestResult
    {
        public long Id
        {
            get;
            set;
        }

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
