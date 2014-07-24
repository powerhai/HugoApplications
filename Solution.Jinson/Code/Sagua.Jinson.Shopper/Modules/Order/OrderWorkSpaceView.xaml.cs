using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using Microsoft.Practices.Unity;
using Sagua.Jinson.Shopper.Controls;

namespace Sagua.Jinson.Shopper.Modules.Order
{
    /// <summary>
    /// OrderWorkSpaceView.xaml 的交互逻辑
    /// </summary>
    public partial class OrderWorkSpaceView : UserControl
    {
        [Dependency]
        public OrderWorkSpaceViewModel ViewModel
        {
            get
            {
                return this.DataContext as OrderWorkSpaceViewModel;
            }
            set
            {
                this.DataContext = value;
            }
        }

        public OrderWorkSpaceView()
        {
            InitializeComponent();
            this.Loaded += (sender, args) =>
            {
                if (VisualTreeHelper.GetChildrenCount(T_ListView) != 0)
                {
                    var border = VisualTreeHelper.GetChild(T_ListView, 0) as Decorator;
                    var sv = border.Child as ScrollViewer;
                    sv.ScrollChanged += (o, e) =>
                    {
                        var scroll = o as ScrollViewer;
                        if (scroll.IsAtBottom())
                        {
                            ViewModel.LoadNextPage();
                        }
                    };
                }
            };
            this.IsVisibleChanged += MissionWorkSpaceView_IsVisibleChanged;
        }


        void MissionWorkSpaceView_IsVisibleChanged(object sender, System.Windows.DependencyPropertyChangedEventArgs e)
        {
            if (e.NewValue != null && ((bool)e.NewValue) == true)
            {
                ViewModel.Init();
            }
        }
 
    }
}
