using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace OOP.Classes_e_Objetos
{
    class Metodos
    {
        public void Execucao()
        {


             /* Depósitar */
             /*Console.WriteLine();
             Console.WriteLine("Digite o seu nome:");
             var nome = Console.ReadLine();
             Console.WriteLine("Informe um valor para deposito:");*/

             /* Saque */
             Console.WriteLine();
            Console.WriteLine("Digite o seu nome:");
            var nome = Console.ReadLine();
            Console.WriteLine("Informe um valor para saque:");


            //valor = Convert.ToDouble(Console.ReadLine());
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            var conta = new ContaCorrente()
            {
                Agencia = 055,
                Titular = "Maria",
                Numero = 00001,
                Saldo = 5000
            };

            //var depositar = conta.Depositar(valor);
            var saque = conta.Sacar(valor);

        }
    }

    public class ContaCorrente
    {
        public string Titular;
        public int Agencia;
        public int Numero;
        public double Saldo;

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
        /*public double Depositar( double valor)
        {
            Saldo += valor;
            Console.WriteLine("Transação realizada com sucesso!");
            Console.WriteLine();
            Console.WriteLine("-----------------------------------");

            Console.WriteLine("EXTRATO");
            Console.WriteLine(DateTime.Now.ToString("dd'-'MM'-'yyyy"));
            Console.WriteLine($"SALDO: {Saldo}");

            return Saldo;
        }*/
    }
}
