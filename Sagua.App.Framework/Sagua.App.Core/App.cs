using System;
using Xamarin.Forms;

namespace Sagua.App.Core
{
	public class App
	{
		public static Page GetMainPage ()
		{	
			return new  NavigationPage (new MainPage ());
			 
		}
	}
}

