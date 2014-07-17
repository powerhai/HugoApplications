using System;

namespace Sagua.App.Components
{
	public interface IDeviceInfo {

		int ScreenHeight { get; }
		int ScreenWidth { get; }
		string DeviceId { get; }
		string Manufacturer { get; }
		string Model { get; }
		string OperatingSystem { get; }
		bool IsFrontCameraAvailable { get; }
		bool IsRearCameraAvailable { get; }
		bool IsSimulator { get; }
 
	}

}

