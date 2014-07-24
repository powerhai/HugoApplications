using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Input;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Unity;
using Sagua.Jinson.Shopper.Common;
using Sagua.Jinson.Shopper.Controllers;
using Sagua.Jinson.Shopper.Models;
using MessageBox = Xceed.Wpf.Toolkit.MessageBox;

namespace Sagua.Jinson.Shopper.Modules.Server
{
    public class ServerWorkSpaceViewModel : BaseViewModel
    {
        private readonly ServerController mServerController;
        public ServerWorkForm WorkForm
        {
            get
            {
                return mWorkForm ?? (mWorkForm = new ServerWorkForm());
            } 
        }
        private static object LockObject = new object();
        private ObservableCollection<UiServer> mServers;
        private ServerWorkForm mWorkForm;
        public ObservableCollection< UiServer> Servers
        {
            get
            {
                return mServers ?? (mServers = new ObservableCollection<UiServer>());
            }
            
        }

        public ServerWorkSpaceViewModel (IUnityContainer container, ServerController serverController) : base(container)
        {
            mServerController = serverController;
            BindingOperations.EnableCollectionSynchronization(Servers,LockObject);
        }
        public override async void LoadViewData ()
        {
            ShowBusyBox();
            var rv = await  mServerController.GetServers();
            if(rv.IsOk)
            {
                foreach(var item in rv.Servers)
                {
                    Servers.Add(new UiServer() { Id = 1, IsEnable = true, Url = item.Url , IsOpenning = item.IsOpenning  });
                }
            } else
            {
                MessageBox.Show(rv.ErrorMessage, "错误", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            CloseBusyBox();
        }




        public ICommand DelServerCommand
        {
            get
            {
                return new DelegateCommand<UiServer>( async (server) =>
                {
                    ShowBusyBox();
                    var rv = await mServerController.DelServer(server.Id );
                    if (rv.IsOk)
                    {
                        this.Servers.Remove(server);
                    }
                    else
                    {
                        MessageBox.Show(rv.ErrorMessage, "错误", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                    CloseBusyBox();
                });
            }

        }
      

        public ICommand AddServerCommand
        {
            get
            {
                return new DelegateCommand(async () =>
                {
                    ShowBusyBox();
                    var rv = await  mServerController.AddServer(WorkForm.Url, WorkForm.IsOpenning);
                    if(rv.IsOk)
                    {
                        this.Servers.Add(new UiServer()
                        {
                            IsEnable = false,
                            IsOpenning = rv.IsOpenning,
                            Url = rv.Url , 
                            Id = rv.Id 
                        }); 
                    } else
                    {
                        MessageBox.Show(rv.ErrorMessage, "错误", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                    CloseBusyBox();
 
                });
            }

        }



        public ICommand SetOpenServerCommand
        {
            get
            {
                return new DelegateCommand<UiServer>((server) =>
                {
                    server.IsOpenning = true;
                });
            }

        }



        public ICommand SetCloseServerCommand
        {
            get
            {
                return new DelegateCommand<UiServer>((server) =>
                {
                    server.IsOpenning = false;
                });
            }

        }
      
      
      
    }
}
