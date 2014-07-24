using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Unity;
using Sagua.Jinson.Shopper.Common;
using Sagua.Jinson.Shopper.Controllers;
using Sagua.Jinson.Shopper.Services;
using MessageBox = Xceed.Wpf.Toolkit.MessageBox;

namespace Sagua.Jinson.Shopper.Modules.Setup.ChangeUserInfomation
{
    public class ChangeUserInformationViewModel : BaseViewModel
    {
        private readonly UserController mUserController;
        private readonly AuthorizationService mAuthorizationService;

        private bool mIsLoadOk;
        public bool IsLoadOk
        {
            get
            {
                return mIsLoadOk;
            }
            set
            {
                mIsLoadOk = value;
                OnPropertyChanged();
            }
        }
      

        private UserInfoForm mDataForm;
        public UserInfoForm DataForm
        {
            get
            {
                return mDataForm ?? (mDataForm = new UserInfoForm());
            }
            set
            {
                mDataForm = value;
                OnPropertyChanged();
            }
        }



        public ICommand UpdateUserInfoCommand
        {
            get
            {
                return new DelegateCommand(async () =>
                {
                    ShowBusyBox();
                    var rv = await mUserController.UpdateUserInfo(mAuthorizationService.UserName, DataForm.QQ, DataForm.Mail,DataForm.Tel);
                    if(rv.IsOk)
                    {
                        MessageBox.Show("资料保存成功", "提示", MessageBoxButton.OK, MessageBoxImage.Asterisk);
                    } else
                    {
                        MessageBox.Show(rv.ErrorMessage, "错误", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                    CloseBusyBox();
                });
            }

        }
      
      
        public ChangeUserInformationViewModel (IUnityContainer container, UserController userController, AuthorizationService authorizationService) : base(container)
        {
            mUserController = userController;
            mAuthorizationService = authorizationService;
        }
        
        public override async void LoadViewData ()
        {
            var rv = await  mUserController.GetUserInfo(mAuthorizationService.UserName);
            if(rv.IsOk)
            {
                DataForm.Tel = rv.Tel;
                DataForm.Mail = rv.Mail;
                DataForm.QQ = rv.QQ;
                IsLoadOk = true;
            }
        }
    }
}
