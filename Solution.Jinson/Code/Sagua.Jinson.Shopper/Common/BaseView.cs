using System.Windows.Controls;
using Microsoft.Practices.Unity;

namespace Sagua.Jinson.Shopper.Common
{
    public class BaseView<T> : UserControl where T : BaseViewModel
    {
        [Dependency]
        public T ViewModel
        {
            get
            {
                return this.DataContext as T;
            }
            set
            {
                this.DataContext = value;
            }
        }
        public BaseView ()
        { 
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