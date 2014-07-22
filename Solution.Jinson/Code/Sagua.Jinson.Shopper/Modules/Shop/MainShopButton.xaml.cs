using System.Windows.Controls;
using Microsoft.Practices.Prism.Regions;
using Sagua.Jinson.Shopper.Domain;
using Sagua.Jinson.Shopper.Services;

namespace Sagua.Jinson.Shopper.Modules.Shop
{
    /// <summary>
    /// MainShopButton.xaml 的交互逻辑
    /// </summary>
    public partial class MainShopButton : Button
    {
        private readonly IRegionManager mRegionManager;
        private readonly AuthorizationService mAuthorizationService;
        public MainShopButton(IRegionManager regionManager,AuthorizationService authorizationService)
        {
            mRegionManager = regionManager;
            mAuthorizationService = authorizationService;
            InitializeComponent();
        }
        protected override void OnClick ()
        {
            base.OnClick();
            if(mAuthorizationService.IsLogined )
                mRegionManager.Regions[RegionNames.WORK_SPACE_REGION ].RequestNavigate(typeof(ShopWorkSpaceView).FullName);
        }
    }
}
