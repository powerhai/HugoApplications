using System;
using Sagua.App.Common;
using Xamarin.Forms;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace Sagua.App.Core
{
	public class GroupListViewModel : BaseViewModel 
	{
		public ObservableCollection<DoctorGroup> Doctors  { get; set; }

		public GroupListViewModel (Page page): base(page)
		{
			Doctors = new ObservableCollection<DoctorGroup> ();
			Doctors.Add (new DoctorGroup (){ GroupTitle = "助理医生" });
			Doctors.Add (new DoctorGroup (){ GroupTitle = "执业医生"});

			foreach (var item in Doctors) {
				for (var i = 0; i < 5; i++) {
					item.Add (new Doctor (){ Name = "hai" + DateTime.Now.ToString() , ImageUrl = "http://www.baidu.com/img/baidu_jgylogo3.gif?v=04876784.gif" });
				}
			}
		}
		 
	}
}

