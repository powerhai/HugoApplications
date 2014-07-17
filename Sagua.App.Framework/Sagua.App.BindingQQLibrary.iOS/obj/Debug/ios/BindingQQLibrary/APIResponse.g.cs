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
	[Register("APIResponse", true)]
	public unsafe partial class APIResponse : NSObject {
		[CompilerGenerated]
		const string selDetailRetCode = "detailRetCode";
		static readonly IntPtr selDetailRetCodeHandle = Selector.GetHandle ("detailRetCode");
		[CompilerGenerated]
		const string selErrorMsg = "errorMsg";
		static readonly IntPtr selErrorMsgHandle = Selector.GetHandle ("errorMsg");
		[CompilerGenerated]
		const string selJsonResponse = "jsonResponse";
		static readonly IntPtr selJsonResponseHandle = Selector.GetHandle ("jsonResponse");
		[CompilerGenerated]
		const string selMessage = "message";
		static readonly IntPtr selMessageHandle = Selector.GetHandle ("message");
		[CompilerGenerated]
		const string selRetCode = "retCode";
		static readonly IntPtr selRetCodeHandle = Selector.GetHandle ("retCode");
		[CompilerGenerated]
		const string selSeq = "seq";
		static readonly IntPtr selSeqHandle = Selector.GetHandle ("seq");
		[CompilerGenerated]
		const string selSetDetailRetCode_ = "setDetailRetCode:";
		static readonly IntPtr selSetDetailRetCode_Handle = Selector.GetHandle ("setDetailRetCode:");
		[CompilerGenerated]
		const string selSetErrorMsg_ = "setErrorMsg:";
		static readonly IntPtr selSetErrorMsg_Handle = Selector.GetHandle ("setErrorMsg:");
		[CompilerGenerated]
		const string selSetJsonResponse_ = "setJsonResponse:";
		static readonly IntPtr selSetJsonResponse_Handle = Selector.GetHandle ("setJsonResponse:");
		[CompilerGenerated]
		const string selSetMessage_ = "setMessage:";
		static readonly IntPtr selSetMessage_Handle = Selector.GetHandle ("setMessage:");
		[CompilerGenerated]
		const string selSetRetCode_ = "setRetCode:";
		static readonly IntPtr selSetRetCode_Handle = Selector.GetHandle ("setRetCode:");
		[CompilerGenerated]
		const string selSetSeq_ = "setSeq:";
		static readonly IntPtr selSetSeq_Handle = Selector.GetHandle ("setSeq:");
		[CompilerGenerated]
		const string selSetUserData_ = "setUserData:";
		static readonly IntPtr selSetUserData_Handle = Selector.GetHandle ("setUserData:");
		[CompilerGenerated]
		const string selUserData = "userData";
		static readonly IntPtr selUserDataHandle = Selector.GetHandle ("userData");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("APIResponse");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public APIResponse () : base (NSObjectFlag.Empty)
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
		public APIResponse (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public APIResponse (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public APIResponse (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		public virtual int DetailRetCode {
			[Export ("detailRetCode")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selDetailRetCodeHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selDetailRetCodeHandle);
				}
			}
			
			[Export ("setDetailRetCode:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_int (this.Handle, selSetDetailRetCode_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, selSetDetailRetCode_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual string ErrorMsg {
			[Export ("errorMsg", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selErrorMsgHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selErrorMsgHandle));
				}
			}
			
			[Export ("setErrorMsg:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetErrorMsg_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetErrorMsg_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		object __mt_JsonResponse_var;
		[CompilerGenerated]
		public virtual NSDictionary JsonResponse {
			[Export ("jsonResponse", ArgumentSemantic.Retain)]
			get {
				NSDictionary ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSDictionary> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selJsonResponseHandle));
				} else {
					ret =  Runtime.GetNSObject<NSDictionary> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selJsonResponseHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_JsonResponse_var = ret;
				return ret;
			}
			
			[Export ("setJsonResponse:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetJsonResponse_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetJsonResponse_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_JsonResponse_var = value;
			}
		}
		
		[CompilerGenerated]
		public virtual string Message {
			[Export ("message", ArgumentSemantic.Retain)]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selMessageHandle));
				} else {
					return NSString.FromHandle (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selMessageHandle));
				}
			}
			
			[Export ("setMessage:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetMessage_Handle, nsvalue);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetMessage_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual int RetCode {
			[Export ("retCode")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selRetCodeHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selRetCodeHandle);
				}
			}
			
			[Export ("setRetCode:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_int (this.Handle, selSetRetCode_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, selSetRetCode_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual int Seq {
			[Export ("seq")]
			get {
				if (IsDirectBinding) {
					return MonoTouch.ObjCRuntime.Messaging.int_objc_msgSend (this.Handle, selSeqHandle);
				} else {
					return MonoTouch.ObjCRuntime.Messaging.int_objc_msgSendSuper (this.SuperHandle, selSeqHandle);
				}
			}
			
			[Export ("setSeq:")]
			set {
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_int (this.Handle, selSetSeq_Handle, value);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, selSetSeq_Handle, value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_UserData_var;
		[CompilerGenerated]
		public virtual NSObject UserData {
			[Export ("userData", ArgumentSemantic.Retain)]
			get {
				NSObject ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selUserDataHandle));
				} else {
					ret =  Runtime.GetNSObject<NSObject> (MonoTouch.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selUserDataHandle));
				}
				if (!IsNewRefcountEnabled ())
					__mt_UserData_var = ret;
				return ret;
			}
			
			[Export ("setUserData:", ArgumentSemantic.Retain)]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				if (IsDirectBinding) {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetUserData_Handle, value.Handle);
				} else {
					MonoTouch.ObjCRuntime.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetUserData_Handle, value.Handle);
				}
				if (!IsNewRefcountEnabled ())
					__mt_UserData_var = value;
			}
		}
		
		[CompilerGenerated]
		static NSString _PARAM_APP_DESC;
		[Field ("PARAM_APP_DESC",  "__Internal")]
		public static NSString PARAM_APP_DESC {
			get {
				if (_PARAM_APP_DESC == null)
					_PARAM_APP_DESC = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "PARAM_APP_DESC");
				return _PARAM_APP_DESC;
			}
		}
		[CompilerGenerated]
		static NSString _PARAM_APP_ICON;
		[Field ("PARAM_APP_ICON",  "__Internal")]
		public static NSString PARAM_APP_ICON {
			get {
				if (_PARAM_APP_ICON == null)
					_PARAM_APP_ICON = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "PARAM_APP_ICON");
				return _PARAM_APP_ICON;
			}
		}
		[CompilerGenerated]
		static NSString _PARAM_APP_INVITED_OPENIDS;
		[Field ("PARAM_APP_INVITED_OPENIDS",  "__Internal")]
		public static NSString PARAM_APP_INVITED_OPENIDS {
			get {
				if (_PARAM_APP_INVITED_OPENIDS == null)
					_PARAM_APP_INVITED_OPENIDS = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "PARAM_APP_INVITED_OPENIDS");
				return _PARAM_APP_INVITED_OPENIDS;
			}
		}
		[CompilerGenerated]
		static NSString _PARAM_DATA;
		[Field ("PARAM_DATA",  "__Internal")]
		public static NSString PARAM_DATA {
			get {
				if (_PARAM_DATA == null)
					_PARAM_DATA = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "PARAM_DATA");
				return _PARAM_DATA;
			}
		}
		[CompilerGenerated]
		static NSString _PARAM_MESSAGE;
		[Field ("PARAM_MESSAGE",  "__Internal")]
		public static NSString PARAM_MESSAGE {
			get {
				if (_PARAM_MESSAGE == null)
					_PARAM_MESSAGE = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "PARAM_MESSAGE");
				return _PARAM_MESSAGE;
			}
		}
		[CompilerGenerated]
		static NSString _PARAM_RETCODE;
		[Field ("PARAM_RETCODE",  "__Internal")]
		public static NSString PARAM_RETCODE {
			get {
				if (_PARAM_RETCODE == null)
					_PARAM_RETCODE = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "PARAM_RETCODE");
				return _PARAM_RETCODE;
			}
		}
		[CompilerGenerated]
		static NSString _PARAM_SENDSTORY_ACT;
		[Field ("PARAM_SENDSTORY_ACT",  "__Internal")]
		public static NSString PARAM_SENDSTORY_ACT {
			get {
				if (_PARAM_SENDSTORY_ACT == null)
					_PARAM_SENDSTORY_ACT = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "PARAM_SENDSTORY_ACT");
				return _PARAM_SENDSTORY_ACT;
			}
		}
		[CompilerGenerated]
		static NSString _PARAM_SENDSTORY_COMMENT;
		[Field ("PARAM_SENDSTORY_COMMENT",  "__Internal")]
		public static NSString PARAM_SENDSTORY_COMMENT {
			get {
				if (_PARAM_SENDSTORY_COMMENT == null)
					_PARAM_SENDSTORY_COMMENT = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "PARAM_SENDSTORY_COMMENT");
				return _PARAM_SENDSTORY_COMMENT;
			}
		}
		[CompilerGenerated]
		static NSString _PARAM_SENDSTORY_IMAGE;
		[Field ("PARAM_SENDSTORY_IMAGE",  "__Internal")]
		public static NSString PARAM_SENDSTORY_IMAGE {
			get {
				if (_PARAM_SENDSTORY_IMAGE == null)
					_PARAM_SENDSTORY_IMAGE = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "PARAM_SENDSTORY_IMAGE");
				return _PARAM_SENDSTORY_IMAGE;
			}
		}
		[CompilerGenerated]
		static NSString _PARAM_SENDSTORY_RECEIVER;
		[Field ("PARAM_SENDSTORY_RECEIVER",  "__Internal")]
		public static NSString PARAM_SENDSTORY_RECEIVER {
			get {
				if (_PARAM_SENDSTORY_RECEIVER == null)
					_PARAM_SENDSTORY_RECEIVER = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "PARAM_SENDSTORY_RECEIVER");
				return _PARAM_SENDSTORY_RECEIVER;
			}
		}
		[CompilerGenerated]
		static NSString _PARAM_SENDSTORY_SUMMARY;
		[Field ("PARAM_SENDSTORY_SUMMARY",  "__Internal")]
		public static NSString PARAM_SENDSTORY_SUMMARY {
			get {
				if (_PARAM_SENDSTORY_SUMMARY == null)
					_PARAM_SENDSTORY_SUMMARY = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "PARAM_SENDSTORY_SUMMARY");
				return _PARAM_SENDSTORY_SUMMARY;
			}
		}
		[CompilerGenerated]
		static NSString _PARAM_SENDSTORY_TITLE;
		[Field ("PARAM_SENDSTORY_TITLE",  "__Internal")]
		public static NSString PARAM_SENDSTORY_TITLE {
			get {
				if (_PARAM_SENDSTORY_TITLE == null)
					_PARAM_SENDSTORY_TITLE = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "PARAM_SENDSTORY_TITLE");
				return _PARAM_SENDSTORY_TITLE;
			}
		}
		[CompilerGenerated]
		static NSString _PARAM_SENDSTORY_URL;
		[Field ("PARAM_SENDSTORY_URL",  "__Internal")]
		public static NSString PARAM_SENDSTORY_URL {
			get {
				if (_PARAM_SENDSTORY_URL == null)
					_PARAM_SENDSTORY_URL = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "PARAM_SENDSTORY_URL");
				return _PARAM_SENDSTORY_URL;
			}
		}
		[CompilerGenerated]
		static NSString _PARAM_SETUSERHEAD_FILENAME;
		[Field ("PARAM_SETUSERHEAD_FILENAME",  "__Internal")]
		public static NSString PARAM_SETUSERHEAD_FILENAME {
			get {
				if (_PARAM_SETUSERHEAD_FILENAME == null)
					_PARAM_SETUSERHEAD_FILENAME = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "PARAM_SETUSERHEAD_FILENAME");
				return _PARAM_SETUSERHEAD_FILENAME;
			}
		}
		[CompilerGenerated]
		static NSString _PARAM_SETUSERHEAD_PIC;
		[Field ("PARAM_SETUSERHEAD_PIC",  "__Internal")]
		public static NSString PARAM_SETUSERHEAD_PIC {
			get {
				if (_PARAM_SETUSERHEAD_PIC == null)
					_PARAM_SETUSERHEAD_PIC = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "PARAM_SETUSERHEAD_PIC");
				return _PARAM_SETUSERHEAD_PIC;
			}
		}
		[CompilerGenerated]
		static NSString _PARAM_USER_DATA;
		[Field ("PARAM_USER_DATA",  "__Internal")]
		public static NSString PARAM_USER_DATA {
			get {
				if (_PARAM_USER_DATA == null)
					_PARAM_USER_DATA = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "PARAM_USER_DATA");
				return _PARAM_USER_DATA;
			}
		}
		[CompilerGenerated]
		static NSString _TCOpenSDKErrorKeyExtraInfo;
		[Field ("TCOpenSDKErrorKeyExtraInfo",  "__Internal")]
		public static NSString TCOpenSDKErrorKeyExtraInfo {
			get {
				if (_TCOpenSDKErrorKeyExtraInfo == null)
					_TCOpenSDKErrorKeyExtraInfo = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "TCOpenSDKErrorKeyExtraInfo");
				return _TCOpenSDKErrorKeyExtraInfo;
			}
		}
		[CompilerGenerated]
		static NSString _TCOpenSDKErrorKeyMsg;
		[Field ("TCOpenSDKErrorKeyMsg",  "__Internal")]
		public static NSString TCOpenSDKErrorKeyMsg {
			get {
				if (_TCOpenSDKErrorKeyMsg == null)
					_TCOpenSDKErrorKeyMsg = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "TCOpenSDKErrorKeyMsg");
				return _TCOpenSDKErrorKeyMsg;
			}
		}
		[CompilerGenerated]
		static NSString _TCOpenSDKErrorKeyRetCode;
		[Field ("TCOpenSDKErrorKeyRetCode",  "__Internal")]
		public static NSString TCOpenSDKErrorKeyRetCode {
			get {
				if (_TCOpenSDKErrorKeyRetCode == null)
					_TCOpenSDKErrorKeyRetCode = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "TCOpenSDKErrorKeyRetCode");
				return _TCOpenSDKErrorKeyRetCode;
			}
		}
		[CompilerGenerated]
		static NSString _TCOpenSDKErrorMsgDataParse;
		[Field ("TCOpenSDKErrorMsgDataParse",  "__Internal")]
		public static NSString TCOpenSDKErrorMsgDataParse {
			get {
				if (_TCOpenSDKErrorMsgDataParse == null)
					_TCOpenSDKErrorMsgDataParse = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "TCOpenSDKErrorMsgDataParse");
				return _TCOpenSDKErrorMsgDataParse;
			}
		}
		[CompilerGenerated]
		static NSString _TCOpenSDKErrorMsgIO;
		[Field ("TCOpenSDKErrorMsgIO",  "__Internal")]
		public static NSString TCOpenSDKErrorMsgIO {
			get {
				if (_TCOpenSDKErrorMsgIO == null)
					_TCOpenSDKErrorMsgIO = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "TCOpenSDKErrorMsgIO");
				return _TCOpenSDKErrorMsgIO;
			}
		}
		[CompilerGenerated]
		static NSString _TCOpenSDKErrorMsgNetwork;
		[Field ("TCOpenSDKErrorMsgNetwork",  "__Internal")]
		public static NSString TCOpenSDKErrorMsgNetwork {
			get {
				if (_TCOpenSDKErrorMsgNetwork == null)
					_TCOpenSDKErrorMsgNetwork = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "TCOpenSDKErrorMsgNetwork");
				return _TCOpenSDKErrorMsgNetwork;
			}
		}
		[CompilerGenerated]
		static NSString _TCOpenSDKErrorMsgOperationDeny;
		[Field ("TCOpenSDKErrorMsgOperationDeny",  "__Internal")]
		public static NSString TCOpenSDKErrorMsgOperationDeny {
			get {
				if (_TCOpenSDKErrorMsgOperationDeny == null)
					_TCOpenSDKErrorMsgOperationDeny = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "TCOpenSDKErrorMsgOperationDeny");
				return _TCOpenSDKErrorMsgOperationDeny;
			}
		}
		[CompilerGenerated]
		static NSString _TCOpenSDKErrorMsgParam;
		[Field ("TCOpenSDKErrorMsgParam",  "__Internal")]
		public static NSString TCOpenSDKErrorMsgParam {
			get {
				if (_TCOpenSDKErrorMsgParam == null)
					_TCOpenSDKErrorMsgParam = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "TCOpenSDKErrorMsgParam");
				return _TCOpenSDKErrorMsgParam;
			}
		}
		[CompilerGenerated]
		static NSString _TCOpenSDKErrorMsgReLogin;
		[Field ("TCOpenSDKErrorMsgReLogin",  "__Internal")]
		public static NSString TCOpenSDKErrorMsgReLogin {
			get {
				if (_TCOpenSDKErrorMsgReLogin == null)
					_TCOpenSDKErrorMsgReLogin = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "TCOpenSDKErrorMsgReLogin");
				return _TCOpenSDKErrorMsgReLogin;
			}
		}
		[CompilerGenerated]
		static NSString _TCOpenSDKErrorMsgSecurity;
		[Field ("TCOpenSDKErrorMsgSecurity",  "__Internal")]
		public static NSString TCOpenSDKErrorMsgSecurity {
			get {
				if (_TCOpenSDKErrorMsgSecurity == null)
					_TCOpenSDKErrorMsgSecurity = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "TCOpenSDKErrorMsgSecurity");
				return _TCOpenSDKErrorMsgSecurity;
			}
		}
		[CompilerGenerated]
		static NSString _TCOpenSDKErrorMsgServer;
		[Field ("TCOpenSDKErrorMsgServer",  "__Internal")]
		public static NSString TCOpenSDKErrorMsgServer {
			get {
				if (_TCOpenSDKErrorMsgServer == null)
					_TCOpenSDKErrorMsgServer = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "TCOpenSDKErrorMsgServer");
				return _TCOpenSDKErrorMsgServer;
			}
		}
		[CompilerGenerated]
		static NSString _TCOpenSDKErrorMsgSuccess;
		[Field ("TCOpenSDKErrorMsgSuccess",  "__Internal")]
		public static NSString TCOpenSDKErrorMsgSuccess {
			get {
				if (_TCOpenSDKErrorMsgSuccess == null)
					_TCOpenSDKErrorMsgSuccess = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "TCOpenSDKErrorMsgSuccess");
				return _TCOpenSDKErrorMsgSuccess;
			}
		}
		[CompilerGenerated]
		static NSString _TCOpenSDKErrorMsgTimeout;
		[Field ("TCOpenSDKErrorMsgTimeout",  "__Internal")]
		public static NSString TCOpenSDKErrorMsgTimeout {
			get {
				if (_TCOpenSDKErrorMsgTimeout == null)
					_TCOpenSDKErrorMsgTimeout = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "TCOpenSDKErrorMsgTimeout");
				return _TCOpenSDKErrorMsgTimeout;
			}
		}
		[CompilerGenerated]
		static NSString _TCOpenSDKErrorMsgUnknown;
		[Field ("TCOpenSDKErrorMsgUnknown",  "__Internal")]
		public static NSString TCOpenSDKErrorMsgUnknown {
			get {
				if (_TCOpenSDKErrorMsgUnknown == null)
					_TCOpenSDKErrorMsgUnknown = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "TCOpenSDKErrorMsgUnknown");
				return _TCOpenSDKErrorMsgUnknown;
			}
		}
		[CompilerGenerated]
		static NSString _TCOpenSDKErrorMsgUnsupportedAPI;
		[Field ("TCOpenSDKErrorMsgUnsupportedAPI",  "__Internal")]
		public static NSString TCOpenSDKErrorMsgUnsupportedAPI {
			get {
				if (_TCOpenSDKErrorMsgUnsupportedAPI == null)
					_TCOpenSDKErrorMsgUnsupportedAPI = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "TCOpenSDKErrorMsgUnsupportedAPI");
				return _TCOpenSDKErrorMsgUnsupportedAPI;
			}
		}
		[CompilerGenerated]
		static NSString _TCOpenSDKErrorMsgURL;
		[Field ("TCOpenSDKErrorMsgURL",  "__Internal")]
		public static NSString TCOpenSDKErrorMsgURL {
			get {
				if (_TCOpenSDKErrorMsgURL == null)
					_TCOpenSDKErrorMsgURL = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "TCOpenSDKErrorMsgURL");
				return _TCOpenSDKErrorMsgURL;
			}
		}
		[CompilerGenerated]
		static NSString _TCOpenSDKErrorMsgUserCancel;
		[Field ("TCOpenSDKErrorMsgUserCancel",  "__Internal")]
		public static NSString TCOpenSDKErrorMsgUserCancel {
			get {
				if (_TCOpenSDKErrorMsgUserCancel == null)
					_TCOpenSDKErrorMsgUserCancel = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "TCOpenSDKErrorMsgUserCancel");
				return _TCOpenSDKErrorMsgUserCancel;
			}
		}
		[CompilerGenerated]
		static NSString _TCOpenSDKErrorMsgUserHeadPicLarge;
		[Field ("TCOpenSDKErrorMsgUserHeadPicLarge",  "__Internal")]
		public static NSString TCOpenSDKErrorMsgUserHeadPicLarge {
			get {
				if (_TCOpenSDKErrorMsgUserHeadPicLarge == null)
					_TCOpenSDKErrorMsgUserHeadPicLarge = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "TCOpenSDKErrorMsgUserHeadPicLarge");
				return _TCOpenSDKErrorMsgUserHeadPicLarge;
			}
		}
		[CompilerGenerated]
		static NSString _TCOpenSDKErrorMsgWebPage;
		[Field ("TCOpenSDKErrorMsgWebPage",  "__Internal")]
		public static NSString TCOpenSDKErrorMsgWebPage {
			get {
				if (_TCOpenSDKErrorMsgWebPage == null)
					_TCOpenSDKErrorMsgWebPage = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "TCOpenSDKErrorMsgWebPage");
				return _TCOpenSDKErrorMsgWebPage;
			}
		}
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_JsonResponse_var = null;
				__mt_UserData_var = null;
			}
		}
	} /* class APIResponse */
}
