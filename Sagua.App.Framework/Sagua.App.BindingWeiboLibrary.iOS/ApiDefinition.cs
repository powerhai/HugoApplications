using System;
using System.Drawing;
using MonoTouch.ObjCRuntime;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace Sagua.App.BindingWeiboLibrary.iOS
{
	// The first step to creating a binding is to add your native library ("libNativeLibrary.a")
	// to the project by right-clicking (or Control-clicking) the folder containing this source
	// file and clicking "Add files..." and then simply select the native library (or libraries)
	// that you want to bind.
	//
	// When you do that, you'll notice that MonoDevelop generates a code-behind file for each
	// native library which will contain a [LinkWith] attribute. MonoDevelop auto-detects the
	// architectures that the native library supports and fills in that information for you,
	// however, it cannot auto-detect any Frameworks or other system libraries that the
	// native library may depend on, so you'll need to fill in that information yourself.
	//
	// Once you've done that, you're ready to move on to binding the API...
	//
	//
	// Here is where you'd define your API definition for the native Objective-C library.
	//
	// For example, to bind the following Objective-C class:
	//
	//     @interface Widget : NSObject {
	//     }
	//
	// The C# binding would look like this:
	//
	//     [BaseType (typeof (NSObject))]
	//     interface Widget {
	//     }
	//
	// To bind Objective-C properties, such as:
	//
	//     @property (nonatomic, readwrite, assign) CGPoint center;
	//
	// You would add a property definition in the C# interface like so:
	//
	//     [Export ("center")]
	//     PointF Center { get; set; }
	//
	// To bind an Objective-C method, such as:
	//
	//     -(void) doSomething:(NSObject *)object atIndex:(NSInteger)index;
	//
	// You would add a method definition to the C# interface like so:
	//
	//     [Export ("doSomething:atIndex:")]
	//     void DoSomething (NSObject object, int index);
	//
	// Objective-C "constructors" such as:
	//
	//     -(id)initWithElmo:(ElmoMuppet *)elmo;
	//
	// Can be bound as:
	//
	//     [Export ("initWithElmo:")]
	//     IntPtr Constructor (ElmoMuppet elmo);
	//
	// For more information, see http://docs.xamarin.com/ios/advanced_topics/binding_objective-c_libraries
	//


	[BaseType (typeof (NSObject))]
	public partial interface WeiboSDK {

		[Static, Export ("isWeiboAppInstalled") ]
		bool IsWeiboAppInstalled { get; }

		[Static, Export ("openWeiboApp") ]
		bool OpenWeiboApp { get; }

		[Static, Export ("getWeiboAppInstallUrl") ]
		string GetWeiboAppInstallUrl { get; }

		[Static, Export ("getWeiboAppSupportMaxSDKVersion") ]
		string GetWeiboAppSupportMaxSDKVersion { get; }

		[Static, Export ("getSDKVersion") ]
		string GetSDKVersion { get; }

		[Static, Export ("registerApp:")]
		bool RegisterApp (string appKey);

		[Static, Export ("handleOpenURL:delegate:")]
		bool HandleOpenURL (NSUrl url, WeiboSDKDelegate delegatec);

		[Static, Export ("sendRequest:")]
		bool SendRequest (WBBaseRequest request);

		[Static, Export ("sendResponse:")]
		bool SendResponse (WBBaseResponse response);

		[Static, Export ("enableDebugMode:")]
		void EnableDebugMode (bool enabled);

		[Static, Export ("logOutWithToken:delegate:withTag:")]
		void LogOutWithToken (string token, WBHttpRequestDelegate delegatec, string tag);

		[Static, Export ("inviteFriend:withUid:withToken:delegate:withTag:")]
		void InviteFriend (string data, string uid, string access_token, WBHttpRequestDelegate delegatec, string tag);
	}

	[Model, BaseType (typeof (NSObject))]
	public partial interface WeiboSDKDelegate {

		[Export ("didReceiveWeiboRequest:")]
		void  didReceiveWeiboRequest(WBBaseRequest request);

		[Export ("didReceiveWeiboResponse:")]
		void  didReceiveWeiboResponse(WBBaseResponse response);
	}

	[Model, BaseType (typeof (NSObject))]
	public partial interface WBHttpRequestDelegate {

		[Export ("request:didReceiveResponse:")]
		void DidReceiveResponse (WBHttpRequest request, NSUrlResponse response);

		[Export ("request:didFailWithError:")]
		void DidFailWithError (WBHttpRequest request, NSError error);

		[Export ("request:didFinishLoadingWithResult:")]
		void DidFinishLoadingWithResult (WBHttpRequest request, string result);

		[Export ("request:didFinishLoadingWithDataResult:")]
		void DidFinishLoadingWithDataResult (WBHttpRequest request, NSData data);
	}

	[BaseType (typeof (NSObject))]
	public partial interface WBHttpRequest {

		[Export ("url", ArgumentSemantic.Retain)]
		string Url { get; set; }

		[Export ("httpMethod", ArgumentSemantic.Retain)]
		string HttpMethod { get; set; }

		[Export ("params", ArgumentSemantic.Retain)]
		NSDictionary Params { get; set; }

		[Export ("delegate", ArgumentSemantic.Assign)]
		WBHttpRequestDelegate Delegate { get; set; }

		[Export ("tag", ArgumentSemantic.Retain)]
		string Tag { get; set; }

		[Static, Export ("requestWithURL:httpMethod:params:delegate:withTag:")]
		WBHttpRequest RequestWithURL (string url, string httpMethod, NSDictionary paramsc, WBHttpRequestDelegate delegatec, string tag);

		[Static, Export ("requestWithAccessToken:url:httpMethod:params:delegate:withTag:")]
		WBHttpRequest RequestWithAccessToken (string accessToken, string url, string httpMethod, NSDictionary paramsc, WBHttpRequestDelegate delegatec, string tag);

		[Export ("disconnect")]
		void Disconnect ();
	}

	[BaseType (typeof (NSObject))]
	public partial interface WBDataTransferObject {

		[Export ("userInfo", ArgumentSemantic.Retain)]
		NSDictionary UserInfo { get; set; }

		[Export ("sdkVersion")]
		string SdkVersion { get; }

		[Export ("shouldOpenWeiboAppInstallPageIfNotInstalled")]
		bool ShouldOpenWeiboAppInstallPageIfNotInstalled { get; set; }
	}

	[BaseType (typeof (WBDataTransferObject))]
	public partial interface WBBaseRequest {

		[Static, Export ("request") ]
		NSObject Request { get; }
	}

	[BaseType (typeof (WBDataTransferObject))]
	public partial interface WBBaseResponse {

		[Export ("requestUserInfo")]
		NSDictionary RequestUserInfo { get; }

		[Export ("statusCode")]
		WeiboSDKResponseStatusCode StatusCode { get; set; }

		[Static, Export ("response") ]
		NSObject Response { get; }
	}

	[BaseType (typeof (WBBaseRequest))]
	public partial interface WBAuthorizeRequest {

		[Export ("redirectURI", ArgumentSemantic.Retain)]
		string RedirectURI { get; set; }

		[Export ("scope", ArgumentSemantic.Retain)]
		string Scope { get; set; }
	}

	[BaseType (typeof (WBBaseResponse))]
	public partial interface WBAuthorizeResponse {

		[Export ("userID", ArgumentSemantic.Retain)]
		string UserID { get; set; }

		[Export ("accessToken", ArgumentSemantic.Retain)]
		string AccessToken { get; set; }

		[Export ("expirationDate", ArgumentSemantic.Retain)]
		NSDate ExpirationDate { get; set; }
	}

	[BaseType (typeof (WBBaseResponse))]
	public partial interface WBProvideMessageForWeiboResponse {

		[Export ("message", ArgumentSemantic.Retain)]
		WBMessageObject Message { get; set; }

		[Static, Export ("responseWithMessage:")]
		NSObject ResponseWithMessage (WBMessageObject message);
	}

	[BaseType (typeof (WBBaseRequest))]
	public partial interface WBSendMessageToWeiboRequest {

		[Export ("message", ArgumentSemantic.Retain)]
		WBMessageObject Message { get; set; }

		[Static, Export ("requestWithMessage:")]
		NSObject RequestWithMessage (WBMessageObject message);
	}

	[BaseType (typeof (NSObject))]
	public partial interface WBMessageObject {

		[Export ("text", ArgumentSemantic.Retain)]
		string Text { get; set; }

		[Export ("imageObject", ArgumentSemantic.Retain)]
		WBImageObject ImageObject { get; set; }

		[Export ("mediaObject", ArgumentSemantic.Retain)]
		WBBaseMediaObject MediaObject { get; set; }

		[Static, Export ("message") ]
		NSObject Message { get; }
	}

	[BaseType (typeof (NSObject))]
	public partial interface WBImageObject {

		[Export ("imageData", ArgumentSemantic.Retain)]
		NSData ImageData { get; set; }

		[Static, Export ("object") ]
		NSObject Object { get; }

		[Export ("image") ]
		UIImage Image { get; }
	}

	[BaseType (typeof (NSObject))]
	public partial interface WBBaseMediaObject {

		[Export ("objectID", ArgumentSemantic.Retain)]
		string ObjectID { get; set; }

		[Export ("title", ArgumentSemantic.Retain)]
		string Title { get; set; }

		[Export ("description", ArgumentSemantic.Retain)]
		string Description { get; set; }

		[Export ("thumbnailData", ArgumentSemantic.Retain)]
		NSData ThumbnailData { get; set; }

		[Export ("scheme", ArgumentSemantic.Retain)]
		string Scheme { get; set; }

		[Static, Export ("object") ]
		NSObject Object { get; }
	}

	[BaseType (typeof (WBBaseMediaObject))]
	public partial interface WBVideoObject {

		[Export ("videoUrl", ArgumentSemantic.Retain)]
		string VideoUrl { get; set; }

		[Export ("videoLowBandUrl", ArgumentSemantic.Retain)]
		string VideoLowBandUrl { get; set; }

		[Export ("videoStreamUrl", ArgumentSemantic.Retain)]
		string VideoStreamUrl { get; set; }

		[Export ("videoLowBandStreamUrl", ArgumentSemantic.Retain)]
		string VideoLowBandStreamUrl { get; set; }
	}

	[BaseType (typeof (WBBaseMediaObject))]
	public partial interface WBMusicObject {

		[Export ("musicUrl", ArgumentSemantic.Retain)]
		string MusicUrl { get; set; }

		[Export ("musicLowBandUrl", ArgumentSemantic.Retain)]
		string MusicLowBandUrl { get; set; }

		[Export ("musicStreamUrl", ArgumentSemantic.Retain)]
		string MusicStreamUrl { get; set; }

		[Export ("musicLowBandStreamUrl", ArgumentSemantic.Retain)]
		string MusicLowBandStreamUrl { get; set; }
	}

	[BaseType (typeof (WBBaseMediaObject))]
	public partial interface WBWebpageObject {

		[Export ("webpageUrl", ArgumentSemantic.Retain)]
		string WebpageUrl { get; set; }
	}
}

