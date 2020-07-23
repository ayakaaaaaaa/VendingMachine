using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.Process.CustomException
{
	/// <summary>
	/// 釣銭切れエラー
	/// </summary>
	public class OutOfChangeException : Exception
	{
		public override string Message => "釣銭切れです！";
	}
}
