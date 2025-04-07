using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Criando uma instância da classe Conversoes
            Conversoes conversoes = new Conversoes(); // instanciar a classe conversoes

            Console.WriteLine("Aplicação Cálculos");
            //Console.ReadKey();
            //Console.WriteLine("Pressione qualquer tecla para iniciar");

            Console.WriteLine($"4 + 2 = {Aritmetica.Somar(4, 2)}");
            Console.WriteLine($"4 - 2 = {Aritmetica.Subtrair(4, 2)}");
            double t1 = conversoes.ConverterTemperatura(Conversoes.ConversaoTemperatura.CelsiusFahrenheit, 36);
            double t2 = conversoes.ConverterTemperatura(Conversoes.ConversaoTemperatura.FahrenheitCelsius, 100);

            Console.WriteLine($"36º Celsius = {t1}º Fahrenheit");
            Console.WriteLine($"100º Fahrenheit = {t2}º Celsius");

        }
    }
}
