using System;
using System.Globalization;
using System.Collections.Generic;

namespace CadastroDeFuncionario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos funcionario tem a empresa?: ");
            int quantFunc = int.Parse(Console.ReadLine());
            Console.WriteLine();

            List<Aumento> list = new List<Aumento>(quantFunc);
            for (int i = 0; i < quantFunc; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Cadastro #" + i + ":");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Salario: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                list.Add(new Aumento(id, nome, salario));
            }

            Console.WriteLine();
            Console.Write("Digite o id do funcionario para ser adicionado o aumento: ");
            int procuraId = int.Parse(Console.ReadLine());

            Aumento procId = list.Find(x => x.Id == procuraId);
            if (procId != null)
            {
                Console.Write("Digite a porcentagem: ");
                double percent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                procId.AumentoSalario(percent);
            }
            else
            {
                Console.WriteLine("Esse id não existe");
            }

            Console.WriteLine();
            Console.WriteLine("Lista de funcionarios: ");
            foreach (Aumento p in list)
            {
                Console.WriteLine(p);
            }




        }
    }
}
