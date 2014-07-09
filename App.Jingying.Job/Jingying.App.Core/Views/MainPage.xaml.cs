using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Jingying.App.Core
{	
	public partial class MainPage : ContentPage
	{	
		public MainPage ()
		{
			InitializeComponent ();
			this.BindingContext = new MainPageViewModel (this);
		}
	}
}

