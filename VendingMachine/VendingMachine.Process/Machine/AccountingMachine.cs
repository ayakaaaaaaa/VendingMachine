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
	/// 会計を行うクラス
	/// </summary>
	public class AccountingMachine
	{
		/// <summary>
		/// 代金の合計
		/// </summary>
		private int _payment;

		//釣銭をストックするクラス
		private ChangeStocker _changeStocker = null;

		/// <summary>
		/// コンストラクタ
		/// </summary>
		public AccountingMachine(ChangeStocker changeStocker)
		{
			this._changeStocker = changeStocker;
		}

		/// <summary>
		/// 代金を預かる
		/// </summary>
		/// <param name="money"></param>
		public void KeepPayment(IMoney money)
		{
			this._changeStocker.Add(money);
			this._payment += money.GetPrice();
		}

		/// <summary>
		/// 購入処理
		/// </summary>
		public bool Buy(IDrink drink)
		{
			int price = drink.GetPrice();

			//投入金額が商品金額より小さいなら、会計をしない
			if(this._payment < price)
			{
				return false;
			}

			this._payment -= drink.GetPrice();
			return true;
		}

		/// <summary>
		/// おつりを返す
		/// </summary>
		/// <returns></returns>
		public List<IMoney> ReturnChange()
		{
			var calculator = new ChangeCalculator(this._changeStocker);
			var change = calculator.ReturnChange(this._payment);
			CleatPayment();
			return change;
		}

		/// <summary>
		/// 代金を初期化
		/// </summary>
		private void CleatPayment()
		{
			this._payment = 0;
		}
	}
}
