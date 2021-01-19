using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Classes_e_Objetos
{
    class ClassesObjetos
    {
        public class Conta
        {
            public int Agencia { get; set; }
            public string TipoConta { get; set; }
            public string Banco { get; set; }
            public int NumeroConta { get; set; }
            public double Saldo { get; set; }

        }

        public class Cliente
        {
            public string Nome { get; set; }
            public int Idade { get; set; }
            public string Telefone { get; set; }
            public string Email { get; set; }

        }
        public void Execucao()
        {
            var conta = new Conta()
            {
                Agencia = 055,
                TipoConta = "Conta corrente",
                Banco = "Banco dos Devs",
                NumeroConta = 00001,
                Saldo = 5000
            };

            var cliente = new Cliente()
            {
                Nome = "Maria",
                Idade = 25,
                Email = "maria@mail.com",
                Telefone = "55+(63)99999999"
            };

            Console.WriteLine();
            Console.WriteLine("Dados Bancários:");
            Console.WriteLine();
            Console.WriteLine($"Banco: {conta.Banco}");
            Console.WriteLine($"Agencia: {conta.Agencia}");
            Console.WriteLine($"Tipo: {conta.TipoConta}");
            Console.WriteLine($"Número: {conta.NumeroConta}");
            Console.WriteLine($"Saldo: {conta.Saldo}");
            Console.WriteLine();
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Dados do Cliente:");
            Console.WriteLine();
            Console.WriteLine($"Nome: {cliente.Nome}");
            Console.WriteLine($"Idade: {cliente.Idade}");
            Console.WriteLine($"Email: {cliente.Email}");
            Console.WriteLine($"Telefone: {cliente.Telefone}");
            
        }
    }
}
