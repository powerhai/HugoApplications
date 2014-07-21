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

namespace Sagua.Jinson.Shopper.Modules.Setup
{
    /// <summary>
    /// MainSetupButton.xaml 的交互逻辑
    /// </summary>
    public partial class MainSetupButton : Button
    {
        private readonly IRegionManager mRegionManager;
        public MainSetupButton(IRegionManager regionManager)
        {
            mRegionManager = regionManager;
            InitializeComponent();
        }
        protected override void OnClick ()
        {
            base.OnClick();
            mRegionManager.Regions[RegionNames.WORK_SPACE_REGION].RequestNavigate(typeof(SetupWorkSpaceView).FullName);
        }
    }
}
