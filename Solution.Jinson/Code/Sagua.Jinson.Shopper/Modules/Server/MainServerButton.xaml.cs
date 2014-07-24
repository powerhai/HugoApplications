using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Practices.Prism.Regions;
using Sagua.Jinson.Shopper.Domain;
using Sagua.Jinson.Shopper.Modules.Mission;
using Sagua.Jinson.Shopper.Services;

namespace Sagua.Jinson.Shopper.Modules.Server
{
    /// <summary>
    /// MainServerButton.xaml 的交互逻辑
    /// </summary>
    public partial class MainServerButton 
    {
        private readonly AuthorizationService mAuthorizationService;
        private readonly IRegionManager mRegionManager;
        public MainServerButton(AuthorizationService authorizationService, IRegionManager regionManager)
        {
            mAuthorizationService = authorizationService;
            mRegionManager = regionManager;
            InitializeComponent();
        }
        protected override void OnClick()
        {
            base.OnClick();
            if (mAuthorizationService.IsLogined)
                mRegionManager.Regions[RegionNames.WORK_SPACE_REGION].RequestNavigate(typeof(ServerWorkSpaceView ).FullName);
        }
    }
}
