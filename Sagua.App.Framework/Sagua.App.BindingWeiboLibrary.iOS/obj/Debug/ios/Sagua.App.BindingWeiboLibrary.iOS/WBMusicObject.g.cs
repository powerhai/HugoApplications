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
	[Register("WBMusicObject", true)]
	public unsafe partial class WBMusicObject : WBBaseMediaObject {
		[CompilerGenerated]
		const string selMusicLowBandStreamUrl = "musicLowBandStreamUrl";
		static readonly IntPtr selMusicLowBandStreamUrlHandle = Selector.GetHandle ("musicLowBandStreamUrl");
		[CompilerGenerated]
		const string selMusicLowBandUrl = "musicLowBandUrl";
		static readonly IntPtr selMusicLowBandUrlHandle = Selector.GetHandle ("musicLowBandUrl");
		[CompilerGenerated]
		const string selMusicStreamUrl = "musicStreamUrl";
		static readonly IntPtr selMusicStreamUrlHandle = Selector.GetHandle ("musicStreamUrl");
		[CompilerGenerated]
		const string selMusicUrl = "musicUrl";
		static readonly IntPtr selMusicUrlHandle = Selector.GetHandle ("musicUrl");
		[CompilerGenerated]
		const string selSetMusicLowBandStreamUrl_ = "setMusicLowBandStreamUrl:";
		static readonly IntPtr selSetMusicLowBandStreamUrl_Handle = Selector.GetHandle ("setMusicLowBandStreamUrl:");
		[CompilerGenerated]
		const string selSetMusicLowBandUrl_ = "setMusicLowBandUrl:";
		static readonly IntPtr selSetMusicLowBandUrl_Handle = Selector.GetHandle ("setMusicLowBandUrl:");
		[CompilerGenerated]
		const string selSetMusicStreamUrl_ = "setMusicStreamUrl:";
		static readonly IntPtr selSetMusicStreamUrl_Handle = Selector.GetHandle ("setMusicStreamUrl:");
		[CompilerGenerated]
		const string selSetMusicUrl_ = "setMusicUrl:";
		static readonly IntPtr selSetMusicUrl_Handle = Selector.GetHandle ("setMusicUrl:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("WBMusicObject");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public WBMusicObject () : base (NSObjectFlag.Empty)
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
		public WBMusicObject (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public WBMusicObject (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public WBMusicObject (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		public virtual string MusicLowBandStreamUrl {
			[Export ("musicLowBandStreamUrl", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selMusicLowBandStreamUrlHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selMusicLowBandStreamUrlHandle));
				}
			}
			
			[Export ("setMusicLowBandStreamUrl:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetMusicLowBandStreamUrl_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetMusicLowBandStreamUrl_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual string MusicLowBandUrl {
			[Export ("musicLowBandUrl", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selMusicLowBandUrlHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selMusicLowBandUrlHandle));
				}
			}
			
			[Export ("setMusicLowBandUrl:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetMusicLowBandUrl_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetMusicLowBandUrl_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual string MusicStreamUrl {
			[Export ("musicStreamUrl", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selMusicStreamUrlHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selMusicStreamUrlHandle));
				}
			}
			
			[Export ("setMusicStreamUrl:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetMusicStreamUrl_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetMusicStreamUrl_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual string MusicUrl {
			[Export ("musicUrl", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selMusicUrlHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selMusicUrlHandle));
				}
			}
			
			[Export ("setMusicUrl:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetMusicUrl_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetMusicUrl_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
	} /* class WBMusicObject */
}
