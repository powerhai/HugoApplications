using System; 
using MonoTouch.Foundation;
using Sagua.App.Components.iOS;
using BindingQQLibrary;
 
[assembly: Xamarin.Forms.Dependency (typeof (QQ_OAuth))]

namespace Sagua.App.Components.iOS
{


	public class QQ_OAuth :TencentSessionDelegate, IQQ_OAuth
	{ 
		TencentOAuth mAuth;
		QQSessionDelegate mDelegate;

		public QQ_OAuth ()
		{

		}

		public override void getUserInfoResponse (APIResponse response)
		{ 
			if(mDelegate != null)
				mDelegate.GetUserInfo (response.Message);
		}
 
		public void Login (string appId, QQSessionDelegate dele)
		{
			mAuth = new TencentOAuth(appId,this); 
			mDelegate = dele;
			var nss = NSArray.FromObjects(new object[]{ "all"});
			mAuth.Authorize( nss,false);
		}
  
		public override void TencentDidLogin ()
		{
			if(mDelegate != null)
				mDelegate.DidLogin (mAuth.OpenId, mAuth.AccessToken, (DateTime)mAuth.ExpirationDate );
		}
		 
	}
	 


}

