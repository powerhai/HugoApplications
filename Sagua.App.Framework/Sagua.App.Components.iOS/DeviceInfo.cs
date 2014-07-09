using System;
using MonoTouch.UIKit;
using MonoTouch.ObjCRuntime;
using Sagua.App.Components.iOS;


[assembly: Xamarin.Forms.Dependency (typeof (DeviceInfo))]

namespace Sagua.App.Components.iOS
{
	public class DeviceInfo : IDeviceInfo {

		public int ScreenHeight {
			get { return (int)UIScreen.MainScreen.Bounds.Height; }
		}


		public int ScreenWidth {
			get { return (int)UIScreen.MainScreen.Bounds.Width; }
		}


		public string DeviceId {
			get { return UIDevice.CurrentDevice.IdentifierForVendor.AsString(); }
		}


		public string Manufacturer {
			get { return "Apple"; }
		}


		public string Model {
			get { return UIDevice.CurrentDevice.Model; }
		}

		private string os;
		public string OperatingSystem {
			get {
				this.os = this.os ?? String.Format("{0} {1}", UIDevice.CurrentDevice.SystemName, UIDevice.CurrentDevice.SystemVersion);
				return this.os;
			}
		}

		public bool IsFrontCameraAvailable {
			get { return UIImagePickerController.IsCameraDeviceAvailable(UIImagePickerControllerCameraDevice.Front); }
		}


		public bool IsRearCameraAvailable {
			get { return UIImagePickerController.IsCameraDeviceAvailable(UIImagePickerControllerCameraDevice.Rear); }
		}


		public bool IsSimulator {
			get { return (Runtime.Arch == Arch.SIMULATOR); }
		}
	}
}

