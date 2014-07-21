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
using System.Windows.Shapes;
using Microsoft.Practices.Unity;

namespace Sagua.Jinson.Shopper.Modules.Shop
{
    /// <summary>
    /// WindowModifyShop.xaml 的交互逻辑
    /// </summary>
    public partial class WindowModifyShop : Window
    {
        [Dependency]
        public ModifyShopViewModel ViewModel
        {
            get
            {
                return this.DataContext as ModifyShopViewModel;
            }
            set
            {
                this.DataContext = value;
            }
        }
        public WindowModifyShop()
        {
            InitializeComponent();
        }
        private void ButtonOk_OnClick (object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;

        }
    }
}
