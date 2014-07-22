using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sagua.Jinson.Shopper.Services
{
    public class BusinessServerProvider
    {
        private List<BusinessServer> Servers = new List<BusinessServer>(); 
        public BusinessServerProvider ()
        {
            Servers.Add(new BusinessServer("http://localhost:1600")); 
        }
        private BusinessServer mLastAbleServer;
        private static readonly Random RandomObject = new Random();
        public string GetServerUrl ()
        {
            if(mLastAbleServer == null || mLastAbleServer.IsAble == false )
            {
                var ableServers = Servers.Where(a => a.IsAble == true ).ToArray();
                if(!ableServers.Any())
                    return "";
                mLastAbleServer = ableServers[RandomObject.Next(0, ableServers.Count())];
            }
            return mLastAbleServer.ServerUrl;
        }

        public void UnableConnectCurrentServer ()
        {
            if(mLastAbleServer !=null)
            mLastAbleServer.IsAble = false;
        }

        public class BusinessServer
        {
            public BusinessServer (string serverUrl)
            {
                ServerUrl = serverUrl;
                IsAble = true;
            }
            public string ServerUrl
            {
                get;
                set;
            }
            public bool IsAble
            {
                get;
                set;
            }
        }
    }
}
