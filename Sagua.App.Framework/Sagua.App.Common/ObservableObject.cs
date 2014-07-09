using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms;
 

namespace Sagua.App.Common
{

	public class ObservableObject : INotifyPropertyChanged
	{ 
		public event PropertyChangedEventHandler PropertyChanged;
		public void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			var handler = PropertyChanged;
			if (handler != null)
			{
				handler(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}

}

