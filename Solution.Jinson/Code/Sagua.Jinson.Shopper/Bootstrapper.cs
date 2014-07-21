using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.UnityExtensions;
using Microsoft.Practices.ServiceLocation;
using Sagua.Jinson.Shopper;

namespace Sagua.Jingson.Shopper
{
    public class Bootstrapper : UnityBootstrapper
    {
        protected override void ConfigureModuleCatalog()
        {
            base.ConfigureModuleCatalog();
            var moduleCatalog = (ModuleCatalog)this.ModuleCatalog;
            moduleCatalog.AddModule(typeof(ShopperModule));
        }
        protected override DependencyObject CreateShell()
        {
            var view = this.Container.TryResolve<Shell>();
            return view;
        }

        protected override void InitializeShell ()
        {
            Application.Current.MainWindow = Shell as Window;
            Application.Current.MainWindow.Show();

        }
    }
}
