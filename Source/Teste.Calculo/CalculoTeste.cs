using System.Collections.Generic;
using Xunit;

namespace Teste.Calculo
{
    public class CalculoTeste
    {
        [Fact(DisplayName = "Teste Numeros Divisores")]
        public void DeveRetornarNumerosDivisores()
        {
            //Arrange
            var numerosDivisoresResult = new List<int>
            {
                1, 3, 5, 9, 15, 45
            };

            //Act
            var numerosDivisores = Base.Calculo.Calculo.ObterNumerosDivisores(45);

            //Assert
            Assert.Equal(numerosDivisoresResult, numerosDivisores);
        }

        [Fact(DisplayName = "Teste Numeros Primos")]
        public void DeveRetornarNumerosPrimos()
        {
            //Arrange
            var numerosPrimosResult = new List<int>
            {
                1, 3, 5
            };

            //Act
            var numerosPrimos = Base.Calculo.Calculo.ObterNumerosPrimos(45);

            //Assert
            Assert.Equal(numerosPrimosResult, numerosPrimos);
        }
    }
}
