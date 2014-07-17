//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected

#pragma warning disable 414

using System;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using MonoTouch.UIKit;
using MonoTouch.GLKit;
using MonoTouch.MapKit;
using MonoTouch.Security;
using MonoTouch.CoreVideo;
using MonoTouch.CoreMedia;
using MonoTouch.QuickLook;
using MonoTouch.Foundation;
using MonoTouch.CoreMotion;
using MonoTouch.ObjCRuntime;
using MonoTouch.CoreGraphics;
using MonoTouch.CoreLocation;
using MonoTouch.NewsstandKit;
using MonoTouch.AVFoundation;
using MonoTouch.CoreAnimation;
using MonoTouch.CoreFoundation;

namespace BindingQQLibrary {
	[Register("TencentOAuth", true)]
	public unsafe partial class TencentOAuth : NSObject, global::MonoTouch.UIKit.IUIWebViewDelegate {
		[CompilerGenerated]
		const string selAccessToken = "accessToken";
		static readonly IntPtr selAccessTokenHandle = Selector.GetHandle ("accessToken");
		[CompilerGenerated]
		const string selAddAlbumWithParams_ = "addAlbumWithParams:";
		static readonly IntPtr selAddAlbumWithParams_Handle = Selector.GetHandle ("addAlbumWithParams:");
		[CompilerGenerated]
		const string selAppId = "appId";
		static readonly IntPtr selAppIdHandle = Selector.GetHandle ("appId");
		[CompilerGenerated]
		const string selAuthorize_ = "authorize:";
		static readonly IntPtr selAuthorize_Handle = Selector.GetHandle ("authorize:");
		[CompilerGenerated]
		const string selAuthorizeInSafari_ = "authorize:inSafari:";
		static readonly IntPtr selAuthorizeInSafari_Handle = Selector.GetHandle ("authorize:inSafari:");
		[CompilerGenerated]
		const string selAuthorizeLocalAppIdInSafari_ = "authorize:localAppId:inSafari:";
		static readonly IntPtr selAuthorizeLocalAppIdInSafari_Handle = Selector.GetHandle ("authorize:localAppId:inSafari:");
		[CompilerGenerated]
		const string selCancel_ = "cancel:";
		static readonly IntPtr selCancel_Handle = Selector.GetHandle ("cancel:");
		[CompilerGenerated]
		const string selCanHandleOpenURL_ = "CanHandleOpenURL:";
		static readonly IntPtr selCanHandleOpenURL_Handle = Selector.GetHandle ("CanHandleOpenURL:");
		[CompilerGenerated]
		const string selCgiRequestWithURLMethodParamsCallback_ = "cgiRequestWithURL:method:params:callback:";
		static readonly IntPtr selCgiRequestWithURLMethodParamsCallback_Handle = Selector.GetHandle ("cgiRequestWithURL:method:params:callback:");
		[CompilerGenerated]
		const string selCheckPageFansWithParams_ = "checkPageFansWithParams:";
		static readonly IntPtr selCheckPageFansWithParams_Handle = Selector.GetHandle ("checkPageFansWithParams:");
		[CompilerGenerated]
		const string selExpirationDate = "expirationDate";
		static readonly IntPtr selExpirationDateHandle = Selector.GetHandle ("expirationDate");
		[CompilerGenerated]
		const string selGetIntimateFriends_ = "getIntimateFriends:";
		static readonly IntPtr selGetIntimateFriends_Handle = Selector.GetHandle ("getIntimateFriends:");
		[CompilerGenerated]
		const string selGetListAlbum = "getListAlbum";
		static readonly IntPtr selGetListAlbumHandle = Selector.GetHandle ("getListAlbum");
		[CompilerGenerated]
		const string selGetListPhotoWithParams_ = "getListPhotoWithParams:";
		static readonly IntPtr selGetListPhotoWithParams_Handle = Selector.GetHandle ("getListPhotoWithParams:");
		[CompilerGenerated]
		const string selGetUserInfo = "getUserInfo";
		static readonly IntPtr selGetUserInfoHandle = Selector.GetHandle ("getUserInfo");
		[CompilerGenerated]
		const string selGetVipInfo = "getVipInfo";
		static readonly IntPtr selGetVipInfoHandle = Selector.GetHandle ("getVipInfo");
		[CompilerGenerated]
		const string selGetVipRichInfo = "getVipRichInfo";
		static readonly IntPtr selGetVipRichInfoHandle = Selector.GetHandle ("getVipRichInfo");
		[CompilerGenerated]
		const string selHandleOpenURL_ = "HandleOpenURL:";
		static readonly IntPtr selHandleOpenURL_Handle = Selector.GetHandle ("HandleOpenURL:");
		[CompilerGenerated]
		const string selIncrAuthWithPermissions_ = "incrAuthWithPermissions:";
		static readonly IntPtr selIncrAuthWithPermissions_Handle = Selector.GetHandle ("incrAuthWithPermissions:");
		[CompilerGenerated]
		const string selInitWithAppIdAndDelegate_ = "initWithAppId:andDelegate:";
		static readonly IntPtr selInitWithAppIdAndDelegate_Handle = Selector.GetHandle ("initWithAppId:andDelegate:");
		[CompilerGenerated]
		const string selIphoneQQInstalled = "iphoneQQInstalled";
		static readonly IntPtr selIphoneQQInstalledHandle = Selector.GetHandle ("iphoneQQInstalled");
		[CompilerGenerated]
		const string selIphoneQQSupportSSOLogin = "iphoneQQSupportSSOLogin";
		static readonly IntPtr selIphoneQQSupportSSOLoginHandle = Selector.GetHandle ("iphoneQQSupportSSOLogin");
		[CompilerGenerated]
		const string selIphoneQZoneInstalled = "iphoneQZoneInstalled";
		static readonly IntPtr selIphoneQZoneInstalledHandle = Selector.GetHandle ("iphoneQZoneInstalled");
		[CompilerGenerated]
		const string selIphoneQZoneSupportSSOLogin = "iphoneQZoneSupportSSOLogin";
		static readonly IntPtr selIphoneQZoneSupportSSOLoginHandle = Selector.GetHandle ("iphoneQZoneSupportSSOLogin");
		[CompilerGenerated]
		const string selIsSessionValid = "isSessionValid";
		static readonly IntPtr selIsSessionValidHandle = Selector.GetHandle ("isSessionValid");
		[CompilerGenerated]
		const string selLocalAppId = "localAppId";
		static readonly IntPtr selLocalAppIdHandle = Selector.GetHandle ("localAppId");
		[CompilerGenerated]
		const string selLogout_ = "logout:";
		static readonly IntPtr selLogout_Handle = Selector.GetHandle ("logout:");
		[CompilerGenerated]
		const string selMatchNickTips_ = "matchNickTips:";
		static readonly IntPtr selMatchNickTips_Handle = Selector.GetHandle ("matchNickTips:");
		[CompilerGenerated]
		const string selOpenId = "openId";
		static readonly IntPtr selOpenIdHandle = Selector.GetHandle ("openId");
		[CompilerGenerated]
		const string selReauthorizeWithPermissions_ = "reauthorizeWithPermissions:";
		static readonly IntPtr selReauthorizeWithPermissions_Handle = Selector.GetHandle ("reauthorizeWithPermissions:");
		[CompilerGenerated]
		const string selRedirectURI = "redirectURI";
		static readonly IntPtr selRedirectURIHandle = Selector.GetHandle ("redirectURI");
		[CompilerGenerated]
		const string selSendAPIJSKey_ = "sendAPIJS:key:";
		static readonly IntPtr selSendAPIJSKey_Handle = Selector.GetHandle ("sendAPIJS:key:");
		[CompilerGenerated]
		const string selSendAPIRequestCallback_ = "sendAPIRequest:callback:";
		static readonly IntPtr selSendAPIRequestCallback_Handle = Selector.GetHandle ("sendAPIRequest:callback:");
		[CompilerGenerated]
		const string selSendAppInvitationWithDescriptionImageURLSource_ = "sendAppInvitationWithDescription:imageURL:source:";
		static readonly IntPtr selSendAppInvitationWithDescriptionImageURLSource_Handle = Selector.GetHandle ("sendAppInvitationWithDescription:imageURL:source:");
		[CompilerGenerated]
		const string selSendChallengeTypeImageURLMessageSource_ = "sendChallenge:type:imageURL:message:source:";
		static readonly IntPtr selSendChallengeTypeImageURLMessageSource_Handle = Selector.GetHandle ("sendChallenge:type:imageURL:message:source:");
		[CompilerGenerated]
		const string selSendGiftRequestExcludeSpecifiedOnlyTypeTitleMessageImageURLSource_ = "sendGiftRequest:exclude:specified:only:type:title:message:imageURL:source:";
		static readonly IntPtr selSendGiftRequestExcludeSpecifiedOnlyTypeTitleMessageImageURLSource_Handle = Selector.GetHandle ("sendGiftRequest:exclude:specified:only:type:title:message:imageURL:source:");
		[CompilerGenerated]
		const string selSendStoryFriendList_ = "sendStory:friendList:";
		static readonly IntPtr selSendStoryFriendList_Handle = Selector.GetHandle ("sendStory:friendList:");
		[CompilerGenerated]
		const string selSessionDelegate = "sessionDelegate";
		static readonly IntPtr selSessionDelegateHandle = Selector.GetHandle ("sessionDelegate");
		[CompilerGenerated]
		const string selSetAccessToken_ = "setAccessToken:";
		static readonly IntPtr selSetAccessToken_Handle = Selector.GetHandle ("setAccessToken:");
		[CompilerGenerated]
		const string selSetAppId_ = "setAppId:";
		static readonly IntPtr selSetAppId_Handle = Selector.GetHandle ("setAppId:");
		[CompilerGenerated]
		const string selSetExpirationDate_ = "setExpirationDate:";
		static readonly IntPtr selSetExpirationDate_Handle = Selector.GetHandle ("setExpirationDate:");
		[CompilerGenerated]
		const string selSetLocalAppId_ = "setLocalAppId:";
		static readonly IntPtr selSetLocalAppId_Handle = Selector.GetHandle ("setLocalAppId:");
		[CompilerGenerated]
		const string selSetOpenId_ = "setOpenId:";
		static readonly IntPtr selSetOpenId_Handle = Selector.GetHandle ("setOpenId:");
		[CompilerGenerated]
		const string selSetRedirectURI_ = "setRedirectURI:";
		static readonly IntPtr selSetRedirectURI_Handle = Selector.GetHandle ("setRedirectURI:");
		[CompilerGenerated]
		const string selSetSessionDelegate_ = "setSessionDelegate:";
		static readonly IntPtr selSetSessionDelegate_Handle = Selector.GetHandle ("setSessionDelegate:");
		[CompilerGenerated]
		const string selSetUserHeadpic_ = "setUserHeadpic:";
		static readonly IntPtr selSetUserHeadpic_Handle = Selector.GetHandle ("setUserHeadpic:");
		[CompilerGenerated]
		const string selSetUserHeadpicAndViewController_ = "setUserHeadpic:andViewController:";
		static readonly IntPtr selSetUserHeadpicAndViewController_Handle = Selector.GetHandle ("setUserHeadpic:andViewController:");
		[CompilerGenerated]
		const string selUploadPicWithParams_ = "uploadPicWithParams:";
		static readonly IntPtr selUploadPicWithParams_Handle = Selector.GetHandle ("uploadPicWithParams:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("TencentOAuth");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public TencentOAuth () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.Init), "init");
			} else {
				InitializeHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.Init), "init");
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("initWithCoder:")]
		public TencentOAuth (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public TencentOAuth (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public TencentOAuth (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithAppId:andDelegate:")]
		[CompilerGenerated]
		public TencentOAuth (string appId, TencentSessionDelegate delegatec)
			: base (NSObjectFlag.Empty)
		{
			if (appId == null)
				throw new ArgumentNullException ("appId");
			if (delegatec == null)
				throw new ArgumentNullException ("delegatec");
			var nsappId = NSString.CreateNative (appId);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, selInitWithAppIdAndDelegate_Handle, nsappId, delegatec.Handle), "initWithAppId:andDelegate:");
			} else {
				InitializeHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selInitWithAppIdAndDelegate_Handle, nsappId, delegatec.Handle), "initWithAppId:andDelegate:");
			}
			NSString.ReleaseNative (nsappId);
			
		}
		
		[Export ("addAlbumWithParams:")]
		[CompilerGenerated]
		public virtual bool AddAlbumWithParams (NSMutableDictionary paramsc)
		{
			if (paramsc == null)
				throw new ArgumentNullException ("paramsc");
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr (this.Handle, selAddAlbumWithParams_Handle, paramsc.Handle);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, selAddAlbumWithParams_Handle, paramsc.Handle);
			}
		}
		
		[Export ("authorize:")]
		[CompilerGenerated]
		public virtual bool Authorize (NSObject[] permissions)
		{
			if (permissions == null)
				throw new ArgumentNullException ("permissions");
			var nsa_permissions = NSArray.FromNSObjects (permissions);
			
			bool ret;
			if (IsDirectBinding) {
				ret = MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr (this.Handle, selAuthorize_Handle, nsa_permissions.Handle);
			} else {
				ret = MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, selAuthorize_Handle, nsa_permissions.Handle);
			}
			nsa_permissions.Dispose ();
			
			return ret;
		}
		
		[Export ("authorize:inSafari:")]
		[CompilerGenerated]
		public virtual bool Authorize (NSArray permissions, bool bInSafari)
		{
			if (permissions == null)
				throw new ArgumentNullException ("permissions");
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr_bool (this.Handle, selAuthorizeInSafari_Handle, permissions.Handle, bInSafari);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr_bool (this.SuperHandle, selAuthorizeInSafari_Handle, permissions.Handle, bInSafari);
			}
		}
		
		[Export ("authorize:localAppId:inSafari:")]
		[CompilerGenerated]
		public virtual bool Authorize (NSArray permissions, string localAppId, bool bInSafari)
		{
			if (permissions == null)
				throw new ArgumentNullException ("permissions");
			if (localAppId == null)
				throw new ArgumentNullException ("localAppId");
			var nslocalAppId = NSString.CreateNative (localAppId);
			
			bool ret;
			if (IsDirectBinding) {
				ret = ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_IntPtr_bool (this.Handle, selAuthorizeLocalAppIdInSafari_Handle, permissions.Handle, nslocalAppId, bInSafari);
			} else {
				ret = ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_bool (this.SuperHandle, selAuthorizeLocalAppIdInSafari_Handle, permissions.Handle, nslocalAppId, bInSafari);
			}
			NSString.ReleaseNative (nslocalAppId);
			
			return ret;
		}
		
		[Export ("cancel:")]
		[CompilerGenerated]
		public virtual bool Cancel (NSObject userData)
		{
			if (userData == null)
				throw new ArgumentNullException ("userData");
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr (this.Handle, selCancel_Handle, userData.Handle);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, selCancel_Handle, userData.Handle);
			}
		}
		
		[Export ("CanHandleOpenURL:")]
		[CompilerGenerated]
		public static bool CanHandleOpenURL (NSUrl url)
		{
			if (url == null)
				throw new ArgumentNullException ("url");
			return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr (class_ptr, selCanHandleOpenURL_Handle, url.Handle);
		}
		
		[Export ("cgiRequestWithURL:method:params:callback:")]
		[CompilerGenerated]
		public virtual TCAPIRequest CgiRequestWithURL (NSUrl apiURL, string method, NSDictionary paramsc, TCAPIRequestDelegate callback)
		{
			if (apiURL == null)
				throw new ArgumentNullException ("apiURL");
			if (method == null)
				throw new ArgumentNullException ("method");
			if (paramsc == null)
				throw new ArgumentNullException ("paramsc");
			if (callback == null)
				throw new ArgumentNullException ("callback");
			var nsmethod = NSString.CreateNative (method);
			
			TCAPIRequest ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<TCAPIRequest> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr (this.Handle, selCgiRequestWithURLMethodParamsCallback_Handle, apiURL.Handle, nsmethod, paramsc.Handle, callback.Handle));
			} else {
				ret =  Runtime.GetNSObject<TCAPIRequest> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr (this.SuperHandle, selCgiRequestWithURLMethodParamsCallback_Handle, apiURL.Handle, nsmethod, paramsc.Handle, callback.Handle));
			}
			NSString.ReleaseNative (nsmethod);
			
			return ret;
		}
		
		[Export ("checkPageFansWithParams:")]
		[CompilerGenerated]
		public virtual bool CheckPageFansWithParams (NSMutableDictionary paramsc)
		{
			if (paramsc == null)
				throw new ArgumentNullException ("paramsc");
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr (this.Handle, selCheckPageFansWithParams_Handle, paramsc.Handle);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, selCheckPageFansWithParams_Handle, paramsc.Handle);
			}
		}
		
		[Export ("getIntimateFriends:")]
		[CompilerGenerated]
		public virtual bool GetIntimateFriends (NSMutableDictionary paramsc)
		{
			if (paramsc == null)
				throw new ArgumentNullException ("paramsc");
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr (this.Handle, selGetIntimateFriends_Handle, paramsc.Handle);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, selGetIntimateFriends_Handle, paramsc.Handle);
			}
		}
		
		[Export ("getListPhotoWithParams:")]
		[CompilerGenerated]
		public virtual bool GetListPhotoWithParams (NSMutableDictionary paramsc)
		{
			if (paramsc == null)
				throw new ArgumentNullException ("paramsc");
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr (this.Handle, selGetListPhotoWithParams_Handle, paramsc.Handle);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, selGetListPhotoWithParams_Handle, paramsc.Handle);
			}
		}
		
		[Export ("getUserInfo")]
		[CompilerGenerated]
		public virtual bool GetUserInfo ()
		{
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selGetUserInfoHandle);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selGetUserInfoHandle);
			}
		}
		
		[Export ("HandleOpenURL:")]
		[CompilerGenerated]
		public static bool HandleOpenURL (NSUrl url)
		{
			if (url == null)
				throw new ArgumentNullException ("url");
			return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr (class_ptr, selHandleOpenURL_Handle, url.Handle);
		}
		
		[Export ("incrAuthWithPermissions:")]
		[CompilerGenerated]
		public virtual bool IncrAuthWithPermissions (NSObject[] permissions)
		{
			if (permissions == null)
				throw new ArgumentNullException ("permissions");
			var nsa_permissions = NSArray.FromNSObjects (permissions);
			
			bool ret;
			if (IsDirectBinding) {
				ret = MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr (this.Handle, selIncrAuthWithPermissions_Handle, nsa_permissions.Handle);
			} else {
				ret = MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, selIncrAuthWithPermissions_Handle, nsa_permissions.Handle);
			}
			nsa_permissions.Dispose ();
			
			return ret;
		}
		
		[Export ("logout:")]
		[CompilerGenerated]
		public virtual void Logout (TencentSessionDelegate delegatec)
		{
			if (delegatec == null)
				throw new ArgumentNullException ("delegatec");
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selLogout_Handle, delegatec.Handle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selLogout_Handle, delegatec.Handle);
			}
		}
		
		[Export ("matchNickTips:")]
		[CompilerGenerated]
		public virtual bool MatchNickTips (NSMutableDictionary paramsc)
		{
			if (paramsc == null)
				throw new ArgumentNullException ("paramsc");
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr (this.Handle, selMatchNickTips_Handle, paramsc.Handle);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, selMatchNickTips_Handle, paramsc.Handle);
			}
		}
		
		[Export ("reauthorizeWithPermissions:")]
		[CompilerGenerated]
		public virtual bool ReauthorizeWithPermissions (NSObject[] permissions)
		{
			if (permissions == null)
				throw new ArgumentNullException ("permissions");
			var nsa_permissions = NSArray.FromNSObjects (permissions);
			
			bool ret;
			if (IsDirectBinding) {
				ret = MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr (this.Handle, selReauthorizeWithPermissions_Handle, nsa_permissions.Handle);
			} else {
				ret = MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, selReauthorizeWithPermissions_Handle, nsa_permissions.Handle);
			}
			nsa_permissions.Dispose ();
			
			return ret;
		}
		
		[Export ("sendAPIJS:key:")]
		[CompilerGenerated]
		public virtual bool SendAPIJS (NSMutableDictionary paramsc, string JSkey)
		{
			if (paramsc == null)
				throw new ArgumentNullException ("paramsc");
			if (JSkey == null)
				throw new ArgumentNullException ("JSkey");
			var nsJSkey = NSString.CreateNative (JSkey);
			
			bool ret;
			if (IsDirectBinding) {
				ret = MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr_IntPtr (this.Handle, selSendAPIJSKey_Handle, paramsc.Handle, nsJSkey);
			} else {
				ret = MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selSendAPIJSKey_Handle, paramsc.Handle, nsJSkey);
			}
			NSString.ReleaseNative (nsJSkey);
			
			return ret;
		}
		
		[Export ("sendAPIRequest:callback:")]
		[CompilerGenerated]
		public virtual bool SendAPIRequest (TCAPIRequest request, TCAPIRequestDelegate callback)
		{
			if (request == null)
				throw new ArgumentNullException ("request");
			if (callback == null)
				throw new ArgumentNullException ("callback");
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr_IntPtr (this.Handle, selSendAPIRequestCallback_Handle, request.Handle, callback.Handle);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selSendAPIRequestCallback_Handle, request.Handle, callback.Handle);
			}
		}
		
		[Export ("sendAppInvitationWithDescription:imageURL:source:")]
		[CompilerGenerated]
		public virtual bool SendAppInvitationWithDescription (string desc, string imageUrl, string source)
		{
			if (desc == null)
				throw new ArgumentNullException ("desc");
			if (imageUrl == null)
				throw new ArgumentNullException ("imageUrl");
			if (source == null)
				throw new ArgumentNullException ("source");
			var nsdesc = NSString.CreateNative (desc);
			var nsimageUrl = NSString.CreateNative (imageUrl);
			var nssource = NSString.CreateNative (source);
			
			bool ret;
			if (IsDirectBinding) {
				ret = MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, selSendAppInvitationWithDescriptionImageURLSource_Handle, nsdesc, nsimageUrl, nssource);
			} else {
				ret = MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (this.SuperHandle, selSendAppInvitationWithDescriptionImageURLSource_Handle, nsdesc, nsimageUrl, nssource);
			}
			NSString.ReleaseNative (nsdesc);
			NSString.ReleaseNative (nsimageUrl);
			NSString.ReleaseNative (nssource);
			
			return ret;
		}
		
		[Export ("sendChallenge:type:imageURL:message:source:")]
		[CompilerGenerated]
		public virtual bool SendChallenge (string receiver, string type, string imageUrl, string message, string source)
		{
			if (receiver == null)
				throw new ArgumentNullException ("receiver");
			if (type == null)
				throw new ArgumentNullException ("type");
			if (imageUrl == null)
				throw new ArgumentNullException ("imageUrl");
			if (message == null)
				throw new ArgumentNullException ("message");
			if (source == null)
				throw new ArgumentNullException ("source");
			var nsreceiver = NSString.CreateNative (receiver);
			var nstype = NSString.CreateNative (type);
			var nsimageUrl = NSString.CreateNative (imageUrl);
			var nsmessage = NSString.CreateNative (message);
			var nssource = NSString.CreateNative (source);
			
			bool ret;
			if (IsDirectBinding) {
				ret = MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr (this.Handle, selSendChallengeTypeImageURLMessageSource_Handle, nsreceiver, nstype, nsimageUrl, nsmessage, nssource);
			} else {
				ret = MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr (this.SuperHandle, selSendChallengeTypeImageURLMessageSource_Handle, nsreceiver, nstype, nsimageUrl, nsmessage, nssource);
			}
			NSString.ReleaseNative (nsreceiver);
			NSString.ReleaseNative (nstype);
			NSString.ReleaseNative (nsimageUrl);
			NSString.ReleaseNative (nsmessage);
			NSString.ReleaseNative (nssource);
			
			return ret;
		}
		
		[Export ("sendGiftRequest:exclude:specified:only:type:title:message:imageURL:source:")]
		[CompilerGenerated]
		public virtual bool SendGiftRequest (string receiver, string exclude, string specified, bool only, string type, string title, string message, string imageUrl, string source)
		{
			if (receiver == null)
				throw new ArgumentNullException ("receiver");
			if (exclude == null)
				throw new ArgumentNullException ("exclude");
			if (specified == null)
				throw new ArgumentNullException ("specified");
			if (type == null)
				throw new ArgumentNullException ("type");
			if (title == null)
				throw new ArgumentNullException ("title");
			if (message == null)
				throw new ArgumentNullException ("message");
			if (imageUrl == null)
				throw new ArgumentNullException ("imageUrl");
			if (source == null)
				throw new ArgumentNullException ("source");
			var nsreceiver = NSString.CreateNative (receiver);
			var nsexclude = NSString.CreateNative (exclude);
			var nsspecified = NSString.CreateNative (specified);
			var nstype = NSString.CreateNative (type);
			var nstitle = NSString.CreateNative (title);
			var nsmessage = NSString.CreateNative (message);
			var nsimageUrl = NSString.CreateNative (imageUrl);
			var nssource = NSString.CreateNative (source);
			
			bool ret;
			if (IsDirectBinding) {
				ret = ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr_bool_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr (this.Handle, selSendGiftRequestExcludeSpecifiedOnlyTypeTitleMessageImageURLSource_Handle, nsreceiver, nsexclude, nsspecified, only, nstype, nstitle, nsmessage, nsimageUrl, nssource);
			} else {
				ret = ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_bool_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr (this.SuperHandle, selSendGiftRequestExcludeSpecifiedOnlyTypeTitleMessageImageURLSource_Handle, nsreceiver, nsexclude, nsspecified, only, nstype, nstitle, nsmessage, nsimageUrl, nssource);
			}
			NSString.ReleaseNative (nsreceiver);
			NSString.ReleaseNative (nsexclude);
			NSString.ReleaseNative (nsspecified);
			NSString.ReleaseNative (nstype);
			NSString.ReleaseNative (nstitle);
			NSString.ReleaseNative (nsmessage);
			NSString.ReleaseNative (nsimageUrl);
			NSString.ReleaseNative (nssource);
			
			return ret;
		}
		
		[Export ("sendStory:friendList:")]
		[CompilerGenerated]
		public virtual bool SendStory (NSMutableDictionary paramsc, NSObject[] fopenIdArray)
		{
			if (paramsc == null)
				throw new ArgumentNullException ("paramsc");
			if (fopenIdArray == null)
				throw new ArgumentNullException ("fopenIdArray");
			var nsa_fopenIdArray = NSArray.FromNSObjects (fopenIdArray);
			
			bool ret;
			if (IsDirectBinding) {
				ret = MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr_IntPtr (this.Handle, selSendStoryFriendList_Handle, paramsc.Handle, nsa_fopenIdArray.Handle);
			} else {
				ret = MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selSendStoryFriendList_Handle, paramsc.Handle, nsa_fopenIdArray.Handle);
			}
			nsa_fopenIdArray.Dispose ();
			
			return ret;
		}
		
		[Export ("setUserHeadpic:")]
		[CompilerGenerated]
		public virtual bool SetUserHeadpic (NSMutableDictionary paramsc)
		{
			if (paramsc == null)
				throw new ArgumentNullException ("paramsc");
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr (this.Handle, selSetUserHeadpic_Handle, paramsc.Handle);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetUserHeadpic_Handle, paramsc.Handle);
			}
		}
		
		[Export ("setUserHeadpic:andViewController:")]
		[CompilerGenerated]
		public virtual bool SetUserHeadpic (NSMutableDictionary paramsc, out global::MonoTouch.UIKit.UIViewController viewController)
		{
			if (paramsc == null)
				throw new ArgumentNullException ("paramsc");
			IntPtr viewControllerPtr = Marshal.AllocHGlobal(IntPtr.Size);
			Marshal.WriteIntPtr(viewControllerPtr, IntPtr.Zero);
			
			bool ret;
			if (IsDirectBinding) {
				ret = MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr_IntPtr (this.Handle, selSetUserHeadpicAndViewController_Handle, paramsc.Handle, viewControllerPtr);
			} else {
				ret = MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selSetUserHeadpicAndViewController_Handle, paramsc.Handle, viewControllerPtr);
			}
			
			IntPtr viewControllerValue = Marshal.ReadIntPtr(viewControllerPtr);
			viewController = viewControllerValue != IntPtr.Zero ? Runtime.GetNSObject<UIViewController> (viewControllerValue) : null;
			Marshal.FreeHGlobal(viewControllerPtr);
			
			return ret;
		}
		
		[Export ("uploadPicWithParams:")]
		[CompilerGenerated]
		public virtual bool UploadPicWithParams (NSMutableDictionary paramsc)
		{
			if (paramsc == null)
				throw new ArgumentNullException ("paramsc");
			if (IsDirectBinding) {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr (this.Handle, selUploadPicWithParams_Handle, paramsc.Handle);
			} else {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, selUploadPicWithParams_Handle, paramsc.Handle);
			}
		}
		
		[CompilerGenerated]
		public virtual string AccessToken {
			[Export ("accessToken", ArgumentSemantic.Copy)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selAccessTokenHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selAccessTokenHandle));
				}
			}
			
			[Export ("setAccessToken:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetAccessToken_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetAccessToken_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual string AppId {
			[Export ("appId", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selAppIdHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selAppIdHandle));
				}
			}
			
			[Export ("setAppId:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetAppId_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetAppId_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		object __mt_ExpirationDate_var;
		[CompilerGenerated]
		public virtual NSDate ExpirationDate {
			[Export ("expirationDate", ArgumentSemantic.Copy)]
			get {
				NSDate ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDate> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selExpirationDateHandle));
				} else {
					ret =  Runtime.GetNSObject<NSDate> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selExpirationDateHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_ExpirationDate_var = ret;
				return ret;
			}
			
			[Export ("setExpirationDate:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetExpirationDate_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetExpirationDate_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_ExpirationDate_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual bool GetListAlbum {
			[Export ("getListAlbum")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selGetListAlbumHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selGetListAlbumHandle);
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool GetVipInfo {
			[Export ("getVipInfo")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selGetVipInfoHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selGetVipInfoHandle);
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool GetVipRichInfo {
			[Export ("getVipRichInfo")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selGetVipRichInfoHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selGetVipRichInfoHandle);
				}
			}
			
		}
		
		[CompilerGenerated]
		public static bool IphoneQQInstalled {
			[Export ("iphoneQQInstalled")]
			get {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (class_ptr, selIphoneQQInstalledHandle);
			}
			
		}
		
		[CompilerGenerated]
		public static bool IphoneQQSupportSSOLogin {
			[Export ("iphoneQQSupportSSOLogin")]
			get {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (class_ptr, selIphoneQQSupportSSOLoginHandle);
			}
			
		}
		
		[CompilerGenerated]
		public static bool IphoneQZoneInstalled {
			[Export ("iphoneQZoneInstalled")]
			get {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (class_ptr, selIphoneQZoneInstalledHandle);
			}
			
		}
		
		[CompilerGenerated]
		public static bool IphoneQZoneSupportSSOLogin {
			[Export ("iphoneQZoneSupportSSOLogin")]
			get {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (class_ptr, selIphoneQZoneSupportSSOLoginHandle);
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool IsSessionValid {
			[Export ("isSessionValid")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selIsSessionValidHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selIsSessionValidHandle);
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual string LocalAppId {
			[Export ("localAppId", ArgumentSemantic.Copy)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selLocalAppIdHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selLocalAppIdHandle));
				}
			}
			
			[Export ("setLocalAppId:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetLocalAppId_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetLocalAppId_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual string OpenId {
			[Export ("openId", ArgumentSemantic.Copy)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selOpenIdHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selOpenIdHandle));
				}
			}
			
			[Export ("setOpenId:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetOpenId_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetOpenId_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual string RedirectURI {
			[Export ("redirectURI", ArgumentSemantic.Copy)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selRedirectURIHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selRedirectURIHandle));
				}
			}
			
			[Export ("setRedirectURI:", ArgumentSemantic.Copy)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetRedirectURI_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetRedirectURI_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		object __mt_SessionDelegate_var;
		[CompilerGenerated]
		public virtual TencentSessionDelegate SessionDelegate {
			[Export ("sessionDelegate", ArgumentSemantic.UnsafeUnretained)]
			get {
				TencentSessionDelegate ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<TencentSessionDelegate> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selSessionDelegateHandle));
				} else {
					ret =  Runtime.GetNSObject<TencentSessionDelegate> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selSessionDelegateHandle));
				}
				MarkDirty ();
				__mt_SessionDelegate_var = ret;
				return ret;
			}
			
			[Export ("setSessionDelegate:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetSessionDelegate_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetSessionDelegate_Handle, value.Handle);
				}
				MarkDirty ();
				__mt_SessionDelegate_var = value;
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_ExpirationDate_var = null;
				__mt_SessionDelegate_var = null;
			}
		}
	} /* class TencentOAuth */
}
