using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media.Imaging; 

namespace Sagua.App.Common.WinPhone
{
    public static class WriteableBitmapEx
    {
        public static byte[] GetJpegBytes(this WriteableBitmap bitmap, int width, int height)
        {
            var bit = (WriteableBitmap) bitmap;
            var stream = new MemoryStream();
            bit.SaveJpeg(stream, width, height, 0, 90);
            var bytes = new byte[stream.Length];
            stream.Write(bytes, 0, bytes.Length);
            stream.Close();
            return bytes;
        }
    }
}
