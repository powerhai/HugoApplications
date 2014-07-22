using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sagua.Global.Common;

namespace Sagua.Jinson.Shopper.Services
{
    public class AuthorizationService : ObservableObject
    {

        private String mUserName;
        public String UserName
        {
            get
            {
                return mUserName;
            }
            set
            {
                mUserName = value;
                OnPropertyChanged();
            }
        }
      

        private bool mIsLogined;
        public bool IsLogined
        {
            get
            {
                return mIsLogined;
            }
            set
            {
                mIsLogined = value;
                OnPropertyChanged();
            }
        }
      
    }
}
