using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using Exercicio_Udemy_Aula_119.Entites.Enums;
namespace Exercicio_Udemy_Aula_119.Entites
{
    class Worker
    {
        public string Name { get; set; }
        public  WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Departament Departament { get; set; }
        public  List<HourContract> hourcontract { get; set; }
        public Worker()
        {

        }
        public Worker(string name, WorkerLevel level, double baseSalary, Departament departament)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Departament = departament;
            hourcontract = new List<HourContract>();
        }

        public void AddContract(HourContract contract)
        {
            hourcontract.Add(contract);
        }
        public void RemoveContract(HourContract contract)
        {
            hourcontract.Remove(contract);
        }
        public double Income(int year, int month)
        {
            double tot = BaseSalary;
          foreach(HourContract list in hourcontract)
            {
                if(year == list.Date.Year && month == list.Date.Month)
                {
                    tot += list.TotalValue();
                }              
            }
            return tot;
        }       
    }
}
