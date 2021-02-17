using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBanco
{
	class Conta
	{
		public int Ag { get; set; }
		public int Numero { get; set; }
		public double Saldo { get; set; }

		public Conta()
		{
		}

		public Conta(int ag, int numero, double saldo)
		{
			Ag = ag;
			Numero = numero;
			Saldo = saldo;
		}

		public virtual void Saque(double quantia)
		{
			if (Saldo < quantia)
				Console.WriteLine("Operacao invalida! ");
			else
				Saldo -= quantia;
		}

		public void Deposito(double quantia)
		{
			Saldo += quantia;
		} 
	}
}
