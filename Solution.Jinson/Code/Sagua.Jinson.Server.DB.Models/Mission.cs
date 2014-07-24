using System;
using System.ComponentModel.DataAnnotations;
using Sagua.Jinson.Global.Domain;

namespace Sagua.Jinson.Server.DB.Models
{
    public class Mission
    {
        [Key]
        public long MissionId
        {
            get;
            set;
        }


        public DateTime Date
        {
            get;
            set;
        }
      
      
        public long UserId
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
        public int? RealCount
        {
            get;
            set;
        }
        public ShopType ShopType
        {
            get;
            set;
        }
        public BuyTaskStatus MissionStatus
        {
            get;
            set;
        }
    }
}