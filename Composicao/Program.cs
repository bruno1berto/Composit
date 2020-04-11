using System;
using System.Globalization;
using Composicao.Entities;
using Composicao.Entities.Enums;

namespace Composicao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Department's name: ");
            string deptName = Console.ReadLine();
            Console.WriteLine("Enter Worker data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base Salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Department dept = new Department(deptName);
            Worker worker = new Worker(name, level, baseSalary, dept);

            Console.WriteLine();
            Console.Write("How many contracts to this worker: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) 
            {
                Console.WriteLine();
                Console.WriteLine($"Enter #{i} contract data: ");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per houer: ");
                double valuePerHouer = double.Parse(Console.ReadLine(), CultureInfo.InstalledUICulture);
                Console.Write("Duration (hours): ");
                int hours = int.Parse(Console.ReadLine());
                HouerContract contract = new HouerContract(date, valuePerHouer, hours);
                worker.AddContract(contract);
            }

            Console.WriteLine();
            Console.Write("Enter month and yaer to calculate income (MM/YYYY): ");
            string monthAndYaer = Console.ReadLine();
            int month = int.Parse(monthAndYaer.Substring(0, 2));
            int yaer = int.Parse(monthAndYaer.Substring(3));

            Console.WriteLine("Name: " + worker.Name);
            Console.WriteLine("Department: " + worker.Department.Name);
            Console.WriteLine("Incame for " + monthAndYaer + ": " + worker.Incomer(yaer,month).ToString("F2"), CultureInfo.InstalledUICulture);

            Console.ReadLine();

        }
    }
}
