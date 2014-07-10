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
using Xamarin.Geolocation;
using Xamarin.Media;
using ZXing;
using ZXing.Common;
using ZXing.Mobile;
using Sagua.App.Components.WinPhone;
using Xamarin.Forms;

[assembly: Dependency(typeof(ProgressDialog))]

namespace Sagua.App.Components.WinPhone
{
    public class ProgressDialog : IProgressDialog
    {
        private readonly ProgressPopUp progress = new ProgressPopUp();

        #region IProgressDialog Members

        private string text;
        public string Title
        {
            get { return this.text; }
            set
            {
                if (this.text == value)
                    return;

                this.text = value;
                this.Refresh();
            }
        }


        private int percentComplete;
        public int PercentComplete
        {
            get { return this.percentComplete; }
            set
            {
                if (this.percentComplete == value)
                    return;

                if (value > 100)
                {
                    this.percentComplete = 100;
                }
                else if (value < 0)
                {
                    this.percentComplete = 0;
                }
                else
                {
                    this.percentComplete = value;
                }
                this.percentComplete = value;
                this.Refresh();
            }
        }


        public bool IsDeterministic
        {
            get { return !this.progress.IsIndeterminate; }
            set { this.progress.IsIndeterminate = !value; }
        }


        public bool IsShowing { get; private set; }


        public void SetCancel(Action onCancel, string cancelText)
        {
            this.progress.SetCancel(onCancel, cancelText);
        }


        public void Show()
        {
            if (this.IsShowing)
                return;

            this.IsShowing = true;
            this.Dispatch(this.progress.Show);
        }


        public void Hide()
        {
            if (!this.IsShowing)
                return;

            this.IsShowing = false;
            this.Dispatch(this.progress.Hide);
        }


        protected void Dispatch(Action action)
        {
            Deployment.Current.Dispatcher.BeginInvoke(action);
        }


        private void Refresh()
        {
            this.Dispatch(() =>
            {
                this.progress.LoadingText = this.text;
                if (this.IsDeterministic)
                {
                    this.progress.PercentComplete = this.percentComplete;
                    this.progress.CompletionText = this.percentComplete + "%";
                }
            });
        }


        #endregion

        #region IDisposable Members

        public void Dispose()
        {
            this.Hide();
        }

        #endregion
    }
}
