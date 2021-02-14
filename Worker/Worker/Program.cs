using System;
using Worker.Entities;

namespace Worker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter department's name: ");
            string depart = Console.ReadLine();

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Level (Junior,MidLevel,Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());

            Console.Write("Base Salary: ");
            double salary = double.Parse(Console.ReadLine());

            Department department = new Department(depart);
            Work work = new Work(name, level, salary, department);

            Console.Write("How many contracts to this worker?: ");
            int quantCont = int.Parse(Console.ReadLine());

            for(int i = 0; i < quantCont; i++)
            {
                Console.Write("Enter #" + (i+1) + " contract data: ");
                Console.Write("Date (MM/DD/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                
                Console.Write("Value per hour: ");
                double value = double.Parse(Console.ReadLine());

                Console.Write("Daration (Hours): ");
                int duration = int.Parse(Console.ReadLine());

                HourContract contract = new HourContract(date, value, duration);
                work.AddContract(contract);

            }

            Console.WriteLine();
            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string mouthAndYear = Console.ReadLine();
            int mouth = int.Parse(mouthAndYear.Substring(0, 2));
            int year = int.Parse(mouthAndYear.Substring(3));
            Console.WriteLine("Name: " + work.Name);
            Console.WriteLine("Department: " + work.Department.Name);
            Console.WriteLine("Income for " + mouthAndYear + ": " + work.Income(year,mouth).ToString("F2"));
           






        }
    }

}

