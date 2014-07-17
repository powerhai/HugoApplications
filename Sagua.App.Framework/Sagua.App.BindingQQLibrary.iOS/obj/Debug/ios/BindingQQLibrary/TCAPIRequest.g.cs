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
	[Register("TCAPIRequest", true)]
	public unsafe partial class TCAPIRequest : NSMutableDictionary {
		[CompilerGenerated]
		const string selApiURL = "apiURL";
		static readonly IntPtr selApiURLHandle = Selector.GetHandle ("apiURL");
		[CompilerGenerated]
		const string selCancel = "cancel";
		static readonly IntPtr selCancelHandle = Selector.GetHandle ("cancel");
		[CompilerGenerated]
		const string selMethod = "method";
		static readonly IntPtr selMethodHandle = Selector.GetHandle ("method");
		[CompilerGenerated]
		const string selParamUserData = "paramUserData";
		static readonly IntPtr selParamUserDataHandle = Selector.GetHandle ("paramUserData");
		[CompilerGenerated]
		const string selResponse = "response";
		static readonly IntPtr selResponseHandle = Selector.GetHandle ("response");
		[CompilerGenerated]
		const string selSetParamUserData_ = "setParamUserData:";
		static readonly IntPtr selSetParamUserData_Handle = Selector.GetHandle ("setParamUserData:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("TCAPIRequest");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public TCAPIRequest () : base (NSObjectFlag.Empty)
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
		public TCAPIRequest (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public TCAPIRequest (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public TCAPIRequest (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("cancel")]
		[CompilerGenerated]
		public virtual void Cancel ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selCancelHandle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selCancelHandle);
			}
		}
		
		[CompilerGenerated]
		object __mt_ApiURL_var;
		[CompilerGenerated]
		public virtual NSUrl ApiURL {
			[Export ("apiURL")]
			get {
				NSUrl ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSUrl> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selApiURLHandle));
				} else {
					ret =  Runtime.GetNSObject<NSUrl> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selApiURLHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_ApiURL_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual string Method {
			[Export ("method")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selMethodHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selMethodHandle));
				}
			}
			
		}
		
		[CompilerGenerated]
		object __mt_ParamUserData_var;
		[CompilerGenerated]
		public virtual NSObject ParamUserData {
			[Export ("paramUserData", ArgumentSemantic.Retain)]
			get {
				NSObject ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selParamUserDataHandle));
				} else {
					ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selParamUserDataHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_ParamUserData_var = ret;
				return ret;
			}
			
			[Export ("setParamUserData:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetParamUserData_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetParamUserData_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_ParamUserData_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_Response_var;
		[CompilerGenerated]
		public virtual APIResponse Response {
			[Export ("response")]
			get {
				APIResponse ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<APIResponse> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selResponseHandle));
				} else {
					ret =  Runtime.GetNSObject<APIResponse> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selResponseHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Response_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_ApiURL_var = null;
				__mt_ParamUserData_var = null;
				__mt_Response_var = null;
			}
		}
	} /* class TCAPIRequest */
}
