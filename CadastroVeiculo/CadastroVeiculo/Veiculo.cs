using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroVeiculo
{
	class Veiculo
	{
		public int Renavan { get; set; }
		public string Chassi { get; set; }
		public string Placa { get; set; }
		public string Marca { get; set; }
		public string Modelo { get; set; }
		public string Cor { get; set; }
		public int Ano { get; set; }

		public Veiculo()
		{
		}

		public Veiculo(int renavan, string chassi, string placa, string marca, string modelo, string cor, int ano)
		{
			Renavan = renavan;
			Chassi = chassi;
			Placa = placa;
			Marca = marca;
			Modelo = modelo;
			Cor = cor;
			Ano = ano;
		}

		public override string ToString()
		{
			return ("Renavan: " + Renavan + "\nChassi: " + Chassi
				+ "\nPlaca: " + Placa + "\nMarca: " + Marca
				+ "\nModelo: " + Modelo + "\nCor: " + Cor
				+ "\n Ano: " + Ano);
		}
	}
}
