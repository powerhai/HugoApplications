using System;
using ZXing;
using ZXing.Common;
using MonoTouch.UIKit;
using Sagua.App.Components.iOS;


[assembly: Xamarin.Forms.Dependency (typeof (BarCodeBuilder))]

namespace Sagua.App.Components.iOS
{
	public class BarCodeBuilder : IBarCodeBuilder
	{
		public object GetBarcodeImage (string code, int width, int height, BarCodeFormat codeType)
		{
			var writer = new BarcodeWriter();
			writer.Format = (BarcodeFormat)codeType;
			writer.Options = new EncodingOptions() {Height = height , Margin = 1, Width = width};
			var bit = writer.Write(code);
			return bit;
		}

		 
		public byte[] GetBarcode (string code, int width, int height, BarCodeFormat codeType)
		{
			var bit = (UIImage)GetBarcodeImage (code, width, height, codeType);
			var img = bit.AsJPEG ();
			var stream = img.AsStream ();
			var bytes = new byte[stream.Length];
			stream.Write (bytes, 0, bytes.Length);
			stream.Close ();
			return bytes;
		}


  
	}
}

