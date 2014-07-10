using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Phone.Net.NetworkInformation;
using Sagua.App.Components;
using  Sagua.App.Components.WinPhone;
using Xamarin.Forms; 
[assembly: Dependency(typeof(NetworkService))]
namespace Sagua.App.Components.WinPhone
{
    public class NetworkService : AbstractNetworkService
    {

        public NetworkService()
        {
            DeviceNetworkInformation.NetworkAvailabilityChanged += this.OnNetworkAvailabilityChanged;
            this.SetStatus(
                DeviceNetworkInformation.IsNetworkAvailable,
                DeviceNetworkInformation.IsWiFiEnabled,
                DeviceNetworkInformation.IsCellularDataEnabled
            );
        }


        private void OnNetworkAvailabilityChanged(object sender, NetworkNotificationEventArgs e)
        {
            this.SetStatus(
                DeviceNetworkInformation.IsNetworkAvailable,
                DeviceNetworkInformation.IsWiFiEnabled,
                DeviceNetworkInformation.IsCellularDataEnabled
            );
        }


        public override Task<bool> IsHostReachable(string host)
        {
            // TODO
            return null;
        }
    }
}
