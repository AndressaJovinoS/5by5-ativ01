using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
	class Program
	{
		static void Main(string[] args)
		{
			char[,] tab = new char[3, 3] { { ' ', ' ', ' ' }, { ' ', ' ', ' ' }, { ' ', ' ', ' ' } }; 
			char[,] pos = new char[3, 3] { { '7', '8', '9' }, { '4', '5', '6' }, { '1', '2', '3' } }; //matriz p/ orientar o usuario
			int jogador1 = 1, jogador2 = -1, cont = 0;
			bool situacao = true;
			string nome1, nome2;
			int fim;

			Console.WriteLine("Informe o nome do primeiro jogador! ");
			nome1 = Console.ReadLine();
			Console.WriteLine("Informe o nome do segundo jogador! ");
			nome2 = Console.ReadLine();

			for (int l = 0; l < pos.GetLength(0); l++) //estruturando o tabuleiro
			{
				Console.WriteLine("");
				for (int c = 0; c < pos.GetLength(1); c++)
				{
					if (c == 0)
						Console.Write("\t " + pos[l, c]+" ");
					else
						Console.Write("|" + pos[l, c]+" ");

				}
				Console.WriteLine(" ");
				if (l < 2)
					Console.Write("\t----------");
			}

			do
			{
				if (cont % 2 == 0) //define qual jogador vai inserir a jogada
					insereJogada(tab, nome1, jogador1);
				else
					insereJogada(tab, nome2, jogador2);
				imprimirJogada(tab);
				
				if (cont > 3) //começa verificar qdo ha possibilidade de ganhar
				{
					fim = verificaStatus(tab);
					if (fim == 0)
					{
						Console.WriteLine("\n  Empate :/ ");
						situacao = false;
					}
					else if (fim == 1)
					{
						Console.WriteLine("\n  " + nome1 + " venceu  o/");
						situacao = false;
					}
					else if (fim == 2)
					{
						Console.WriteLine("\n  " + nome2 + " venceu o/");
						situacao = false;
					}
				}
				cont++;
			} while (situacao);
			Console.WriteLine("Pressione qualquer tecla para sair! ");
			Console.ReadKey();
		}

		static void insereJogada(char[,] tab, string nome, int jogador) //insere a jogada atribuindo (x) para jogador 1 e (o) para jogador 2 
		{
			bool preenchido = true;
			char xo;
			if (jogador == 1)
				xo = 'x'; 
			else
				xo = 'o';

			do  //o designer desta matriz, está baseado na usabilidade do jogador(servindo como referência o teclado numérico)
			{
				Console.WriteLine("Vez do(a) jogador(a) " + nome);
				Console.WriteLine("Informe a posicao desejada! ");
				char posicao = char.Parse(Console.ReadLine());

				if ((posicao != '9') && (posicao != '8') && (posicao != '7') && (posicao != '6') && (posicao != '5') 
					&& (posicao != '4') && (posicao != '3') && (posicao != '2') && (posicao != '1'))
				{
					Console.WriteLine("Informe uma posicao válida! ");
				}
				if (posicao == '7')
				{
					preenchido = verificaPos(tab, 0, 0);
					if (preenchido != false)
						tab[0, 0] = xo;
				}
				else if (posicao == '8')
				{
					preenchido = verificaPos(tab, 0, 1);
					if (preenchido != false)
						tab[0, 1] = xo;
				}
				else if (posicao == '9')
				{
					preenchido = verificaPos(tab, 0, 2);
					if (preenchido != false)
						tab[0, 2] = xo;
				}
				else if (posicao == '4')
				{
					preenchido = verificaPos(tab, 1, 0);
					if (preenchido != false)
						tab[1, 0] = xo;
				}
				else if (posicao == '5')
				{
					preenchido = verificaPos(tab, 1, 1);
					if (preenchido != false)
						tab[1, 1] = xo;
				}
				else if (posicao == '6')
				{
					preenchido = verificaPos(tab, 1, 2);
					if (preenchido != false)
						tab[1, 2] = xo;
				}
				else if (posicao == '1')
				{
					preenchido = verificaPos(tab, 2, 0);
					if (preenchido != false)
						tab[2, 0] = xo;
				}
				else if (posicao == '2')
				{
					preenchido = verificaPos(tab, 2, 1);
					if (preenchido != false)
						tab[2, 1] = xo;
				}
				else if (posicao == '3')
				{
					preenchido = verificaPos(tab, 2, 2);
					if (preenchido != false)
						tab[2, 2] = xo;
				}
			} while (preenchido != true);
		}

		static void imprimirJogada(char[,] tab) //imprime a jogada no tabuleiro atual 
		{
			Console.Clear();
			for (int l = 0; l < tab.GetLength(0); l++)
			{
				Console.WriteLine("");
				for (int c = 0; c < tab.GetLength(1); c++)
				{
					if (c == 0)
						Console.Write("\t" + tab[l, c]);
					else
						Console.Write("|" + tab[l, c]);
				}
				Console.WriteLine(" ");
				if (l < 2)
					Console.Write("\t------");
			}
		}

		static bool verificaPos(char[,] tab, int linha, int coluna) // verifica se a posição ecolhida está disponível
		{
			if (tab[linha, coluna] == ' ')
				return true;
			else
				Console.WriteLine("Posicao invalida! ");
				return false;
		}

		static int verificaStatus(char[,] tab) //verifica se a partida está em andamento ou empatou ou quem ganhou
		{
			char ganhador = ' ';
			bool ganhou = false;
			bool andamento = false;
			if ((tab[0,0] != ' ') && (tab[0, 0] == tab[0, 1]) && (tab[0,0] == tab[0,2]))	//verifica se venceu na 1 linha
			{
				ganhador = tab[0, 0];
				ganhou = true;
			}
			if ((tab[1, 0] != ' ') && (tab[1, 0] == tab[1, 1]) && (tab[1, 0] == tab[1, 2])) //verifica se venceu na 2 linha
			{ 
					ganhador = tab[1, 0];
					ganhou = true;
			}
			if ((tab[2, 0] != ' ') && (tab[2, 0] == tab[2, 1]) && (tab[2, 0] == tab[2, 2])) //verifica se venceu na 3 linha
			{
					ganhador = tab[2, 0];
					ganhou = true;
			}
			if ((tab[0, 0] != ' ') && (tab[0, 0] == tab[1, 0]) && (tab[0, 0] == tab[2, 0]))//verifica se venceu na 1 coluna
			{
					ganhador = tab[0, 0];
					ganhou = true;
			}			
			if ((tab[0, 1] != ' ') && (tab[0, 1] == tab[1, 1]) && (tab[0, 1] == tab[2, 1])) //verifica se venceu na 2 coluna
			{
					ganhador = tab[0, 1];
					ganhou = true;
			}			
			if ((tab[0, 2] != ' ') && (tab[0, 2] == tab[1, 2]) && (tab[0, 2] == tab[2, 2]))//verifica se venceu na 3 coluna
			{
					ganhador = tab[0, 2];
					ganhou = true;
			}
			if ((tab[0, 0] != ' ') && (tab[0, 0] == tab[1, 1]) && (tab[0, 0] == tab[2, 2]))//verifica se venceu na diagonal principal
			{
					ganhador = tab[0, 0];
					ganhou = true;
			}
			if ((tab[0, 2] != ' ') && (tab[0, 2] == tab[1, 1]) && (tab[0, 2] == tab[2, 0]))//verifica se venceu na diagonal secundária
			{
					ganhador = tab[0, 2];
					ganhou = true;
			}

			if (ganhou == true) //informa qual foi o vencedor
			{
				if (ganhador == 'x')
					return 1;
				else
					return 2;
			}
			for (int l = 0; l < tab.GetLength(0); l++)
			{
				for (int c = 0; c < tab.GetLength(1); c++)
				{
					if (tab[l, c] == ' ')
						andamento = true;
				}
			}

			if (andamento == true) //informa que a partida está em andamento
				return 5;

			return 0; //informa que deu empate
		}
	}
}
