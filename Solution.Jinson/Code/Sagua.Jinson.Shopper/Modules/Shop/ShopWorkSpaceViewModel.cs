using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Input;
using Microsoft.Practices.Prism;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Unity;
using Sagua.Global.Common;
using Sagua.Jingson.Shopper;
using Sagua.Jinson.Global.Domain;
using Sagua.Jinson.Shopper.Common;
using Sagua.Jinson.Shopper.Controllers;
using Sagua.Jinson.Shopper.Models;
using MessageBox = Xceed.Wpf.Toolkit.MessageBox;
namespace Sagua.Jinson.Shopper.Modules.Shop
{
    

    public class ShopWorkSpaceViewModel : BaseViewModel
    {
        private readonly ShopController mShopController;

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
        private static object Lock = new object();

        public InputDataBlocak AddDataBlocak
        {
            get
            {
                return mAddDataBlocak ?? (mAddDataBlocak = new InputDataBlocak());
            } 
        }

        public ShopWorkSpaceViewModel (IUnityContainer container, ShopController shopController) : base(container)
        {
            mShopController = shopController;
            BindingOperations.EnableCollectionSynchronization(Shops , Lock);
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
            get { return new DelegateCommand(async () =>
            {
                ShowBusyBox();
                var result = await mShopController.AddShop( AddDataBlocak.Title, AddDataBlocak.Url, AddDataBlocak.ShopType);
                if(result.IsOk)
                {
                    Shops.Add(new UiShop()
                    {
                        ShopType = AddDataBlocak.ShopType,
                        Title = AddDataBlocak.Title,
                        Url = AddDataBlocak.Url,
                        ID = result.ShopId
                    });
                } else
                {
                    MessageBox.Show(result.ErrorMessage, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                CloseBusyBox();
            });}
        }

        public ICommand EditShopCommand
        {
            get
            {
                return new DelegateCommand<UiShop>(async (shop) =>
                {
                    var dialog = mContainer.Resolve<WindowModifyShop>();
                    dialog.Owner = App.Current.MainWindow;
                    dialog.ViewModel.Shop = new UiShop(){ ID = shop.ID, ShopType = shop.ShopType, Title = shop.Title,Url = shop.Url };
                    var result =  dialog.ShowDialog();
                   
                    if(result.HasValue && result.Value == true)
                    { 
                        var resultShop = dialog.ViewModel.Shop;
                        ShowBusyBox();
                        var serResult = await mShopController.UpdateShop(resultShop.ID , resultShop.Title, resultShop.Url, resultShop.ShopType);
                        if(serResult.IsOk)
                        {
                            shop.Url = dialog.ViewModel.Shop.Url;
                            shop.Title = dialog.ViewModel.Shop.Title;
                            shop.ShopType = dialog.ViewModel.Shop.ShopType; 
                        } else
                        {
                            MessageBox.Show(serResult.ErrorMessage, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                        CloseBusyBox();
                    }
                });
            }
        }
        public ICommand DelShopCommand
        {
            get {return new DelegateCommand<UiShop>(async (shop) =>
            {
                ShowBusyBox();
                var result = await  mShopController.DeleteShop(shop.ID);
                if(result.IsOk)
                {
                    Shops.Remove(shop);
                } else
                {
                    MessageBox.Show(result.ErrorMessage, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                CloseBusyBox();
            });}
        }
        public ICommand GoToUrlCommand
        {
            get
            {
                return new DelegateCommand<string>((url) =>
                {
                    try
                    {
                        System.Diagnostics.Process.Start(url);
                    } catch(Exception e) {}
                });
            }
        }
        public override async void LoadViewData ()
        {
            ShowBusyBox();
            var result = await  mShopController.GetShopsOfBusinessUser();
            if(result.IsOk)
            {
                foreach(var item in result.Shops)
                {
                    Shops.Add(new UiShop(){ID = item.Id,  ShopType = item.ShopType,Title = item.Title , Url = item.Url });
                }
            }
            CloseBusyBox();
 
        }
    }
}
