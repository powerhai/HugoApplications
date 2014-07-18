using System;
using Sagua.App.Common;
using System.Windows.Input;
using Xamarin.Forms;
using Sagua.App.Components;

namespace Jingying.App.Core
{

	public class LoginViewModel : BaseViewModel, QQSessionDelegate
	{
		 
		public void DidLogin (string openId, string accessToken, DateTime expirationDate)
		{
			Page.Navigation.PopModalAsync ();
		}

		public void GetUserInfo (string jsonData)
		{ 
		}
 

		public LoginViewModel (Page page):base(page)
		{
			
		}
		public ICommand LoginByQQCommand{
			get{
				return new Command ((o) => {
					var qqlogin = DependencyService.Get<IQQ_OAuth> ();
					qqlogin.Login ("100478302", this);
				});
			}
		}

		public ICommand LoginByWeiboCommand
		{
			get{
				return new Command ((o) => {
					var weibologin = DependencyService.Get<IWeibo_OAuth> ();
					weibologin.Login ("1781235272");
				});
			}
		}


	}
}

