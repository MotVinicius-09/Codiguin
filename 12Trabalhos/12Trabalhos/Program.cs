using System;

namespace _12Trabalhos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escreva um programa que receba um caractere informado pelo usuário e determine,
            //se o caractere é uma string maiúscula ou minúscula, um digito ou um símbolo especial.

            Console.WriteLine("Digite algum caractere: ");
            char carac = Convert.ToChar(Console.ReadLine());
            int valor = Convert.ToInt32(carac);

            if(valor >= 97 && valor <= 122)
            {
                Console.WriteLine("Caractere minúscula");
            }
            else if(valor >= 65 && valor <= 90)
            {
                Console.WriteLine("Caractere Maiúscula");
            }
            else if(valor >= 48 && valor <= 57)
            {
                Console.WriteLine("Digito");
            }

            if(valor >= 0 && valor <= 47 || valor >= 58 && valor <= 64 || valor >= 91 && valor <= 96 || valor >= 123 && valor <= 127)
            {
                Console.WriteLine("Digito especial");
            }
            else if(valor >= 127)
            {
                Console.WriteLine("Simbolo especial");
            }
        }
    }
}
                                                                