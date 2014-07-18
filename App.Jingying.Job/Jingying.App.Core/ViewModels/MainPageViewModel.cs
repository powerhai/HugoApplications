using System;
using Sagua.App.Common;
using Xamarin.Forms;
using System.Windows.Input;

namespace Jingying.App.Core
{

	public class MainPageViewModel : BaseViewModel 
	{
		public MainPageViewModel (Page page): base(page)
		{   
		}



		public ICommand GoPersonHomeCommand{
			get{ 
				return new Command(()=>{ 
					Page.Navigation.PushAsync(new ShowClinicPage());				 
				});
			}
		}

		public ICommand GoClinicHomeCommand{
			get{ 
				return new Command (() => {  
					Page.Navigation.PushModalAsync(new ClinicHomePage());

				});
			}
		}

	}
}

