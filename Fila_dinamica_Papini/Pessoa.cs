using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fila_dinamica_Papini
{
    internal class Pessoa
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime DataNasc { get; set; }
        public Pessoa Proximo { get; set; }

        public Pessoa(string nome, string cpf, DateTime dataNasc)
        {
            Nome = nome;
            Cpf = cpf;
            DataNasc = dataNasc;
            Proximo = null;
        }

        public override string ToString()
        {
            return ">> Dados Da Pessoa <<<\nNome:\t"+Nome+"\nCPF:\t"+Cpf+"\nData Nasc:\t"+DataNasc;
        }
    }
}
