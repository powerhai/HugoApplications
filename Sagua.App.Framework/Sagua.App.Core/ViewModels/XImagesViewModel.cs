using System;
using Sagua.App.Common;
using Xamarin.Forms;
using System.Windows.Input;
using System.Collections.Generic;
using Sagua.App.Controls;

namespace Sagua.App.Core
{
	public class XImagesViewModel : BaseViewModel 
	{
		List<ImageInfo> images;
		public List<ImageInfo> Images {
			get {
				return images;
			}
			set {
				images = value;
				OnPropertyChanged ();
			}
		}
		public XImagesViewModel (Page page):base(page)
		{
			var imgs = new List<ImageInfo>{ };
			for (var i = 0; i < 12; i++)
				imgs.Add (new ImageInfo (){ Info = "asdfa as asda a" + i.ToString(), Url = "http://y0.ifengimg.com/2014/07/08/08455611.jpg" });
			Images = imgs;
		}
	}
	
}
