using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sagua.Jinson.Shopper.Common;
using MessageBox = Xceed.Wpf.Toolkit.MessageBox;
namespace Sagua.Jinson.Shopper.Modules.Mission
{
    public class MissionQueryForm : DataForm
    {
        public MissionQueryForm ()
        {
            Price = 100;
            DayRise = 1;
            DayCount = 10;
            StartCount = 10;
            StartDate = DateTime.Now.AddDays(1);
        }
        private decimal mPrice;
        public decimal Price
        {
            get
            {
                return mPrice;
            }
            set
            {
                mPrice = value;
                OnPropertyChanged();
            }
        }
      
        private string mGoodsId;
        public string GoodsId
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
      

        private decimal mDayRise;
        public decimal DayRise
        {
            get
            {
                return mDayRise;
            }
            set
            {
                mDayRise = value;
                OnPropertyChanged();
            }
        }
      
        
        private int mDayCount;
        public int DayCount
        {
            get
            {
                return mDayCount;
            }
            set
            {
                mDayCount = value;
                OnPropertyChanged();
            }
        }
      

        private int mStartCount;
        public int StartCount
        {
            get
            {
                return mStartCount;
            }
            set
            {
                mStartCount = value;
                OnPropertyChanged();
            }
        }
      

        private DateTime mStartDate;
        public DateTime StartDate
        {
            get
            {
                return mStartDate;
            }
            set
            {
                mStartDate = value;
                OnPropertyChanged();
            }
        }
      
    }
}
