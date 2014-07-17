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
	[Register("WBDataTransferObject", true)]
	public unsafe partial class WBDataTransferObject : NSObject {
		[CompilerGenerated]
		const string selSdkVersion = "sdkVersion";
		static readonly IntPtr selSdkVersionHandle = Selector.GetHandle ("sdkVersion");
		[CompilerGenerated]
		const string selSetShouldOpenWeiboAppInstallPageIfNotInstalled_ = "setShouldOpenWeiboAppInstallPageIfNotInstalled:";
		static readonly IntPtr selSetShouldOpenWeiboAppInstallPageIfNotInstalled_Handle = Selector.GetHandle ("setShouldOpenWeiboAppInstallPageIfNotInstalled:");
		[CompilerGenerated]
		const string selSetUserInfo_ = "setUserInfo:";
		static readonly IntPtr selSetUserInfo_Handle = Selector.GetHandle ("setUserInfo:");
		[CompilerGenerated]
		const string selShouldOpenWeiboAppInstallPageIfNotInstalled = "shouldOpenWeiboAppInstallPageIfNotInstalled";
		static readonly IntPtr selShouldOpenWeiboAppInstallPageIfNotInstalledHandle = Selector.GetHandle ("shouldOpenWeiboAppInstallPageIfNotInstalled");
		[CompilerGenerated]
		const string selUserInfo = "userInfo";
		static readonly IntPtr selUserInfoHandle = Selector.GetHandle ("userInfo");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("WBDataTransferObject");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public WBDataTransferObject () : base (NSObjectFlag.Empty)
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
		public WBDataTransferObject (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public WBDataTransferObject (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public WBDataTransferObject (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		public virtual string SdkVersion {
			[Export ("sdkVersion")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selSdkVersionHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selSdkVersionHandle));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool ShouldOpenWeiboAppInstallPageIfNotInstalled {
			[Export ("shouldOpenWeiboAppInstallPageIfNotInstalled")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSend (this.Handle, selShouldOpenWeiboAppInstallPageIfNotInstalledHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selShouldOpenWeiboAppInstallPageIfNotInstalledHandle);
				}
			}
			
			[Export ("setShouldOpenWeiboAppInstallPageIfNotInstalled:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_bool (this.Handle, selSetShouldOpenWeiboAppInstallPageIfNotInstalled_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetShouldOpenWeiboAppInstallPageIfNotInstalled_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_UserInfo_var;
		[CompilerGenerated]
		public virtual NSDictionary UserInfo {
			[Export ("userInfo", ArgumentSemantic.Retain)]
			get {
				NSDictionary ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selUserInfoHandle));
				} else {
					ret =  Runtime.GetNSObject<NSDictionary> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selUserInfoHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_UserInfo_var = ret;
				return ret;
			}
			
			[Export ("setUserInfo:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetUserInfo_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetUserInfo_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_UserInfo_var = value;
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_UserInfo_var = null;
			}
		}
	} /* class WBDataTransferObject */
}
