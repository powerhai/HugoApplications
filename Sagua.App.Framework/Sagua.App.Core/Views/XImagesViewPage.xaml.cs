using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace Sagua.App.Core
{	
	public partial class XImagesViewPage : ContentPage
	{	
		public XImagesViewPage ()
		{
			InitializeComponent ();

			this.BindingContext = new XImagesViewModel (this);
		}
	}
}

