using System.Windows.Media;
using Microsoft.Practices.Unity;
using Sagua.Global.Common;
using Sagua.Jinson.Shopper.Controls;

namespace Sagua.Jinson.Shopper.Common
{
    public abstract  class BaseViewModel : ObservableObject
    {
        protected readonly IUnityContainer mContainer;
        private readonly RegionBusyBox mRegionBusyBox;
        public void ShowBusyBox ()
        {
            mRegionBusyBox.Show();
        }
        public void CloseBusyBox ()
        {
            mRegionBusyBox.Close();
        }
        public    BaseViewModel (IUnityContainer container)
        {
            mContainer = container;
            mRegionBusyBox = mContainer.Resolve<RegionBusyBox>();
             
        }
        private bool IsLoaded = false;
        public void Init ()
        {
            if(IsLoaded)
                return;
            LoadViewData();
            IsLoaded = true;

        }
        public abstract    void LoadViewData ();
    }
}