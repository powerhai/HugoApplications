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
	[Register("WBSendMessageToWeiboRequest", true)]
	public unsafe partial class WBSendMessageToWeiboRequest : WBBaseRequest {
		[CompilerGenerated]
		const string selMessage = "message";
		static readonly IntPtr selMessageHandle = Selector.GetHandle ("message");
		[CompilerGenerated]
		const string selRequestWithMessage_ = "requestWithMessage:";
		static readonly IntPtr selRequestWithMessage_Handle = Selector.GetHandle ("requestWithMessage:");
		[CompilerGenerated]
		const string selSetMessage_ = "setMessage:";
		static readonly IntPtr selSetMessage_Handle = Selector.GetHandle ("setMessage:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("WBSendMessageToWeiboRequest");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public WBSendMessageToWeiboRequest () : base (NSObjectFlag.Empty)
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
		public WBSendMessageToWeiboRequest (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public WBSendMessageToWeiboRequest (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public WBSendMessageToWeiboRequest (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("requestWithMessage:")]
		[CompilerGenerated]
		public static NSObject RequestWithMessage (WBMessageObject message)
		{
			if (message == null)
				throw new ArgumentNullException ("message");
			return  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, selRequestWithMessage_Handle, message.Handle));
		}
		
		[CompilerGenerated]
		object __mt_Message_var;
		[CompilerGenerated]
		public virtual WBMessageObject Message {
			[Export ("message", ArgumentSemantic.Retain)]
			get {
				WBMessageObject ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<WBMessageObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selMessageHandle));
				} else {
					ret =  Runtime.GetNSObject<WBMessageObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selMessageHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Message_var = ret;
				return ret;
			}
			
			[Export ("setMessage:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetMessage_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetMessage_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_Message_var = value;
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_Message_var = null;
			}
		}
	} /* class WBSendMessageToWeiboRequest */
}
