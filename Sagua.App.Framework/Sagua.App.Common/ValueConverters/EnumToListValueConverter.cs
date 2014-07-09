using System;
using Xamarin.Forms;
using Sagua.Global.Common;

namespace Sagua.App.Common
{

	public class EnumToListValueConverter : IValueConverter
	{ 
		public object Convert (object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
			return (value as Enum ).GetChildren();
		}

		public object ConvertBack (object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
			return value;
		}

	}
	
}
