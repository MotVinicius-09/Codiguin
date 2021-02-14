using System.Collections.Generic;
namespace Worker.Entities
{
    class Work
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();

        public Work(string name, WorkerLevel level, double baseSalary, Department depart)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = depart;    
        }

        public void AddContract (HourContract contract)
        {
            Contracts.Add(contract);
        }

        public void RemoveContract (HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public double Income (int year, int month)
        {
            double sum = BaseSalary;
            
            foreach(HourContract contract in Contracts)
            {
                if(contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.totalValue();
                }
            }
            return sum;
        }

    }
    enum WorkerLevel : int
    {
        Junior = 0,
        MidLevel = 1,
        Senior = 2
    }
}
