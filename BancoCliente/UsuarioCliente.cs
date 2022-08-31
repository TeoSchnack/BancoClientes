using System;
namespace BancoCliente
{
    class UsuarioCliente
    {
        //static void Main(string[] args)
        public static void UMain()
        {
            string NomeCorrentista ="Teo";
            Cliente Correntista = Extra.AbrirCliente(NomeCorrentista);

            Auxiliar.WhileConta(Correntista, NomeCorrentista);
        }
    }
}