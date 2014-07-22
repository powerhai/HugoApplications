using System;
using System.Collections.Generic;
using System.Text;
using Sagua.Global.Common;
using Sagua.Jinson.Global.Domain; 

namespace Sagua.Jinson.Global.Models.PostModels
{
    public class UpdateMissionPostModel : BaseRestPostModel
    {
        public long MissionId
        {
            get;
            set;
        }
 
        public ShopType ShopType
        {
            get;
            set;
        }

        public int PlanCount
        {
            get;
            set;
        }

        public string GoodsId
        {
            get;
            set;
        }


        
    }
}
