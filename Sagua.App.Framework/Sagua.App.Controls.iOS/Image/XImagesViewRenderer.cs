using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS; 
using MonoTouch.UIKit; 
using Sagua.App.Controls.iOS;
using System.Drawing;
using Sagua.App.Controls;
using System.Collections.Generic;


[assembly:ExportRendererAttribute(typeof(XImagesView), typeof(XImagesViewRenderer))]
namespace Sagua.App.Controls.iOS
{ 
	public class XImagesViewRenderer : BoxRenderer
	{
		private UIScrollView mScrollView; 
		public int CurrentPageIndex { get; private set; }
		private XImagesView SourceModel{get{ return this.Model as XImagesView;}}
		private Queue<ZoomImageView> mCacheViews = new Queue<ZoomImageView> ();
		private Dictionary<int,ZoomImageView> mShowingViews = new Dictionary<int, ZoomImageView>();

		public XImagesViewRenderer ()
		{  
			CurrentPageIndex = 0;
		}

		void InitViews ()
		{
			mScrollView = new UIScrollView (){BackgroundColor = UIColor.Black,PagingEnabled = true,
				ShowsHorizontalScrollIndicator = false, ShowsVerticalScrollIndicator = false ,	Bounces = false  
			};  

			mScrollView.Scrolled += (object sender, EventArgs e) => {
				var lastPage = CurrentPageIndex;
				CurrentPageIndex = (int)Math.Floor (mScrollView.ContentOffset.X / mScrollView.Bounds.Width + 0.5); 
				if(lastPage != CurrentPageIndex)
				{
					if(lastPage < CurrentPageIndex)
					{
						UnLoadPage(lastPage -1);
						LoadPage(CurrentPageIndex + 1);
					}
					else
					{
						UnLoadPage(lastPage +1);
						LoadPage(CurrentPageIndex - 1);
					}
				}
			};


			AddSubview (mScrollView);
			LoadPages ();
		}

		void LoadPages(){
			if (SourceModel.Images == null || SourceModel.Images.Count <= 0)
				return;
			ResetScrollView ();
			LoadPage (CurrentPageIndex - 1);
			LoadPage (CurrentPageIndex);
			LoadPage (CurrentPageIndex + 1);

		}

		void UnLoadPage(int index)
		{
			if (index < 0 || index >= SourceModel.Images.Count)
				return;
			var view = mShowingViews [index];
			view.MovedToSuperview ();
			this.mCacheViews.Enqueue (view);
			this.mShowingViews.Remove (index);
		}

		private RectangleF FrameOfPage(int index)
		{
			var startPoint = new PointF ((this.Frame.Width ) * index , 0f);
			var frame = new RectangleF (startPoint, this.Frame.Size); 
			return frame;
		}

		void LoadPage(int index)
		{
			if (index < 0 || index >= SourceModel.Images.Count)
				return;
			var view = CreateOrGetCachePageView (SourceModel.Images[index]);
			view.StartLoadImage ();
			LoadImage (index);
			view.Frame = FrameOfPage (index);
			this.mShowingViews.Add (index, view);
			this.mScrollView.AddSubview (view); 
		}
		 
		ZoomImageView  CreateOrGetCachePageView(ImageInfo imageInfo)
		{
			var view = this.mCacheViews.Count > 0 ? this.mCacheViews.Dequeue () : new ZoomImageView ();					 
			return view;
		}

		async  void LoadImage(int index)
		{
			var imgLoader = new  ImageLoaderSourceHandler ();
			var img  = await  imgLoader.LoadImageAsync (new UriImageSource (){ Uri = new Uri ( this.SourceModel.Images[index].Url ) }) ;
			var view = this.mShowingViews [index];
			if (view != null) {
				view.SetImage (img, this.SourceModel.Images[index].Info );
			}
		}
		 
		protected override void OnModelSet (VisualElement model)
		{
			base.OnModelSet (model);
			InitViews ();		
		}
		public override void LayoutSubviews ()
		{
			base.LayoutSubviews ();
			var rect = new RectangleF (0, 0, Frame.Width, Frame.Height);
			mScrollView.Frame = rect;
			ResetScrollView ();
			foreach (var item in this.mShowingViews ) {
				item.Value.Frame = FrameOfPage (item.Key);
			}
			ScrollToPage (CurrentPageIndex);
		}

		private void ScrollToPage(int index)
		{
			var point = new PointF ();
			point.Y = 0;
			point.X = (this.Frame.Width ) * index   ; 
			mScrollView.ContentOffset = point;
		}

		private void ResetScrollView()
		{
			if (SourceModel.Images == null || SourceModel.Images.Count <= 0) {
				mScrollView.ContentSize = SizeF.Empty;
				return;
			}
			mScrollView.ContentSize = new SizeF (SourceModel.Images.Count * this.Frame.Width, this.Frame.Height);
		}

		protected override void OnHandlePropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
		{
			base.OnHandlePropertyChanged(sender, e);

			if (e.PropertyName == XImagesView.ImagesProperty .PropertyName  ) {
				ResetScrollView ();
			}
		}
 
	}
}

