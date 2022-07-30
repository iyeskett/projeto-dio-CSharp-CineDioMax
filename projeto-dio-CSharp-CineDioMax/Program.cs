using System;

namespace projeto_dio_CSharp_CineDioMax
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Desejar acessar a sessão de filmes ou séries? (1 - Filmes / 2 - Séries / X para sair)");
            string filmeOuSerie = Console.ReadLine();
            string opcaoUsuario = ObterOpcaoUsuario(filmeOuSerie);
            while (filmeOuSerie.ToUpper() != "X")
            {
                while (opcaoUsuario.ToUpper() != "X")
                {
                    switch (opcaoUsuario)
                    {
                        case "1":
                            if (filmeOuSerie == "1")
                            {
                                Opcoes.ListarFilmes();
                                break;
                            }
                            Opcoes.ListarSeries();
                            break;
                        case "2":
                            if (filmeOuSerie == "1")
                            {
                                Opcoes.InserirFilme();
                                break;
                            }
                            Opcoes.InserirSerie();
                            break;
                        case "3":
                            if (filmeOuSerie == "1")
                            {
                                Opcoes.AtualizarFilme();
                                break;
                            }
                            Opcoes.AtualizarSerie();
                            break;
                        case "4":
                            if (filmeOuSerie == "1")
                            {
                                Opcoes.ExcluirFilme();
                                break;
                            }
                            Opcoes.ExcluirSerie();
                            break;
                        case "5":
                            if (filmeOuSerie == "1")
                            {
                                Opcoes.VisualizarFilme();
                                break;
                            }
                            Opcoes.VisualizarSerie();
                            break;
                        case "C":
                            Console.Clear();
                            break;
                        default:
                            throw new ArgumentOutOfRangeException();
                    }

                    opcaoUsuario = ObterOpcaoUsuario(filmeOuSerie);
                }
                Console.WriteLine("Desejar acessar a sessão de filmes ou séries? (1 - Filmes / 2 - Séries / X para sair)");
                filmeOuSerie = Console.ReadLine();
                opcaoUsuario = ObterOpcaoUsuario(filmeOuSerie);
            }

            Console.WriteLine();
            Console.WriteLine("Obrigado por usar o CINE DIOMAX");

        }


        private static string ObterOpcaoUsuario(string escolherFilmeSerie)
        {
            string mascOuFem;
            string filmeOuSerie = "";
            int numero;
            bool converteu = int.TryParse(escolherFilmeSerie, out numero);

            if (converteu)
            {
                filmeOuSerie = Enum.GetName(typeof(Tipo), numero);
            }


            if (filmeOuSerie == "filme")
            {
                mascOuFem = "o";
            }
            else
            {
                mascOuFem = "a";
            }

            if (converteu)
            {
                Console.WriteLine();
                Console.WriteLine($"CINE DIOMAX {Enum.GetName(typeof(Tipo), numero)}s");
                Console.WriteLine("Informe a opção desejada: (Apenas números)");

                Console.WriteLine($"1- Listar {Enum.GetName(typeof(Tipo), numero)}s");
                Console.WriteLine($"2- Inserir nov{mascOuFem} {Enum.GetName(typeof(Tipo), numero)}");
                Console.WriteLine($"3- Atualizar {Enum.GetName(typeof(Tipo), numero)}");
                Console.WriteLine($"4- Excluir {Enum.GetName(typeof(Tipo), numero)}");
                Console.WriteLine($"5- Visualizar {Enum.GetName(typeof(Tipo), numero)}");
                Console.WriteLine($"C- Limpar Tela");
                Console.WriteLine($"X- Sair");
                Console.WriteLine();

                string opcaoUsuario = Console.ReadLine().ToUpper();
                Console.WriteLine();
                return opcaoUsuario;
            }

            return "X".ToUpper();



        }

    }
}
