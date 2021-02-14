using System;

namespace Trabalho_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Program nProgram = new Program();
            {
                Console.Write("Informe o lado A: ");
                int a = int.Parse(Console.ReadLine());

                Console.Write("Informe o lado B: ");
                int b = int.Parse(Console.ReadLine());

                Console.Write("informe o lado c: ");
                int c = int.Parse(Console.ReadLine());
                double areaTriang = Program.AreaDoTriangulo(a, b, c);
                Program.TriangExiste(a, b, c);

                Console.WriteLine("Area do Triangulo: " + areaTriang.ToString("F2"));
            }
        }
        public static double AreaDoTriangulo(int a, int b, int c)
        {
            double p = (a + b + c) / 2;
            double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            return area;
        }

        private static void TriangExiste(int a,int b,int c)
        {
            if((a < b+c) && (b < a+c) && (c < a+b))
            {
                Console.WriteLine();
                Console.WriteLine("Formam um triângulo!");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Não forma um triângulo!");
            }
        }
    }
}
