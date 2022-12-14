namespace bytebank
{
    public class ContaCorrente
    {
        public string titular;
        public string conta;
        public string nome_agencia;
        public int numero_agencia;
        public double saldo;

        public bool Sacar(double valor)
        {
            if(saldo < valor)
            {
                Console.WriteLine("Saldo insuficiente para saque!");
                return false;
            } else
            {
                saldo = saldo - valor;
                return true;
            }
        }

        public void Depositar(double valor)
        {
            saldo = saldo + valor;
        }

        public bool Transferir(double valor, ContaCorrente destino)
        {
            if(saldo < valor)
            {
                return false;
            } else if(valor < 0)
            {
                return false;
            } else
            {
                saldo = saldo - valor;
                destino.saldo = destino.saldo + valor;
                return true;
            }
        }
    }
}