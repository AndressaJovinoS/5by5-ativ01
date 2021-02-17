using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroVeiculo
{
	class Program
	{
		static void Main(string[] args)
		{
			int op;
			Veiculo v = new Veiculo();
			Proprietario p = new Proprietario();
			do
			{
				Console.WriteLine("Informe a opcao desejada\n" +
				"1 para Informar todos os dados\n" +
				"2 para imprimir os dados que possui\n" +
				"3 para finalizar o programa ");
				 op = int.Parse(Console.ReadLine());

				switch (op)
				{
					case 1:
						Console.WriteLine("Informe o Renavan do veiculo: ");
						v.Renavan = int.Parse(Console.ReadLine());
						Console.WriteLine("Informe o Chassi do veiculo: ");
						v.Chassi = Console.ReadLine();
						Console.WriteLine("Informe a Placa do veiculo: ");
						v.Placa = Console.ReadLine();
						Console.WriteLine("Informe a Marca do veiculo: ");
						v.Marca = Console.ReadLine();
						Console.WriteLine("Informe o Modelo do veiculo: ");
						v.Modelo = Console.ReadLine();
						Console.WriteLine("Informe a Cor do veiculo: ");
						v.Cor = Console.ReadLine();
						Console.WriteLine("Informe o Ano do veiculo: ");
						v.Ano = int.Parse(Console.ReadLine());


						Console.WriteLine("Nome do proprietario do veiculo: ");
						p.Nome = Console.ReadLine();
						Console.WriteLine("CPF do proprietario do veiculo: ");
						p.CPF = long.Parse(Console.ReadLine());
						Console.WriteLine("Endereco do proprietario do veiculo: ");
						p.Endereco = Console.ReadLine();
						Console.WriteLine("Data de Nascimento do proprietario do veiculo: ");
						p.DataNasc = DateTime.Parse(Console.ReadLine());
						Console.WriteLine("Data da compra do veiculo: ");
						p.DataComp = DateTime.Parse(Console.ReadLine());
						Console.WriteLine("Cadastrando...");
						Console.ReadKey();
						break;

					case 2:
						Console.WriteLine(v.ToString());
						Console.WriteLine(p.ToString());
						Console.ReadKey();
						break;
					case 3:

						break;
				}
			} while (op != 3);

		}
	}
}
