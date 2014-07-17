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
	[Register("WBMessageObject", true)]
	public unsafe partial class WBMessageObject : NSObject {
		[CompilerGenerated]
		const string selImageObject = "imageObject";
		static readonly IntPtr selImageObjectHandle = Selector.GetHandle ("imageObject");
		[CompilerGenerated]
		const string selMediaObject = "mediaObject";
		static readonly IntPtr selMediaObjectHandle = Selector.GetHandle ("mediaObject");
		[CompilerGenerated]
		const string selMessage = "message";
		static readonly IntPtr selMessageHandle = Selector.GetHandle ("message");
		[CompilerGenerated]
		const string selSetImageObject_ = "setImageObject:";
		static readonly IntPtr selSetImageObject_Handle = Selector.GetHandle ("setImageObject:");
		[CompilerGenerated]
		const string selSetMediaObject_ = "setMediaObject:";
		static readonly IntPtr selSetMediaObject_Handle = Selector.GetHandle ("setMediaObject:");
		[CompilerGenerated]
		const string selSetText_ = "setText:";
		static readonly IntPtr selSetText_Handle = Selector.GetHandle ("setText:");
		[CompilerGenerated]
		const string selText = "text";
		static readonly IntPtr selTextHandle = Selector.GetHandle ("text");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("WBMessageObject");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public WBMessageObject () : base (NSObjectFlag.Empty)
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
		public WBMessageObject (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public WBMessageObject (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public WBMessageObject (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		object __mt_ImageObject_var;
		[CompilerGenerated]
		public virtual WBImageObject ImageObject {
			[Export ("imageObject", ArgumentSemantic.Retain)]
			get {
				WBImageObject ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<WBImageObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selImageObjectHandle));
				} else {
					ret =  Runtime.GetNSObject<WBImageObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selImageObjectHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_ImageObject_var = ret;
				return ret;
			}
			
			[Export ("setImageObject:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetImageObject_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetImageObject_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_ImageObject_var = value;
			}
		}
		
		[CompilerGenerated]
		object __mt_MediaObject_var;
		[CompilerGenerated]
		public virtual WBBaseMediaObject MediaObject {
			[Export ("mediaObject", ArgumentSemantic.Retain)]
			get {
				WBBaseMediaObject ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<WBBaseMediaObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selMediaObjectHandle));
				} else {
					ret =  Runtime.GetNSObject<WBBaseMediaObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selMediaObjectHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_MediaObject_var = ret;
				return ret;
			}
			
			[Export ("setMediaObject:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetMediaObject_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetMediaObject_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_MediaObject_var = value;
			}
		}
		
		[CompilerGenerated]
		static object __mt_Message_var_static;
		[CompilerGenerated]
		public static NSObject Message {
			[Export ("message")]
			get {
				NSObject ret;
				ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (class_ptr, selMessageHandle));
				if (!NSObject.IsNewRefcountEnabled ())
					__mt_Message_var_static = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual string Text {
			[Export ("text", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selTextHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selTextHandle));
				}
			}
			
			[Export ("setText:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetText_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetText_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_ImageObject_var = null;
				__mt_MediaObject_var = null;
			}
		}
	} /* class WBMessageObject */
}
