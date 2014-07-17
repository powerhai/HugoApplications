using System;
using System.Drawing;
using MonoTouch.ObjCRuntime; 
using MonoTouch.UIKit;
using MonoTouch.Foundation;  

namespace BindingQQLibrary
{

	[BaseType (typeof (NSObject))]
	public partial interface APIResponse {

		[Export ("detailRetCode")]
		int DetailRetCode { get; set; }

		[Export ("retCode")]
		int RetCode { get; set; }

		[Export ("seq")]
		int Seq { get; set; }

		[Export ("errorMsg", ArgumentSemantic.Retain)]
		string ErrorMsg { get; set; }

		[Export ("jsonResponse", ArgumentSemantic.Retain)]
		NSDictionary JsonResponse { get; set; }

		[Export ("message", ArgumentSemantic.Retain)]
		string Message { get; set; }

		[Export ("userData", ArgumentSemantic.Retain)]
		NSObject UserData { get; set; }

		[Field ("PARAM_USER_DATA", "__Internal")]
		NSString PARAM_USER_DATA { get; }

		[Field ("PARAM_APP_ICON", "__Internal")]
		NSString PARAM_APP_ICON { get; }

		[Field ("PARAM_APP_DESC", "__Internal")]
		NSString PARAM_APP_DESC { get; }

		[Field ("PARAM_APP_INVITED_OPENIDS", "__Internal")]
		NSString PARAM_APP_INVITED_OPENIDS { get; }

		[Field ("PARAM_SENDSTORY_RECEIVER", "__Internal")]
		NSString PARAM_SENDSTORY_RECEIVER { get; }

		[Field ("PARAM_SENDSTORY_TITLE", "__Internal")]
		NSString PARAM_SENDSTORY_TITLE { get; }

		[Field ("PARAM_SENDSTORY_COMMENT", "__Internal")]
		NSString PARAM_SENDSTORY_COMMENT { get; }

		[Field ("PARAM_SENDSTORY_SUMMARY", "__Internal")]
		NSString PARAM_SENDSTORY_SUMMARY { get; }

		[Field ("PARAM_SENDSTORY_IMAGE", "__Internal")]
		NSString PARAM_SENDSTORY_IMAGE { get; }

		[Field ("PARAM_SENDSTORY_URL", "__Internal")]
		NSString PARAM_SENDSTORY_URL { get; }

		[Field ("PARAM_SENDSTORY_ACT", "__Internal")]
		NSString PARAM_SENDSTORY_ACT { get; }

		[Field ("PARAM_SETUSERHEAD_PIC", "__Internal")]
		NSString PARAM_SETUSERHEAD_PIC { get; }

		[Field ("PARAM_SETUSERHEAD_FILENAME", "__Internal")]
		NSString PARAM_SETUSERHEAD_FILENAME { get; }

		[Field ("PARAM_RETCODE", "__Internal")]
		NSString PARAM_RETCODE { get; }

		[Field ("PARAM_MESSAGE", "__Internal")]
		NSString PARAM_MESSAGE { get; }

		[Field ("PARAM_DATA", "__Internal")]
		NSString PARAM_DATA { get; }

		[Field ("TCOpenSDKErrorKeyExtraInfo", "__Internal")]
		NSString TCOpenSDKErrorKeyExtraInfo { get; }

		[Field ("TCOpenSDKErrorKeyRetCode", "__Internal")]
		NSString TCOpenSDKErrorKeyRetCode { get; }

		[Field ("TCOpenSDKErrorKeyMsg", "__Internal")]
		NSString TCOpenSDKErrorKeyMsg { get; }

		[Field ("TCOpenSDKErrorMsgUnsupportedAPI", "__Internal")]
		NSString TCOpenSDKErrorMsgUnsupportedAPI { get; }

		[Field ("TCOpenSDKErrorMsgSuccess", "__Internal")]
		NSString TCOpenSDKErrorMsgSuccess { get; }

		[Field ("TCOpenSDKErrorMsgUnknown", "__Internal")]
		NSString TCOpenSDKErrorMsgUnknown { get; }

		[Field ("TCOpenSDKErrorMsgUserCancel", "__Internal")]
		NSString TCOpenSDKErrorMsgUserCancel { get; }

		[Field ("TCOpenSDKErrorMsgReLogin", "__Internal")]
		NSString TCOpenSDKErrorMsgReLogin { get; }

		[Field ("TCOpenSDKErrorMsgOperationDeny", "__Internal")]
		NSString TCOpenSDKErrorMsgOperationDeny { get; }

		[Field ("TCOpenSDKErrorMsgNetwork", "__Internal")]
		NSString TCOpenSDKErrorMsgNetwork { get; }

		[Field ("TCOpenSDKErrorMsgURL", "__Internal")]
		NSString TCOpenSDKErrorMsgURL { get; }

		[Field ("TCOpenSDKErrorMsgDataParse", "__Internal")]
		NSString TCOpenSDKErrorMsgDataParse { get; }

		[Field ("TCOpenSDKErrorMsgParam", "__Internal")]
		NSString TCOpenSDKErrorMsgParam { get; }

		[Field ("TCOpenSDKErrorMsgTimeout", "__Internal")]
		NSString TCOpenSDKErrorMsgTimeout { get; }

		[Field ("TCOpenSDKErrorMsgSecurity", "__Internal")]
		NSString TCOpenSDKErrorMsgSecurity { get; }

		[Field ("TCOpenSDKErrorMsgIO", "__Internal")]
		NSString TCOpenSDKErrorMsgIO { get; }

		[Field ("TCOpenSDKErrorMsgServer", "__Internal")]
		NSString TCOpenSDKErrorMsgServer { get; }

		[Field ("TCOpenSDKErrorMsgWebPage", "__Internal")]
		NSString TCOpenSDKErrorMsgWebPage { get; }

		[Field ("TCOpenSDKErrorMsgUserHeadPicLarge", "__Internal")]
		NSString TCOpenSDKErrorMsgUserHeadPicLarge { get; }
	}


	[BaseType (typeof (NSMutableDictionary))]
	public partial interface TCAPIRequest {

		[Export ("apiURL")]
		NSUrl ApiURL { get; }

		[Export ("method")]
		string Method { get; }

		[Export ("paramUserData", ArgumentSemantic.Retain)]
		NSObject ParamUserData { get; set; }

		[Export ("response")]
		APIResponse Response { get; }

		[Export ("cancel")]
		void Cancel ();
	}

	[Model, BaseType (typeof (NSObject))]
	public partial interface TCAPIRequestDelegate {

		[Export ("cgiRequest:didResponse:")]
		void DidResponse (TCAPIRequest request, APIResponse response);
	}

	[BaseType (typeof (TCAPIRequest))]
	public partial interface TCAddTopicDic {

		[Static, Export ("dictionary") ]
		TCAddTopicDic Dictionary { get; }

		[Export ("paramRichtype", ArgumentSemantic.Retain)]
		string ParamRichtype { get; set; }

		[Export ("paramRichval", ArgumentSemantic.Retain)]
		string ParamRichval { get; set; }

		[Export ("paramCon", ArgumentSemantic.Retain)]
		string ParamCon { get; set; }

		[Export ("paramLbs_nm", ArgumentSemantic.Retain)]
		string ParamLbs_nm { get; set; }

		[Export ("paramLbs_x", ArgumentSemantic.Retain)]
		string ParamLbs_x { get; set; }

		[Export ("paramLbs_y", ArgumentSemantic.Retain)]
		string ParamLbs_y { get; set; }

		[Export ("paramThirdSource", ArgumentSemantic.Retain)]
		string ParamThirdSource { get; set; }
	}

	[BaseType (typeof (TCAPIRequest))]
	public partial interface TCAddOneBlogDic {

		[Static, Export ("dictionary") ]
		TCAddOneBlogDic Dictionary { get; }

		[Export ("paramTitle", ArgumentSemantic.Retain)]
		string ParamTitle { get; set; }

		[Export ("paramContent", ArgumentSemantic.Retain)]
		string ParamContent { get; set; }
	}

	[BaseType (typeof (TCAPIRequest))]
	public partial interface TCAddAlbumDic {

		[Static, Export ("dictionary") ]
		TCAddAlbumDic Dictionary { get; }

		[Export ("paramAlbumname", ArgumentSemantic.Retain)]
		string ParamAlbumname { get; set; }

		[Export ("paramAlbumdesc", ArgumentSemantic.Retain)]
		string ParamAlbumdesc { get; set; }

		[Export ("paramPriv", ArgumentSemantic.Retain)]
		string ParamPriv { get; set; }

		[Export ("paramQuestion", ArgumentSemantic.Retain)]
		string ParamQuestion { get; set; }

		[Export ("paramAnswer", ArgumentSemantic.Retain)]
		string ParamAnswer { get; set; }
	}

	[BaseType (typeof (TCAPIRequest))]
	public partial interface TCUploadPicDic {

		[Static, Export ("dictionary") ]
		TCUploadPicDic Dictionary { get; }

		[Export ("paramPhotodesc", ArgumentSemantic.Retain)]
		string ParamPhotodesc { get; set; }

		[Export ("paramTitle", ArgumentSemantic.Retain)]
		string ParamTitle { get; set; }

		[Export ("paramAlbumid", ArgumentSemantic.Retain)]
		string ParamAlbumid { get; set; }

		[Export ("paramMobile", ArgumentSemantic.Assign)]
		string ParamMobile { get; set; }

		[Export ("paramX", ArgumentSemantic.Retain)]
		string ParamX { get; set; }

		[Export ("paramY", ArgumentSemantic.Retain)]
		string ParamY { get; set; }

		[Export ("paramPicture", ArgumentSemantic.Retain)]
		UIImage ParamPicture { get; set; }

		[Export ("paramNeedfeed", ArgumentSemantic.Assign)]
		string ParamNeedfeed { get; set; }

		[Export ("paramSuccessnum", ArgumentSemantic.Assign)]
		string ParamSuccessnum { get; set; }

		[Export ("paramPicnum", ArgumentSemantic.Assign)]
		string ParamPicnum { get; set; }
	}

	[BaseType (typeof (TCAPIRequest))]
	public partial interface TCAddShareDic {

		[Static, Export ("dictionary") ]
		TCAddShareDic Dictionary { get; }

		[Export ("paramTitle", ArgumentSemantic.Retain)]
		string ParamTitle { get; set; }

		[Export ("paramUrl", ArgumentSemantic.Retain)]
		string ParamUrl { get; set; }

		[Export ("paramComment", ArgumentSemantic.Retain)]
		string ParamComment { get; set; }

		[Export ("paramSummary", ArgumentSemantic.Retain)]
		string ParamSummary { get; set; }

		[Export ("paramImages", ArgumentSemantic.Retain)]
		string ParamImages { get; set; }

		[Export ("paramType", ArgumentSemantic.Retain)]
		string ParamType { get; set; }

		[Export ("paramPlayurl", ArgumentSemantic.Retain)]
		string ParamPlayurl { get; set; }

		[Export ("paramSite", ArgumentSemantic.Retain)]
		string ParamSite { get; set; }

		[Export ("paramFromurl", ArgumentSemantic.Retain)]
		string ParamFromurl { get; set; }

		[Export ("paramNswb", ArgumentSemantic.Retain)]
		string ParamNswb { get; set; }
	}

	[BaseType (typeof (TCAPIRequest))]
	public partial interface TCCheckPageFansDic {

		[Static, Export ("dictionary") ]
		TCCheckPageFansDic Dictionary { get; }

		[Export ("paramPage_id", ArgumentSemantic.Retain)]
		string ParamPage_id { get; set; }
	}

	[BaseType (typeof (TCAPIRequest))]
	public partial interface TCSetUserHeadpic {

		[Static, Export ("dictionary") ]
		TCSetUserHeadpic Dictionary { get; }

		[Export ("paramImage", ArgumentSemantic.Retain)]
		UIImage ParamImage { get; set; }

		[Export ("paramFileName", ArgumentSemantic.Retain)]
		string ParamFileName { get; set; }
	}

	[BaseType (typeof (TCAPIRequest))]
	public partial interface TCListPhotoDic {

		[Static, Export ("dictionary") ]
		TCListPhotoDic Dictionary { get; }

		[Export ("paramAlbumid", ArgumentSemantic.Retain)]
		string ParamAlbumid { get; set; }
	}

	[BaseType (typeof (TCAPIRequest))]
	public partial interface TCMatchNickTipsDic {

		[Static, Export ("dictionary") ]
		TCMatchNickTipsDic Dictionary { get; }

		[Export ("paramMatch", ArgumentSemantic.Retain)]
		string ParamMatch { get; set; }

		[Export ("paramReqnum", ArgumentSemantic.Retain)]
		string ParamReqnum { get; set; }
	}

	[BaseType (typeof (TCAPIRequest))]
	public partial interface TCGetIntimateFriendsDic {

		[Static, Export ("dictionary") ]
		TCGetIntimateFriendsDic Dictionary { get; }

		[Export ("paramReqnum", ArgumentSemantic.Retain)]
		string ParamReqnum { get; set; }
	}

	[BaseType (typeof (TCAPIRequest))]
	public partial interface TCSendStoryDic {

		[Static, Export ("dictionary") ]
		TCSendStoryDic Dictionary { get; }

		[Export ("paramTitle", ArgumentSemantic.Retain)]
		string ParamTitle { get; set; }

		[Export ("paramSummary", ArgumentSemantic.Retain)]
		string ParamSummary { get; set; }

		[Export ("paramDescription", ArgumentSemantic.Retain)]
		string ParamDescription { get; set; }

		[Export ("paramPics", ArgumentSemantic.Retain)]
		string ParamPics { get; set; }

		[Export ("paramAct", ArgumentSemantic.Retain)]
		string ParamAct { get; set; }

		[Export ("paramShareUrl", ArgumentSemantic.Retain)]
		string ParamShareUrl { get; set; }
	}

	//	[BaseType (typeof (WeiBo_baseRequest))]
	//	public partial interface WeiBo_add_t_POST {
	//
	//		[Export ("param_content", ArgumentSemantic.Retain)]
	//		string Param_content { get; set; }
	//
	//		[Export ("param_clientip", ArgumentSemantic.Retain)]
	//		string Param_clientip { get; set; }
	//
	//		[Export ("param_longitude", ArgumentSemantic.Retain)]
	//		string Param_longitude { get; set; }
	//
	//		[Export ("param_latitude", ArgumentSemantic.Retain)]
	//		string Param_latitude { get; set; }
	//
	//		[Export ("param_compatibleflag", ArgumentSemantic.Retain)]
	//		string Param_compatibleflag { get; set; }
	//	}
	//
	//	[BaseType (typeof (WeiBo_add_t_POST))]
	//	public partial interface WeiBo_add_pic_t_POST {
	//
	//		[Export ("param_pic", ArgumentSemantic.Retain)]
	//		UIImage Param_pic { get; set; }
	//	}

	[Model]
	public partial interface TCAPIRequestUploadDelegate : TCAPIRequestDelegate {

		[Export ("cgiUploadRequest:shouldBeginUploadingStorageRequest:")]
		bool ShouldBeginUploadingStorageRequest (TCAPIRequest uploadRequest, NSUrlRequest storageRequest);
	}

	[Model]
	public partial interface TCAPIRequestDownloadDelegate : TCAPIRequestDelegate {

		[Export ("cgiDownloadRequest:shouldBeginDownloadingStorageRequest:")]
		bool ShouldBeginDownloadingStorageRequest (TCAPIRequest downloadRequest, NSUrlRequest storageRequest);
	}
	//
	//	[BaseType (typeof (WeiYun_BaseRequest))]
	//	public partial interface WeiYun_upload_photo_GET {
	//
	//		[Export ("param_sha", ArgumentSemantic.Retain)]
	//		string Param_sha { get; set; }
	//
	//		[Export ("param_md5", ArgumentSemantic.Retain)]
	//		string Param_md5 { get; set; }
	//
	//		[Export ("param_size", ArgumentSemantic.Retain)]
	//		string Param_size { get; set; }
	//
	//		[Export ("param_name", ArgumentSemantic.Retain)]
	//		string Param_name { get; set; }
	//
	//		[Export ("param_upload_type", ArgumentSemantic.Retain)]
	//		string Param_upload_type { get; set; }
	//
	//		[Export ("paramUploadData", ArgumentSemantic.Retain)]
	//		NSData ParamUploadData { get; set; }
	//	}
	//
	//	[BaseType (typeof (WeiYun_BaseRequest))]
	//	public partial interface WeiYun_download_photo_GET {
	//
	//		[Export ("param_file_id", ArgumentSemantic.Retain)]
	//		string Param_file_id { get; set; }
	//	}
	//
	//	[BaseType (typeof (WeiYun_BaseRequest))]
	//	public partial interface WeiYun_get_photo_list_GET {
	//
	//		[Export ("param_offset", ArgumentSemantic.Retain)]
	//		string Param_offset { get; set; }
	//
	//		[Export ("param_number", ArgumentSemantic.Retain)]
	//		string Param_number { get; set; }
	//	}
	//
	//	[BaseType (typeof (WeiYun_BaseRequest))]
	//	public partial interface WeiYun_delete_photo_GET {
	//
	//		[Export ("param_file_id", ArgumentSemantic.Retain)]
	//		string Param_file_id { get; set; }
	//	}

	//	[BaseType (typeof (WeiYun_download_photo_GET))]
	//	public partial interface WeiYun_get_photo_thumb_GET {
	//
	//		[Export ("param_thumb", ArgumentSemantic.Retain)]
	//		string Param_thumb { get; set; }
	//	}
	//
	//	[BaseType (typeof (WeiYun_BaseRequest))]
	//	public partial interface WeiYun_check_record_GET {
	//
	//		[Export ("param_key", ArgumentSemantic.Retain)]
	//		string Param_key { get; set; }
	//	}
	//
	//	[BaseType (typeof (WeiYun_BaseRequest))]
	//	public partial interface WeiYun_create_record_POST {
	//
	//		[Export ("param_key", ArgumentSemantic.Retain)]
	//		string Param_key { get; set; }
	//
	//		[Export ("param_value", ArgumentSemantic.Retain)]
	//		NSData Param_value { get; set; }
	//	}

	[BaseType (typeof (NSObject))]
	public partial interface TencentOAuth : IUIWebViewDelegate
	{
		
				[Export ("accessToken", ArgumentSemantic.Copy)]
				string AccessToken { get; set; }
		
				[Export ("expirationDate", ArgumentSemantic.Copy)]
				NSDate ExpirationDate { get; set; }
		
				[Export ("sessionDelegate", ArgumentSemantic.Assign)]
				TencentSessionDelegate SessionDelegate { get; set; }
		
				[Export ("localAppId", ArgumentSemantic.Copy)]
				string LocalAppId { get; set; }
		
				[Export ("openId", ArgumentSemantic.Copy)]
				string OpenId { get; set; }
		
		[Export ("redirectURI", ArgumentSemantic.Copy)]
		string RedirectURI { get; set; }
		
				[Export ("appId", ArgumentSemantic.Retain)]
				string AppId { get; set; }
		
		[Export ("initWithAppId:andDelegate:")]
		IntPtr Constructor (string appId, TencentSessionDelegate delegatec);
		
				[Static, Export ("iphoneQQInstalled") ]
				bool IphoneQQInstalled { get; }
		
				[Static, Export ("iphoneQQSupportSSOLogin") ]
				bool IphoneQQSupportSSOLogin { get; }
		
				[Static, Export ("iphoneQZoneInstalled") ]
				bool IphoneQZoneInstalled { get; }
		
				[Static, Export ("iphoneQZoneSupportSSOLogin") ]
				bool IphoneQZoneSupportSSOLogin { get; }
		
				[Static, Export ("HandleOpenURL:")]
				bool HandleOpenURL (NSUrl url);
		
				[Static, Export ("CanHandleOpenURL:")]
				bool CanHandleOpenURL (NSUrl url);

		[Export ("authorize:")]
		bool Authorize (  NSObject [] permissions);

		[Export ("authorize:inSafari:")]
		bool Authorize (  NSArray permissions, bool bInSafari);


		[Export ("authorize:localAppId:inSafari:")]
		bool Authorize ( NSArray permissions, string localAppId, bool bInSafari);
		
				[Export ("incrAuthWithPermissions:")]
				bool IncrAuthWithPermissions (  NSObject [] permissions);
		
				[Export ("reauthorizeWithPermissions:")]
				bool ReauthorizeWithPermissions (  NSObject [] permissions);
		
				[Export ("logout:")]
				void Logout (TencentSessionDelegate delegatec);
		
				[Export ("isSessionValid") ]
				bool IsSessionValid { get; }
		
				[Export ("getUserInfo") ]
		bool GetUserInfo ();
		
				[Export ("getListAlbum") ]
				bool GetListAlbum { get; }
		
				[Export ("getListPhotoWithParams:")]
				bool GetListPhotoWithParams (NSMutableDictionary paramsc);
		
				[Export ("uploadPicWithParams:")]
				bool UploadPicWithParams (NSMutableDictionary paramsc);
		
				[Export ("addAlbumWithParams:")]
				bool AddAlbumWithParams (NSMutableDictionary paramsc);
		
				[Export ("checkPageFansWithParams:")]
				bool CheckPageFansWithParams (NSMutableDictionary paramsc);
		
				[Export ("sendAPIJS:key:")]
				bool SendAPIJS (NSMutableDictionary paramsc, string JSkey);
		
				[Export ("getVipInfo") ]
				bool GetVipInfo { get; }
		
				[Export ("getVipRichInfo") ]
				bool GetVipRichInfo { get; }
		
				[Export ("matchNickTips:")]
				bool MatchNickTips (NSMutableDictionary paramsc);
		
				[Export ("getIntimateFriends:")]
				bool GetIntimateFriends (NSMutableDictionary paramsc);
		
				[Export ("cancel:")]
				bool Cancel (NSObject userData);
		
				[Export ("setUserHeadpic:")]
				bool SetUserHeadpic (NSMutableDictionary paramsc);
		
				[Export ("setUserHeadpic:andViewController:")]
				bool SetUserHeadpic (NSMutableDictionary paramsc, out UIViewController viewController);
		
				[Export ("sendStory:friendList:")]
				bool SendStory (NSMutableDictionary paramsc , NSObject [] fopenIdArray);
		
				[Export ("sendAppInvitationWithDescription:imageURL:source:")]
				bool SendAppInvitationWithDescription (string desc, string imageUrl, string source);
		
				[Export ("sendChallenge:type:imageURL:message:source:")]
				bool SendChallenge (string receiver, string type, string imageUrl, string message, string source);
		
				[Export ("sendGiftRequest:exclude:specified:only:type:title:message:imageURL:source:")]
				bool SendGiftRequest (string receiver, string exclude, string specified, bool only, string type, string title, string message, string imageUrl, string source);
		
				[Export ("cgiRequestWithURL:method:params:callback:")]
				TCAPIRequest CgiRequestWithURL (NSUrl apiURL, string method, NSDictionary paramsc, TCAPIRequestDelegate callback);
		
				[Export ("sendAPIRequest:callback:")]
				bool SendAPIRequest (TCAPIRequest request, TCAPIRequestDelegate callback);
		
	}

	[Model, BaseType (typeof (NSObject))]
	public partial interface TencentLoginDelegate {

		[Export ("tencentDidLogin")]
		void TencentDidLogin ();

		[Export ("tencentDidNotLogin:")]
		void  tencentDidNotLogin(bool cancelled);

		[Export ("tencentDidNotNetWork")]
		void TencentDidNotNetWork ();

		[Export ("getAuthorizedPermissions:withExtraParams:") ]
		NSObject [] WithExtraParams (  NSObject [] permissions, NSDictionary extraParams);
	}

	[BaseType (typeof (NSObject))]
	public partial interface TencentApiReq {

		[Static, Export ("reqFromSeq:type:")]
		TencentApiReq ReqFromSeq (int apiSeq, TencentReqMessageType type);

		[Export ("nMessageType")]
		int NMessageType { get; }

		[Export ("nPlatform")]
		int NPlatform { get; }

		[Export ("nSdkVersion")]
		int NSdkVersion { get; }

		[Export ("nSeq")]
		int NSeq { get; }

		[Export ("sAppID", ArgumentSemantic.Retain)]
		string SAppID { get; set; }

		[Export ("arrMessage", ArgumentSemantic.Retain) ]
		NSObject [] ArrMessage { get; set; }

		[Export ("sDescription", ArgumentSemantic.Retain)]
		string SDescription { get; set; }
	}

	[BaseType (typeof (NSObject))]
	public partial interface TencentApiResp {

		[Static, Export ("respFromReq:")]
		TencentApiResp RespFromReq (TencentApiReq req);

		[Export ("nRetCode")]
		int NRetCode { get; set; }

		[Export ("sRetMsg", ArgumentSemantic.Retain)]
		string SRetMsg { get; set; }

		[Export ("objReq", ArgumentSemantic.Retain)]
		TencentApiReq ObjReq { get; set; }
	}

	[Model, BaseType (typeof (NSObject))]
	public partial interface TencentApiInterfaceDelegate {

		[Export ("onTencentReq:")]
		bool  onTencentReq(TencentApiReq req);

		[Export ("onTencentResp:")]
		bool  onTencentResp(TencentApiResp resp);
	}

	[Model, BaseType (typeof (NSObject))]
	public partial interface TencentSessionDelegate : TencentLoginDelegate , TencentApiInterfaceDelegate 
	{

		[Export ("tencentDidLogout")]
		void TencentDidLogout ();

		[Export ("tencentNeedPerformIncrAuth:withPermissions:")]
		bool WithPermissions (TencentOAuth tencentOAuth,  NSObject [] permissions);

		[Export ("tencentNeedPerformReAuth:")]
		bool  tencentNeedPerformReAuth(TencentOAuth tencentOAuth);

		[Export ("tencentDidUpdate:")]
		void  tencentDidUpdate(TencentOAuth tencentOAuth);

		[Export ("tencentFailedUpdate:")]
		void  tencentFailedUpdate(UpdateFailType reason);

		[Export ("getUserInfoResponse:")]
		void  getUserInfoResponse(APIResponse response);

		[Export ("getListAlbumResponse:")]
		void  getListAlbumResponse(APIResponse response);

		[Export ("getListPhotoResponse:")]
		void  getListPhotoResponse(APIResponse response);

		[Export ("checkPageFansResponse:")]
		void  checkPageFansResponse(APIResponse response);

		[Export ("addShareResponse:")]
		void  addShareResponse(APIResponse response);

		[Export ("addAlbumResponse:")]
		void  addAlbumResponse(APIResponse response);

		[Export ("uploadPicResponse:")]
		void  uploadPicResponse(APIResponse response);

		[Export ("addTopicResponse:")]
		void  addTopicResponse(APIResponse response);

		[Export ("getVipInfoResponse:")]
		void  getVipInfoResponse(APIResponse response);

		[Export ("getVipRichInfoResponse:")]
		void  getVipRichInfoResponse(APIResponse response);

		[Export ("matchNickTipsResponse:")]
		void  matchNickTipsResponse(APIResponse response);

		[Export ("getIntimateFriendsResponse:")]
		void  getIntimateFriendsResponse(APIResponse response);

		[Export ("userHeadpicResponse")]
		APIResponse UserHeadpicResponse { set; }

		[Export ("sendStoryResponse:")]
		void  sendStoryResponse(APIResponse response);

		[Export ("responseDidReceived:forMessage:")]
		void ForMessage (APIResponse response, string message);

		[Export ("tencentOAuth:didSendBodyData:totalBytesWritten:totalBytesExpectedToWrite:userData:")]
		void DidSendBodyData (TencentOAuth tencentOAuth, int bytesWritten, int totalBytesWritten, int totalBytesExpectedToWrite, NSObject userData);

		[Export ("tencentOAuth:doCloseViewController:")]
		void DoCloseViewController (TencentOAuth tencentOAuth, UIViewController viewController);
	}
}

