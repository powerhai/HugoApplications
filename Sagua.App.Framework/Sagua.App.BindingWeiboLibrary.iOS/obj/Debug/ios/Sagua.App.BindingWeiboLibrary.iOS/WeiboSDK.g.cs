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

namespace Sagua.App.BindingWeiboLibrary.iOS {
	[Register("WeiboSDK", true)]
	public unsafe partial class WeiboSDK : NSObject {
		[CompilerGenerated]
		const string selEnableDebugMode_ = "enableDebugMode:";
		static readonly IntPtr selEnableDebugMode_Handle = Selector.GetHandle ("enableDebugMode:");
		[CompilerGenerated]
		const string selGetSDKVersion = "getSDKVersion";
		static readonly IntPtr selGetSDKVersionHandle = Selector.GetHandle ("getSDKVersion");
		[CompilerGenerated]
		const string selGetWeiboAppInstallUrl = "getWeiboAppInstallUrl";
		static readonly IntPtr selGetWeiboAppInstallUrlHandle = Selector.GetHandle ("getWeiboAppInstallUrl");
		[CompilerGenerated]
		const string selGetWeiboAppSupportMaxSDKVersion = "getWeiboAppSupportMaxSDKVersion";
		static readonly IntPtr selGetWeiboAppSupportMaxSDKVersionHandle = Selector.GetHandle ("getWeiboAppSupportMaxSDKVersion");
		[CompilerGenerated]
		const string selHandleOpenURLDelegate_ = "handleOpenURL:delegate:";
		static readonly IntPtr selHandleOpenURLDelegate_Handle = Selector.GetHandle ("handleOpenURL:delegate:");
		[CompilerGenerated]
		const string selInviteFriendWithUidWithTokenDelegateWithTag_ = "inviteFriend:withUid:withToken:delegate:withTag:";
		static readonly IntPtr selInviteFriendWithUidWithTokenDelegateWithTag_Handle = Selector.GetHandle ("inviteFriend:withUid:withToken:delegate:withTag:");
		[CompilerGenerated]
		const string selIsWeiboAppInstalled = "isWeiboAppInstalled";
		static readonly IntPtr selIsWeiboAppInstalledHandle = Selector.GetHandle ("isWeiboAppInstalled");
		[CompilerGenerated]
		const string selLogOutWithTokenDelegateWithTag_ = "logOutWithToken:delegate:withTag:";
		static readonly IntPtr selLogOutWithTokenDelegateWithTag_Handle = Selector.GetHandle ("logOutWithToken:delegate:withTag:");
		[CompilerGenerated]
		const string selOpenWeiboApp = "openWeiboApp";
		static readonly IntPtr selOpenWeiboAppHandle = Selector.GetHandle ("openWeiboApp");
		[CompilerGenerated]
		const string selRegisterApp_ = "registerApp:";
		static readonly IntPtr selRegisterApp_Handle = Selector.GetHandle ("registerApp:");
		[CompilerGenerated]
		const string selSendRequest_ = "sendRequest:";
		static readonly IntPtr selSendRequest_Handle = Selector.GetHandle ("sendRequest:");
		[CompilerGenerated]
		const string selSendResponse_ = "sendResponse:";
		static readonly IntPtr selSendResponse_Handle = Selector.GetHandle ("sendResponse:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("WeiboSDK");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public WeiboSDK () : base (NSObjectFlag.Empty)
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
		public WeiboSDK (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public WeiboSDK (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public WeiboSDK (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("enableDebugMode:")]
		[CompilerGenerated]
		public static void EnableDebugMode (bool enabled)
		{
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (class_ptr, selEnableDebugMode_Handle, enabled);
		}
		
		[Export ("handleOpenURL:delegate:")]
		[CompilerGenerated]
		public static bool HandleOpenURL (NSUrl url, WeiboSDKDelegate delegatec)
		{
			if (url == null)
				throw new ArgumentNullException ("url");
			if (delegatec == null)
				throw new ArgumentNullException ("delegatec");
			return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr_IntPtr (class_ptr, selHandleOpenURLDelegate_Handle, url.Handle, delegatec.Handle);
		}
		
		[Export ("inviteFriend:withUid:withToken:delegate:withTag:")]
		[CompilerGenerated]
		public static void InviteFriend (string data, string uid, string access_token, WBHttpRequestDelegate delegatec, string tag)
		{
			if (data == null)
				throw new ArgumentNullException ("data");
			if (uid == null)
				throw new ArgumentNullException ("uid");
			if (access_token == null)
				throw new ArgumentNullException ("access_token");
			if (delegatec == null)
				throw new ArgumentNullException ("delegatec");
			if (tag == null)
				throw new ArgumentNullException ("tag");
			var nsdata = NSString.CreateNative (data);
			var nsuid = NSString.CreateNative (uid);
			var nsaccess_token = NSString.CreateNative (access_token);
			var nstag = NSString.CreateNative (tag);
			
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr (class_ptr, selInviteFriendWithUidWithTokenDelegateWithTag_Handle, nsdata, nsuid, nsaccess_token, delegatec.Handle, nstag);
			NSString.ReleaseNative (nsdata);
			NSString.ReleaseNative (nsuid);
			NSString.ReleaseNative (nsaccess_token);
			NSString.ReleaseNative (nstag);
			
		}
		
		[Export ("logOutWithToken:delegate:withTag:")]
		[CompilerGenerated]
		public static void LogOutWithToken (string token, WBHttpRequestDelegate delegatec, string tag)
		{
			if (token == null)
				throw new ArgumentNullException ("token");
			if (delegatec == null)
				throw new ArgumentNullException ("delegatec");
			if (tag == null)
				throw new ArgumentNullException ("tag");
			var nstoken = NSString.CreateNative (token);
			var nstag = NSString.CreateNative (tag);
			
			MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (class_ptr, selLogOutWithTokenDelegateWithTag_Handle, nstoken, delegatec.Handle, nstag);
			NSString.ReleaseNative (nstoken);
			NSString.ReleaseNative (nstag);
			
		}
		
		[Export ("registerApp:")]
		[CompilerGenerated]
		public static bool RegisterApp (string appKey)
		{
			if (appKey == null)
				throw new ArgumentNullException ("appKey");
			var nsappKey = NSString.CreateNative (appKey);
			
			bool ret;
			ret = MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr (class_ptr, selRegisterApp_Handle, nsappKey);
			NSString.ReleaseNative (nsappKey);
			
			return ret;
		}
		
		[Export ("sendRequest:")]
		[CompilerGenerated]
		public static bool SendRequest (WBBaseRequest request)
		{
			if (request == null)
				throw new ArgumentNullException ("request");
			return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr (class_ptr, selSendRequest_Handle, request.Handle);
		}
		
		[Export ("sendResponse:")]
		[CompilerGenerated]
		public static bool SendResponse (WBBaseResponse response)
		{
			if (response == null)
				throw new ArgumentNullException ("response");
			return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend_IntPtr (class_ptr, selSendResponse_Handle, response.Handle);
		}
		
		[CompilerGenerated]
		public static string GetSDKVersion {
			[Export ("getSDKVersion")]
			get {
				return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (class_ptr, selGetSDKVersionHandle));
			}
			
		}
		
		[CompilerGenerated]
		public static string GetWeiboAppInstallUrl {
			[Export ("getWeiboAppInstallUrl")]
			get {
				return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (class_ptr, selGetWeiboAppInstallUrlHandle));
			}
			
		}
		
		[CompilerGenerated]
		public static string GetWeiboAppSupportMaxSDKVersion {
			[Export ("getWeiboAppSupportMaxSDKVersion")]
			get {
				return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (class_ptr, selGetWeiboAppSupportMaxSDKVersionHandle));
			}
			
		}
		
		[CompilerGenerated]
		public static bool IsWeiboAppInstalled {
			[Export ("isWeiboAppInstalled")]
			get {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (class_ptr, selIsWeiboAppInstalledHandle);
			}
			
		}
		
		[CompilerGenerated]
		public static bool OpenWeiboApp {
			[Export ("openWeiboApp")]
			get {
				return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (class_ptr, selOpenWeiboAppHandle);
			}
			
		}
		
	} /* class WeiboSDK */
}
