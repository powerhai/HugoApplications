using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Microsoft.Practices.Prism.Commands;
using Sagua.Jinson.Shopper.Common;

namespace Sagua.Jinson.Shopper.Modules.Setup.ChangePassword
{
    public class ChangePasswordViewModel : BaseViewModel
    {

        private String mOldPassword;
        public String OldPassword
        {
            get
            {
                return mOldPassword;
            }
            set
            {
                mOldPassword = value;
                OnPropertyChanged();
            }
        }


        private String mNewPassword;
        public String NewPassword
        {
            get
            {
                return mNewPassword;
            }
            set
            {
                mNewPassword = value;
                OnPropertyChanged();
            }
        }


        private String mNewPasswordAgain;
        public String NewPasswordAgain
        {
            get
            {
                return mNewPasswordAgain;
            }
            set
            {
                mNewPasswordAgain = value;
                OnPropertyChanged();
            }
        }

        

        public ICommand SavePasswordCommand
        {
            get
            {
                return new DelegateCommand(() =>
                {

                });
            }

        }
      
      
    }
}
