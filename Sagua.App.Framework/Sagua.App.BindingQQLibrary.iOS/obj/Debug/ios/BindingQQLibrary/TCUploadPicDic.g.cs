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
	[Register("TCUploadPicDic", true)]
	public unsafe partial class TCUploadPicDic : TCAPIRequest {
		[CompilerGenerated]
		const string selDictionary = "dictionary";
		static readonly IntPtr selDictionaryHandle = Selector.GetHandle ("dictionary");
		[CompilerGenerated]
		const string selParamAlbumid = "paramAlbumid";
		static readonly IntPtr selParamAlbumidHandle = Selector.GetHandle ("paramAlbumid");
		[CompilerGenerated]
		const string selParamMobile = "paramMobile";
		static readonly IntPtr selParamMobileHandle = Selector.GetHandle ("paramMobile");
		[CompilerGenerated]
		const string selParamNeedfeed = "paramNeedfeed";
		static readonly IntPtr selParamNeedfeedHandle = Selector.GetHandle ("paramNeedfeed");
		[CompilerGenerated]
		const string selParamPhotodesc = "paramPhotodesc";
		static readonly IntPtr selParamPhotodescHandle = Selector.GetHandle ("paramPhotodesc");
		[CompilerGenerated]
		const string selParamPicnum = "paramPicnum";
		static readonly IntPtr selParamPicnumHandle = Selector.GetHandle ("paramPicnum");
		[CompilerGenerated]
		const string selParamPicture = "paramPicture";
		static readonly IntPtr selParamPictureHandle = Selector.GetHandle ("paramPicture");
		[CompilerGenerated]
		const string selParamSuccessnum = "paramSuccessnum";
		static readonly IntPtr selParamSuccessnumHandle = Selector.GetHandle ("paramSuccessnum");
		[CompilerGenerated]
		const string selParamTitle = "paramTitle";
		static readonly IntPtr selParamTitleHandle = Selector.GetHandle ("paramTitle");
		[CompilerGenerated]
		const string selParamX = "paramX";
		static readonly IntPtr selParamXHandle = Selector.GetHandle ("paramX");
		[CompilerGenerated]
		const string selParamY = "paramY";
		static readonly IntPtr selParamYHandle = Selector.GetHandle ("paramY");
		[CompilerGenerated]
		const string selSetParamAlbumid_ = "setParamAlbumid:";
		static readonly IntPtr selSetParamAlbumid_Handle = Selector.GetHandle ("setParamAlbumid:");
		[CompilerGenerated]
		const string selSetParamMobile_ = "setParamMobile:";
		static readonly IntPtr selSetParamMobile_Handle = Selector.GetHandle ("setParamMobile:");
		[CompilerGenerated]
		const string selSetParamNeedfeed_ = "setParamNeedfeed:";
		static readonly IntPtr selSetParamNeedfeed_Handle = Selector.GetHandle ("setParamNeedfeed:");
		[CompilerGenerated]
		const string selSetParamPhotodesc_ = "setParamPhotodesc:";
		static readonly IntPtr selSetParamPhotodesc_Handle = Selector.GetHandle ("setParamPhotodesc:");
		[CompilerGenerated]
		const string selSetParamPicnum_ = "setParamPicnum:";
		static readonly IntPtr selSetParamPicnum_Handle = Selector.GetHandle ("setParamPicnum:");
		[CompilerGenerated]
		const string selSetParamPicture_ = "setParamPicture:";
		static readonly IntPtr selSetParamPicture_Handle = Selector.GetHandle ("setParamPicture:");
		[CompilerGenerated]
		const string selSetParamSuccessnum_ = "setParamSuccessnum:";
		static readonly IntPtr selSetParamSuccessnum_Handle = Selector.GetHandle ("setParamSuccessnum:");
		[CompilerGenerated]
		const string selSetParamTitle_ = "setParamTitle:";
		static readonly IntPtr selSetParamTitle_Handle = Selector.GetHandle ("setParamTitle:");
		[CompilerGenerated]
		const string selSetParamX_ = "setParamX:";
		static readonly IntPtr selSetParamX_Handle = Selector.GetHandle ("setParamX:");
		[CompilerGenerated]
		const string selSetParamY_ = "setParamY:";
		static readonly IntPtr selSetParamY_Handle = Selector.GetHandle ("setParamY:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("TCUploadPicDic");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public TCUploadPicDic () : base (NSObjectFlag.Empty)
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
		public TCUploadPicDic (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public TCUploadPicDic (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public TCUploadPicDic (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		static object __mt_Dictionary_var_static;
		[CompilerGenerated]
		public static TCUploadPicDic Dictionary {
			[Export ("dictionary")]
			get {
				TCUploadPicDic ret;
				ret =  Runtime.GetNSObject<TCUploadPicDic> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (class_ptr, selDictionaryHandle));
				if (!NSObject.IsNewRefcountEnabled ())
					__mt_Dictionary_var_static = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual string ParamAlbumid {
			[Export ("paramAlbumid", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selParamAlbumidHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selParamAlbumidHandle));
				}
			}
			
			[Export ("setParamAlbumid:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetParamAlbumid_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetParamAlbumid_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual string ParamMobile {
			[Export ("paramMobile", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selParamMobileHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selParamMobileHandle));
				}
			}
			
			[Export ("setParamMobile:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetParamMobile_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetParamMobile_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual string ParamNeedfeed {
			[Export ("paramNeedfeed", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selParamNeedfeedHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selParamNeedfeedHandle));
				}
			}
			
			[Export ("setParamNeedfeed:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetParamNeedfeed_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetParamNeedfeed_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual string ParamPhotodesc {
			[Export ("paramPhotodesc", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selParamPhotodescHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selParamPhotodescHandle));
				}
			}
			
			[Export ("setParamPhotodesc:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetParamPhotodesc_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetParamPhotodesc_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual string ParamPicnum {
			[Export ("paramPicnum", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selParamPicnumHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selParamPicnumHandle));
				}
			}
			
			[Export ("setParamPicnum:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetParamPicnum_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetParamPicnum_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		object __mt_ParamPicture_var;
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIImage ParamPicture {
			[Export ("paramPicture", ArgumentSemantic.Retain)]
			get {
				global::MonoTouch.UIKit.UIImage ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::MonoTouch.UIKit.UIImage> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selParamPictureHandle));
				} else {
					ret =  Runtime.GetNSObject<global::MonoTouch.UIKit.UIImage> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selParamPictureHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_ParamPicture_var = ret;
				return ret;
			}
			
			[Export ("setParamPicture:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetParamPicture_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetParamPicture_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_ParamPicture_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual string ParamSuccessnum {
			[Export ("paramSuccessnum", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selParamSuccessnumHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selParamSuccessnumHandle));
				}
			}
			
			[Export ("setParamSuccessnum:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetParamSuccessnum_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetParamSuccessnum_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual string ParamTitle {
			[Export ("paramTitle", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selParamTitleHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selParamTitleHandle));
				}
			}
			
			[Export ("setParamTitle:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetParamTitle_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetParamTitle_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual string ParamX {
			[Export ("paramX", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selParamXHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selParamXHandle));
				}
			}
			
			[Export ("setParamX:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetParamX_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetParamX_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual string ParamY {
			[Export ("paramY", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selParamYHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selParamYHandle));
				}
			}
			
			[Export ("setParamY:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetParamY_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetParamY_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_ParamPicture_var = null;
			}
		}
	} /* class TCUploadPicDic */
}
