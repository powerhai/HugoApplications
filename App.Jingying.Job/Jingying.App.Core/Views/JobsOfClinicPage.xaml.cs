using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Jingying.App.Core
{	
	public partial class JobsOfClinicPage : ContentPage
	{	
		public JobsOfClinicPage ()
		{
			InitializeComponent ();
			this.BindingContext = new JobsOfClinicViewModel (this);
		}
	}
}

