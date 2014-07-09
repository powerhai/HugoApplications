using System;

namespace Sagua.App.Components
{
	public interface  ICrossBitmap
	{
		void SetSource(object bitmap);
		object ToNative();
		float Height { get; }
		float Width { get; }
		byte[] GetJpegBytes(float quality); 

	}
}

