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
	[Register("WBBaseResponse", true)]
	public unsafe partial class WBBaseResponse : WBDataTransferObject {
		[CompilerGenerated]
		const string selRequestUserInfo = "requestUserInfo";
		static readonly IntPtr selRequestUserInfoHandle = Selector.GetHandle ("requestUserInfo");
		[CompilerGenerated]
		const string selResponse = "response";
		static readonly IntPtr selResponseHandle = Selector.GetHandle ("response");
		[CompilerGenerated]
		const string selSetStatusCode_ = "setStatusCode:";
		static readonly IntPtr selSetStatusCode_Handle = Selector.GetHandle ("setStatusCode:");
		[CompilerGenerated]
		const string selStatusCode = "statusCode";
		static readonly IntPtr selStatusCodeHandle = Selector.GetHandle ("statusCode");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("WBBaseResponse");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public WBBaseResponse () : base (NSObjectFlag.Empty)
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
		public WBBaseResponse (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public WBBaseResponse (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public WBBaseResponse (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		object __mt_RequestUserInfo_var;
		[CompilerGenerated]
		public virtual NSDictionary RequestUserInfo {
			[Export ("requestUserInfo")]
			get {
				NSDictionary ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selRequestUserInfoHandle));
				} else {
					ret =  Runtime.GetNSObject<NSDictionary> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selRequestUserInfoHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_RequestUserInfo_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		static object __mt_Response_var_static;
		[CompilerGenerated]
		public static NSObject Response {
			[Export ("response")]
			get {
				NSObject ret;
				ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (class_ptr, selResponseHandle));
				if (!NSObject.IsNewRefcountEnabled ())
					__mt_Response_var_static = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual WeiboSDKResponseStatusCode StatusCode {
			[Export ("statusCode")]
			get {
				if (IsDirectBinding) {
					return (WeiboSDKResponseStatusCode) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selStatusCodeHandle);
				} else {
					return (WeiboSDKResponseStatusCode) MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selStatusCodeHandle);
				}
			}
			
			[Export ("setStatusCode:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_int (this.Handle, selSetStatusCode_Handle, (int)value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, selSetStatusCode_Handle, (int)value);
				}
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_RequestUserInfo_var = null;
			}
		}
	} /* class WBBaseResponse */
}
