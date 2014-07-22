using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Microsoft.Practices.Unity;
using Sagua.Jinson.Shopper.Common;
using Sagua.Jinson.Shopper.Models;

namespace Sagua.Jinson.Shopper.Modules.Shop
{
    public class ModifyShopViewModel : BaseViewModel
    {
        private UiShop mShop;
        public ModifyShopViewModel (IUnityContainer container) : base(container) {}
        public UiShop Shop
        {
            get
            {
                return mShop;
            }
            set
            {
                mShop = value;
                OnPropertyChanged();
            }
        }
        public ICommand SaveCommand
        {
            get;
            set;
        }
        public override void LoadViewData ()
        {
             
        }
    }
}
