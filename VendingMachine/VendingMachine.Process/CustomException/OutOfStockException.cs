using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.Process.CustomException
{
	/// <summary>
	/// 品切れエラー
	/// </summary>
	public class OutOfStockException : Exception
	{
		public override string Message => "品切れです!";
	}
}
