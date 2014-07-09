using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS; 
using MonoTouch.UIKit;
using Sagua.App.Controls;
using Sagua.App.Controls.iOS;
using System.Drawing;
 
namespace Sagua.App.Controls.iOS
{

	public class ZoomImageView : UIView
	{
		private UIScrollView mScrollView;
		private UIImageView mImageView;
		private UIActivityIndicatorView mActivityView;

		public ZoomImageView ()
		{
			InitViews ();
		}
		public void StartLoadImage()
		{
			mActivityView.StartAnimating (); 
			mImageView.Image = null;
		}
		public  void SetImage(UIImage  image, string info)
		{
			ResetViewState ();
			mImageView.Image = image;
			mActivityView.StopAnimating ();
		}
		public override void LayoutSubviews ()
		{
			base.LayoutSubviews (); 
			var rect = new RectangleF (0, 0, Frame.Width, Frame.Height);
			mScrollView.Frame = rect;
			mImageView.Frame = rect;
			mActivityView.Frame = rect;
			ResetViewState ();
		}

		private void ResetViewState()
		{
			var rect = new RectangleF (0, 0, Frame.Width, Frame.Height); 
			mScrollView.ContentSize = rect.Size;
			mScrollView.SetZoomScale (1, false);
			mScrollView.ContentInset = UIEdgeInsets.Zero;
			mScrollView.ContentOffset = new PointF (0 , 0 );

		}
		private void InitViews()
		{
			mScrollView = new UIScrollView (){BackgroundColor = UIColor.Black,  MinimumZoomScale=1.0f, MaximumZoomScale=3.0f, 
				ShowsHorizontalScrollIndicator = false, ShowsVerticalScrollIndicator = false ,
				AlwaysBounceHorizontal  = false, AlwaysBounceVertical = false, Bounces = true 
			}; 

			mScrollView.ViewForZoomingInScrollView = delegate(UIScrollView scrollView2) 
			{
				return mImageView;  
			} ;
			mScrollView.DidZoom += (object sender, EventArgs e) => {
				var offsetX = (mScrollView.Bounds.Size.Width  > mScrollView.ContentSize.Width)?
					(mScrollView.Bounds.Size.Width - mScrollView.ContentSize.Width) * 0.5f : 0.0f;
				var offsetY = (mScrollView.Bounds.Size.Height > mScrollView.ContentSize.Height)?
					(mScrollView.Bounds.Size.Height - mScrollView.ContentSize.Height) * 0.5f : 0.0f;
				mImageView.Center = new PointF(mScrollView.ContentSize.Width * 0.5f + offsetX,
					mScrollView.ContentSize.Height * 0.5f + offsetY);
			};

			mImageView = new UIImageView (){ContentMode = UIViewContentMode.ScaleAspectFit }; 
			this.AddSubview (mScrollView);
			mImageView.BackgroundColor = UIColor.Brown;
			mScrollView.AddSubview (mImageView); 
			 
			mActivityView = new UIActivityIndicatorView (UIActivityIndicatorViewStyle.WhiteLarge){ HidesWhenStopped = true };
			this.AddSubview (mActivityView); 

		}
	}
	
}
