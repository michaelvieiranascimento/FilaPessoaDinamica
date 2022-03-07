using System;

namespace Fila_dinamica_Papini
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fila_Pessoa minha_fila = new Fila_Pessoa();

            Pessoa pessoa = new Pessoa("Michael", "123.456.789-10", new DateTime(2000, 10, 13));
            minha_fila.push(pessoa);

            minha_fila.print();

            minha_fila.pop();

            minha_fila.print();
        }
    }
}
