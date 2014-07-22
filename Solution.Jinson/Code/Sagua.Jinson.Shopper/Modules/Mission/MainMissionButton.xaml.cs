using System.Windows.Controls;
using Microsoft.Practices.Prism.Regions;
using Sagua.Jinson.Shopper.Domain;
using Sagua.Jinson.Shopper.Services;

namespace Sagua.Jinson.Shopper.Modules.Mission
{
    /// <summary>
    /// MainMissionButton.xaml 的交互逻辑
    /// </summary>
    public partial class MainMissionButton : Button
    {
        private readonly IRegionManager mRegionManager;
        private readonly AuthorizationService mAuthorizationService;

        public MainMissionButton(IRegionManager regionManager, AuthorizationService authorizationService )
        {
            mRegionManager = regionManager;
            mAuthorizationService = authorizationService;
            InitializeComponent();
        }

        protected override void OnClick ()
        {
            base.OnClick(); 
            if(mAuthorizationService .IsLogined )
                mRegionManager.Regions[RegionNames.WORK_SPACE_REGION].RequestNavigate(typeof(MissionWorkSpaceView).FullName);
        }
    }
}
