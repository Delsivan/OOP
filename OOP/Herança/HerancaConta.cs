using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Herança
{
    class HerancaConta
    {
        public int Numero { get; private set; }
        public string Titular { get; private set; }
        public double Saldo { get; protected set; }

        public HerancaConta()
        {

        }

        public HerancaConta(int numero, string titular, double saldo)
        {
            Numero = numero;
            Titular = titular;
            this.Saldo = saldo;
        }

        public double Sacar(double valor)
        {
            if (Saldo < valor)
            {
                Console.WriteLine($"Transação não realizada. Seu Saldo {Saldo} é inferior ao valor do Saque {valor}.");
            }
            else
            {
                Saldo -= valor;
                Console.WriteLine("Transação realizada com sucesso!");
                Console.WriteLine();

                Console.WriteLine("-----------------------------------");
                Console.WriteLine("EXTRATO");
                Console.WriteLine(DateTime.Now.ToString("dd'-'MM'-'yyyy"));
                Console.WriteLine("SALDO:" + Saldo.ToString("F2"));


                return Saldo;
            }
            return Saldo;
        }
        public double Depositar( double valor)
        {
            Saldo += valor;
            Console.WriteLine("Transação realizada com sucesso!");
            Console.WriteLine();
            Console.WriteLine("-----------------------------------");

            Console.WriteLine("EXTRATO");
            Console.WriteLine(DateTime.Now.ToString("dd'-'MM'-'yyyy"));
            Console.WriteLine($"SALDO: {Saldo}");

            return Saldo;
        }
    }
}
