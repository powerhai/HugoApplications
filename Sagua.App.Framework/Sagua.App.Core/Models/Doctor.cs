using System;
using Sagua.App.Common;
using Xamarin.Forms;
using System.Windows.Input;
using System.Collections.ObjectModel;

namespace Sagua.App.Core
{

	public class DoctorGroup : ObservableCollection<Doctor>
	{
		string groupTitle;
		public string GroupTitle {
			get {
				return groupTitle;
			}
			set {
				groupTitle = value;
				 
			}
		}
	}

	public class Doctor : ObservableObject 
	{
		public string Name{get;set;}
		public string ImageUrl{get;set;}
	}

	
}
