using System.Windows.Controls;
using Microsoft.Practices.Prism.Regions;
using Sagua.Jinson.Shopper.Domain;

namespace Sagua.Jinson.Shopper.Modules.Shop
{
    /// <summary>
    /// MainShopButton.xaml 的交互逻辑
    /// </summary>
    public partial class MainShopButton : Button
    {
        private readonly IRegionManager mRegionManager;
        public MainShopButton(IRegionManager regionManager)
        {
            mRegionManager = regionManager;
            InitializeComponent();
        }
        protected override void OnClick ()
        {
            base.OnClick();
            mRegionManager.Regions[RegionNames.WORK_SPACE_REGION ].RequestNavigate(typeof(ShopWorkSpaceView).FullName);
        }
    }
}
