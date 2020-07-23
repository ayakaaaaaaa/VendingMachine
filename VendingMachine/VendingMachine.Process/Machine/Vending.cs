using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.Process.Drink;
using VendingMachine.Process.Money;

namespace VendingMachine.Process.Machine
{
	/// <summary>
	/// 自販機クラス
	/// </summary>
	public class Vending
	{
		//ドリンクストッククラス
		private DrinkStocker _drinkStocker = null;

		//会計クラス
		private AccountingMachine _accountingMachine = null;

		/// <summary>
		/// コンストラクタ
		/// </summary>
		public Vending(DrinkStocker drinkStocker,  ChangeStocker changeStocker)
		{
			this._drinkStocker = drinkStocker;
			this._accountingMachine = new AccountingMachine(changeStocker);
		}

		/// <summary>
		/// お金を払う
		/// </summary>
		/// <param name="money"></param>
		public void PayMoney(IMoney money)
		{
			_accountingMachine.KeepPayment(money);
		}

		/// <summary>
		/// ドリンクを選択する
		/// </summary>
		/// <returns></returns>
		public IDrink Select(Menu.Drink selected)
		{
			var drink = this._drinkStocker.PutOutDrink(selected);
			_accountingMachine.Buy(drink);

			return drink;
		}

		/// <summary>
		/// おつりを返す
		/// </summary>
		/// <returns></returns>
		public List<IMoney> ReturnChange()
		{
			return _accountingMachine.ReturnChange();
		}
	}
}
