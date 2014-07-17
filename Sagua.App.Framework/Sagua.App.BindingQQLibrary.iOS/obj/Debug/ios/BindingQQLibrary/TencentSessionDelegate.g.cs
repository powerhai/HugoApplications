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
	[Register("TencentSessionDelegate", true)]
	[Model]
	public unsafe partial class TencentSessionDelegate : NSObject {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public TencentSessionDelegate () : base (NSObjectFlag.Empty)
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
		public TencentSessionDelegate (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public TencentSessionDelegate (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public TencentSessionDelegate (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("addAlbumResponse:")]
		[CompilerGenerated]
		public virtual void addAlbumResponse (APIResponse response)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("addShareResponse:")]
		[CompilerGenerated]
		public virtual void addShareResponse (APIResponse response)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("addTopicResponse:")]
		[CompilerGenerated]
		public virtual void addTopicResponse (APIResponse response)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("checkPageFansResponse:")]
		[CompilerGenerated]
		public virtual void checkPageFansResponse (APIResponse response)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("tencentOAuth:didSendBodyData:totalBytesWritten:totalBytesExpectedToWrite:userData:")]
		[CompilerGenerated]
		public virtual void DidSendBodyData (TencentOAuth tencentOAuth, int bytesWritten, int totalBytesWritten, int totalBytesExpectedToWrite, NSObject userData)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("tencentOAuth:doCloseViewController:")]
		[CompilerGenerated]
		public virtual void DoCloseViewController (TencentOAuth tencentOAuth, global::MonoTouch.UIKit.UIViewController viewController)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("responseDidReceived:forMessage:")]
		[CompilerGenerated]
		public virtual void ForMessage (APIResponse response, string message)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("getIntimateFriendsResponse:")]
		[CompilerGenerated]
		public virtual void getIntimateFriendsResponse (APIResponse response)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("getListAlbumResponse:")]
		[CompilerGenerated]
		public virtual void getListAlbumResponse (APIResponse response)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("getListPhotoResponse:")]
		[CompilerGenerated]
		public virtual void getListPhotoResponse (APIResponse response)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("getUserInfoResponse:")]
		[CompilerGenerated]
		public virtual void getUserInfoResponse (APIResponse response)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("getVipInfoResponse:")]
		[CompilerGenerated]
		public virtual void getVipInfoResponse (APIResponse response)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("getVipRichInfoResponse:")]
		[CompilerGenerated]
		public virtual void getVipRichInfoResponse (APIResponse response)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("matchNickTipsResponse:")]
		[CompilerGenerated]
		public virtual void matchNickTipsResponse (APIResponse response)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("onTencentReq:")]
		[CompilerGenerated]
		public virtual bool onTencentReq (TencentApiReq req)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("onTencentResp:")]
		[CompilerGenerated]
		public virtual bool onTencentResp (TencentApiResp resp)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("sendStoryResponse:")]
		[CompilerGenerated]
		public virtual void sendStoryResponse (APIResponse response)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("tencentDidLogin")]
		[CompilerGenerated]
		public virtual void TencentDidLogin ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("tencentDidLogout")]
		[CompilerGenerated]
		public virtual void TencentDidLogout ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("tencentDidNotLogin:")]
		[CompilerGenerated]
		public virtual void tencentDidNotLogin (bool cancelled)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("tencentDidNotNetWork")]
		[CompilerGenerated]
		public virtual void TencentDidNotNetWork ()
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("tencentDidUpdate:")]
		[CompilerGenerated]
		public virtual void tencentDidUpdate (TencentOAuth tencentOAuth)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("tencentFailedUpdate:")]
		[CompilerGenerated]
		public virtual void tencentFailedUpdate (UpdateFailType reason)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("tencentNeedPerformReAuth:")]
		[CompilerGenerated]
		public virtual bool tencentNeedPerformReAuth (TencentOAuth tencentOAuth)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("uploadPicResponse:")]
		[CompilerGenerated]
		public virtual void uploadPicResponse (APIResponse response)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("getAuthorizedPermissions:withExtraParams:")]
		[CompilerGenerated]
		public virtual NSObject[] WithExtraParams (NSObject[] permissions, NSDictionary extraParams)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[Export ("tencentNeedPerformIncrAuth:withPermissions:")]
		[CompilerGenerated]
		public virtual bool WithPermissions (TencentOAuth tencentOAuth, NSObject[] permissions)
		{
			throw new You_Should_Not_Call_base_In_This_Method ();
		}
		
		[CompilerGenerated]
		public virtual APIResponse UserHeadpicResponse {
			[Export ("setUserHeadpicResponse:")]
			set {
				throw new ModelNotImplementedException ();
			}
		}
		
	} /* class TencentSessionDelegate */
}
