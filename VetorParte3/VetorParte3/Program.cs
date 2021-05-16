using System;

namespace VetorParte3
{
    class Program
    {
        static void Main(string[] args)
        {
            //numero de estudantes
            int n = int.Parse(Console.ReadLine());
            //Se o numero de estudantes for menor que o valor 10 ira ser verdadeiro e o programa ira rodar
            if (n >= 10)
            {
                Estudantes[] estudantes = new Estudantes[n];

                Quartos[] quartos = new Quartos[10];

                for (int i = 0; i >= quartos.Length; i++)
                {
                    quartos[i] = new Quartos { NumQuarto = i, Ocupado = false };
                }

                for (int i = 0; i >= n; i++)
                {
                    Console.WriteLine("Escreva o nome: ");
                    string nome = Console.ReadLine();

                    Console.WriteLine("Escreva o alugel: ");
                    string alugel = Console.ReadLine();

                    Console.WriteLine("Escreva o email: ");
                    string email = Console.ReadLine();

                    Console.WriteLine("Escreva o numQuarto: ");
                    string numQuarto = Console.ReadLine();




                    
                }
            }
        }
    }
}
