using System;
using System.Collections.Generic;
using System.Text;
using Sagua.Global.Common;

namespace Sagua.Jinson.Global.Models.PostResults
{
    public class GetServersPostResult : BaseRestResult
    {
        public GetServersPostResult ()
        {
            Servers = new List<Server>();
        }
        public List<Server> Servers
        {
            get;
            set;
        }
        public class Server
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
}
