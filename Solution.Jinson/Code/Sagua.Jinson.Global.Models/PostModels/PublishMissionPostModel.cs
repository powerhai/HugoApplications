using System;
using System.Collections.Generic;
using System.Text;
using Sagua.Global.Common;
using Sagua.Jinson.Global.Domain; 

namespace Sagua.Jinson.Global.Models.PostModels
{
    public class PublishMissionPostModel : BaseRestPostModel
    {
        public DateTime StartDate
        {
            get;
            set;
        }

        public int StartCount
        {
            get;
            set;
        }
        public int DayCount
        {
            get;
            set;
        }

        public decimal DayRise
        {
            get;
            set;
        }
        public string GoodsId
        {
            get;
            set;
        }
        public decimal Price
        {
            get;
            set;
        }
        
    }
}
