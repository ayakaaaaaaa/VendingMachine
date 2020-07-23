using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.Process.Drink
{
	/// <summary>
	/// アイスティークラス
	/// </summary>
	public class IceTea : IDrink
	{
		/// <summary>
		/// 名前を返す
		/// </summary>
		/// <returns></returns>
		public string GetName()
		{
			return "アイスティー";
		}

		/// <summary>
		/// 金額を返す
		/// </summary>
		/// <returns></returns>
		public int GetPrice()
		{
			return 100;
		}
	}
}
