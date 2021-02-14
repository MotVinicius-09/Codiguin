using System;

namespace CriaArquivosMatematicos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Que tabuada de multiplicação você quer ver?: ");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("Tabuada do " + num + ":");

            for(int i = 0; i <= 10; i ++)
            {
                Console.WriteLine(num + " * " + i + " = "+ (num*i));
            }
        }
    }
}
