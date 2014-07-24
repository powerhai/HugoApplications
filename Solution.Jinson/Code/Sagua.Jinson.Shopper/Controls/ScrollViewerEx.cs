using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Sagua.Jinson.Shopper.Controls
{
    public static class ScrollViewerEx
    {
        public static bool IsAtBottom (this ScrollViewer scroll)
        {
            if(scroll == null)
                return false;
            bool isAtButtom = false;
            double dVer = scroll.VerticalOffset;
            double dViewport = scroll.ViewportHeight;
            double dExtent = scroll.ExtentHeight;

            if (dVer != 0)
            {
                if (dVer + dViewport == dExtent)
                {
                    isAtButtom = true;
                }
                else
                {
                    isAtButtom = false;
                }
            }
            else
            {
                isAtButtom = false;
            }

            if (scroll.VerticalScrollBarVisibility == ScrollBarVisibility.Disabled
                || scroll.VerticalScrollBarVisibility == ScrollBarVisibility.Hidden)
            {
                isAtButtom = true;
            }
            return isAtButtom;
        }
    }
}
