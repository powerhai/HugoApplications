using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Sagua.App.Core
{	
	public partial class XListViewPage : ContentPage
	{	
		public XListViewPage ()
		{
			InitializeComponent ();
			this.BindingContext = new RefreshListViewPageViewModel (this);
 
		}
	}
}

