using System;

namespace Sagua.Global.Common
{
	public class BaseRestResult
	{
		public BaseRestResult()
		{
			IsOk = false;
		}
		public bool IsOk { get; set; }
		public string ErrorMessage { get; set; }
	}
}

