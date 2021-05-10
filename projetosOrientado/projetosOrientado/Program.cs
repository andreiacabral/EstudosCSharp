﻿using System;
using System.Globalization;


namespace CalculoAreaTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            double xA, xB, xC, yA,yB,yC;
            Console.WriteLine("entre com as medidas do triangulo y: ");

            yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.WriteLine("entre com as medidas do triangulo x: ");
            xA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            xC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            double p = (xA + xB + xC) / 2.0;
            double areaX = Math.Sqrt(p * (p - xA) * (p - xB) * (p - xC));

            p = (yA + yB + yC) / 2.0;
            double areaY = Math.Sqrt(p * (p - yA) * (p - yB) * (p - yC));

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
