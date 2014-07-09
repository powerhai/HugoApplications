using System;

namespace Sagua.App.Components
{
	public interface IPhoneService {

		void Call(string person, string number);
		void Sms(string number, string message); 
	}
}

