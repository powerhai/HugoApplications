using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Sagua.App.Core
{	
	public partial class GroupListViewPage : ContentPage
	{	
		public GroupListViewPage ()
		{
			InitializeComponent ();
			this.BindingContext = new GroupListViewModel (this);
			ListView list;
			 
		}
	}
}

