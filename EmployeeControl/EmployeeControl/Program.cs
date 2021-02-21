using System;
using System.Collections.Generic;

namespace EmployeeControl
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();
            Console.Write("Enter the number of employees: ");
            int numberEmployees = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberEmployees; i++)
            {
                Console.WriteLine("Employee #" + (i + 1) + " data:");
                Console.Write("Outsourced (y/n)?: ");
                char answer = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine());

                if (answer == 'Y' || answer == 'y')
                {
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine());
                    list.Add(new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge));
                }
                else
                {
                    list.Add(new Employee(name, hours, valuePerHour));
                }
            }

            Console.WriteLine();
            foreach (Employee employee in list)
            {
                Console.WriteLine(employee.Name + "- $ " + employee.Payment().ToString("F2"));
            }
        }
    }
}
