using System;
using Xamarin.Forms;
using System.Windows.Input;

namespace Sagua.App.Controls
{

	public class XViewCell : ViewCell
	{
		public static readonly BindableProperty CommandProperty = 
			BindableProperty.Create<XViewCell,Command> (
				p => p.Command, null);

		public Command Command {
			get { return (Command)GetValue (CommandProperty); }
			set { SetValue (CommandProperty, value); }
		}
		protected override void OnTapped ()
		{
			base.OnTapped ();
			if (Command != null) {
				Command.Execute (this.BindingContext);
			}
		}
	}
}
