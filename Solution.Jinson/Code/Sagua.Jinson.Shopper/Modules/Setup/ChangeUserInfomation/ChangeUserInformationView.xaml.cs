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
using Microsoft.Practices.Unity;

namespace Sagua.Jinson.Shopper.Modules.Setup.ChangeUserInfomation
{
    /// <summary>
    /// ChangeUserInformationView.xaml 的交互逻辑
    /// </summary>
    public partial class ChangeUserInformationView : UserControl
    {
        [Dependency]
        public ChangeUserInformationViewModel ViewModel
        {
            get
            {
              return   this.DataContext as ChangeUserInformationViewModel;
            }
            set
            {
                this.DataContext = value;
            }
        }
        public ChangeUserInformationView()
        {
            InitializeComponent();
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
