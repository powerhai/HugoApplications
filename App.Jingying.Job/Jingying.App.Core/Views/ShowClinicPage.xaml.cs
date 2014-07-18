using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Jingying.App.Core
{	
	public partial class ShowClinicPage : ContentPage
	{	
		public ShowClinicPage ()
		{
			InitializeComponent ();
			this.BindingContext = new ShowClinicViewModel (this);
		}
	}
}

