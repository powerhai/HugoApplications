using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;
using Microsoft.Phone.Net.NetworkInformation;
using Microsoft.Phone.Tasks;
using Sagua.App.Components;
using Xamarin.Geolocation;
using Xamarin.Media;
using ZXing;
using ZXing.Common;
using ZXing.Mobile;
using Sagua.App.Components.WinPhone;

using Xamarin.Forms;

[assembly: Dependency(typeof(BarCodeBuilder))]

namespace Sagua.App.Components.WinPhone
{
    public class BarCodeBuilder : IBarCodeBuilder
    {
        public object GetBarcodeImage(string code, int width, int height, BarCodeFormat codeType)
        {
            var writer = new BarcodeWriter();
            writer.Format = (BarcodeFormat)codeType;
            writer.Options = new EncodingOptions() { Height = height, Margin = 1, Width = width };
            var bit = writer.Write(code);
            return bit;
        }


        public byte[] GetBarcode(string code, int width, int height, BarCodeFormat codeType)
        {
            var bit = (WriteableBitmap)GetBarcodeImage(code, width, height, codeType);
            var stream = new MemoryStream();
            bit.SaveJpeg(stream, width, height, 0, 90);
            var bytes = new byte[stream.Length];
            stream.Write(bytes, 0, bytes.Length);
            stream.Close();
            return bytes;
        }



    }
}
