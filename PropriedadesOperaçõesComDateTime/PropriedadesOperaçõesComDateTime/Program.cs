using System;

namespace PropriedadesOperaçõesComDateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d = new DateTime(2001, 8, 15, 13, 45, 58);

            string s1 = d.ToLongTimeString();
            string s2 = d.ToShortDateString();
            string s3 = d.ToShortTimeString();
            string s4 = d.ToString();
            string s5 = d.ToString("yyyy-MM-dd-HH:mm:ss");
            string s6 = d.ToString("yyyy-MM-dd-HH:mm:fff");


            Console.WriteLine(d.ToLongDateString());
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine(s4);
            Console.WriteLine(s5);
            Console.WriteLine(s6);
        }
        
    }
}
