using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilha_Dinamica_Livro
{
	class Program
	{
		static void Main(string[] args)
		{
			int op;
			Pilha_Dinamica_Livro minhaPilha = new Pilha_Dinamica_Livro { Topo = null, Cont = 0 };
			string busc;

			do
			{
				Console.WriteLine("Informe a opcao desejada\n"
					+ "1 - Inserir Livro\n"
					+ "2 - Remover Livro\n"
					+ "3 - Imprimir Pilha\n"
					+ "4 - Quantidades de Livros na Pilha\n"
					+ "5 - Busca de Liro no Pilha por Titulo\n"
					+ "0 - Sair");
				op = int.Parse(Console.ReadLine());

				switch (op)
				{
					case 1:
						Livro l = new Livro();
						Console.WriteLine("Titulo do Livro: ");
						l.Titulo = Console.ReadLine();
						Console.WriteLine("Autor: ");
						l.Autor = Console.ReadLine();
						Console.WriteLine("ISBN: ");
						l.Isbn = int.Parse(Console.ReadLine());
						l.Anterior = null;

						minhaPilha.Push(l);
						Console.ReadKey();
						break;
					case 2:
						minhaPilha.pop();
						Console.ReadKey();
						break;
					case 3:
						minhaPilha.Imprimir();
						Console.ReadKey();
						break;
					case 4:
						Console.WriteLine("Quantidade de livros sao:\n ");
						Console.WriteLine(minhaPilha.Cont);
						Console.ReadKey();
						break;
					case 5:
						Console.WriteLine("Informe o livro que deseja buscar: ");
						busc = Console.ReadLine();
						minhaPilha.Buscar(busc);
						Console.ReadKey();
						break;
					case 0:
						break;
				}
			} while (op != 0);
		}
	}
}

