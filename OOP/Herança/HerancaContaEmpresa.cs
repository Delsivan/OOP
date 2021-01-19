using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Herança
{
    class HerancaContaEmpresa : HerancaConta
    {
        public double LimiteEmprestimo { get; set; }

        public HerancaContaEmpresa()
        {
        }

        public HerancaContaEmpresa(int numero, string titular, double saldo, double limiteEmprestimo)
            : base(numero, titular, saldo)
        {
            LimiteEmprestimo = limiteEmprestimo;
        }

        public void Emprestimo(double valor)
        {
            if (valor <= LimiteEmprestimo)
            {
                Saldo += valor;
            }
        }
    }
}
