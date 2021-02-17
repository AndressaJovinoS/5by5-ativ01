using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBanco
{
	class Cliente : Conta
	{
		public long CPF { get; set; }
		public string Nome { get; set; }
		public string Logradouro { get; set; }
		public int Num { get; set; }
		public string Localidade { get; set; }

		public Cliente()
		{
		}

		public Cliente(long cPF, string nome, string logradouro, int num, string localidade)
		{
			CPF = cPF;
			Nome = nome;
			Logradouro = logradouro;
			Numero = num;
			Localidade = localidade;
		}
	}
}
