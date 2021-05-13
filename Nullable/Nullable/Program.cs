using System;

namespace Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            double? x = null;
            double? y = 10.00;

            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());

            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);

            //Console.WriteLine(x.Value);
            Console.WriteLine(y.Value);

            if (x.HasValue)
                Console.WriteLine(x.Value);

            else
                Console.WriteLine(x is null);
            Console.WriteLine(y is null);

            if (y.HasValue)
                Console.WriteLine(y.Value);

            else
                Console.WriteLine(y.Value);

        }
    }
}
