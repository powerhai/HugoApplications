using System;
using Sagua.App.Common;
using Xamarin.Forms;
using System.Windows.Input;
using System.Collections.ObjectModel;

namespace Jingying.App.Core
{

	public class UiJob : ObservableObject
	{
		string title;
		public string Title {
			get {
				return title;
			}
			set {
				title = value;
				OnPropertyChanged ();
			}
		}
		public long Id{get;set;}
	}
	
}
