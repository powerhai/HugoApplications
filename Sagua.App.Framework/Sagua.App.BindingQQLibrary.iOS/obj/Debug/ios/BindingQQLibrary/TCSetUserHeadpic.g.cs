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
	[Register("TCSetUserHeadpic", true)]
	public unsafe partial class TCSetUserHeadpic : TCAPIRequest {
		[CompilerGenerated]
		const string selDictionary = "dictionary";
		static readonly IntPtr selDictionaryHandle = Selector.GetHandle ("dictionary");
		[CompilerGenerated]
		const string selParamFileName = "paramFileName";
		static readonly IntPtr selParamFileNameHandle = Selector.GetHandle ("paramFileName");
		[CompilerGenerated]
		const string selParamImage = "paramImage";
		static readonly IntPtr selParamImageHandle = Selector.GetHandle ("paramImage");
		[CompilerGenerated]
		const string selSetParamFileName_ = "setParamFileName:";
		static readonly IntPtr selSetParamFileName_Handle = Selector.GetHandle ("setParamFileName:");
		[CompilerGenerated]
		const string selSetParamImage_ = "setParamImage:";
		static readonly IntPtr selSetParamImage_Handle = Selector.GetHandle ("setParamImage:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("TCSetUserHeadpic");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public TCSetUserHeadpic () : base (NSObjectFlag.Empty)
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
		public TCSetUserHeadpic (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public TCSetUserHeadpic (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public TCSetUserHeadpic (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		static object __mt_Dictionary_var_static;
		[CompilerGenerated]
		public static TCSetUserHeadpic Dictionary {
			[Export ("dictionary")]
			get {
				TCSetUserHeadpic ret;
				ret =  Runtime.GetNSObject<TCSetUserHeadpic> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (class_ptr, selDictionaryHandle));
				if (!NSObject.IsNewRefcountEnabled ())
					__mt_Dictionary_var_static = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual string ParamFileName {
			[Export ("paramFileName", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selParamFileNameHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selParamFileNameHandle));
				}
			}
			
			[Export ("setParamFileName:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetParamFileName_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetParamFileName_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		object __mt_ParamImage_var;
		[CompilerGenerated]
		public virtual global::MonoTouch.UIKit.UIImage ParamImage {
			[Export ("paramImage", ArgumentSemantic.Retain)]
			get {
				global::MonoTouch.UIKit.UIImage ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::MonoTouch.UIKit.UIImage> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selParamImageHandle));
				} else {
					ret =  Runtime.GetNSObject<global::MonoTouch.UIKit.UIImage> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selParamImageHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_ParamImage_var = ret;
				return ret;
			}
			
			[Export ("setParamImage:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetParamImage_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetParamImage_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_ParamImage_var = value;
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_ParamImage_var = null;
			}
		}
	} /* class TCSetUserHeadpic */
}
