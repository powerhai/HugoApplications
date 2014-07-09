using System;
using MonoTouch.UIKit;
using MonoTouch.Foundation;
using Sagua.App.Components.iOS;

[assembly: Xamarin.Forms.Dependency (typeof (PhoneService))]
namespace Sagua.App.Components.iOS
{
	public class PhoneService : IPhoneService {

		public void Call(string person, string number) {
			var url = new NSUrl("tel:" + number);
			UIApplication.SharedApplication.OpenUrl(url);
		}


		public void Sms(string number, string message) { 
			var url = NSUrl.FromString("sms:" + number);
			UIApplication.SharedApplication.OpenUrl(url);
		}
	}
}

