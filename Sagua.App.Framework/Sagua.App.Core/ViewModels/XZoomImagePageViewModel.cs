using System;
using Sagua.App.Common;
using Xamarin.Forms;
using System.Windows.Input;

namespace Sagua.App.Core
{
	public class XZoomImagePageViewModel : BaseViewModel 
	{
		string imageUrl;
		public string ImageUrl {
			get {
				return imageUrl;
			}
			set {
				imageUrl = value;
				OnPropertyChanged ();
			}
		}

		public XZoomImagePageViewModel (Page page):base(page)
		{
			ImageUrl = "http://developer.xamarin.com/guides/cross-platform/xamarin-forms/xaml-for-xamarin-forms/essential_xaml_syntax/Images/GridDemo.png";
		}

		public ICommand SetImageUrlCommand{
			get{ 
				return new Command (() => {
					ImageUrl = "http://developer.xamarin.com/guides/cross-platform/xamarin-forms/xaml-for-xamarin-forms/essential_xaml_syntax/Images/AbsoluteDemo-large.png";
				});
			}
		}
	}
	
}
