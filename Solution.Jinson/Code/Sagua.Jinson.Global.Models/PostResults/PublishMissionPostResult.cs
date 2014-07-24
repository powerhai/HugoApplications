using System;
using System.Collections.Generic;
using System.Text;
using Sagua.Global.Common;
using Sagua.Jinson.Global.Domain;

namespace Sagua.Jinson.Global.Models.PostResults
{
    public class PublishMissionPostResult : BaseRestResult
    {
        public PublishMissionPostResult ()
        {
            Missions = new List<Mission>();
        }
        public List<Mission> Missions
        {
            get;
            set;
        }
        public class Mission
        {
            public long Id
            {
                get;
                set;
            }

            public DateTime Date
            {
                get;
                set;
            }

            public BuyTaskStatus TaskStatus
            {
                get;
                set;
            }

            public string GoodsId
            {
                get;
                set;
            }
            public int PlanCount
            {
                get;
                set;
            }
 
            public ShopType ShopType
            {
                get;
                set;
            }
 
        }
    }
}
