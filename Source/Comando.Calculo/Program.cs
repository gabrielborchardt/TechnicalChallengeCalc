using System;
using System.Collections.Generic;
using System.Linq;

namespace Comando.Calculo
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroDigitado;
            Console.WriteLine("Digite um número:");

            while (!int.TryParse(Console.ReadLine(), out numeroDigitado) || numeroDigitado <= 0)
                ConsoleNumeroInvalido();

            ConsoleResultado(numeroDigitado, Base.Calculo.Calculo.ObterNumerosDivisores(numeroDigitado), Base.Calculo.Calculo.ObterNumerosPrimos(numeroDigitado));
        }

        private static void ConsoleNumeroInvalido()
        {
            Console.Clear();
            Console.WriteLine("Você informou um número inválido, tente novamente informando um valor maior que zero.");
            Console.Write("Digite um número: ");
        }

        private static void ConsoleResultado(int numeroDigitado, List<int> numerosDivisores, List<int> numerosPrimos)
        {
            Console.Clear();
            Console.WriteLine($"Número de Entrada: {numeroDigitado}");
            Console.WriteLine($"Números Divisores: {string.Join(" ", numerosDivisores.Select(n => n.ToString()).ToArray())}");
            Console.WriteLine($"Divisores Primos: {string.Join(" ", numerosPrimos.Select(n => n.ToString()).ToArray())}");
            Console.ReadKey();
        }
    }
}
