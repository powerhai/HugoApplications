using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS; 
using MonoTouch.UIKit;
using Sagua.App.Controls;
using Sagua.App.Controls.iOS;

[assembly:ExportRendererAttribute(typeof(XListView), typeof(XListViewRenderer))]
namespace Sagua.App.Controls.iOS
{
	public class XListViewRenderer : ListViewRenderer
	{
		public XListViewRenderer ()
		{
		}

		private LoadMoreView loadMoreView;
		private FormsUIRefreshControl refreshControl;

		protected override void OnModelSet(VisualElement model)
		{
			base.OnModelSet(model);
 
			var xListView = (XListView)this.Model;
			var tableView = (UITableView) this.Control;
			if (xListView.LoadmoreCommand != null) {
				loadMoreView = new LoadMoreView ();
				loadMoreView.SetHandleScrollView (tableView as UIScrollView);
				loadMoreView.LoadmoreCommand = xListView.LoadmoreCommand;
			}
			if (xListView.RefreshCommand != null) {
				refreshControl = new FormsUIRefreshControl ();
				refreshControl.RefreshCommand = xListView.RefreshCommand;
				tableView.AddSubview (refreshControl);
			}


		}


		/// <summary>
		/// Called when the underlying model's properties are changed
		/// </summary>
		/// <param name="sender">Model</param>
		/// <param name="e">Event arguments</param>
		protected override void OnHandlePropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
		{
			base.OnHandlePropertyChanged(sender, e);
			 
		}
	}
}

