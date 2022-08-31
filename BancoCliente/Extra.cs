using System;
using System.IO;
namespace BancoCliente
{
    class Extra
    {
        //Gerar Novo Cadastro de Cliente
        public static Cliente NovoCliente()
        {
            string[] files = Directory.GetFiles(@"C:\Users\teodoro.soares\Pictures\CSharp\BancoCliente\Dados\");
            Console.WriteLine("Qual o nome da conta?");
            string nomeConta = Console.ReadLine();
            Console.WriteLine("Deseja fazer um deposito inicial?");
            double saldoConta = 0;
            string T = Console.ReadLine();
            if (T.Equals("s") || T.Equals("S"))
            {
                Console.WriteLine("Qual Valor?");
                saldoConta = double.Parse(Console.ReadLine());
            }

            return new Cliente(files.Length+1, nomeConta, saldoConta);
        }

        //Arquivo
        public static Cliente AbrirCliente(string nome)
        {
            try
            {
                string[] dadosConta = File.ReadAllLines(@"C:\Users\teodoro.soares\Pictures\CSharp\BancoCliente\Dados\" + nome);
                return new Cliente(int.Parse(dadosConta[0]), dadosConta[1], double.Parse(dadosConta[2]));
            }
            catch
            {
                return null;
            }

            
        }
        public static void SalvarCliente(Cliente Correntista, string nomeDaConta)
        {
            File.Delete(@"C:\Users\teodoro.soares\Pictures\CSharp\BancoCliente\Dados\" + nomeDaConta);
            string[] _salva = { Correntista.ID + "",
                                Correntista.Nome  + "",
                                Correntista.Saldo + "" };
            using (StreamWriter sw = File.AppendText(@"C:\Users\teodoro.soares\Pictures\CSharp\BancoCliente\Dados\" + nomeDaConta))
            {
                for (int I = 0; I < _salva.Length; I++)
                {
                    sw.WriteLine(_salva[I]);
                }
            }
        }

        //Menus
        public static MenuConta MenuC()
        {
            int retorno = 5;
            try
            {
                while (!((retorno == 0) || (retorno == 1) || (retorno == 2) || (retorno == 3) || (retorno == 4)))
                {
                    Console.WriteLine(" 1 | Depositar");
                    Console.WriteLine(" 2 | Transferir");
                    Console.WriteLine(" 3 | Retirada");
                    Console.WriteLine(" 4 | Visualizar");
                    Console.WriteLine("----------------");
                    Console.WriteLine(" 0 | Sair");

                    retorno = int.Parse(Console.ReadLine());

                    if (!((retorno == 0) || (retorno == 1) || (retorno == 2) || (retorno == 3) || (retorno == 4)))
                    {
                        Erro();
                    }
                }
            }
            catch
            {
                Erro();
            }

            return (MenuConta)retorno;
        }
        public static MenuFuncionario MenuF()
        {
            int retorno = 3;
            try
            {
                while (!((retorno == 0) || (retorno == 1) || (retorno == 2)))
                {
                    Console.WriteLine(" 1 | Entrar em Conta");
                    Console.WriteLine(" 2 | Criar nova Conta");
                    Console.WriteLine("----------------");
                    Console.WriteLine(" 0 | Sair");

                    retorno = int.Parse(Console.ReadLine());

                    if (!((retorno == 0) || (retorno == 1) || (retorno == 2)))
                    {
                        Erro();
                    }
                }
            }
            catch
            {
                Erro();
            }

            return (MenuFuncionario)retorno;
        }
        //Mensagem de Erro
        public static void Erro()
        {
            ConsoleColor Aux = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Erro!");
            Console.WriteLine("Entrada Inválida!");
            Console.ForegroundColor = Aux;
        }

        //Limpa Tela
        public static void Gap (int ln)
        {
            for (int I = 0; I < ln; I ++)
            {
                Console.WriteLine();
            }
        }
    }
}