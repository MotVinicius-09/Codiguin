using System;

namespace Trabalho_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escreva um programa que usando a instrução switch e que a partir de um valor,
            //informado pelo usuário realize as seguintes conversões:
            //P->Polegadas para Centímetros
            //G->Galão para Litros
            //M->Milhas para Kilometros
            //Para a primeira conversão o usuário deverá informar a opção P , para a segunda deve,
            //informar G e para a terceira deve informar M.

            Console.Write("Digite um numero para ser convertido: ");
            double num = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("Digite a opção para a conversão: ");
            Console.WriteLine("[1] Polegadas para Centímetros");
            Console.WriteLine("[2] Galão para Litros");
            Console.WriteLine("[3] Milhas para Kilometros");

            Console.Write("Opcao: ");
            int opcao = int.Parse(Console.ReadLine());
            Console.WriteLine();

            double result;
            switch (opcao)
            {
                case 1:
                    {
                        result = num / 0.3937;
                        Console.WriteLine("[1] " + num + " polegas são " + result + " centimetros");
                        break;
                    }
                case 2:
                    {
                        result = num * 3.78;
                        Console.WriteLine("[2] " + num + " galões são " + result + " litros");
                        break;
                    }
                case 3:
                    {
                        result = num * 1.60;
                        Console.WriteLine("[3] " + num + " milhas são " + result + " kilometros");
                        break;
                    }  
            }

        }
    }
}
