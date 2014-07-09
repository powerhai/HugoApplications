using System;
using Sagua.App.Common;
using Xamarin.Forms;
using System.Windows.Input;
using System.Collections.ObjectModel;

namespace Sagua.App.Core
{

	public class RefreshListViewPageViewModel: BaseViewModel
	{
		bool isRefreshing;
		public bool IsRefreshing {
			get {
				return isRefreshing;
			}
			set {
				isRefreshing = value;
				OnPropertyChanged ();
			}
		}
		public RefreshListViewPageViewModel (Page page): base(page)
		{
			for(var i = 0;i<12;i++)
				Doctors.Add (new Doctor (){Name= DateTime.Now.ToString(), ImageUrl="http://news.cnblogs.com/images/logo/apple.png" });
			IsRefreshing = true;
		}

		public ICommand RefreshCommand {
			get{ 
				return new Command<Action> ( async(action) => {

					await Page.DisplayAlert("Refresh","loading...","ok","no");
					Doctors.Clear();
					for(var i = 0;i<12;i++)
						Doctors.Add (new Doctor (){Name= DateTime.Now.ToString(), ImageUrl="http://news.cnblogs.com/images/logo/google.gif" });
					action();
				});
			}
		}

	 

		public ICommand LoadmoreCommand{
			get{ 
				return new Command<Action<bool>> ( async(Action<bool> act) => {

					await Page.DisplayAlert("Refresh","loading...","ok","no");
					for(var i = 0;i<3;i++)
						Doctors.Add (new Doctor (){Name= DateTime.Now.ToString(), ImageUrl="http://news.cnblogs.com/images/logo/google.gif" });
					act(false);
				});
			}
		}

		ObservableCollection<Doctor> doctors;
		public ObservableCollection<Doctor> Doctors {
			get {
				return doctors ?? (doctors = new ObservableCollection<Doctor> ());
			} 
		}
	}
	
}
