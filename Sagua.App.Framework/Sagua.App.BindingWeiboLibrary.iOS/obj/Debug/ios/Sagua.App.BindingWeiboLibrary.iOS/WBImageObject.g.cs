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
	[Register("WBImageObject", true)]
	public unsafe partial class WBImageObject : NSObject {
		[CompilerGenerated]
		const string selImage = "image";
		static readonly IntPtr selImageHandle = Selector.GetHandle ("image");
		[CompilerGenerated]
		const string selImageData = "imageData";
		static readonly IntPtr selImageDataHandle = Selector.GetHandle ("imageData");
		[CompilerGenerated]
		const string selObject = "object";
		static readonly IntPtr selObjectHandle = Selector.GetHandle ("object");
		[CompilerGenerated]
		const string selSetImageData_ = "setImageData:";
		static readonly IntPtr selSetImageData_Handle = Selector.GetHandle ("setImageData:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("WBImageObject");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public WBImageObject () : base (NSObjectFlag.Empty)
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
		public WBImageObject (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public WBImageObject (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public WBImageObject (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		object __mt_Image_var;
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIImage Image {
			[Export ("image")]
			get {
				global::MonoTouch.UIKit.UIImage ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::MonoTouch.UIKit.UIImage> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selImageHandle));
				} else {
					ret =  Runtime.GetNSObject<global::MonoTouch.UIKit.UIImage> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selImageHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Image_var = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		object __mt_ImageData_var;
		[CompilerGenerated]
		public virtual NSData ImageData {
			[Export ("imageData", ArgumentSemantic.Retain)]
			get {
				NSData ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSData> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selImageDataHandle));
				} else {
					ret =  Runtime.GetNSObject<NSData> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selImageDataHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_ImageData_var = ret;
				return ret;
			}
			
			[Export ("setImageData:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetImageData_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetImageData_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_ImageData_var = value;
			}
		}
		
		[CompilerGenerated]
		static object __mt_Object_var_static;
		[CompilerGenerated]
		public static NSObject Object {
			[Export ("object")]
			get {
				NSObject ret;
				ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (class_ptr, selObjectHandle));
				if (!NSObject.IsNewRefcountEnabled ())
					__mt_Object_var_static = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_Image_var = null;
				__mt_ImageData_var = null;
			}
		}
	} /* class WBImageObject */
}
