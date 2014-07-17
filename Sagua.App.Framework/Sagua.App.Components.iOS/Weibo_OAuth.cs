using System; 
using MonoTouch.Foundation;
using Sagua.App.Components.iOS; 
using Sagua.App.BindingWeiboLibrary.iOS;

[assembly: Xamarin.Forms.Dependency (typeof (Weibo_OAuth))]

namespace Sagua.App.Components.iOS
{
	
	public class Weibo_OAuth : IWeibo_OAuth{
		public void Login(string appId)
		{
			WeiboSDK.EnableDebugMode (true);
			WeiboSDK.RegisterApp(appId);

			WBAuthorizeRequest auth = new WBAuthorizeRequest();
			var cccc = WeiboSDK.IsWeiboAppInstalled;
			auth.RedirectURI = "http://www.weibo.com";
			auth.Scope = "all";
			var cadc = WeiboSDK.SendRequest(auth); 
		}
	}
}
