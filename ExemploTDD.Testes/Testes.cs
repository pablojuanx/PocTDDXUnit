using System;
using Xunit;
using ExemploTDD;

namespace ExemploTDD.Testes
{
    public class Testes
    {
        [Theory]
        [InlineData(32, 0)]
        [InlineData(86, 30)]
        [InlineData(90.5, 32.5)]
        [InlineData(212, 100)]
        public void TestarConversaoTemperatura(
            double valorInformado, double valorEsperado)
        {
            double valorCalculado =
                ConversorTemperatura.FahrenheitParaCelsius(valorInformado);
            Assert.Equal(valorEsperado, valorCalculado);
        }

        /*[Fact]
        public void Teste1ConversaoTemperatura()
        {
            double valorCalculado =
                ConversorTemperatura.FahrenheitParaCelsius(32);
            Assert.Equal(0, valorCalculado);
        }

        [Fact]
        public void Teste2ConversaoTemperatura()
        {
            double valorCalculado =
                ConversorTemperatura.FahrenheitParaCelsius(86);
            Assert.Equal(30, valorCalculado);
        }

        [Fact]
        public void Teste3ConversaoTemperatura()
        {
            double valorCalculado =
                ConversorTemperatura.FahrenheitParaCelsius(90.5);
            Assert.Equal(32.5, valorCalculado);
        }

        [Fact]
        public void Teste4ConversaoTemperatura()
        {
            double valorCalculado =
                ConversorTemperatura.FahrenheitParaCelsius(212);
            Assert.Equal(100, valorCalculado);
        }*/
    }
}