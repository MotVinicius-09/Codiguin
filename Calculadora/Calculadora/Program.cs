using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------");
            Console.WriteLine(" C A L C U L A D O R A ");
            Console.WriteLine("-----------------------");

            Console.WriteLine();
            Console.WriteLine("Digite o primeiro numero: ");
            string valorInicial = Console.ReadLine();
            bool isNumInteiro = double.TryParse(valorInicial, out double num);

            double valor1 = 0;
            if(isNumInteiro)
            {
                valor1 = Math.Round(double.Parse(valorInicial), 4);
            }
            else
            {
                Console.WriteLine("Digite um valor valido");
            }

            Console.WriteLine("Digite a operação +/-/*/%");
            string operacao = Console.ReadLine();
            
            Console.WriteLine();
            Console.WriteLine("Digite o Segundo numero: ");
            valorInicial = Console.ReadLine();
            isNumInteiro = double.TryParse(valorInicial, out num);

            double valor2 = 0;
            if (isNumInteiro)
            {
                valor2 = Math.Round(double.Parse(valorInicial), 4);
            }
            else
            {
                Console.WriteLine("Digite um valor valido");
            }

            double resultado = 0;
            switch(operacao)
            {
                case "+":
                    resultado = Math.Round(valor1 + valor2, 4);
                    Console.WriteLine($"{valor1} {"+"} {valor2} = {resultado}");
                    break;
                case "-":
                    resultado = Math.Round(valor1 - valor2, 4);
                    Console.WriteLine($"{valor1} {"-"} {valor2} = {resultado}");
                    break;
                case "*":
                    resultado = Math.Round(valor1 * valor2, 4);
                    Console.WriteLine($"{valor1} {"*"} {valor2} = {resultado}");
                    break;
                case "/":
                    resultado = Math.Round(valor1 / valor2, 4);
                    Console.WriteLine($"{valor1} {"/"} {valor2} = {resultado}");
                    break;
            }
            
            Console.ReadKey();
        }
    }
}
