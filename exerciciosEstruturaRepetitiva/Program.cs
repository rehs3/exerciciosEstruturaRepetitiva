using System;
using System.Globalization;

namespace repetitivo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a senha: ");
            int senha= int.Parse(Console.ReadLine());

            while( senha != 2002)
            {
                Console.WriteLine("Senha incorreta!!");
                senha = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Senha correta!!");
        }
    }
}
