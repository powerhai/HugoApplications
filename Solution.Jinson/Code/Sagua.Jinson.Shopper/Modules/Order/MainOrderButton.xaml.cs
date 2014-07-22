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
using Sagua.Jinson.Shopper.Services;

namespace Sagua.Jinson.Shopper.Modules.Order
{
    /// <summary>
    /// MainOrderButton.xaml 的交互逻辑
    /// </summary>
    public partial class MainOrderButton : Button
    {
        private readonly IRegionManager mRegionManager;
        private readonly AuthorizationService mAuthorizationService;
        public MainOrderButton(IRegionManager regionManager, AuthorizationService authorizationService)
        {
            mRegionManager = regionManager;
            mAuthorizationService = authorizationService;
            InitializeComponent();
        }
        protected override void OnClick ()
        {
            base.OnClick();
            if(mAuthorizationService.IsLogined)
                mRegionManager.Regions[RegionNames.WORK_SPACE_REGION].RequestNavigate(typeof(OrderWorkSpaceView).FullName);
        }
    }
}
