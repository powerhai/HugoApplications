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
	[Register("TencentApiResp", true)]
	public unsafe partial class TencentApiResp : NSObject {
		[CompilerGenerated]
		const string selNRetCode = "nRetCode";
		static readonly IntPtr selNRetCodeHandle = Selector.GetHandle ("nRetCode");
		[CompilerGenerated]
		const string selObjReq = "objReq";
		static readonly IntPtr selObjReqHandle = Selector.GetHandle ("objReq");
		[CompilerGenerated]
		const string selRespFromReq_ = "respFromReq:";
		static readonly IntPtr selRespFromReq_Handle = Selector.GetHandle ("respFromReq:");
		[CompilerGenerated]
		const string selSetNRetCode_ = "setNRetCode:";
		static readonly IntPtr selSetNRetCode_Handle = Selector.GetHandle ("setNRetCode:");
		[CompilerGenerated]
		const string selSetObjReq_ = "setObjReq:";
		static readonly IntPtr selSetObjReq_Handle = Selector.GetHandle ("setObjReq:");
		[CompilerGenerated]
		const string selSetSRetMsg_ = "setSRetMsg:";
		static readonly IntPtr selSetSRetMsg_Handle = Selector.GetHandle ("setSRetMsg:");
		[CompilerGenerated]
		const string selSRetMsg = "sRetMsg";
		static readonly IntPtr selSRetMsgHandle = Selector.GetHandle ("sRetMsg");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("TencentApiResp");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public TencentApiResp () : base (NSObjectFlag.Empty)
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
		public TencentApiResp (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public TencentApiResp (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public TencentApiResp (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("respFromReq:")]
		[CompilerGenerated]
		public static TencentApiResp RespFromReq (TencentApiReq req)
		{
			if (req == null)
				throw new ArgumentNullException ("req");
			return  Runtime.GetNSObject<TencentApiResp> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, selRespFromReq_Handle, req.Handle));
		}
		
		[CompilerGenerated]
		public virtual int NRetCode {
			[Export ("nRetCode")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selNRetCodeHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selNRetCodeHandle);
				}
			}
			
			[Export ("setNRetCode:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_int (this.Handle, selSetNRetCode_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, selSetNRetCode_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_ObjReq_var;
		[CompilerGenerated]
		public virtual TencentApiReq ObjReq {
			[Export ("objReq", ArgumentSemantic.Retain)]
			get {
				TencentApiReq ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<TencentApiReq> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selObjReqHandle));
				} else {
					ret =  Runtime.GetNSObject<TencentApiReq> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selObjReqHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_ObjReq_var = ret;
				return ret;
			}
			
			[Export ("setObjReq:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetObjReq_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetObjReq_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_ObjReq_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual string SRetMsg {
			[Export ("sRetMsg", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selSRetMsgHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selSRetMsgHandle));
				}
			}
			
			[Export ("setSRetMsg:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetSRetMsg_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetSRetMsg_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_ObjReq_var = null;
			}
		}
	} /* class TencentApiResp */
}
