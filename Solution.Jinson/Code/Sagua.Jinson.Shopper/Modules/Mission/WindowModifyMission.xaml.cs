using System.Windows;
using Microsoft.Practices.Unity;

namespace Sagua.Jinson.Shopper.Modules.Mission
{
    /// <summary>
    /// WindowModifyMission.xaml 的交互逻辑
    /// </summary>
    public partial class WindowModifyMission : Window
    {
        public WindowModifyMission()
        {
            InitializeComponent();
        }
        [Dependency]
        public ModifyMissionViewModel ViewModel
        {
            get
            {
                return this.DataContext as ModifyMissionViewModel;
            }
            set
            {
                this.DataContext = value;
            }
        }

        private void ButtonOk_OnClick(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;

        }
    }
}
