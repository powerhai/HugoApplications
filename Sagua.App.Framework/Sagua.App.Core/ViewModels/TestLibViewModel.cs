using System;
using Sagua.App.Common;
using Xamarin.Forms;
using System.Collections.ObjectModel;
using Sagua.App.Components;

namespace Sagua.App.Core
{
	public class TestLibViewModel: BaseViewModel
	{
		public ObservableCollection<string> Commands { get; set; }

		public TestLibViewModel (Page page):base(page)
		{
			Commands = new ObservableCollection<string>{ "Scan QR barcode", "Get QR barcode", "call phone", "send sms" , "progress dialog","take a photo","get a photo"};
		}

		public void DoCommand(string index)
		{
			switch (index) {
				case( "Scan QR barcode"):
					{
						DependencyService.Get<IBarCodeScanner> ().Read((async (BarCodeResult obj) => {
						Page.DisplayAlert("Barcode", obj.Code , "ok","no"); 
						}));
						break;
					}
			case("call phone"):
				{
					DependencyService.Get<IPhoneService> ().Call ("hai", "15821522733");
					break;
				}
			case("send sms"):
				{
					DependencyService.Get<IPhoneService> ().Sms ("15821522733", "你好");
					break;
				}
			case("progress dialog"):
				{
					var ccc = DependencyService.Get<IProgressDialog> ();
					ccc.Title = "hai";
					ccc.Show ();
					ccc.Hide ();
					break;
				}
			case("take a photo"):
				{
					DependencyService.Get<IPhotoService> ().FromGallery ();
					break;
				}
			case("get a photo"):
				{
					DependencyService.Get<IPhotoService> ().FromCamera();
					break;
				}
			}
		}

	}
}

