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
	[Register("WBHttpRequest", true)]
	public unsafe partial class WBHttpRequest : NSObject {
		[CompilerGenerated]
		const string selDelegate = "delegate";
		static readonly IntPtr selDelegateHandle = Selector.GetHandle ("delegate");
		[CompilerGenerated]
		const string selDisconnect = "disconnect";
		static readonly IntPtr selDisconnectHandle = Selector.GetHandle ("disconnect");
		[CompilerGenerated]
		const string selHttpMethod = "httpMethod";
		static readonly IntPtr selHttpMethodHandle = Selector.GetHandle ("httpMethod");
		[CompilerGenerated]
		const string selParams = "params";
		static readonly IntPtr selParamsHandle = Selector.GetHandle ("params");
		[CompilerGenerated]
		const string selRequestWithAccessTokenUrlHttpMethodParamsDelegateWithTag_ = "requestWithAccessToken:url:httpMethod:params:delegate:withTag:";
		static readonly IntPtr selRequestWithAccessTokenUrlHttpMethodParamsDelegateWithTag_Handle = Selector.GetHandle ("requestWithAccessToken:url:httpMethod:params:delegate:withTag:");
		[CompilerGenerated]
		const string selRequestWithURLHttpMethodParamsDelegateWithTag_ = "requestWithURL:httpMethod:params:delegate:withTag:";
		static readonly IntPtr selRequestWithURLHttpMethodParamsDelegateWithTag_Handle = Selector.GetHandle ("requestWithURL:httpMethod:params:delegate:withTag:");
		[CompilerGenerated]
		const string selSetDelegate_ = "setDelegate:";
		static readonly IntPtr selSetDelegate_Handle = Selector.GetHandle ("setDelegate:");
		[CompilerGenerated]
		const string selSetHttpMethod_ = "setHttpMethod:";
		static readonly IntPtr selSetHttpMethod_Handle = Selector.GetHandle ("setHttpMethod:");
		[CompilerGenerated]
		const string selSetParams_ = "setParams:";
		static readonly IntPtr selSetParams_Handle = Selector.GetHandle ("setParams:");
		[CompilerGenerated]
		const string selSetTag_ = "setTag:";
		static readonly IntPtr selSetTag_Handle = Selector.GetHandle ("setTag:");
		[CompilerGenerated]
		const string selSetUrl_ = "setUrl:";
		static readonly IntPtr selSetUrl_Handle = Selector.GetHandle ("setUrl:");
		[CompilerGenerated]
		const string selTag = "tag";
		static readonly IntPtr selTagHandle = Selector.GetHandle ("tag");
		[CompilerGenerated]
		const string selUrl = "url";
		static readonly IntPtr selUrlHandle = Selector.GetHandle ("url");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("WBHttpRequest");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public WBHttpRequest () : base (NSObjectFlag.Empty)
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
		public WBHttpRequest (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public WBHttpRequest (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public WBHttpRequest (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("disconnect")]
		[CompilerGenerated]
		public virtual void Disconnect ()
		{
			if (IsDirectBinding) {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend (this.Handle, selDisconnectHandle);
			} else {
				MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper (this.SuperHandle, selDisconnectHandle);
			}
		}
		
		[Export ("requestWithAccessToken:url:httpMethod:params:delegate:withTag:")]
		[CompilerGenerated]
		public static WBHttpRequest RequestWithAccessToken (string accessToken, string url, string httpMethod, NSDictionary paramsc, WBHttpRequestDelegate delegatec, string tag)
		{
			if (accessToken == null)
				throw new ArgumentNullException ("accessToken");
			if (url == null)
				throw new ArgumentNullException ("url");
			if (httpMethod == null)
				throw new ArgumentNullException ("httpMethod");
			if (paramsc == null)
				throw new ArgumentNullException ("paramsc");
			if (delegatec == null)
				throw new ArgumentNullException ("delegatec");
			if (tag == null)
				throw new ArgumentNullException ("tag");
			var nsaccessToken = NSString.CreateNative (accessToken);
			var nsurl = NSString.CreateNative (url);
			var nshttpMethod = NSString.CreateNative (httpMethod);
			var nstag = NSString.CreateNative (tag);
			
			WBHttpRequest ret;
			ret =  Runtime.GetNSObject<WBHttpRequest> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr (class_ptr, selRequestWithAccessTokenUrlHttpMethodParamsDelegateWithTag_Handle, nsaccessToken, nsurl, nshttpMethod, paramsc.Handle, delegatec.Handle, nstag));
			NSString.ReleaseNative (nsaccessToken);
			NSString.ReleaseNative (nsurl);
			NSString.ReleaseNative (nshttpMethod);
			NSString.ReleaseNative (nstag);
			
			return ret;
		}
		
		[Export ("requestWithURL:httpMethod:params:delegate:withTag:")]
		[CompilerGenerated]
		public static WBHttpRequest RequestWithURL (string url, string httpMethod, NSDictionary paramsc, WBHttpRequestDelegate delegatec, string tag)
		{
			if (url == null)
				throw new ArgumentNullException ("url");
			if (httpMethod == null)
				throw new ArgumentNullException ("httpMethod");
			if (paramsc == null)
				throw new ArgumentNullException ("paramsc");
			if (delegatec == null)
				throw new ArgumentNullException ("delegatec");
			if (tag == null)
				throw new ArgumentNullException ("tag");
			var nsurl = NSString.CreateNative (url);
			var nshttpMethod = NSString.CreateNative (httpMethod);
			var nstag = NSString.CreateNative (tag);
			
			WBHttpRequest ret;
			ret =  Runtime.GetNSObject<WBHttpRequest> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr_IntPtr (class_ptr, selRequestWithURLHttpMethodParamsDelegateWithTag_Handle, nsurl, nshttpMethod, paramsc.Handle, delegatec.Handle, nstag));
			NSString.ReleaseNative (nsurl);
			NSString.ReleaseNative (nshttpMethod);
			NSString.ReleaseNative (nstag);
			
			return ret;
		}
		
		[CompilerGenerated]
		object __mt_Delegate_var;
		[CompilerGenerated]
		public virtual WBHttpRequestDelegate Delegate {
			[Export ("delegate", ArgumentSemantic.UnsafeUnretained)]
			get {
				WBHttpRequestDelegate ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<WBHttpRequestDelegate> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selDelegateHandle));
				} else {
					ret =  Runtime.GetNSObject<WBHttpRequestDelegate> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selDelegateHandle));
				}
				MarkDirty ();
				__mt_Delegate_var = ret;
				return ret;
			}
			
			[Export ("setDelegate:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetDelegate_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetDelegate_Handle, value.Handle);
				}
				MarkDirty ();
				__mt_Delegate_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual string HttpMethod {
			[Export ("httpMethod", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selHttpMethodHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selHttpMethodHandle));
				}
			}
			
			[Export ("setHttpMethod:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetHttpMethod_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetHttpMethod_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		object __mt_Params_var;
		[CompilerGenerated]
		public virtual NSDictionary Params {
			[Export ("params", ArgumentSemantic.Retain)]
			get {
				NSDictionary ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selParamsHandle));
				} else {
					ret =  Runtime.GetNSObject<NSDictionary> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selParamsHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_Params_var = ret;
				return ret;
			}
			
			[Export ("setParams:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetParams_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetParams_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_Params_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual string Tag {
			[Export ("tag", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selTagHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selTagHandle));
				}
			}
			
			[Export ("setTag:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetTag_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetTag_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual string Url {
			[Export ("url", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selUrlHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selUrlHandle));
				}
			}
			
			[Export ("setUrl:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetUrl_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetUrl_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_Delegate_var = null;
				__mt_Params_var = null;
			}
		}
	} /* class WBHttpRequest */
}
