using System;
using POO_1112.Classes;

namespace POO_1112
{
    class Program
    {
        static void Main(string[] args)
        {
           //instanciamos nossa claase de Funcionário
            Funcionario fun = new Funcionario();
            fun.Mostrar();
            fun.Mostrar(" Gabriela");
            fun.Mostrar(3);

            Console.Beep();
        }
    }
}
