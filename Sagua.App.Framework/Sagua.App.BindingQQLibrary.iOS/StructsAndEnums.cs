using System;

namespace BindingQQLibrary
{

	public enum REPONSE_RESULT {
		URLREQUEST_SUCCEED = 0,
		URLREQUEST_FAILED = 1
	}

	public enum UpdateFailType  {
		Unknown = 1,
		UserCancel,
		Network
	}


	public enum OpenSDKError   {
		Invalid = -1,
		UnsupportedAPI = -2,
		Success = 0,
		Unknown,
		UserCancel,
		ReLogin,
		OperationDeny,
		Network,
		URL,
		DataParse,
		Param,
		ConnTimeout,
		Security,
		IO,
		Server,
		WebPage,
		UserHeadPicLarge = 65536
	}

	public enum TencentReqMessageType  {
		ReqFromTencentAppQueryContent,
		ReqFromTencentAppShowContent,
		ReqFromThirdAppQueryContent,
		ReqFromThirdAppShowContent
	}
}

