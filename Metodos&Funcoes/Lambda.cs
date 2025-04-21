using System;


namespace CursoCSharp.Metodos_Funcoes
{
    class Lambda
    {
        public static void Executar()
        {
            Action algoNoConsole = () => 
            {
                Console.WriteLine("Lambda com C#! ");
            };

            algoNoConsole();

            Func<int> jogarDado = () => 
            {
                Random ramdom = new Random();
                return ramdom.Next(1, 7);
            };

            Console.WriteLine(jogarDado());

            Func<int, string> conversorHex = numero => numero.ToString("X");
            Console.WriteLine(conversorHex(1234));

            Func<int, int, int, string> formatarData = (dia, mes, ano) =>
                String.Format("{0:D2}/{1:D2}/{2:D4}", dia, mes, ano);
            Console.WriteLine(formatarData(4, 4, 1999));

        }
    }
}
