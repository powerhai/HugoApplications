using System;
using Sagua.App.Common;
using Xamarin.Forms;
using System.Collections.ObjectModel;
using Sagua.App.Components;
using RestSharp.Portable;
using Sagua.Global.Models.RestPostModels;
using Sagua.Global.Models.RestResults;

namespace Sagua.App.Core
{
	public class TestLibViewModel: BaseViewModel, QQSessionDelegate
	{
		public ObservableCollection<string> Commands { get; set; }

		public TestLibViewModel (Page page):base(page)
		{
			Commands = new ObservableCollection<string>{"weibo login","qq login", "Scan QR barcode", "Get QR barcode", "call phone", "send sms" , "progress dialog","take a photo","get a photo","get doctor", "post photo"};
		}

		public async void DoCommand(string index)
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
            case ("get doctor"):
			    {
					var client = new RestClient(new Uri("http://192.168.1.107"));
					var request = new RestRequest ("/Sagua/Doctor/GetDoctorById");
					request.AddBody (new GetDoctorByIdPostModel (){ Id = 3});
					var result = await client.Execute<GetDoctorByIdResults>(request); 
					Page.DisplayAlert ("ok", result.Data.Name, "ok", "no");
			        break;
			    }
			case ("post photo"):
				{
					var client = new RestClient(new Uri("http://192.168.1.107"));
					var request = new RestRequest ("/Sagua/Doctor/SetDoctorPhoto");					 
					request.AddParameter ("Id", "3");
					request.AddFile ("image", new byte[]{ 0x01, 0x02, 0x03, 0x04 }, "ok.file");
					var result = await client.Execute<SetDoctorPhotoResults>(request); 
					Page.DisplayAlert ("ok", result.Data.Info, "ok", "no");
					break;
				}
			case("qq login"):
				{
					var qqlogin = DependencyService.Get<IQQ_OAuth> ();
					qqlogin.Login ("100478302", this);
					break;
				}

			case("weibo login"):
				{
					var weibologin = DependencyService.Get<IWeibo_OAuth> ();
					weibologin.Login ("1781235272");
					break;
				}

			}
		} 

		public void DidLogin (string openId, string accessToken, DateTime expirationDate)
		{
			Page.DisplayAlert (openId, accessToken + " " + expirationDate.ToString(),  "ok", "no");
		}
		public void GetUserInfo (string jsonData)
		{
			 
		} 
	}
}

