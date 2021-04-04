using System;
using System.Collections.Generic;
using System.Globalization;
using Exercicio_Udemy_Aula_119.Entites;
using Exercicio_Udemy_Aula_119.Entites.Enums;
namespace Exercicio_Udemy_Aula_119
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter departament's name: ");
            string namedepartament = Console.ReadLine();
            Departament departament = new Departament(namedepartament);
            Console.WriteLine("Enter worker data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel level  = Enum.Parse<WorkerLevel>(Console.ReadLine());

            Console.Write("Base salary: ");
            double basesalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Worker worker = new Worker(name, level, basesalary, departament);
            Console.Write("How many contracts to this worker? ");
            int n = int.Parse(Console.ReadLine());
            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} contract data: ");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valueperhour = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                Console.Write("Duration (hours): ");
                int hours = int.Parse(Console.ReadLine());
                HourContract hourContract = new HourContract(date, valueperhour, hours);
                worker.AddContract(hourContract);
            }
            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string[] yearmoth = Console.ReadLine().Split('/');
            int monht = int.Parse(yearmoth[0]);
            int year = int.Parse(yearmoth[1]);
            Console.WriteLine("Name: " 
                + worker.Name
                + "\nDepartament: "
                + departament.Name + "\nIncome for "
                + monht + "/" + year + ": " + worker.Income(year, monht).ToString("F2", CultureInfo.InvariantCulture));
           
            
                
        }
    }
}
