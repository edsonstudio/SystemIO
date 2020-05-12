using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace SystemIO.Entities
{
    public class Personagem
    {
        public string Nome { get; set; }
        public string DataDeNascimento { get; set; }
        public Personagem(string nome, string dataDeNascimento)
        {
            Nome = nome;
            DataDeNascimento = dataDeNascimento;
        }

        public override string ToString()
        {
            return "Nome: " + Nome + "\n" + "Data de Nascimento: " + DataDeNascimento + "\n";
        }
    }
}
