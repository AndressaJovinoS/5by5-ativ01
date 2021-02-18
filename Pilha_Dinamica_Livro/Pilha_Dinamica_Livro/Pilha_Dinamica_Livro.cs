using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilha_Dinamica_Livro
{
	class Pilha_Dinamica_Livro
	{
		public Livro Topo { get; set; }
		public int Cont { get; set; }

		public void Push(Livro aux)
		{
			aux.Anterior = Topo;
			Topo = aux;
			Cont++;
			Console.WriteLine("Inserido com sucesso! ");
			return;
		}

		private bool Vazia()
		{
			if (Topo == null)
				return true;
			return false;
		}

		public void Imprimir()
		{
			if (Vazia())
			{
				Console.WriteLine("Impossivel imprimir, Pilha vazia! ");
				Console.ReadKey();
			}
			else
			{
				Livro aux = Topo;
				Console.WriteLine("Os elementos na pilha sao: ");

				do
				{
					Console.WriteLine(aux.ToString());
					aux = aux.Anterior;
				} while (aux != null);

				Console.WriteLine(">>>FIM<<<");

			}
			return;
		}

		public void pop()
		{
			if (Vazia())
			{
				Console.WriteLine("Impossivel remover, Pilha vazia!");
				Console.ReadKey();
			}
			else
			{
				Topo = Topo.Anterior;
				Cont--;
				Console.WriteLine("Removido! ");
			}
		}

		public void Buscar(string busc)
		{
			bool encontrado = false;
			if (Topo == null)
			{
				Console.WriteLine("Pilha Vazia! ");
			}
			else
			{
				Livro aux = Topo;
				do
				{
					if (busc.ToUpper() == aux.Titulo.ToUpper())
					{
						encontrado = true;
						Console.WriteLine("Livro encontrado! ");
						Console.WriteLine(aux.ToString());
					}
					aux = aux.Anterior;
				} while (aux != null);
				if (!encontrado)
				{
					Console.WriteLine("Nao Encontrado! ");
				}
			}
			return;
		}
	}
}
