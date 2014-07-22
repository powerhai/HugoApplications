using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.Unity;
using Sagua.Jinson.Shopper.Common;
using Sagua.Jinson.Shopper.Controllers;
using Sagua.Jinson.Shopper.Domain;
using Sagua.Jinson.Shopper.Modules.Mission;
using Sagua.Jinson.Shopper.Modules.Register;
using Sagua.Jinson.Shopper.Services;

namespace Sagua.Jinson.Shopper.Modules.Login
{
    public class LoginViewModel : BaseViewModel
    {

        private String mPassword;
        public String Password
        {
            get
            {
                return mPassword;
            }
            set
            {
                mPassword = value;
                OnPropertyChanged();
            }
        }
      

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
      
        private readonly IRegionManager mRegionManager;
        private readonly LoginController mLoginController;
        public LoginViewModel(IUnityContainer container, IRegionManager regionManager, LoginController loginController)
            : base(container)
        {
            mRegionManager = regionManager;
            mLoginController = loginController;
        }

        public ICommand LoginCommand
        {
            get
            {
                return new DelegateCommand(async () =>
                {
                    ShowBusyBox();
                    var result = await  mLoginController.Login(UserName, Password );
                    if(!result.IsOk)
                    {
                        MessageBox.Show( result.ErrorMessage,"登录错误", MessageBoxButton.OK, MessageBoxImage.Error);
                    } else
                    {
                        mRegionManager.Regions[RegionNames.WORK_SPACE_REGION ].RequestNavigate(typeof(MissionWorkSpaceView).FullName);
                    }
                    CloseBusyBox();
                });
            }

        }

        

        public ICommand RegisterCommand
        {
            get
            {
                return new DelegateCommand(() =>
                {
                    mRegionManager.Regions[RegionNames.WORK_SPACE_REGION].RequestNavigate(typeof(RegisterView).FullName);

                });
            }

        }

        public override void LoadViewData ()
        {
             
        }
    }
}
