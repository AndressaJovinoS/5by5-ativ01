using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBanco
{
	class Program
	{
		static void Main(string[] args)
		{
			List<Conta> list = new List<Conta>();
			List<Cliente> list2 = new List<Cliente>();

			list.Add(new Conta(0213, 000123, 0.0));
			list.Add(new Conta(0321, 000321, 0.0));
			list2.Add(new Cliente(0001111, "Felipe P ", "Rua 1", 123, "Araraquara"));
			list2.Add(new Cliente(0002222, "Fabio P ", "Rua 2", 321, "Araraquara"));

			double deposito = 0.0;
			foreach (Conta c in list)
			{
				deposito += c.Saldo;
			}

			foreach (Conta acc in list2)
			{
				Console.WriteLine("Contas Cadastradas: " + acc.Numero);
			}

			

			Console.ReadKey();
		}
	}
}
