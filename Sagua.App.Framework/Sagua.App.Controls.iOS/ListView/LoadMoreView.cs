using System;
using MonoTouch.UIKit;
using MonoTouch.Foundation;
using System.Drawing;
using System.Windows.Input;
using Xamarin.Forms;

namespace Sagua.App.Controls.iOS
{


	public class LoadMoreView : UIView 
	{
		public LoadMoreView ()
		{ 
		}
		private UIScrollView mScrollView;
		public static readonly NSString LoadMoreContentOffset = new NSString("contentOffset");
		public static readonly NSString LoadMoreContentSize = new NSString("contentSize");

		public UIImage ImgPullToLoad{get;set;}
		public UIImage ImgReleaseLoad{ get; set; }
		public UIImage ImgNoMore{ get; set; }
		public string TextPullToLoad{ get; set; }
		public string TextReleaseLoad{ get; set; }
		public string TextNoMore{ get; set; }
		public string TextLoading{ get;set;}
		private UILabel TextLabel{get;set;}
		private UIActivityIndicatorView ActivityView{ get; set; }
		private UIView LeftView{ get; set; }
		private UIImageView ImageView{get;set;}
		private LoadMoreStateType mState{ get; set; }
		private static readonly  float ImageWidth = 25f; 
		private static readonly float ViewHeight = 40f;
		public ICommand LoadmoreCommand{ get; set; }

		public void SetHandleScrollView(UIScrollView scrollView){
			if(mScrollView != null)
				mScrollView.RemoveObserver (this, LoadMoreContentOffset);
			mScrollView = scrollView;
			mScrollView.AddObserver(this,  LoadMoreContentSize, NSKeyValueObservingOptions.New, IntPtr.Zero );
			mScrollView.AddObserver(this,  LoadMoreContentOffset, NSKeyValueObservingOptions.New, IntPtr.Zero );

			this.MovedToSuperview ();
			mScrollView.AddSubview (this);  
			//this.AutoresizingMask = UIViewAutoresizing.FlexibleLeftMargin | UIViewAutoresizing.FlexibleRightMargin;
			InitSubviews ();

		}

		public override void LayoutSubviews ()
		{
			base.LayoutSubviews ();
			var textFrame = TextLabel.Frame;
			var b  = this.Bounds;
			textFrame.X = (this.Frame.Width - textFrame.Width  ) / 2;
			var leftFrame = new RectangleF (textFrame.X - ViewHeight, 0f, ViewHeight, ViewHeight);
			this.TextLabel.Frame = textFrame;
			this.LeftView.Frame = leftFrame;
		}

		private void InitSubviews()
		{
			TextNoMore = "全部加载完了";
			TextReleaseLoad = "释放加载下一页";
			TextPullToLoad = "上拉加载下一页";
			TextLoading = "加载中...";

			ImgNoMore = UIImage.FromFile ("loadmore_nomore.png");
			ImgPullToLoad = UIImage.FromFile ("loadmore_up.png");
			ImgReleaseLoad = UIImage.FromFile ("loadmore_down.png");

			LeftView = new UIView (new RectangleF(0f, 0f, ViewHeight, ViewHeight));			 
			this.AddSubview (LeftView);

			ImageView = new UIImageView (new RectangleF( (ViewHeight - ImageWidth) / 2, (ViewHeight - ImageWidth) / 2,ImageWidth,ImageWidth) );
			ImageView.Image = ImgPullToLoad;
			LeftView.AddSubview (ImageView);

			ActivityView = new UIActivityIndicatorView (new RectangleF (0f, 0f, ViewHeight, ViewHeight));
			ActivityView.ActivityIndicatorViewStyle = UIActivityIndicatorViewStyle.Gray;
			LeftView.AddSubview (ActivityView);

			TextLabel = new UILabel (new RectangleF (ViewHeight, 0f, 120f, ViewHeight));
			TextLabel.Text = TextPullToLoad;
			TextLabel.BackgroundColor = UIColor.Clear;
			TextLabel.Font = UIFont.SystemFontOfSize (UIFont.SmallSystemFontSize);
			TextLabel.TextColor = UIColor.FromRGB(0x66,0x66,0x66);
			TextLabel.TextAlignment = UITextAlignment.Center;
			this.AddSubview (TextLabel);

			SetState (LoadMoreStateType.Normal);
		}

		public void SetState(LoadMoreStateType state )
		{
			if (state == mState)
				return;
			switch (state) {
			case(LoadMoreStateType.Normal):{
					ActivityView.StopAnimating ();
					ImageView.Image = ImgPullToLoad;
					TextLabel.Text = TextPullToLoad;
					break;
				}
			case (LoadMoreStateType.ReadyLoading):
				{
					ImageView.Image = ImgReleaseLoad;
					TextLabel.Text = TextReleaseLoad;
					ActivityView.StopAnimating ();
					break;
				}
			case (LoadMoreStateType.NoMore):
				{
					ImageView.Image = ImgNoMore;
					TextLabel.Text = TextNoMore;
					ActivityView.StopAnimating ();
					break;
				}
			case(LoadMoreStateType.Loading):
				{
					ImageView.Image  = UIImage.FromFile(""); 
					ActivityView.StartAnimating ();
					TextLabel.Text = TextLoading;
					if (LoadmoreCommand != null) {
						LoadmoreCommand.Execute (new Action<bool>(LoadOver) );
					}
					break;
				}

			}
			mState = state;
		} 

		public void LoadOver(bool isAllLoaded)
		{
			if (isAllLoaded) {
				SetState (LoadMoreStateType.NoMore);
			} else {
				SetState (LoadMoreStateType.Normal);
			}
		}

		public override void ObserveValue (NSString keyPath, NSObject ofObject, NSDictionary change, IntPtr context)
		{			
			float contentHeight = mScrollView.ContentSize.Height;
			float scrollHeight = mScrollView.Frame.Size.Height;

			if (keyPath == LoadMoreContentOffset) 
			{			
				if (contentHeight == 0 || contentHeight < scrollHeight || mState == LoadMoreStateType.NoMore)
					return; 

				if (mScrollView.ContentOffset.Y + scrollHeight > mScrollView.ContentSize.Height + 60f) {
					if (mScrollView.Dragging) {	
						if (mState != LoadMoreStateType.Loading)
							SetState (LoadMoreStateType.ReadyLoading);
					} else {
						SetState (LoadMoreStateType.Loading);
					}

				} else {
					if (mState != LoadMoreStateType.Loading)
						SetState (LoadMoreStateType.Normal);
				}

				return;
			}

			if (keyPath == LoadMoreContentSize) {

				if (contentHeight == 0 || contentHeight < scrollHeight) {
					this.Hidden = true;
					return;
				}
				this.Hidden = false;

				this.Frame = new RectangleF (0f, contentHeight, mScrollView.Frame.Width, 60f); 
				var inset = mScrollView.ContentInset;
				if (inset.Bottom == 60f ||  HasSeted == true) {
					HasSeted = true;
					return;
				}
				inset.Bottom += 60f;
				mScrollView.ContentInset = inset;
			}

		}
		private bool HasSeted = false;

	}

}
