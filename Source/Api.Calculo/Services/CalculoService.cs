using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Calculo.Services
{
    public interface ICalculoService
    {
        dynamic ObterNumerosDivisoresEPrimos(int numero);
    }

    public class CalculoService : ICalculoService
    {
        private readonly ILogger<CalculoService> _logger;

        public CalculoService(ILogger<CalculoService> logger)
        {
            _logger = logger;
        }

        public dynamic ObterNumerosDivisoresEPrimos(int numero)
        {
            try
            {
                if (numero <= 0)
                    throw new Exception("Você informou um número inválido, tente novamente informando um valor maior que zero.");

                var numerosDivisores = Base.Calculo.Calculo.ObterNumerosDivisores(numero);
                var numerosPrimos = Base.Calculo.Calculo.ObterNumerosPrimos(numero);

                _logger.LogInformation("Número de Entrada: {0} - Números Divisores: {1} - Divisores Primos: {2}", numero, string.Join(" ", numerosDivisores.Select(n => n.ToString()).ToArray()), string.Join(" ", numerosPrimos.Select(n => n.ToString()).ToArray()));

                return new
                {  
                    numerosDivisores,
                    numerosPrimos
                };
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                throw;
            }
        }
    }
}
