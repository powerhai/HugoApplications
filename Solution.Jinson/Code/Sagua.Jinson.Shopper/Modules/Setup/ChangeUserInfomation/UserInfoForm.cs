using System;
using Sagua.Jinson.Shopper.Common;

namespace Sagua.Jinson.Shopper.Modules.Setup.ChangeUserInfomation
{
    public class UserInfoForm : DataForm
    {

        private String mTel;
        public String Tel
        {
            get
            {
                return mTel;
            }
            set
            {
                mTel = value;
                OnPropertyChanged();
            }
        }
      
        private String mMail;
        public String Mail
        {
            get
            {
                return mMail;
            }
            set
            {
                mMail = value;
                OnPropertyChanged();
            }
        }
      
        private string mQQ;
        public string QQ
        {
            get
            {
                return mQQ;
            }
            set
            {
                mQQ = value;
                OnPropertyChanged();
            }
        }
      
    }
}