using System;

namespace TTimeSpan
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan t1 = new TimeSpan(0, 1, 30);

            TimeSpan t2 = new TimeSpan(1, 2, 11, 21);
            Console.WriteLine(t1);
            Console.WriteLine(t2);
        }
    }
}
