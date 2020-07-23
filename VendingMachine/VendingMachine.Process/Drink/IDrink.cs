using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.Process.Drink
{
	/// <summary>
	/// 飲み物クラス
	/// </summary>
	public interface IDrink 
	{
		/// <summary>
		/// 飲み物名を返す
		/// </summary>
		/// <returns></returns>
		string GetName();

		/// <summary>
		/// 金額を返す
		/// </summary>
		/// <returns></returns>
		int GetPrice();
	}
}
