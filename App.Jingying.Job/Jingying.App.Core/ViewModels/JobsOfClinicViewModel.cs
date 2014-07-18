using System;
using Sagua.App.Common;
using System.Windows.Input;
using Xamarin.Forms;
using Sagua.App.Components;
using System.Collections.ObjectModel;

namespace Jingying.App.Core
{

	public class JobsOfClinicViewModel : BaseViewModel
	{
		ObservableCollection<UiJob> jobs = new ObservableCollection<UiJob> ();
		public ObservableCollection<UiJob> Jobs {
			get {
				return jobs;
			}
			set {
				jobs = value;
				OnPropertyChanged ();
			}
		}

		public JobsOfClinicViewModel (Page page): base(page)
		{
			Jobs.Add (new UiJob (){Title = "招聘职业医生，福利好" });
			Jobs.Add (new UiJob (){Title = "招聘口腔职业医生，福利好" });
			Jobs.Add (new UiJob (){Title = "招聘牙科执业医生，福利好" });
			Jobs.Add (new UiJob (){Title = "招聘助理医师，福利不错的" });

		}

		public ICommand GotoJobCommand{
			get{ 
				return new Command<UiJob> ((job) => {
					Page.DisplayAlert("job", job.Title, "ok","no");
				});
			}
		}

	}
	
}
