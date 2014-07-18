using System;
using Sagua.App.Common;
using System.Windows.Input;
using Xamarin.Forms;
using Sagua.App.Components;

namespace Jingying.App.Core
{
	public class ShowClinicViewModel : BaseViewModel 
	{
		public ShowClinicViewModel (Page page):base(page)
		{
			
		}
		public ICommand ShowJobsOfClinicCommand{
			get{ 
				return new Command (() => {
					Page.Navigation.PushAsync(new JobsOfClinicPage());
				});
			}
		}
	}
	
}
