using System;
using Xamarin.Forms;
using System.Collections.Generic;

namespace Sagua.App.Controls
{

	public class XImagesView : BoxView
	{
		public static readonly BindableProperty ImagesProperty = 
			BindableProperty.Create<XImagesView,List<ImageInfo> > (
				p => p.Images, new List<ImageInfo>());

		public List<ImageInfo> Images {
			get { return (List<ImageInfo> )GetValue (ImagesProperty); }
			set { SetValue (ImagesProperty, value); }
		}

	}	

	public class ImageInfo{
		public string Url{get;set;}
		public string Info{get;set;}
	}
}
