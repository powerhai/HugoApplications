using System;
using MonoTouch.UIKit;
using Sagua.App.Components.iOS;

[assembly: Xamarin.Forms.Dependency (typeof (IOSBitmap))]
namespace Sagua.App.Components.iOS
{
	public class IOSBitmap : ICrossBitmap
	{
		UIImage mImage;

		public void SetSource (object bitmap)
		{
			mImage = bitmap as UIImage;
		}

		public object ToNative ()
		{
			return mImage;
		}

		public byte[] GetJpegBytes (float quality)
		{
			var imgBytes = mImage.AsJPEG (quality);
			var stream = imgBytes.AsStream ();
			var bytes = new byte[stream.Length];
			imgBytes.AsStream ().Read (bytes, 0, bytes.Length);
			return bytes; 
		}

		public float Height {
			get {
				return mImage != null ? mImage.Size.Height : 0;
			}
		}

		public float Width {
			get {
				return mImage != null ? mImage.Size.Width : 0;
			}
		}
 

	}

	//drod
//	public class CrossBitmap : ICrossBitmap
//	{
//		private Bitmap _bitmap;
//
//		public void SetSource(object bitmap)
//		{
//			_bitmap = (Bitmap) bitmap;
//		}
//
//		public object ToNative()
//		{
//			return _bitmap;
//		}
//
//		public int Height
//		{
//			get { return _bitmap == null ? 0 : _bitmap.Height; }
//		}
//
//		public int Width
//		{
//			get{ return _bitmap == null ? 0 : _bitmap.Width; }
//		}
//
//		public byte[] GetJpegBytes(int quality = 100)
//		{
//			if(_bitmap == null)
//				return null;
//			using (var memio = new System.IO.MemoryStream())
//			{
//				_bitmap.Compress( Bitmap.CompressFormat.Jpeg , quality , memio );
//				return memio.ToArray();
//			}
//		}
//	}
}

