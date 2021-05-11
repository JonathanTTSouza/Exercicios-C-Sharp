using System;
using System.Collections.Generic;
using System.Text;

namespace exercicio_fixacao
{
    class ContaBancaria
    {
        public int NumConta { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria (int numeroConta, string titular)
        {
            NumConta = numeroConta;
            Titular = titular;
        }
        public ContaBancaria(int numeroConta, string titular, double saldo):this(numeroConta, titular)
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
            return "Numero conta" + NumConta + "Nome: "  + Titular + "Saldo " +  Saldo.ToString("F2");
        }
    }
}
