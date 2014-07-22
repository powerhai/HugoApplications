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

namespace Sagua.Jinson.Shopper.Controls
{
    /// <summary>
    /// RegionBusyBox.xaml 的交互逻辑
    /// </summary>
    public partial class RegionBusyBox : UserControl
    {
        private readonly IRegionManager mRegionManager;
        public RegionBusyBox(IRegionManager regionManager)
        {
            mRegionManager = regionManager;
            InitializeComponent();
        }

        public   void Show ()
        { 
            mRegionManager.RegisterViewWithRegion(RegionNames.WORK_SPACE_BUSY_REGION, () => { return this; });
        }
        public void Close ()
        { 
            mRegionManager.Regions[RegionNames.WORK_SPACE_BUSY_REGION].Remove(this);
        }
    }
}
