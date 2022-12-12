using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_3__bim
{
    class Jogador
    {
        private string Nome;
        private string Camisa;
        private int Gols;
        public Jogador(string n, string c, int g)
        {
            Nome = n;
            Camisa = c;
            Gols = g;
        }
        public override string ToString()
        {
            return $"Nome: {Nome} - Camisa: {Camisa} - Quantidade de Gols: {Gols}";
        }
    }
}
