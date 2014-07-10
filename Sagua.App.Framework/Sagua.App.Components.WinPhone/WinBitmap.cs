using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using Coding4Fun.Toolkit.Controls;
using Microsoft.Phone.Net.NetworkInformation;
using Microsoft.Phone.Tasks;
using Sagua.App.Components;
using Sagua.App.Components.WinPhone;
using Xamarin.Forms;
using Xamarin.Geolocation;
using Xamarin.Media;
using ZXing;
using ZXing.Common;
using ZXing.Mobile;

[assembly: Dependency(typeof(WinBitmap))]
namespace Sagua.App.Components.WinPhone
{
    public class WinBitmap : ICrossBitmap
    {
        WriteableBitmap mImage;

        public void SetSource(object bitmap)
        {
            mImage = bitmap as WriteableBitmap;
        }

        public object ToNative()
        {
            return mImage;
        }

        public byte[] GetJpegBytes(float quality)
        { 
            var stream = new MemoryStream();
            mImage.SaveJpeg(stream, mImage.PixelWidth , mImage.PixelHeight, 0, (int)quality);
            var bytes = new byte[stream.Length];
            stream.Write(bytes, 0, bytes.Length);
            stream.Close();
            return bytes;
        }

        public float Height
        {
            get
            {
                return mImage != null ? mImage.PixelHeight : 0;
            }
        }

        public float Width
        {
            get
            {
                return mImage != null ? mImage.PixelWidth : 0;
            }
        }


    }
}
