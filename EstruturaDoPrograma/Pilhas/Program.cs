using System;
using EstruturaDoPrograma.Exemplos;

namespace Pilhas
{
    class Program
    {
        static void Main()
        {
            var s = new Pilha(); //criando um novo objeto
            s.Empilha(1);
            s.Empilha(10);
            s.Empilha(100);
            Console.WriteLine(s.Desempilha());
            Console.WriteLine(s.Desempilha());
            Console.WriteLine(s.Desempilha());
            

        }
    }
}