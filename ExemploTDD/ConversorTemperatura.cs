using System;

namespace ExemploTDD
{
    public static class ConversorTemperatura
    {
        /// <summary>
        /// Teste
        /// </summary>
        /// <param name="temperatura"></param>
        /// <returns></returns>
        public static double FahrenheitParaCelsius(double temperatura)
        {
            return Math.Round((temperatura - 32) / 1.2, 2);




        }
    }
}