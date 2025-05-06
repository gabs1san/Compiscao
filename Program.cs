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
            Console.Write("Name");
            string name = Console.ReadLine();

            Console.Write("Level (Junir/Pleo/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());

            Console.WriteLine("BaseSalary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvarianteCulture);

            Department dept = new Department(deptName);
            Worker worker = new Worker(name, level, baseSalary, dept);



        }
    }
}