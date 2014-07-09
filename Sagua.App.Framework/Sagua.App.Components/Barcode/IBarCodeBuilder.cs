using System;

namespace Sagua.App.Components
{
	public interface IBarCodeBuilder
	{
		byte[] GetBarcode(string code, int width, int height, BarCodeFormat codeType);
		object GetBarcodeImage(string code, int width, int height, BarCodeFormat codeType);
	}
}

