using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fila_dinamica_Papini
{
    internal class Fila_Pessoa
    {
       public Pessoa Head { get; set; }
       public Pessoa Tail { get; set; }

        public Fila_Pessoa()
        {
            Head = Tail = null; 
        }

        public void push(Pessoa aux)
        {
            if (vazia())
            {
                Head = Tail = aux;
            }
            else
            {
                Tail.Proximo=aux;
                Tail = aux;
            }
        }

        public void print()
        {
            if(vazia())
            {
                Console.WriteLine("fila vazia");
            }
            else
            {
                Pessoa aux = Head;
                do
                {
                    Console.WriteLine(aux.ToString());
                    aux = aux.Proximo;
                }while(aux!=null);
                Console.WriteLine(">>> Fim da impressao <<<");
            }
        }

        public bool vazia()
        {
            if ((Head == null) && (Tail == null))
                    return true;
            return false;
        }
        public void pop()
        {
            if (vazia())
            {
                Console.WriteLine(">>> FILA VAZIA <<<");
            }
            else
            {
                Head = Head.Proximo;
                if (Head == null)
                    Tail = null;
            }
        }
    }
}
