using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Sagua.App.Core
{	
	public partial class SettingsPage : ContentPage
	{	
		public SettingsPage ()
		{
			InitializeComponent ();
			this.BindingContext = new SettingsPageViewModel (this);
		}
	}
}

