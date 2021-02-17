using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroVeiculo
{
	class Proprietario
	{
		public long CPF { get; set; }
		public string Nome { get; set; }
		public string Endereco { get; set; }
		public DateTime DataNasc { get; set; }
		public DateTime DataComp { get; set; }

		public Proprietario()
		{
		}

		public Proprietario(long cPF, string nome, string endereco, DateTime dataNasc, DateTime dataComp)
		{
			CPF = cPF;
			Nome = nome;
			Endereco = endereco;
			DataNasc = dataNasc;
			DataComp = dataComp;
		}

		public override string ToString()
		{
			return ("CPF: " + "\nNome: " + Nome + "\nEndereco: " + Endereco +
				"\nData Nascimento: " + DataNasc.ToString("dd/MM/yyyy") + "\n Data da compra: " + DataComp.ToString("dd/MM/yyyyy"));
		}
	}
}
