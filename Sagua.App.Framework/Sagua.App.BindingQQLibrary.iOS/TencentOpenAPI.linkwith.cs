using System;
using MonoTouch.ObjCRuntime;

 

[assembly: LinkWith ("TencentOpenAPI.a", 
	LinkTarget.Simulator | LinkTarget.ArmV7 | LinkTarget.ArmV7s, 
	"-ObjC -fobjc-arc -lsqlite3 -lstdc++", 
	SmartLink = true, 
	ForceLoad = true,
	Frameworks = "SystemConfiguration Security CoreGraphics CoreTelephony"
	//Frameworks = "SystemConfiguration AudioToolbox AVFoundation CoreGraphics CoreMedia Foundation MobileCoreServices OpenGLES QuartzCore Security UIKit StoreKit Security CoreText OpenAL"
	//	Frameworks = "SystemConfiguration AudioToolbox AVFoundation CoreGraphics CoreMedia Foundation MobileCoreServices OpenGLES QuartzCore Security UIKit StoreKit Security CoreText OpenAL"
//	, 
	//Security.framework”, “libiconv.dylib”， "libsqlite3.dylib”、“CoreTelephony.framework”、“libstdc++.dylib”、“libz.dylib”。

//	Frameworks = "CoreGraphics CoreLocation QuartzCore Security", 
//	WeakFrameworks = "Accounts Social"
)]
