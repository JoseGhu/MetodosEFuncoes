using System;


namespace CursoCSharp.Metodos_Funcoes
{
    class DelegatesComParametros
    {
        public delegate int Operacao(int x, int  y);

        public static int Soma(int x, int y)
        {
            return x + y;
        }

        public static string Calculadora(Operacao op, int x, int y)
        {
            var resultado = op(x, y);
            return "Resultado: " + resultado;
        }

        public static void Executar()
        {
            Operacao Subtracao = (int x, int y) => x - y;
            Console.WriteLine(Calculadora(Subtracao, 3, 2));
            Console.WriteLine(Calculadora(Soma, 3, 2));
        }
    }
}
