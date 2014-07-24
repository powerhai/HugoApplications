using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Forms.VisualStyles;
using Microsoft.Practices.Unity;
using Sagua.Jinson.Shopper.Common;
using Sagua.Jinson.Shopper.Controllers;
using Sagua.Jinson.Shopper.Models;
using MessageBox = Xceed.Wpf.Toolkit.MessageBox;

namespace Sagua.Jinson.Shopper.Modules.Order
{
    public class OrderWorkSpaceViewModel : BaseViewModel
    {
        public ObservableCollection<UiOrder> Orders
        {
            get
            {
                return mOrders ?? (mOrders = new ObservableCollection<UiOrder>());
            } 
        }
        private bool mIsPageDataLoading = false;
        public bool IsPageDataLoading
        {
            get
            {
                return mIsPageDataLoading;
            }
            set
            {
                mIsPageDataLoading = value;
                OnPropertyChanged();
            }
        }

        private bool mIsNoMoreData = false;
        public bool IsNoMoreData
        {
            get
            {
                return mIsNoMoreData;
            }
            set
            {
                mIsNoMoreData = value;
                OnPropertyChanged();
            }
        }
      
        
        private long mLastId = 0; 
        private static object Lock = new object();
        private readonly OrderController mOrderController;
        private ObservableCollection<UiOrder> mOrders;
        public OrderWorkSpaceViewModel (IUnityContainer container,OrderController orderController) : base(container)
        {
            mOrderController = orderController;
            BindingOperations.EnableCollectionSynchronization(Orders, Lock);
        }

        public async void LoadNextPage()
        {
            if(IsNoMoreData || IsPageDataLoading )
                return;
            IsPageDataLoading = true;
            var rv = await mOrderController.GetOrdersOfBusinessUserByPage(mLastId);
            IsPageDataLoading = false;
            if (rv.IsOk)
            {
                foreach (var item in rv.Orders)
                {
                    Orders.Add(new UiOrder()
                    {
                        Id = item.OrderId,
                        Buyer = item.Buyer,
                        BuyerAccount = item.BuyerAccount,
                        BuyTime = item.BuyTime,
                        PayTime = item.PayTime,
                        Price = item.Price
                    });
                }
                if (rv.Orders.Count > 0)
                {
                    mLastId = rv.Orders[rv.Orders.Count - 1].OrderId;
                }
                if (rv.IsOver)
                {
                    IsNoMoreData = true;
                    MessageBox.Show("已加载完所有数据", "提示", MessageBoxButton.OK, MessageBoxImage.Asterisk);
                }
            }
            else
            {
                MessageBox.Show(rv.ErrorMessage, "错误", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            
        }
        public override async void LoadViewData ()
        {
            ShowBusyBox();
            var rv  = await  mOrderController.GetOrdersOfBusinessUserByPage(0);
            if(rv.IsOk)
            {
                 foreach(var item in rv.Orders)
                {
                    Orders.Add(new UiOrder()
                    {
                        Id = item.OrderId,
                        Buyer = item.Buyer,
                        BuyerAccount =  item.BuyerAccount,
                        BuyTime =  item.BuyTime,
                        PayTime = item.PayTime,
                        Price = item.Price
                    });
                }
                if (rv.Orders.Count > 0)
                {
                    mLastId = rv.Orders[rv.Orders.Count - 1].OrderId;
                }
                if(rv.IsOver)
                {
                    IsNoMoreData = true; 
                }
            } 
            else
            {
                MessageBox.Show(rv.ErrorMessage, "错误", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            CloseBusyBox();
        }
    }
}
