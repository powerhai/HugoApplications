using System;
using System.Collections.Generic;
using System.Linq;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

using Xamarin.Forms;
using BindingQQLibrary;
using Sagua.App.BindingWeiboLibrary.iOS;

namespace Sagua.App.iOS
{
	[Register ("AppDelegate")]
	public partial class AppDelegate : UIApplicationDelegate
	{
		UIWindow window;

		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
			Forms.Init ();

			window = new UIWindow (UIScreen.MainScreen.Bounds);

			window.RootViewController = Core.App.GetMainPage ().CreateViewController ();
			window.MakeKeyAndVisible ();
			
			return true;
		}

		private static readonly string QQAppName = "com.tencent.mqq";
		private static readonly string WeiboAppName = "com.sina.weibo";
		public override bool HandleOpenURL (UIApplication application, NSUrl url)
		{ 
			return TencentOAuth.HandleOpenURL(url);
		}
		public override bool OpenUrl (UIApplication application, NSUrl url, string sourceApplication, NSObject annotation)
		{
			if (sourceApplication.Equals (QQAppName)) {
				return TencentOAuth.HandleOpenURL(url);
			}
			if(sourceApplication.Equals(WeiboAppName)){

				return WeiboSDK.HandleOpenURL(url, new Wei () );
			} 
			return true;
		}



	}

	class Wei: WeiboSDKDelegate{

		public override void didReceiveWeiboRequest (WBBaseRequest request)
		{
			 
		}
		public override void didReceiveWeiboResponse (WBBaseResponse response)
		{ 
			var wb = response as  WBAuthorizeResponse;
			if (wb != null) {
				var token = wb.AccessToken;
				var userid = wb.UserID;
				var expiration = wb.ExpirationDate;
			}
			string vvvvv = response.RequestUserInfo.ToString ();
		}
	}
}

