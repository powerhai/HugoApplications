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
		EventHandler<ItemTappedEventArgs> mTapped;
		public XListView ()
		{
			mTapped = (sender, e) => { if(Command != null) Command.Execute(e.Item); };
			this.ItemTapped += mTapped;
		}

		public static readonly BindableProperty CommandProperty = 
			BindableProperty.Create<XViewCell,Command> (
				p => p.Command, null);

		public Command Command {
			get { return (Command)GetValue (CommandProperty); }
			set { SetValue (CommandProperty, value); }
		}

	}
}

