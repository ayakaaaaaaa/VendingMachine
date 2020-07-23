using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.Process.Drink
{
	/// <summary>
	/// コーラクラス
	/// </summary>
	public class Cola : IDrink
	{
		/// <summary>
		/// 名前を返す
		/// </summary>
		/// <returns></returns>
		public string GetName()
		{
			return "コーラ";
		}

		/// <summary>
		/// 金額を返す
		/// </summary>
		/// <returns></returns>
		public int GetPrice()
		{
			return 120;
		}
	}
}
