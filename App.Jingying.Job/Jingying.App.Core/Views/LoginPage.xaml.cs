using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Jingying.App.Core
{	
	public partial class LoginPage : ContentPage
	{	
		public LoginPage ()
		{
			InitializeComponent ();
			this.BindingContext = new LoginViewModel (this);
		}
	}
}

