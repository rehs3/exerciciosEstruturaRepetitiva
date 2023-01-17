using System;
using System.Drawing;
using System.Globalization;
using System.Runtime.ConstrainedExecution;

namespace repetitivo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escreva um programa que repita a leitura de uma senha até que ela seja válida. Para cada leitura de senha
            //incorreta informada, escrever a mensagem "Senha Invalida".Quando a senha for informada corretamente deve ser
            //impressa a mensagem "Acesso Permitido" e o algoritmo encerrado.Considere que a senha correta é o valor 2002.
            
           Console.WriteLine("Digite a senha: ");
            int senha= int.Parse(Console.ReadLine());

            while( senha != 2002)
            {
                Console.WriteLine("Senha incorreta!!");
                Console.WriteLine("Digite a senha novamente:");
                senha = int.Parse(Console.ReadLine());
                
            }
            Console.WriteLine("Senha correta!!");

            //Escreva um programa para ler as coordenadas (X,Y) de uma quantidade indeterminada de pontos no sistema
            //cartesiano.Para cada ponto escrever o quadrante a que ele pertence. O algoritmo será encerrado quando pelo menos uma de
            //duas coordenadas for NULA(nesta situação sem escrever mensagem alguma).

            Console.WriteLine("Digite as cordenadas X e Y: ");

            string[] valores = Console.ReadLine().Split(' ');
            int x = int.Parse(valores[0]);
            int y = int.Parse(valores[1]);

            while(x != 0 && y != 0)
            {
                if( x > 0 && y > 0 )
                {
                    Console.WriteLine("PRIMEIRO!!!");
                }
                else if( x < 0 && y > 0 ) {
                    Console.WriteLine(" SEGUNDO!!!");
                }
                else if (x < 0 && y < 0 )
                {
                    Console.WriteLine("TERCEIRO!!!");
                }
                else
                {
                    Console.WriteLine("QUARTO!!!");
                }
                valores = Console.ReadLine().Split(' ');
                x = int.Parse(valores[0]);
                y= int.Parse(valores[1]);
            }
        }
       
    }
}
