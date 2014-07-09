using System;
using Xamarin.Forms;

namespace Sagua.App.Controls
{
	public class PullToRefreshListView : ListView
	{
		public PullToRefreshListView ()
		{
		}

		public static readonly BindableProperty RefreshCommandProperty = 
			BindableProperty.Create<PullToRefreshListView,Command> (
				p => p.RefreshCommand, null);

		public Command RefreshCommand {
			get { return (Command)GetValue (RefreshCommandProperty); }
			set { SetValue (RefreshCommandProperty, value); }
		}


	}
}

