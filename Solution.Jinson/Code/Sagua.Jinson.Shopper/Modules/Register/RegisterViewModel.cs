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
using Sagua.Jinson.Shopper.Controls;
using Sagua.Jinson.Shopper.Domain;
using Sagua.Jinson.Shopper.Modules.Mission;
using MessageBox = Xceed.Wpf.Toolkit.MessageBox;
namespace Sagua.Jinson.Shopper.Modules.Register
{
    public class RegisterViewModel : BaseViewModel
    {
        private readonly RegisterController mRegisterService;
        private readonly IRegionManager mRegionManager;
        public RegisterViewModel(RegisterController registerService, IRegionManager regionManager, IUnityContainer container)
            : base(container)
        {
            mRegisterService = registerService;
            mRegionManager = regionManager; 
        }

        private String mPasswordAgain;
        public String PasswordAgain
        {
            get
            {
                return mPasswordAgain;
            }
            set
            {
                mPasswordAgain = value;
                OnPropertyChanged();
            }
        }
      

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
      
        private String mQQ;
        public String QQ
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
      

        public ICommand RegisterCommand
        {
            get
            {
                return new DelegateCommand(async () =>
                {

                    var busy = mContainer.Resolve<RegionBusyBox>();
                    busy.Show();
                    var result = await mRegisterService.Register(UserName, Password, QQ, Tel, Mail);
                    if(result.IsOk)
                    {
                        MessageBox.Show("注册成功！","提示", MessageBoxButton.OK, MessageBoxImage.Exclamation );
                        mRegionManager.Regions[RegionNames.WORK_SPACE_REGION ].RequestNavigate(typeof(MissionWorkSpaceView).FullName);
                    }
                    busy.Close();
                });
            }

        }

        public override void LoadViewData ()
        {
             
        }
    }
}
