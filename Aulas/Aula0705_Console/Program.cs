using System;

namespace Aula0705_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;

            Console.WriteLine("Hello World");

            Console.WriteLine("a: " + a);

            if (Console.CapsLock)
                Console.WriteLine("CapsLock Ativado");
            else
                Console.WriteLine("CapsLock Desativado");

            Console.ReadKey();
        }
    }
}