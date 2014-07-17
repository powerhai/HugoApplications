using System;

namespace Sagua.App.Components
{
	public interface IQQ_OAuth
	{  
		void Login(string appId, QQSessionDelegate dele);
	}

	public interface QQSessionDelegate
	{
		void DidLogin(string openId,string accessToken,DateTime expirationDate);
		void GetUserInfo(string jsonData);
	}
	 
}

