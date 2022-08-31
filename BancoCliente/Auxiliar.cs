using System;
namespace BancoCliente
{
    class Auxiliar
    {
        public static void WhileConta(Cliente Correntista, string NomeCorrentista)
        {
            MenuConta Opt = MenuConta.Inicio;

            while (Opt != MenuConta.Sair)
            {
                if (Opt == MenuConta.Depositar)
                {
                    Console.WriteLine("Quanto deseja depositar?");
                    try
                    {
                        //Somar ao Saldo
                        if (Correntista.Somar(double.Parse(Console.ReadLine())))
                        {
                            Extra.Gap(10);
                            ConsoleColor Aux = Console.ForegroundColor;
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Sucesso!");
                            Console.ForegroundColor = Aux;
                        }
                        else
                        {

                            Extra.Gap(10);
                            ConsoleColor Aux = Console.ForegroundColor;
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Erro!");
                            Console.WriteLine("Valor Inserido Inválido!");
                            Console.ForegroundColor = Aux;
                        }
                    }
                    catch
                    {
                        Extra.Gap(10);
                        ConsoleColor Aux = Console.ForegroundColor;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Erro!");
                        Console.WriteLine("Entrada Inválida!");
                        Console.ForegroundColor = Aux;
                    }
                }
                else if (Opt == MenuConta.Transferir)
                {
                    Console.WriteLine("Para quem deseja transferir?");
                    try
                    {
                        //Abrir Conta Recebedor
                        Cliente CorrentistaRecebedor = Extra.AbrirCliente(Console.ReadLine());
                        Console.WriteLine("Quanto deseja Transferir?");
                        try
                        {
                            //Receber Valor de Transferencia
                            double Valor = double.Parse(Console.ReadLine());

                            //Sucesso  
                            if (Correntista.Diminuir(Valor))
                            {

                                Extra.Gap(10);
                                ConsoleColor Aux = Console.ForegroundColor;
                                Console.ForegroundColor = ConsoleColor.Green;
                                CorrentistaRecebedor.Somar(Valor);
                                Console.WriteLine("Sucesso!");
                                Console.ForegroundColor = Aux;
                            }
                            //Erro Saldo
                            else
                            {

                                Extra.Gap(10);
                                ConsoleColor Aux = Console.ForegroundColor;
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Erro!");
                                Console.WriteLine("Saldo Insuficiente!");
                                Console.ForegroundColor = Aux;
                            }
                        }
                        catch
                        {

                            Extra.Gap(10);
                            ConsoleColor Aux = Console.ForegroundColor;
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Erro!");
                            Console.WriteLine("Conta Nao Encontrada!");
                            Console.ForegroundColor = Aux;
                        }

                    }
                    catch
                    {

                        Extra.Gap(10);
                        ConsoleColor Aux = Console.ForegroundColor;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Erro!");
                        Console.WriteLine("Cadastro não encontrada");
                        Console.ForegroundColor = Aux;
                    }
                }
                else if (Opt == MenuConta.Retirada)
                {
                    try
                    {
                        Console.WriteLine("Qual o valor a ser retirado?");
                        double Valor = Double.Parse(Console.ReadLine());
                        try
                        {
                            if (Correntista.Diminuir(Valor))
                            {

                                Extra.Gap(10);
                                ConsoleColor Aux = Console.ForegroundColor;
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Erro!");
                                Console.WriteLine("Saldo Insuficiente!");
                                Console.ForegroundColor = Aux;
                            }
                        }
                        catch
                        {

                            Extra.Gap(10);
                            ConsoleColor Aux = Console.ForegroundColor;
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Erro!");
                            Console.WriteLine("Saldo Insuficiente!");
                            Console.ForegroundColor = Aux;
                        }
                    }
                    catch
                    {

                        Extra.Gap(10);
                        ConsoleColor Aux = Console.ForegroundColor;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Erro!");
                        Console.WriteLine("Entrada Invalida!");
                        Console.ForegroundColor = Aux;
                    }
                }
                else if (Opt == MenuConta.Visualizar)
                {
                    Console.WriteLine(Correntista);
                }

                Extra.SalvarCliente(Correntista, NomeCorrentista);

                if (Opt != MenuConta.Inicio)
                {
                    Console.ReadKey();
                    Extra.Gap(30);
                }

                Opt = Extra.MenuC();
            }
        }
    }
}
