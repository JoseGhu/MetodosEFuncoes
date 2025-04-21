using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Metodos_Funcoes
{
    delegate double Operacao(double x, double y);
    class LambidasDelegate
    {
        public static void Executar()
        {
            Operacao som = (x, y) => x + y;
            Operacao sub = (x, y) => x - y;
            Operacao mult = (x, y) => x * y;

            Console.WriteLine(som (3, 3));
            Console.WriteLine(sub (5, 2));
            Console.WriteLine(mult(12, 8));
        }
    }
}
