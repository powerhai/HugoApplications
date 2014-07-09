using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms;
using Sagua.App.Components.Settings;

namespace Sagua.App.Common
{

	public class BaseViewModel : ObservableObject
	{
		protected  Page  Page{ get; private set;}
		protected ISettings Settings{ get; private set; }

		public BaseViewModel (Page page) 
		{
			this.Page = page;	
			Settings = DependencyService.Get<ISettings> ();		
		}
 
	}
}
