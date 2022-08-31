using System;
namespace BancoCliente
{
    class UsuarioFuncionario
    {
        //public static void T()
        public static void Main(string []arg)
        {
            MenuFuncionario Opt = MenuFuncionario.Inicio;

            while (Opt != MenuFuncionario.Sair)
            {
                if (Opt == MenuFuncionario.EntrarEmConta)
                {
                    Console.WriteLine("Qual o nome do titular da conta?");
                    string NomeCorrentista = Console.ReadLine();

                    Cliente Correntista = Extra.AbrirCliente(NomeCorrentista);

                    if (Correntista != null)
                    {
                        Auxiliar.WhileConta(Correntista, NomeCorrentista);
                        Extra.Gap(10);
                    }
                    else
                    {
                        Console.WriteLine("Cliente não encontrado");
                        Console.WriteLine("Deseja gerar um novo cadastro?");

                        if (Console.ReadLine().Equals("s") || Console.ReadLine().Equals("S"))
                        {
                            Extra.NovoCliente();
                        }
                        else
                        {
                            Opt = MenuFuncionario.Inicio;
                        }
                    }
                }
                else if (Opt == MenuFuncionario.CriarNovaConta)
                {
                    Cliente Correntista = Extra.NovoCliente();
                    Extra.SalvarCliente(Correntista, Correntista.Nome);
                }

                Opt = Extra.MenuF();
                Extra.Gap(10);
            }
        }
    }
}