using System;
using System.IO;
using Sagua.Jinson.Shopper.Common;
using Sagua.Jinson.Shopper.Domain;

namespace Sagua.Jinson.Shopper.Models
{
    public class UiTask : ObservableObject
    {
        private DateTime mDate;
        public DateTime Date
        {
            get
            {
                return mDate;
            }
            set
            {
                mDate = value;
                OnPropertyChanged();
            }
        }


        private int mPlanCount;
        public int PlanCount
        {
            get
            {
                return mPlanCount;
            }
            set
            {
                mPlanCount = value;
                OnPropertyChanged();
            }
        }


        private int? mRealCount;
        public int? RealCount
        {
            get
            {
                return mRealCount;
            }
            set
            {
                mRealCount = value;
                OnPropertyChanged();
            }
        }


        private ShopType mShopType;
        public ShopType ShopType
        {
            get
            {
                return mShopType;
            }
            set
            {
                mShopType = value;
                OnPropertyChanged();
            }
        }


        private String mGoodsId;
        public String GoodsId
        {
            get
            {
                return mGoodsId;
            }
            set
            {
                mGoodsId = value;
                OnPropertyChanged();
            }
        }



        private TaskStatus mTaskStatus;
        public TaskStatus TaskStatus
        {
            get
            {
                return mTaskStatus;
            }
            set
            {
                mTaskStatus = value;
                OnPropertyChanged();
            }
        }
      
      
      
      
    }
}