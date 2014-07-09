using System;
using Xamarin.Forms;
using Sagua.Global.Common;

namespace Sagua.App.Common
{
	public class InvertedBoolValueConverter : IValueConverter
	{
		 
		public object Convert (object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
			return !((bool)value);
		}

		public object ConvertBack (object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
			return !((bool)value); 
		}

	}

	
}
