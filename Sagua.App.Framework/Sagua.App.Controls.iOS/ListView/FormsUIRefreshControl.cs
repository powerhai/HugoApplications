using System;
using MonoTouch.UIKit;
using Xamarin.Forms;

namespace Sagua.App.Controls.iOS
{
	public class FormsUIRefreshControl : UIRefreshControl
	{
		public FormsUIRefreshControl()
		{
			this.AttributedTitle = new MonoTouch.Foundation.NSAttributedString("Loading...");

			this.ValueChanged += (object sender, EventArgs e) => 
			{
				var command = RefreshCommand;
				if(command  == null)
					return;
				command.Execute(new Action(()=>{this.EndRefreshing();}));
			};
		}
 

		/// <summary>
		/// Gets or sets the refresh command.
		/// </summary>
		/// <value>The refresh command.</value>
		public Command RefreshCommand { get; set;}
	}
}

