using System;
using Xamarin.Forms;

namespace Sagua.App.Controls
{
	public class XListView : ListView
	{

		public static readonly BindableProperty RefreshCommandProperty = 
			BindableProperty.Create<XListView,Command> (
				p => p.RefreshCommand, null);

		public Command RefreshCommand {
			get { return (Command)GetValue (RefreshCommandProperty); }
			set { SetValue (RefreshCommandProperty, value); }
		}

		public static readonly BindableProperty LoadmoreCommandProperty = 
			BindableProperty.Create<XListView,Command> (
				p => p.LoadmoreCommand, null);

		public Command LoadmoreCommand {
			get { return (Command)GetValue (LoadmoreCommandProperty); }
			set { SetValue (LoadmoreCommandProperty, value); }
		}

	}
}

