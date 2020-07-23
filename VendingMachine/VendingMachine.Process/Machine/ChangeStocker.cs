using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.Process.CustomException;
using VendingMachine.Process.Money;

namespace VendingMachine.Process.Machine
{
	/// <summary>
	/// 釣銭をストックするクラス
	/// </summary>
	public class ChangeStocker : List<IMoney>
	{
		//TODO 釣銭切れ通知


		/// <summary>
		/// 個数分の貨幣をストックから出す
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="count"></param>
		/// <returns></returns>
		public List<MoneyType> PutOutMoney<MoneyType>(int count)
			where MoneyType : IMoney, new()
		{
			//要求された種別のお金を個数分取得
			var moneies = GetMoney<MoneyType>(count);

			//取得した分をリストから削除
			foreach(var money in moneies.ToArray())
			{
				this.Remove(money);
			}

			return moneies.ToList();
		}

		/// <summary>
		/// 貨幣を取得
		/// </summary>
		/// <typeparam name="MoneyType"></typeparam>
		/// <param name="count"></param>
		/// <returns></returns>
		private List<MoneyType> GetMoney<MoneyType>(int count)
			where MoneyType : IMoney, new()
		{
			try
			{
				//要求された種別のお金を個数分取得
				var stock = this.OfType<MoneyType>();
				return new List<MoneyType>(stock.Take(count));
			}
			catch
			{
				throw new OutOfChangeException();
			}
		}
	}
}
