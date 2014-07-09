using System;
using Sagua.App.Common;
using Xamarin.Forms;
using System.Windows.Input;

namespace Sagua.App.Core
{

	public class MainPageViewModel : BaseViewModel 
	{
		public MainPageViewModel (Page page): base(page)
		{  
		}

		public ICommand GotoRefreshListCommand{ 
			get { 
				return new Command (() => {
					Page.Navigation.PushAsync(new RefreshListViewPage());

				});
			} }

		public ICommand GotoTableViewCommand {
			get{
				return new Command (() => {
					Page.Navigation.PushAsync(new TableViewPage());
				});
			}
		}

		public ICommand GotoSettingPageCommand{
			get{ 
				return new Command (()=> {
					Page.Navigation.PushAsync(new SettingsPage());
				});
			}
		}

		public ICommand GotoXListViewCommand{
			get{ 
				return new Command (() => {
					Page.Navigation.PushAsync(new XListViewPage());
				});
			}
		}

		public ICommand GotoXZoomImageCommand{
			get{
				return new Command (() => {
					Page.Navigation.PushAsync(new XZoomImagePage());
				});
			}
		}

		public ICommand  GotoXImagesViewCommand
		{
			get{ 
				return new Command (  () => {
					Page.Navigation.PushAsync(new XImagesViewPage());
					//var client = new RestClient(new Uri("http://wwww.baidu.com"));

					//var request = new RestRequest("/", HttpMethod.Get);
					//var result = await client.Execute<TickerResult>(request);

					//var ccc = await client.Execute<string>(request);


					//var phone = DependencyService.Get<Acr.XamForms.Mobile.IPhoneService>();
					//phone.Call("hai","15821522733");
				});
			}
		}

		public ICommand GotoGroupListCommand{
			get{ 
				return new Command (() => {
					Page.Navigation.PushAsync(new GroupListViewPage());
				});
			}
		}

		public ICommand GotoLibTestCommand
		{
			get{ 
				return new Command (() => {
					Page.Navigation.PushAsync(new TestLibPage());
				});
			}
		}


	}
}

