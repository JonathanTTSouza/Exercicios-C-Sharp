using System.Globalization;

namespace exercicioFixacao
{
    class Conta
    {
        public int NumConta { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public Conta(int numconta, string titular)
        {
            NumConta = numconta;
            Titular = titular;
        }
        public Conta(int numconta, string titular, double saldo) : this(numconta, titular)
        {
            Saldo = saldo;
        }

        public void Deposito(double valorDeposito)
        {
            Saldo = Saldo + valorDeposito;
        }

        public void Saque(double valorSaque)
        {
            Saldo = Saldo - valorSaque - 5.00;
        }

        public override string ToString()
        {
            return "Conta " + NumConta + ", Titular: " + Titular + ", Saldo: $ " + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
