using Composicao.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Composicao.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department Department  { get; set; }
        public List<HouerContract> Contracts { get; set; } = new List<HouerContract>();

        public Worker()
        {
        }

        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddContract(HouerContract contract)
        {
            Contracts.Add(contract);
        }
        public void RemoveContract(HouerContract contract)
        {
            Contracts.Remove(contract);
        }
        public double Incomer(int yaer, int month)
        {
            double sum = BaseSalary;
            foreach (HouerContract contract in Contracts) 
            {
                if (contract.Date.Year == yaer && contract.Date.Month == month)
                {
                    sum += contract.TotalValue();
                }
            }
            return sum;
        }
    }
}
