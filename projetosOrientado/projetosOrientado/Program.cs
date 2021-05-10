using System;
using System.Globalization;


namespace CalculoAreaTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            var trianguloY = new Triangulo { };
            var trianguloX = new Triangulo { };


            Console.WriteLine("entre com as medidas do triangulo y: ");
            trianguloY.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            trianguloY.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            trianguloY.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaY = trianguloY.Area();

           


            Console.WriteLine("entre com as medidas do triangulo x: ");
            trianguloX.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            trianguloX.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            trianguloX.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaX = trianguloX.Area();


            Console.WriteLine("Área de x= " + areaX.ToString("F4",CultureInfo.InvariantCulture));
            Console.WriteLine("Área de y= " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaY){
                Console.WriteLine("Maior area:X");
            }

            else{
                Console.WriteLine("Maior area:Y");
            }


        }
    }
}
