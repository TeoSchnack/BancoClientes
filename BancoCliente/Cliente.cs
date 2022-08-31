namespace BancoCliente
{
    class Cliente
    {
        //Propriedades
        public int ID { get; private set; }
        public string Nome { get; private set; }
        public double Saldo { get; private set; }

        //Construtores
        public Cliente()
        {
        }
        public Cliente(int iD, string nome, double saldo)
        {
            ID = iD;
            Nome = nome;
            Saldo = saldo;
        }


        public bool TesteDiminuir(double Valor)
        {
            if (Valor <= Saldo && Valor > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Diminuir(double valor)
        {
            bool T = false;

            if (valor <= Saldo && valor > 0)
            {
                Saldo -= valor;
                return true;
            }

            return T;
        }
        public bool Somar(double valor)
        {
            bool T = false;

            if (valor > 0)
            {
                Saldo += valor;
                T = true;
            }

            return T;
        }


        public override string ToString()
        {
            string auxNome = "|    " + Nome;
            for ( int I = auxNome.Length; I < 20; I++)
            {
                auxNome += " ";
            }
            auxNome += "|";
            string auxID = "|    ID -> " + ID;
            for (int I = auxID.Length; I < 20; I++)
            {
                auxID += " ";
            }
            auxID += "|";

            string auxSaldo = "|    R$" + Saldo.ToString("F2");
            for (int I = auxSaldo.Length; I < 20; I++)
            {
                auxSaldo += " ";
            }
            auxSaldo += "|";

            string auxLinha1 = " ";
            for (int I = auxLinha1.Length; I < 20; I++)
            {
                auxLinha1 += "_";
            }
            string auxLinha2 = "| ";
            for (int I = auxLinha2.Length; I < 20; I++)
            {
                auxLinha2 += " ";
            }
            auxLinha2 += "|";

            string auxLinhaF = "|";
            for (int I = auxLinhaF.Length; I < 20; I++)
            {
                auxLinhaF += "_";
            }
            auxLinhaF += "|";

            return auxLinha1 + "\n" +
                   auxLinha2 + "\n" +
                   auxNome + "\n" +
                   auxLinhaF + "\n" +
                   auxLinha2 + "\n" +
                   auxID + "\n" +
                   auxSaldo + "\n" +
                   auxLinhaF;

        }
    }
}
