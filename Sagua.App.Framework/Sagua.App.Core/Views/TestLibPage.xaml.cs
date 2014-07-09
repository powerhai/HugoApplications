using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Sagua.App.Core
{	
	public partial class TestLibPage : ContentPage
	{	
		public TestLibPage ()
		{
			InitializeComponent ();
			this.BindingContext = new TestLibViewModel (this);
 
		}

		public void ItemSelected(object sender, SelectedItemChangedEventArgs args)
		{
			var list = sender as ListView;
			var vm = this.BindingContext as TestLibViewModel;
			vm.DoCommand (args.SelectedItem.ToString());
		}
	}
}

