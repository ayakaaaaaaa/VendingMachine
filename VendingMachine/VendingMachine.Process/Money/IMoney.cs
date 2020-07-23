using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.Process.Money
{
	/// <summary>
	/// 貨幣クラス
	/// </summary>
	public interface IMoney
	{
		/// <summary>
		/// 金額を返す
		/// </summary>
		/// <returns></returns>
		int GetPrice();
	}
}
