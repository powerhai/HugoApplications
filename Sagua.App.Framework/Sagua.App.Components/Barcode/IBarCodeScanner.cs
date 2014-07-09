using System;
using System.Threading.Tasks;

namespace Sagua.App.Components
{

	public interface IBarCodeScanner {

		BarCodeScannerConfiguration Configuration { get; }

		void Read(Action<BarCodeResult> onRead);
		Task<BarCodeResult> ReadAsync();
	}
	
}
