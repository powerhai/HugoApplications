using System;
using Xamarin.Forms;

namespace Jingying.App.Core
{
	public class App
	{
		public static Page GetMainPage ()
		{	
			return new  NavigationPage (new MainPage ());
			 
		}
	}
}

