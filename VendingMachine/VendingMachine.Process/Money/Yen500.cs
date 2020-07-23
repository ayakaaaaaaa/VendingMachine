using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.Process.Money
{
	/// <summary>
	/// 500円玉クラス
	/// </summary>
	public class Yen500 : ICoin
	{
		/// <summary>
		/// 金額を返す
		/// </summary>
		/// <returns></returns>
		public int GetPrice()
		{
			return 500;
		}
	}
}
