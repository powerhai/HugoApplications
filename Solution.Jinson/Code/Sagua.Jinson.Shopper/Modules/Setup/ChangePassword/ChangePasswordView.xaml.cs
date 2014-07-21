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

namespace Sagua.Jinson.Shopper.Modules.Setup.ChangePassword
{
    /// <summary>
    /// ChangePasswordView.xaml 的交互逻辑
    /// </summary>
    public partial class ChangePasswordView : UserControl
    {
        [Dependency]
        public ChangePasswordViewModel ViewModel
        {
            get
            {
                return this.DataContext as ChangePasswordViewModel;
            }
            set
            {
                this.DataContext = value;
            }
        }
        public ChangePasswordView()
        {
            InitializeComponent();
        }
        private void OldPassword_OnPasswordChanged (object sender, RoutedEventArgs e)
        {
            this.ViewModel.OldPassword = e.OriginalSource.ToString();
        }
    }
}
