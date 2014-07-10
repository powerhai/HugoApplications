using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Phone.Net.NetworkInformation;
using Microsoft.Phone.Tasks;
using Sagua.App.Components;
using Sagua.App.Components.WinPhone;
using Xamarin.Forms;
[assembly: Dependency(typeof(PhoneService))]
namespace Sagua.App.Components.WinPhone
{
    public class PhoneService : IPhoneService
    {

        #region IPhoneService Members

        public void Call(string name, string number)
        {
            var task = new PhoneCallTask
            {
                DisplayName = name,
                PhoneNumber = number
            };
            task.Show();
        }


        public void Sms(string number, string message)
        {
            var task = new SmsComposeTask
            {
                To = number,
                Body = message
            };
            task.Show();
        }

        #endregion
    }
}
