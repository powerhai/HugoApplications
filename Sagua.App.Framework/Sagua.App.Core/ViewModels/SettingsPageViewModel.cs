using System;
using Sagua.App.Common;
using Xamarin.Forms;
using System.Windows.Input;

namespace Sagua.App.Core
{
	public class SettingsPageViewModel : BaseViewModel 
	{

		string appName;
		public string AppName {
			get {
				return appName;
			}
			set {
				appName = value;
				OnPropertyChanged ();
			}
		}

		public ICommand SaveCommand{
			get{ 
				return new Command (() => {
					Settings.AddOrUpdateValue("AppName",AppName);
					Settings.Save();
				});
			}
		}

		public SettingsPageViewModel (Page page): base(page)
		{
			AppName = Settings.GetValueOrDefault<string> ("AppName");
		}
	}
	
}
