using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Microsoft.Practices.Prism;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Unity;
using Sagua.Jingson.Shopper;
using Sagua.Jinson.Shopper.Common;
using Sagua.Jinson.Shopper.Domain;
using Sagua.Jinson.Shopper.Models;

namespace Sagua.Jinson.Shopper.Modules.Shop
{
    

    public class ShopWorkSpaceViewModel : BaseViewModel
    {
        private readonly IUnityContainer mContainer;

        public class InputDataBlocak : ObservableObject
        {
            private string mTitle;
            private string mUrl;
            private ShopType mShopType;
            public string Title
            {
                get
                {
                    return mTitle;
                }
                set
                {
                    mTitle = value;
                    OnPropertyChanged();
                }
            }

            public string Url
            {
                get
                {
                    return mUrl;
                }
                set
                {
                    mUrl = value;
                    OnPropertyChanged();
                }
            }

            public ShopType ShopType
            {
                get
                {
                    return mShopType;
                }
                set
                {
                    mShopType = value;
                    OnPropertyChanged();
                }
            }
        }

        public InputDataBlocak AddDataBlocak
        {
            get
            {
                return mAddDataBlocak ?? (mAddDataBlocak = new InputDataBlocak());
            } 
        }

        public ShopWorkSpaceViewModel (IUnityContainer container)
        {
            mContainer = container;
            Shops.Add(new UiShop(){ ShopType = ShopType.Taobao, Title = "河边小店", Url = "http://www.taobao.com/shop/123"});
               Shops.Add(new UiShop() { ShopType = ShopType.Taobao, Title = "九匹狼专卖店", Url = "http://www.taobao.com/shop/123" });
               Shops.Add(new UiShop() { ShopType = ShopType.Taobao, Title = "匹力旗巾店", Url = "http://www.taobao.com/shop/123" });
               Shops.Add(new UiShop() { ShopType = ShopType.Taobao, Title = "河边小店", Url = "http://www.taobao.com/shop/123" });

        }

        private ObservableCollection<UiShop> mShops;
        private InputDataBlocak mAddDataBlocak;
        public ObservableCollection<UiShop> Shops
        {
            get
            {
                return mShops ?? (mShops = new ObservableCollection<UiShop>());
            } 
        }

        public ICommand AddShopCommand
        {
            get { return new DelegateCommand(() =>
            {
                Shops.Add(new UiShop() { ShopType = AddDataBlocak.ShopType  , Title = AddDataBlocak.Title , Url =  AddDataBlocak.Url });
                
            });}
        }

        public ICommand EditShopCommand
        {
            get
            {
                return new DelegateCommand<UiShop>((shop) =>
                {
                    var dialog = mContainer.Resolve<WindowModifyShop>();
                    dialog.Owner = App.Current.MainWindow;
                    dialog.ViewModel.Shop = new UiShop(){ ShopType = shop.ShopType, Title = shop.Title,Url = shop.Url };
                    var result =  dialog.ShowDialog();
                    if(result.HasValue && result.Value == true)
                    {
                        shop.Url = dialog.ViewModel.Shop.Url;
                        shop.Title = dialog.ViewModel.Shop.Title;
                        shop.ShopType = dialog.ViewModel.Shop.ShopType;
                    }
                });
            }
        }
        public ICommand DelShopCommand
        {
            get {return new DelegateCommand<UiShop>((shop) =>
            {
                Shops.Remove(shop);
            });}
        }
        public ICommand GoToUrlCommand
        {
            get
            {
                return new DelegateCommand<string>((url) =>
                {
                    System.Diagnostics.Process.Start(url); 
                });
            }
        }
    }
}
