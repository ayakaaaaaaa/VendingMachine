using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.Process;
using VendingMachine.Process.CustomException;
using VendingMachine.Process.Drink;
using VendingMachine.Process.Machine;
using VendingMachine.Process.Money;

namespace VendingMachine
{
	class Program
	{
		// コメント
		//　バグなおした
		// 1
		// 2
		static void Main(string[] args)
		{
			IDrink drink;
			List<IMoney> change;

			try
			{
				var prepare = new PrepareStock();
				var drinkStocker = prepare.PrepareDrink();
				var changeStocker = prepare.PrepareChange();

				var vending = new Vending(drinkStocker, changeStocker);

				vending.PayMoney(new Yen500());
				drink = vending.Select(Menu.Drink.Cola);
				change = vending.ReturnChange();

				Console.WriteLine(drink.GetPrice() + "円の" + drink.GetName() + "を購入しました。");
				foreach(var money in change)
				{
					Console.WriteLine(money.GetPrice() + "円玉が返ってきました。");
				}
			}
			catch(OutOfStockException ex)
			{
				Console.WriteLine(ex.Message);
			}
			catch(OutOfChangeException ex)
			{
				Console.WriteLine(ex.Message);
			}
			catch(Exception ex)
			{
				Console.WriteLine("購入に失敗しました。");
				Console.WriteLine(ex.ToString());
			}
			finally
			{
				Console.ReadKey();
			}
		}
	}
}
