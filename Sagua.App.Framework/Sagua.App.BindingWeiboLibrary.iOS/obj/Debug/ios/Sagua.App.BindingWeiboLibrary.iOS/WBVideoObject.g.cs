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
	[Register("WBVideoObject", true)]
	public unsafe partial class WBVideoObject : WBBaseMediaObject {
		[CompilerGenerated]
		const string selSetVideoLowBandStreamUrl_ = "setVideoLowBandStreamUrl:";
		static readonly IntPtr selSetVideoLowBandStreamUrl_Handle = Selector.GetHandle ("setVideoLowBandStreamUrl:");
		[CompilerGenerated]
		const string selSetVideoLowBandUrl_ = "setVideoLowBandUrl:";
		static readonly IntPtr selSetVideoLowBandUrl_Handle = Selector.GetHandle ("setVideoLowBandUrl:");
		[CompilerGenerated]
		const string selSetVideoStreamUrl_ = "setVideoStreamUrl:";
		static readonly IntPtr selSetVideoStreamUrl_Handle = Selector.GetHandle ("setVideoStreamUrl:");
		[CompilerGenerated]
		const string selSetVideoUrl_ = "setVideoUrl:";
		static readonly IntPtr selSetVideoUrl_Handle = Selector.GetHandle ("setVideoUrl:");
		[CompilerGenerated]
		const string selVideoLowBandStreamUrl = "videoLowBandStreamUrl";
		static readonly IntPtr selVideoLowBandStreamUrlHandle = Selector.GetHandle ("videoLowBandStreamUrl");
		[CompilerGenerated]
		const string selVideoLowBandUrl = "videoLowBandUrl";
		static readonly IntPtr selVideoLowBandUrlHandle = Selector.GetHandle ("videoLowBandUrl");
		[CompilerGenerated]
		const string selVideoStreamUrl = "videoStreamUrl";
		static readonly IntPtr selVideoStreamUrlHandle = Selector.GetHandle ("videoStreamUrl");
		[CompilerGenerated]
		const string selVideoUrl = "videoUrl";
		static readonly IntPtr selVideoUrlHandle = Selector.GetHandle ("videoUrl");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("WBVideoObject");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public WBVideoObject () : base (NSObjectFlag.Empty)
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
		public WBVideoObject (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public WBVideoObject (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public WBVideoObject (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		public virtual string VideoLowBandStreamUrl {
			[Export ("videoLowBandStreamUrl", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selVideoLowBandStreamUrlHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selVideoLowBandStreamUrlHandle));
				}
			}
			
			[Export ("setVideoLowBandStreamUrl:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetVideoLowBandStreamUrl_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetVideoLowBandStreamUrl_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual string VideoLowBandUrl {
			[Export ("videoLowBandUrl", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selVideoLowBandUrlHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selVideoLowBandUrlHandle));
				}
			}
			
			[Export ("setVideoLowBandUrl:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetVideoLowBandUrl_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetVideoLowBandUrl_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual string VideoStreamUrl {
			[Export ("videoStreamUrl", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selVideoStreamUrlHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selVideoStreamUrlHandle));
				}
			}
			
			[Export ("setVideoStreamUrl:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetVideoStreamUrl_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetVideoStreamUrl_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual string VideoUrl {
			[Export ("videoUrl", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selVideoUrlHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selVideoUrlHandle));
				}
			}
			
			[Export ("setVideoUrl:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetVideoUrl_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetVideoUrl_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
	} /* class WBVideoObject */
}
