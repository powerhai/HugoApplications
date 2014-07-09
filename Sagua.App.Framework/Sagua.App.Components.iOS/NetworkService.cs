using System;
using System.Threading.Tasks;
using Sagua.App.Components.iOS;

[assembly: Xamarin.Forms.Dependency (typeof (NetworkService))]
namespace Sagua.App.Components.iOS
{
	public class NetworkService : AbstractNetworkService {

		public NetworkService() {
			this.SetInfo();
			Reachability.ReachabilityChanged += (s, e) => this.SetInfo();
		}


		public override Task<bool> IsHostReachable(string host) {
			return Task<bool>.Run(() => Reachability.IsHostReachable(host));
		}


		private void SetInfo() {
			switch (Reachability.InternetConnectionStatus()) {
			case NetworkStatus.NotReachable:
				this.SetStatus(false, false, false);
				break;

			case NetworkStatus.ReachableViaCarrierDataNetwork:
				this.SetStatus(true, false, true);
				break;

			case NetworkStatus.ReachableViaWiFiNetwork:
				this.SetStatus(true, true, false);
				break;
			}
		}
	}
}

