using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_3__bim
{
	class Time
	{
		private string nome;
		private string estado;
		private int k = 0;
		private Jogador[] jogadores = new Jogador[1];
		public Time(string n, string e)
		{
			nome = n;
			estado = e;
		}
		public void Inserir(Jogador m)
		{
			if (k == jogadores.Length)
				Array.Resize(ref jogadores, jogadores.Length * 2);
			jogadores[k] = m;
			k++;
		}
		public Jogador[] Listar()
		{
			Jogador[] vetor = new Jogador[k];
			Array.Copy(jogadores, vetor, k);

			Console.WriteLine($"Nome do Time: {nome} - Estado: {estado}");
			Console.WriteLine();
			return vetor;

		}



		public override string ToString()
		{
			return $"{nome} - {estado}";
		}
	}
}
