using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Sagua.App.Core
{	
	public partial class XZoomImagePage : ContentPage
	{	
		public XZoomImagePage ()
		{
			InitializeComponent ();
			this.BindingContext = new XZoomImagePageViewModel (this);
		}
	}
}

