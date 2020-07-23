using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.Process.CustomException;
using VendingMachine.Process.Drink;

namespace VendingMachine.Process.Machine
{
	/// <summary>
	/// ドリンクをストックするクラス
	/// </summary>
	public class DrinkStocker : List<IDrink>
	{
		//TODO 品切れ通知

		/// <summary>
		/// ドリンクをストックから出す
		/// </summary>
		/// <param name="selected"></param>
		/// <returns></returns>
		public IDrink PutOutDrink(Menu.Drink selected)
		{
			//要求されたドリンクを取得
			string drinkName = Enum.GetName(typeof(Menu.Drink), selected);
			var drink = GetDrink(drinkName);

			//取得した分をリストから削除
			this.Remove(drink);

			return drink;
		}

		/// <summary>
		/// ドリンクを取得
		/// </summary>
		/// <param name="drinkName"></param>
		/// <returns></returns>
		private IDrink GetDrink(string drinkName)
		{
			try
			{
				return this.Where(x => x.GetType().Name == drinkName).First();
			}
			catch
			{
				throw new OutOfStockException();
			}
		}
	}
}
