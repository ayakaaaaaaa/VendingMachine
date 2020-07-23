using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.Process.Drink;
using VendingMachine.Process.Machine;
using VendingMachine.Process.Money;

namespace VendingMachine.Process
{
	/// <summary>
	/// ストックを用意するクラス
	/// </summary>
	public class PrepareStock
	{
		/// <summary>
		/// ドリンクを用意する
		/// </summary>
		/// <returns></returns>
		public DrinkStocker PrepareDrink()
		{
			DrinkStocker drinkStocker = new DrinkStocker();
			drinkStocker.Add(new Cola());
			drinkStocker.Add(new IceTea());

			return drinkStocker;
		}

		/// <summary>
		/// 釣銭を用意する
		/// </summary>
		/// <returns></returns>
		public ChangeStocker PrepareChange()
		{
			ChangeStocker changeStocker = new ChangeStocker();

			for (int i = 0; i < 5; i++)
			{
				changeStocker.Add(new Yen10());
			}

			for (int i = 0; i < 5; i++)
			{
				changeStocker.Add(new Yen50());
			}

			for (int i = 0; i < 5; i++)
			{
				changeStocker.Add(new Yen100());
			}

			for (int i = 0; i < 5; i++)
			{
				changeStocker.Add(new Yen500());
			}

			return changeStocker;
		}
	}
}
