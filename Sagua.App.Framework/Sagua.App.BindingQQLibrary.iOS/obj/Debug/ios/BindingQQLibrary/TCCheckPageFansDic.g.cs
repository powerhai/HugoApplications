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
	[Register("TCCheckPageFansDic", true)]
	public unsafe partial class TCCheckPageFansDic : TCAPIRequest {
		[CompilerGenerated]
		const string selDictionary = "dictionary";
		static readonly IntPtr selDictionaryHandle = Selector.GetHandle ("dictionary");
		[CompilerGenerated]
		const string selParamPage_id = "paramPage_id";
		static readonly IntPtr selParamPage_idHandle = Selector.GetHandle ("paramPage_id");
		[CompilerGenerated]
		const string selSetParamPage_id_ = "setParamPage_id:";
		static readonly IntPtr selSetParamPage_id_Handle = Selector.GetHandle ("setParamPage_id:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("TCCheckPageFansDic");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public TCCheckPageFansDic () : base (NSObjectFlag.Empty)
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
		public TCCheckPageFansDic (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public TCCheckPageFansDic (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public TCCheckPageFansDic (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		static object __mt_Dictionary_var_static;
		[CompilerGenerated]
		public static TCCheckPageFansDic Dictionary {
			[Export ("dictionary")]
			get {
				TCCheckPageFansDic ret;
				ret =  Runtime.GetNSObject<TCCheckPageFansDic> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (class_ptr, selDictionaryHandle));
				if (!NSObject.IsNewRefcountEnabled ())
					__mt_Dictionary_var_static = ret;
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual string ParamPage_id {
			[Export ("paramPage_id", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selParamPage_idHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selParamPage_idHandle));
				}
			}
			
			[Export ("setParamPage_id:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetParamPage_id_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetParamPage_id_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
	} /* class TCCheckPageFansDic */
}
