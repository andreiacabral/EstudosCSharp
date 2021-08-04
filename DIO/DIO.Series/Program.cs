using System;
using DIO.Series.Enum;

namespace DIO.Series
{
    class Program
    {
        static SerieRepositorio repositorio = new SerieRepositorio();
        static void Main(string[] args)
        {
            string opcaoUsuario = ObterOpcaoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch(opcaoUsuario)
                {
                    case "1":
                    ListarSerie();
                    break;
                       case "2":
                    InserirSerie();
                    break;
                       case "3":
                    AtualizarSerie();
                    break;
                       case "4":
                    ExcluirSerie();
                    break;
                       case "5":
                    VisualizarSerie();
                    break;

                     case "C":
                     Console.Clear();
                     break;

                     default:
                     throw new ArgumentOutOfRangeException();
                }
            }
        }

       

        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("Dio Seriesa a seu dispor!!!");
            Console.WriteLine("Informe a opcao desejada: ");

            Console.WriteLine("1-Listar Series");
            Console.WriteLine("2-Inserir nova Series");
            Console.WriteLine("3-Atualizar Serie");
            Console.WriteLine("4-Exclui Series");
            Console.WriteLine("5-Visualixzar Series");
            Console.WriteLine("c-Limpar Tela");
            Console.WriteLine("x-Sair");
            Console.WriteLine();
        
            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }  

        private static void ListarSerie()
        {
            Console.WriteLine("Listar series");

            var lista=repositorio.Lista();
            if (lista.Count ==0)
            {
                Console.WriteLine("Nenhuma serie cadastrada.");
                return;

            }

            foreach(var serie in lista)
            {
                Console.WriteLine("#ID {0}; - {1}",serie.RetornaId(),serie.RetornaTitulo());
            }
        }
        private static void InserirSerie ()
        {
            Console.WriteLine("Inserir nova Serie ");

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0}={1}",i,Enum.GetName(typeof(Genero),i));
            }
            Console.Write("Digite o genero entre as opcaoes acima: ");
            int entradaGenero =int.Parse(Console.ReadLine());

            Console.Write("Digite o Titulo da Serie: ");
            string entradaTitulo = Console.ReadLine();

            Console.Write("Digiteo Ano de Inicio da Serie: ");
            int entrada = int.Parse(Console.ReadLine());

            Console.Write("Digite a descrição da serie: ");
            string entradaDescricao=Console.ReadLine();

            Serie novaSerie = new Serie(id: repositorio.ProximoId());
        }

        private static void VisualizarSerie()
        {
            throw new NotImplementedException();
        }

        private static void ExcluirSerie()
        {
            throw new NotImplementedException();
        }

        private static void AtualizarSerie()
        {
            throw new NotImplementedException();
        }

    }
}
