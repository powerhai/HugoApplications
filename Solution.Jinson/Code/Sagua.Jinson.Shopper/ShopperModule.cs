using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.Unity;
using Sagua.Jinson.Shopper.Domain;
using Sagua.Jinson.Shopper.Modules.Login;
using Sagua.Jinson.Shopper.Modules.Setup;
using Sagua.Jinson.Shopper.Modules.Setup.ChangePassword;
using Sagua.Jinson.Shopper.Modules.Shop;
using Sagua.Jinson.Shopper.Modules.Task;

namespace Sagua.Jinson.Shopper
{
    public class ShopperModule : IModule
    {
        private readonly IUnityContainer mContainer;
        private readonly IRegionManager mRegionManager;
        public ShopperModule(IUnityContainer container, IRegionManager regionManager)
        {
            mContainer = container;
            mRegionManager = regionManager;
        }
        public void Initialize ()
        {
            mRegionManager.RegisterViewWithRegion(RegionNames.MAIN_BUTTON_REGION, typeof(MainTaskButton));
            mRegionManager.RegisterViewWithRegion(RegionNames.MAIN_BUTTON_REGION, typeof(MainShopButton));
            mRegionManager.RegisterViewWithRegion(RegionNames.MAIN_BUTTON_REGION, typeof(MainSetupButton));

            mRegionManager.RegisterViewWithRegion(RegionNames.WORK_SPACE_REGION, typeof(LoginView));
            mRegionManager.RegisterViewWithRegion(RegionNames.WORK_SPACE_REGION, typeof(TaskWorkSpaceView));
            mRegionManager.RegisterViewWithRegion(RegionNames.WORK_SPACE_REGION, typeof(ShopWorkSpaceView));
            mRegionManager.RegisterViewWithRegion(RegionNames.WORK_SPACE_REGION, typeof(SetupWorkSpaceView));

            mRegionManager.RegisterViewWithRegion(RegionNames.SETUP_REGION , typeof(ChangePasswordView));

        }
    }
}
