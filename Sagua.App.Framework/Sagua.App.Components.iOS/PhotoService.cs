using System;
using System.Threading.Tasks;
using Xamarin.Media;
using System.IO;
using Sagua.App.Components.iOS;

[assembly: Xamarin.Forms.Dependency (typeof (PhotoService))]

namespace Sagua.App.Components.iOS
{
	public class PhotoService : IPhotoService {
		private bool isLoaded;

 
		private MediaPicker CreateMediaPicker() {

			return new MediaPicker();
		}
		 

		private void AssertLoad() {
			if (this.isLoaded)
				return;

			this.isLoaded = true;
			var picker = this.CreateMediaPicker();
			this.isCameraAvailable = picker.IsCameraAvailable && picker.PhotosSupported;
			this.isGalleryAvailable = picker.PhotosSupported;            
		}


		private bool isGalleryAvailable;
		public bool IsGalleryAvailable {
			get {
				this.AssertLoad();
				return this.isGalleryAvailable;
			}
		}


		private bool isCameraAvailable;
		public bool IsCameraAvailable {
			get {
				this.AssertLoad();
				return this.isCameraAvailable;
			}
		}


		public async Task<PhotoResult> FromGallery() {
			var picker = this.CreateMediaPicker();
			if (!this.IsGalleryAvailable)
				throw new Exception("No camera is available");

			try { 
				using (var file = await picker.PickPhotoAsync())
					return new PhotoResult(file.Path, File.OpenRead);
			}
			catch (OperationCanceledException) {
				return PhotoResult.Cancelled;
			}
		}


		public async Task<PhotoResult> FromCamera() {
			var picker = this.CreateMediaPicker();
			if (!picker.IsCameraAvailable)
				throw new Exception("No camera is available");

			try {
				using (var file = await this.UseCamera(picker)) 
					return new PhotoResult(file.Path, File.OpenRead);
			}
			catch (OperationCanceledException) {
				return PhotoResult.Cancelled;
			}
		}


		private async Task<MediaFile> UseCamera(MediaPicker picker) {
			var fileName = DateTime.Now.Ticks + ".png";
			return await picker.TakePhotoAsync(new StoreCameraMediaOptions {
				Directory = "temp",
				Name = fileName
					//DefaultCamera = CameraDevice.Rear
			});
		}
	}
}

