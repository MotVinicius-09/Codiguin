using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeControl
{
    class Employee
    {
        public string  Name { get; set; }
        public int Hours { get; set; }
        public double ValuePerHour { get; set; }

        public Employee()
        {
        }

        public Employee(string name, int hours, double valuePerHour)
        {
            Name = name;
            Hours = hours;
            ValuePerHour = valuePerHour;
        }

 
        public virtual double Payment()
        {
            return Hours * ValuePerHour;
        }

    }

    class OutsourcedEmployee : Employee
    {
        public double AddtionalCharge { get; set; }
        public OutsourcedEmployee()
        {
        }   

        public OutsourcedEmployee(string name, int hours, double valuePerHour, double addtionalCharge) : base(name,hours,valuePerHour)
        {
            AddtionalCharge = addtionalCharge;
        }
        
        public override double Payment()
        {
            return base.Payment() + 1.1 * AddtionalCharge;

        }
    }
}
