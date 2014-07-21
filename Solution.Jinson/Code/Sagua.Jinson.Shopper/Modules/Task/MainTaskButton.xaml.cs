using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
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
using Microsoft.Practices.Unity;
using Sagua.Jinson.Shopper.Domain;
using Sagua.Jinson.Shopper.Modules.Shop;

namespace Sagua.Jinson.Shopper.Modules.Task
{
    /// <summary>
    /// MainTaskButton.xaml 的交互逻辑
    /// </summary>
    public partial class MainTaskButton : Button
    {
        private readonly IRegionManager mRegionManager;

        public MainTaskButton(IRegionManager regionManager )
        {
            mRegionManager = regionManager;
            InitializeComponent();
        }

        protected override void OnClick ()
        {
            base.OnClick();
            mRegionManager.Regions[RegionNames.WORK_SPACE_REGION].RequestNavigate(typeof(TaskWorkSpaceView).FullName);
        }
    }
}
