using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoSem08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Definición de variables
            int celsiusMin = 0;
            int celsiusMax = 100;
            int intervalo = 5;

            double sumaFahrenheit = 0;
            double minFahrenheit = double.MaxValue;
            double maxFahrenheit = double.MinValue;
            int countFahrenheit120to200 = 0;

            // Imprimir encabezado de la tabla
            Console.WriteLine("=============================================");
            Console.WriteLine("     Conversión de Temperaturas");
            Console.WriteLine("=============================================");
            Console.WriteLine("{0,-15}{1,-15}", "Celsius (°C)", "Fahrenheit (°F)");
            Console.WriteLine("---------------------------------------------");

            // Generar tabla y realizar cálculos
            for (int celsius = celsiusMin; celsius <= celsiusMax; celsius += intervalo)
            {
                double fahrenheit = (9.0 / 5.0) * celsius + 32;

                // Actualizar variables para cálculos
                sumaFahrenheit += fahrenheit;
                minFahrenheit = Math.Min(minFahrenheit, fahrenheit);
                maxFahrenheit = Math.Max(maxFahrenheit, fahrenheit);

                // Verificar si la temperatura Fahrenheit está entre 120 y 200
                if (fahrenheit >= 120 && fahrenheit <= 200)
                {
                    countFahrenheit120to200++;
                }

                // Imprimir fila de la tabla
                string celsiusFormatted = celsius.ToString("D3");
                string fahrenheitFormatted = fahrenheit.ToString("N2");
                Console.WriteLine("{0,-15}{1,15}", celsiusFormatted + " °C", fahrenheitFormatted + " °F");
            }

            // Calcular promedio de temperaturas Fahrenheit
            double promedioFahrenheit = sumaFahrenheit / ((celsiusMax - celsiusMin) / intervalo + 1);

            // Imprimir resultados finales
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("\nResultados:");
            Console.WriteLine("Promedio Fahrenheit: {0}", promedioFahrenheit);
            Console.WriteLine("Mínima temperatura Fahrenheit: {0}", minFahrenheit);
            Console.WriteLine("Máxima temperatura Fahrenheit: {0}", maxFahrenheit);
            Console.WriteLine("Cantidad de temperaturas Fahrenheit entre 120 y 200: {0}", countFahrenheit120to200);
            Console.WriteLine("=============================================");
            Console.ReadKey();
        }
    }
}
