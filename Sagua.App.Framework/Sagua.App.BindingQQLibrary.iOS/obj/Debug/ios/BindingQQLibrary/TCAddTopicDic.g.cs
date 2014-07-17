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
	[Register("TCAddTopicDic", true)]
	public unsafe partial class TCAddTopicDic : TCAPIRequest {
		[CompilerGenerated]
		const string selDictionary = "dictionary";
		static readonly IntPtr selDictionaryHandle = Selector.GetHandle ("dictionary");
		[CompilerGenerated]
		const string selParamCon = "paramCon";
		static readonly IntPtr selParamConHandle = Selector.GetHandle ("paramCon");
		[CompilerGenerated]
		const string selParamLbs_nm = "paramLbs_nm";
		static readonly IntPtr selParamLbs_nmHandle = Selector.GetHandle ("paramLbs_nm");
		[CompilerGenerated]
		const string selParamLbs_x = "paramLbs_x";
		static readonly IntPtr selParamLbs_xHandle = Selector.GetHandle ("paramLbs_x");
		[CompilerGenerated]
		const string selParamLbs_y = "paramLbs_y";
		static readonly IntPtr selParamLbs_yHandle = Selector.GetHandle ("paramLbs_y");
		[CompilerGenerated]
		const string selParamRichtype = "paramRichtype";
		static readonly IntPtr selParamRichtypeHandle = Selector.GetHandle ("paramRichtype");
		[CompilerGenerated]
		const string selParamRichval = "paramRichval";
		static readonly IntPtr selParamRichvalHandle = Selector.GetHandle ("paramRichval");
		[CompilerGenerated]
		const string selParamThirdSource = "paramThirdSource";
		static readonly IntPtr selParamThirdSourceHandle = Selector.GetHandle ("paramThirdSource");
		[CompilerGenerated]
		const string selSetParamCon_ = "setParamCon:";
		static readonly IntPtr selSetParamCon_Handle = Selector.GetHandle ("setParamCon:");
		[CompilerGenerated]
		const string selSetParamLbs_nm_ = "setParamLbs_nm:";
		static readonly IntPtr selSetParamLbs_nm_Handle = Selector.GetHandle ("setParamLbs_nm:");
		[CompilerGenerated]
		const string selSetParamLbs_x_ = "setParamLbs_x:";
		static readonly IntPtr selSetParamLbs_x_Handle = Selector.GetHandle ("setParamLbs_x:");
		[CompilerGenerated]
		const string selSetParamLbs_y_ = "setParamLbs_y:";
		static readonly IntPtr selSetParamLbs_y_Handle = Selector.GetHandle ("setParamLbs_y:");
		[CompilerGenerated]
		const string selSetParamRichtype_ = "setParamRichtype:";
		static readonly IntPtr selSetParamRichtype_Handle = Selector.GetHandle ("setParamRichtype:");
		[CompilerGenerated]
		const string selSetParamRichval_ = "setParamRichval:";
		static readonly IntPtr selSetParamRichval_Handle = Selector.GetHandle ("setParamRichval:");
		[CompilerGenerated]
		const string selSetParamThirdSource_ = "setParamThirdSource:";
		static readonly IntPtr selSetParamThirdSource_Handle = Selector.GetHandle ("setParamThirdSource:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("TCAddTopicDic");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public TCAddTopicDic () : base (NSObjectFlag.Empty)
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
		public TCAddTopicDic (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public TCAddTopicDic (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public TCAddTopicDic (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		static object __mt_Dictionary_var_static;
		[CompilerGenerated]
		public static TCAddTopicDic Dictionary {
			[Export ("dictionary")]
			get {
				TCAddTopicDic ret;
				ret =  Runtime.GetNSObject<TCAddTopicDic> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (class_ptr, selDictionaryHandle));
				if (!NSObject.IsNewRefcountEnabled ())
					__mt_Dictionary_var_static = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual string ParamCon {
			[Export ("paramCon", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selParamConHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selParamConHandle));
				}
			}
			
			[Export ("setParamCon:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetParamCon_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetParamCon_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual string ParamLbs_nm {
			[Export ("paramLbs_nm", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selParamLbs_nmHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selParamLbs_nmHandle));
				}
			}
			
			[Export ("setParamLbs_nm:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetParamLbs_nm_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetParamLbs_nm_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual string ParamLbs_x {
			[Export ("paramLbs_x", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selParamLbs_xHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selParamLbs_xHandle));
				}
			}
			
			[Export ("setParamLbs_x:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetParamLbs_x_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetParamLbs_x_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual string ParamLbs_y {
			[Export ("paramLbs_y", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selParamLbs_yHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selParamLbs_yHandle));
				}
			}
			
			[Export ("setParamLbs_y:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetParamLbs_y_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetParamLbs_y_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual string ParamRichtype {
			[Export ("paramRichtype", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selParamRichtypeHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selParamRichtypeHandle));
				}
			}
			
			[Export ("setParamRichtype:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetParamRichtype_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetParamRichtype_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual string ParamRichval {
			[Export ("paramRichval", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selParamRichvalHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selParamRichvalHandle));
				}
			}
			
			[Export ("setParamRichval:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetParamRichval_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetParamRichval_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual string ParamThirdSource {
			[Export ("paramThirdSource", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selParamThirdSourceHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selParamThirdSourceHandle));
				}
			}
			
			[Export ("setParamThirdSource:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetParamThirdSource_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetParamThirdSource_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
	} /* class TCAddTopicDic */
}
