using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Sagua.App.Core
{	
	public partial class RefreshListViewPage : ContentPage
	{	
		public RefreshListViewPage ()
		{
			InitializeComponent ();
			this.BindingContext = new RefreshListViewPageViewModel (this);
		}
	}
}

