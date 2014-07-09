using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS; 
using MonoTouch.UIKit;
using Sagua.App.Controls;
using Sagua.App.Controls.iOS;
using System.Drawing;

[assembly:ExportRendererAttribute(typeof(XZoomImageView), typeof(XZoomImageViewRenderer))]
namespace Sagua.App.Controls.iOS
{


	public class XZoomImageViewRenderer : BoxRenderer
	{
		private UIScrollView mScrollView;
		private UIImageView mImageView;
		private UIActivityIndicatorView mActivityView;
		private XZoomImageView SourceModel{ get{ return this.Model as XZoomImageView;}}
 
		protected override void OnModelSet (VisualElement model)
		{
			base.OnModelSet (model);
			InitViews ();
			LoadImage (SourceModel.ImageUrl);
		}

		public override void LayoutSubviews ()
		{
			base.LayoutSubviews (); 
			var rect = new RectangleF (0, 0, Frame.Width, Frame.Height);
			mScrollView.Frame = rect;
			mImageView.Frame = mImageView.Image != null? FrameOfImage(mImageView.Image.Size,rect) : rect;
			mActivityView.Frame = rect;
			ResetViewState ();
		}

		private RectangleF FrameOfImage(SizeF imgSize,RectangleF viewRect)
		{ 
			var frame = new RectangleF(0f,0f,imgSize.Width, imgSize.Height) ;


			var tw = viewRect.Width;
			var th = frame.Height * viewRect.Width / frame.Width;
			frame.X =  0;
			frame.Y  = (viewRect.Height - th) / 2; 

			if(th > viewRect.Height)
			{
				th = viewRect.Height;
				tw = frame.Width  * viewRect.Height / frame.Height;
				frame.X =  (viewRect.Width - tw) /2;
				frame.Y = 0;
			}

			frame.Width = tw;
			frame.Height = th; 
			return frame;
		}

		private void ResetViewState()
		{
			var rect = new RectangleF (0, 0, Frame.Width, Frame.Height);
			//var imgframe = mImageView.Image != null ? FrameOfImage (mImageView.Image.Size, rect) : mImageView.Frame;
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
		private  async void LoadImage(string url)
		{
			ResetViewState ();
			mActivityView.StartAnimating ();
			var imgLoader = new  ImageLoaderSourceHandler ();
			mImageView.Image  = await  imgLoader.LoadImageAsync (new UriImageSource (){ Uri = new Uri (url) }) ;
			mActivityView.StopAnimating ();
		}

		protected override void OnHandlePropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
		{
			base.OnHandlePropertyChanged(sender, e);
  
			if (e.PropertyName == XZoomImageView.ImageUrlProperty.PropertyName) {
				LoadImage (SourceModel.ImageUrl);
			}
		}
	}
	
}
