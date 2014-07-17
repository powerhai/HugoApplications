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
	[Register("TencentApiReq", true)]
	public unsafe partial class TencentApiReq : NSObject {
		[CompilerGenerated]
		const string selArrMessage = "arrMessage";
		static readonly IntPtr selArrMessageHandle = Selector.GetHandle ("arrMessage");
		[CompilerGenerated]
		const string selNMessageType = "nMessageType";
		static readonly IntPtr selNMessageTypeHandle = Selector.GetHandle ("nMessageType");
		[CompilerGenerated]
		const string selNPlatform = "nPlatform";
		static readonly IntPtr selNPlatformHandle = Selector.GetHandle ("nPlatform");
		[CompilerGenerated]
		const string selNSdkVersion = "nSdkVersion";
		static readonly IntPtr selNSdkVersionHandle = Selector.GetHandle ("nSdkVersion");
		[CompilerGenerated]
		const string selNSeq = "nSeq";
		static readonly IntPtr selNSeqHandle = Selector.GetHandle ("nSeq");
		[CompilerGenerated]
		const string selReqFromSeqType_ = "reqFromSeq:type:";
		static readonly IntPtr selReqFromSeqType_Handle = Selector.GetHandle ("reqFromSeq:type:");
		[CompilerGenerated]
		const string selSAppID = "sAppID";
		static readonly IntPtr selSAppIDHandle = Selector.GetHandle ("sAppID");
		[CompilerGenerated]
		const string selSDescription = "sDescription";
		static readonly IntPtr selSDescriptionHandle = Selector.GetHandle ("sDescription");
		[CompilerGenerated]
		const string selSetArrMessage_ = "setArrMessage:";
		static readonly IntPtr selSetArrMessage_Handle = Selector.GetHandle ("setArrMessage:");
		[CompilerGenerated]
		const string selSetSAppID_ = "setSAppID:";
		static readonly IntPtr selSetSAppID_Handle = Selector.GetHandle ("setSAppID:");
		[CompilerGenerated]
		const string selSetSDescription_ = "setSDescription:";
		static readonly IntPtr selSetSDescription_Handle = Selector.GetHandle ("setSDescription:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("TencentApiReq");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public TencentApiReq () : base (NSObjectFlag.Empty)
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
		public TencentApiReq (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public TencentApiReq (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public TencentApiReq (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("reqFromSeq:type:")]
		[CompilerGenerated]
		public static TencentApiReq ReqFromSeq (int apiSeq, TencentReqMessageType type)
		{
			return  Runtime.GetNSObject<TencentApiReq> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_int_int (class_ptr, selReqFromSeqType_Handle, apiSeq, (int)type));
		}
		
		[CompilerGenerated]
		object __mt_ArrMessage_var;
		[CompilerGenerated]
		public virtual NSObject[] ArrMessage {
			[Export ("arrMessage", ArgumentSemantic.Retain)]
			get {
				NSObject[] ret;
				if (IsDirectBinding) {
					ret = NSArray.ArrayFromHandle<MonoTouch.Foundation.NSObject>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selArrMessageHandle));
				} else {
					ret = NSArray.ArrayFromHandle<MonoTouch.Foundation.NSObject>(MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selArrMessageHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_ArrMessage_var = ret;
				return ret;
			}
			
			[Export ("setArrMessage:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsa_value = NSArray.FromNSObjects (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetArrMessage_Handle, nsa_value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetArrMessage_Handle, nsa_value.Handle);
				}
				nsa_value.Dispose ();
				
				if (!IsNewRefcountEnabled ())
					__mt_ArrMessage_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual int NMessageType {
			[Export ("nMessageType")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selNMessageTypeHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selNMessageTypeHandle);
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual int NPlatform {
			[Export ("nPlatform")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selNPlatformHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selNPlatformHandle);
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual int NSdkVersion {
			[Export ("nSdkVersion")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selNSdkVersionHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selNSdkVersionHandle);
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual int NSeq {
			[Export ("nSeq")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selNSeqHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selNSeqHandle);
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual string SAppID {
			[Export ("sAppID", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selSAppIDHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selSAppIDHandle));
				}
			}
			
			[Export ("setSAppID:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetSAppID_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetSAppID_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual string SDescription {
			[Export ("sDescription", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selSDescriptionHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selSDescriptionHandle));
				}
			}
			
			[Export ("setSDescription:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetSDescription_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetSDescription_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_ArrMessage_var = null;
			}
		}
	} /* class TencentApiReq */
}
