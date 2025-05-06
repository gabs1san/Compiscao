using Compiscao;
using Compiscao.Entities;
using Compiscao.Entities.Enums;
using System;
using System.Globalization;


namespace Composicao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter departments name: ");
            string deptName = Console.ReadLine();

            Console.Write("Enter Worker data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Level (Junir/Pleno/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());

            Console.WriteLine("BaseSalary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Department dept = new Department(deptName);
            Worker worker = new Worker(name, level, baseSalary, dept);

            Console.Write("How many contracts to this worker? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} contract data: ");
                Console.WriteLine("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("value per hour: ");
                double ValuPerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Duration (Hours): ");
                int hours = int.Parse(Console.ReadLine());

                HourContract contract = new HourContract(date, ValuPerHour, hours);
                worker.AddContract(contract);
                 
            }

            Console.WriteLine();
            Console.Write("Enter month and year to calculate income (MM/YYYY): ");

            string monthAndYear = Console.ReadLine();

            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));

            Console.WriteLine("Name:" + worker.Name);
            Console.WriteLine("Department" + worker.Department.Name);
            Console.WriteLine("Income for " + monthAndYear + ": " + worker.Income(year, month));
        }
    }
}