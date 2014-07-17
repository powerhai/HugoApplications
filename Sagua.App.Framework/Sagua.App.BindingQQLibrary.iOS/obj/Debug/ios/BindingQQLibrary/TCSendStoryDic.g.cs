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
	[Register("TCSendStoryDic", true)]
	public unsafe partial class TCSendStoryDic : TCAPIRequest {
		[CompilerGenerated]
		const string selDictionary = "dictionary";
		static readonly IntPtr selDictionaryHandle = Selector.GetHandle ("dictionary");
		[CompilerGenerated]
		const string selParamAct = "paramAct";
		static readonly IntPtr selParamActHandle = Selector.GetHandle ("paramAct");
		[CompilerGenerated]
		const string selParamDescription = "paramDescription";
		static readonly IntPtr selParamDescriptionHandle = Selector.GetHandle ("paramDescription");
		[CompilerGenerated]
		const string selParamPics = "paramPics";
		static readonly IntPtr selParamPicsHandle = Selector.GetHandle ("paramPics");
		[CompilerGenerated]
		const string selParamShareUrl = "paramShareUrl";
		static readonly IntPtr selParamShareUrlHandle = Selector.GetHandle ("paramShareUrl");
		[CompilerGenerated]
		const string selParamSummary = "paramSummary";
		static readonly IntPtr selParamSummaryHandle = Selector.GetHandle ("paramSummary");
		[CompilerGenerated]
		const string selParamTitle = "paramTitle";
		static readonly IntPtr selParamTitleHandle = Selector.GetHandle ("paramTitle");
		[CompilerGenerated]
		const string selSetParamAct_ = "setParamAct:";
		static readonly IntPtr selSetParamAct_Handle = Selector.GetHandle ("setParamAct:");
		[CompilerGenerated]
		const string selSetParamDescription_ = "setParamDescription:";
		static readonly IntPtr selSetParamDescription_Handle = Selector.GetHandle ("setParamDescription:");
		[CompilerGenerated]
		const string selSetParamPics_ = "setParamPics:";
		static readonly IntPtr selSetParamPics_Handle = Selector.GetHandle ("setParamPics:");
		[CompilerGenerated]
		const string selSetParamShareUrl_ = "setParamShareUrl:";
		static readonly IntPtr selSetParamShareUrl_Handle = Selector.GetHandle ("setParamShareUrl:");
		[CompilerGenerated]
		const string selSetParamSummary_ = "setParamSummary:";
		static readonly IntPtr selSetParamSummary_Handle = Selector.GetHandle ("setParamSummary:");
		[CompilerGenerated]
		const string selSetParamTitle_ = "setParamTitle:";
		static readonly IntPtr selSetParamTitle_Handle = Selector.GetHandle ("setParamTitle:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("TCSendStoryDic");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public TCSendStoryDic () : base (NSObjectFlag.Empty)
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
		public TCSendStoryDic (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public TCSendStoryDic (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public TCSendStoryDic (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		static object __mt_Dictionary_var_static;
		[CompilerGenerated]
		public static TCSendStoryDic Dictionary {
			[Export ("dictionary")]
			get {
				TCSendStoryDic ret;
				ret =  Runtime.GetNSObject<TCSendStoryDic> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (class_ptr, selDictionaryHandle));
				if (!NSObject.IsNewRefcountEnabled ())
					__mt_Dictionary_var_static = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual string ParamAct {
			[Export ("paramAct", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selParamActHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selParamActHandle));
				}
			}
			
			[Export ("setParamAct:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetParamAct_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetParamAct_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual string ParamDescription {
			[Export ("paramDescription", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selParamDescriptionHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selParamDescriptionHandle));
				}
			}
			
			[Export ("setParamDescription:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetParamDescription_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetParamDescription_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual string ParamPics {
			[Export ("paramPics", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selParamPicsHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selParamPicsHandle));
				}
			}
			
			[Export ("setParamPics:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetParamPics_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetParamPics_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual string ParamShareUrl {
			[Export ("paramShareUrl", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selParamShareUrlHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selParamShareUrlHandle));
				}
			}
			
			[Export ("setParamShareUrl:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetParamShareUrl_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetParamShareUrl_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual string ParamSummary {
			[Export ("paramSummary", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selParamSummaryHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selParamSummaryHandle));
				}
			}
			
			[Export ("setParamSummary:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetParamSummary_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetParamSummary_Handle, nsvalue);
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
		
	} /* class TCSendStoryDic */
}
