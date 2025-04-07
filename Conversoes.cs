using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos
{
    internal class Conversoes
    {
        /// <summary>
        /// Conversão de temperaturas.
        /// </summary>
        /// <param name="conversao">A conversão a efetuar.</param>
        /// <param name="temperatura">A temperatua a converter.</param>
        /// <returns>Retorna o resultado da conversão da temperatura.</returns>
        public enum ConversaoTemperatura
        {
            Nulo = 0,
            CelsiusFahrenheit,
            FahrenheitCelsius
        }

        public double ConverterTemperatura(ConversaoTemperatura conversao, double temperatura)
        {
            if (conversao == ConversaoTemperatura.CelsiusFahrenheit)
            {
                return (temperatura * 1.8000 + 32);
            }
            else if (conversao == ConversaoTemperatura.FahrenheitCelsius)
            {
                return ((temperatura - 32) / 1.8000);
            }

            return -1;
        }


    }
}
