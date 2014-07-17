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
	[Register("WBBaseMediaObject", true)]
	public unsafe partial class WBBaseMediaObject : NSObject {
		[CompilerGenerated]
		const string selDescription = "description";
		static readonly IntPtr selDescriptionHandle = Selector.GetHandle ("description");
		[CompilerGenerated]
		const string selObject = "object";
		static readonly IntPtr selObjectHandle = Selector.GetHandle ("object");
		[CompilerGenerated]
		const string selObjectID = "objectID";
		static readonly IntPtr selObjectIDHandle = Selector.GetHandle ("objectID");
		[CompilerGenerated]
		const string selScheme = "scheme";
		static readonly IntPtr selSchemeHandle = Selector.GetHandle ("scheme");
		[CompilerGenerated]
		const string selSetDescription_ = "setDescription:";
		static readonly IntPtr selSetDescription_Handle = Selector.GetHandle ("setDescription:");
		[CompilerGenerated]
		const string selSetObjectID_ = "setObjectID:";
		static readonly IntPtr selSetObjectID_Handle = Selector.GetHandle ("setObjectID:");
		[CompilerGenerated]
		const string selSetScheme_ = "setScheme:";
		static readonly IntPtr selSetScheme_Handle = Selector.GetHandle ("setScheme:");
		[CompilerGenerated]
		const string selSetThumbnailData_ = "setThumbnailData:";
		static readonly IntPtr selSetThumbnailData_Handle = Selector.GetHandle ("setThumbnailData:");
		[CompilerGenerated]
		const string selSetTitle_ = "setTitle:";
		static readonly IntPtr selSetTitle_Handle = Selector.GetHandle ("setTitle:");
		[CompilerGenerated]
		const string selThumbnailData = "thumbnailData";
		static readonly IntPtr selThumbnailDataHandle = Selector.GetHandle ("thumbnailData");
		[CompilerGenerated]
		const string selTitle = "title";
		static readonly IntPtr selTitleHandle = Selector.GetHandle ("title");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("WBBaseMediaObject");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public WBBaseMediaObject () : base (NSObjectFlag.Empty)
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
		public WBBaseMediaObject (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public WBBaseMediaObject (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public WBBaseMediaObject (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		public virtual string Description {
			[Export ("description", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selDescriptionHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selDescriptionHandle));
				}
			}
			
			[Export ("setDescription:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetDescription_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetDescription_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
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
		public virtual string ObjectID {
			[Export ("objectID", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selObjectIDHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selObjectIDHandle));
				}
			}
			
			[Export ("setObjectID:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetObjectID_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetObjectID_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual string Scheme {
			[Export ("scheme", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selSchemeHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selSchemeHandle));
				}
			}
			
			[Export ("setScheme:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetScheme_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetScheme_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		object __mt_ThumbnailData_var;
		[CompilerGenerated]
		public virtual NSData ThumbnailData {
			[Export ("thumbnailData", ArgumentSemantic.Retain)]
			get {
				NSData ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSData> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selThumbnailDataHandle));
				} else {
					ret =  Runtime.GetNSObject<NSData> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selThumbnailDataHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_ThumbnailData_var = ret;
				return ret;
			}
			
			[Export ("setThumbnailData:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetThumbnailData_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetThumbnailData_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_ThumbnailData_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual string Title {
			[Export ("title", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selTitleHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selTitleHandle));
				}
			}
			
			[Export ("setTitle:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetTitle_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetTitle_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_ThumbnailData_var = null;
			}
		}
	} /* class WBBaseMediaObject */
}
