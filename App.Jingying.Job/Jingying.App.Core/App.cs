using System;
using Xamarin.Forms;

namespace Jingying.App.Core
{
	public class App
	{ 
		public static Page GetMainPage ()
		{	
			var c =  new  NavigationPage (new MainPage ());
			 
			return c;
		}
	}
}

