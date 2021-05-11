using System;
using System.Globalization;

namespace Membros_estaticos
{
    class Program { 

        static double Pi = 3.14;


    
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com valor de raio: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Circuferencia(raio);
            double volume = Volume(raio);

            Console.WriteLine("Circunferencia: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + volume.ToString("F2",CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de Pi: " + Pi.ToString("F2", CultureInfo.InvariantCulture));

        }

        static double Circuferencia(double raio)
        {
            return 2.0 * Pi * raio;
        }

        static double Volume(double raio)
        {
            return 4.0 / 3.0 * Pi * raio * raio * raio;
        }
    }
}
