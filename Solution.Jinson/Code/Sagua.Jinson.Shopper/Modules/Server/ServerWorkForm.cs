using System;
using Sagua.Jinson.Shopper.Common;

namespace Sagua.Jinson.Shopper.Modules.Server
{
    public class ServerWorkForm : DataForm
    {

        private String mUrl;
        public String Url
        {
            get
            {
                return mUrl;
            }
            set
            {
                mUrl = value;
                OnPropertyChanged();
            }
        }

        private bool mIsOpenning;
        public bool IsOpenning
        {
            get
            {
                return mIsOpenning;
            }
            set
            {
                mIsOpenning = value;
                OnPropertyChanged();
            }
        }
      
      
    }
}