using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilha_Dinamica_Livro
{
	class Livro
	{
		public string Titulo { get; set; }
		public string Autor { get; set; }
		public int Isbn { get; set; }
		public Livro Anterior;

		public override string ToString()
		{
			return "\n>>>DADOS DO LIVRO<<<\nTitulo: " + Titulo + "\nAutor:" + Autor + "\nISBN: " + Isbn;
		}
	}
}
