using System;
using Xamarin.Forms.Platform.iOS;
using MonoTouch.UIKit;
using Xamarin.Forms;
using Sagua.App.Controls;
using Sagua.App.Controls.iOS;


[assembly:ExportRendererAttribute(typeof(XTableView), typeof(IOSXTableview))]

namespace Sagua.App.Controls.iOS
{
	public class IOSXTableview : TableViewRenderer
	{
		 protected override void OnModelSet (Xamarin.Forms.VisualElement view)
		{
			base.OnModelSet (view); 
			var navmodel = this.Control  as UITableView;
			if(UIDevice.CurrentDevice.CheckSystemVersion (7, 0))
				navmodel.SeparatorInset = UIEdgeInsets.Zero;
			//navmodel.SeparatorStyle = UITableViewCellSeparatorStyle.None;
			navmodel.TableFooterView = new UIView ();
		}
	}
}

