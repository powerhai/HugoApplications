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
	[Register("TCAddShareDic", true)]
	public unsafe partial class TCAddShareDic : TCAPIRequest {
		[CompilerGenerated]
		const string selDictionary = "dictionary";
		static readonly IntPtr selDictionaryHandle = Selector.GetHandle ("dictionary");
		[CompilerGenerated]
		const string selParamComment = "paramComment";
		static readonly IntPtr selParamCommentHandle = Selector.GetHandle ("paramComment");
		[CompilerGenerated]
		const string selParamFromurl = "paramFromurl";
		static readonly IntPtr selParamFromurlHandle = Selector.GetHandle ("paramFromurl");
		[CompilerGenerated]
		const string selParamImages = "paramImages";
		static readonly IntPtr selParamImagesHandle = Selector.GetHandle ("paramImages");
		[CompilerGenerated]
		const string selParamNswb = "paramNswb";
		static readonly IntPtr selParamNswbHandle = Selector.GetHandle ("paramNswb");
		[CompilerGenerated]
		const string selParamPlayurl = "paramPlayurl";
		static readonly IntPtr selParamPlayurlHandle = Selector.GetHandle ("paramPlayurl");
		[CompilerGenerated]
		const string selParamSite = "paramSite";
		static readonly IntPtr selParamSiteHandle = Selector.GetHandle ("paramSite");
		[CompilerGenerated]
		const string selParamSummary = "paramSummary";
		static readonly IntPtr selParamSummaryHandle = Selector.GetHandle ("paramSummary");
		[CompilerGenerated]
		const string selParamTitle = "paramTitle";
		static readonly IntPtr selParamTitleHandle = Selector.GetHandle ("paramTitle");
		[CompilerGenerated]
		const string selParamType = "paramType";
		static readonly IntPtr selParamTypeHandle = Selector.GetHandle ("paramType");
		[CompilerGenerated]
		const string selParamUrl = "paramUrl";
		static readonly IntPtr selParamUrlHandle = Selector.GetHandle ("paramUrl");
		[CompilerGenerated]
		const string selSetParamComment_ = "setParamComment:";
		static readonly IntPtr selSetParamComment_Handle = Selector.GetHandle ("setParamComment:");
		[CompilerGenerated]
		const string selSetParamFromurl_ = "setParamFromurl:";
		static readonly IntPtr selSetParamFromurl_Handle = Selector.GetHandle ("setParamFromurl:");
		[CompilerGenerated]
		const string selSetParamImages_ = "setParamImages:";
		static readonly IntPtr selSetParamImages_Handle = Selector.GetHandle ("setParamImages:");
		[CompilerGenerated]
		const string selSetParamNswb_ = "setParamNswb:";
		static readonly IntPtr selSetParamNswb_Handle = Selector.GetHandle ("setParamNswb:");
		[CompilerGenerated]
		const string selSetParamPlayurl_ = "setParamPlayurl:";
		static readonly IntPtr selSetParamPlayurl_Handle = Selector.GetHandle ("setParamPlayurl:");
		[CompilerGenerated]
		const string selSetParamSite_ = "setParamSite:";
		static readonly IntPtr selSetParamSite_Handle = Selector.GetHandle ("setParamSite:");
		[CompilerGenerated]
		const string selSetParamSummary_ = "setParamSummary:";
		static readonly IntPtr selSetParamSummary_Handle = Selector.GetHandle ("setParamSummary:");
		[CompilerGenerated]
		const string selSetParamTitle_ = "setParamTitle:";
		static readonly IntPtr selSetParamTitle_Handle = Selector.GetHandle ("setParamTitle:");
		[CompilerGenerated]
		const string selSetParamType_ = "setParamType:";
		static readonly IntPtr selSetParamType_Handle = Selector.GetHandle ("setParamType:");
		[CompilerGenerated]
		const string selSetParamUrl_ = "setParamUrl:";
		static readonly IntPtr selSetParamUrl_Handle = Selector.GetHandle ("setParamUrl:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("TCAddShareDic");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public TCAddShareDic () : base (NSObjectFlag.Empty)
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
		public TCAddShareDic (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public TCAddShareDic (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public TCAddShareDic (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		static object __mt_Dictionary_var_static;
		[CompilerGenerated]
		public static TCAddShareDic Dictionary {
			[Export ("dictionary")]
			get {
				TCAddShareDic ret;
				ret =  Runtime.GetNSObject<TCAddShareDic> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (class_ptr, selDictionaryHandle));
				if (!NSObject.IsNewRefcountEnabled ())
					__mt_Dictionary_var_static = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual string ParamComment {
			[Export ("paramComment", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selParamCommentHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selParamCommentHandle));
				}
			}
			
			[Export ("setParamComment:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetParamComment_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetParamComment_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual string ParamFromurl {
			[Export ("paramFromurl", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selParamFromurlHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selParamFromurlHandle));
				}
			}
			
			[Export ("setParamFromurl:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetParamFromurl_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetParamFromurl_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual string ParamImages {
			[Export ("paramImages", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selParamImagesHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selParamImagesHandle));
				}
			}
			
			[Export ("setParamImages:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetParamImages_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetParamImages_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual string ParamNswb {
			[Export ("paramNswb", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selParamNswbHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selParamNswbHandle));
				}
			}
			
			[Export ("setParamNswb:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetParamNswb_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetParamNswb_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual string ParamPlayurl {
			[Export ("paramPlayurl", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selParamPlayurlHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selParamPlayurlHandle));
				}
			}
			
			[Export ("setParamPlayurl:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetParamPlayurl_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetParamPlayurl_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual string ParamSite {
			[Export ("paramSite", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selParamSiteHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selParamSiteHandle));
				}
			}
			
			[Export ("setParamSite:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetParamSite_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetParamSite_Handle, nsvalue);
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
		
		[CompilerGenerated]
		public virtual string ParamType {
			[Export ("paramType", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selParamTypeHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selParamTypeHandle));
				}
			}
			
			[Export ("setParamType:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetParamType_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetParamType_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual string ParamUrl {
			[Export ("paramUrl", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selParamUrlHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selParamUrlHandle));
				}
			}
			
			[Export ("setParamUrl:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetParamUrl_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetParamUrl_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
	} /* class TCAddShareDic */
}
