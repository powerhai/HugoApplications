using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Input;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Unity;
using Sagua.Jinson.Shopper.Common;
using Sagua.Jinson.Shopper.Controllers;
using Sagua.Jinson.Shopper.Services;
using MessageBox = Xceed.Wpf.Toolkit.MessageBox;
namespace Sagua.Jinson.Shopper.Modules.Setup.ChangePassword
{
    public class ChangePasswordViewModel : BaseViewModel
    {
        private readonly UserController mUserController;
        private readonly AuthorizationService mAuthorizationService;

        private String mOldPassword;
        public ChangePasswordViewModel (IUnityContainer container,UserController userController, AuthorizationService authorizationService ) : base(container)
        {
            mUserController = userController;
            mAuthorizationService = authorizationService;
        }
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
                return new DelegateCommand(async () =>
                {
                    var result = await mUserController.UpdatePassword(mAuthorizationService.UserName, OldPassword, NewPassword);
                    if(result.IsOk)
                    {
                        MessageBox.Show("密码修改成功", "成功", MessageBoxButton.OK , MessageBoxImage.Asterisk);
                    } else
                    {
                        MessageBox.Show(result.ErrorMessage, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                    NewPassword = "";
                    OldPassword = "";
                    NewPasswordAgain = "";
                });
            }

        }

        public override void LoadViewData ()
        {
             
        }
    }
}
