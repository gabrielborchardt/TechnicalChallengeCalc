using System.Collections.Generic;

namespace Base.Calculo
{
    public class Calculo
    {
        public static List<int> ObterNumerosDivisores(int numero)
        {
            if (numero <= 0)
                return null;

            var divisores = new List<int>();

            for (int i = 1; i <= numero; i++)
                if (numero % i == 0)
                    divisores.Add(i);

            return divisores;
        }

        public static List<int> ObterNumerosPrimos(int numero)
        {
            if (numero <= 0)
                return null;

            var numerosPrimos = new List<int>() { 1 };

            int i = 2;
            while (numero > 1)
            {
                if (numero % i == 0)
                {
                    numero /= i;

                    if (!numerosPrimos.Contains(i))
                        numerosPrimos.Add(i);
                }
                else
                    i++;
            }

            return numerosPrimos;
        }
    }
}
