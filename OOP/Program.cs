using OOP.Classes_e_Objetos;
using OOP.Encapsulamento;
using OOP.Herança;
using OOP.Polimofismo;

using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine(" Escolha uma opção: ");
            Console.WriteLine();
            Console.WriteLine("0 - Classes e Objetos ");
            Console.WriteLine("1 - Métodos");
            Console.WriteLine("2 - Encapsulamento");
            Console.WriteLine("3 - Herança");
            Console.WriteLine("4 - Polimofismo");
            Console.WriteLine();

            int opcao = int.Parse(Console.ReadLine());

            switch (opcao) {
                case 0:
                    new ClassesObjetos().Execucao();
                    break;
                case 1:
                    new Metodos().Execucao();
                    break;
                //case 2:
                   // new Encapsulamento().Execucao();
                   // break;
                //case 3:
                   // new ContaHeranca().Execucao();
                    //break;
                //case 4:
                    //new Polimofismo().Execucao();
                    //break;
            }
            Console.ReadLine();
            
        }
    }
}
