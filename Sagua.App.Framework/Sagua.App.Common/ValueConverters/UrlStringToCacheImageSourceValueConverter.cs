using System;
using Xamarin.Forms;

namespace Sagua.App.Common
{
	public class UrlStringToCacheImageSourceValueConverter : IValueConverter
	{ 
		public object Convert (object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
			var url = value as string;
			var source =  new UriImageSource (){ };
			source.CachingEnabled = true;
			source.CacheValidity = new TimeSpan (5, 0, 0);
			source.Uri = new Uri(url);
			return source;
		}
		public object ConvertBack (object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
			throw new NotImplementedException ();
		} 

	}
}

