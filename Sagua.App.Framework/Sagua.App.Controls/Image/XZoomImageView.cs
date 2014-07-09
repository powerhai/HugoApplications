using System;
using Xamarin.Forms;
using System.Collections.Generic;

namespace Sagua.App.Controls
{

	public class XZoomImageView : BoxView
	{
		public static readonly BindableProperty ImageUrlProperty = 
			BindableProperty.Create<XZoomImageView,string > (
				p => p.ImageUrl, "");

		public string ImageUrl {
			get { return (string )GetValue (ImageUrlProperty); }
			set { SetValue (ImageUrlProperty, value); }
		}
	}

}
