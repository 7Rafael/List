using System;
using System.Collections.Generic;

namespace FixList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employees> list = new List<Employees>();
            Console.WriteLine("How many employees will be registered?");
            int NumEmployees = int.Parse(Console.ReadLine());

            for (int i = 0; i < NumEmployees; i++)
            {
                Console.WriteLine($"Employee #{i + 1}:");
                Console.WriteLine("Id");
                int id = (int.Parse(Console.ReadLine()));
                Console.WriteLine("Name");
                string name = (Console.ReadLine());
                Console.WriteLine("Salary");
                double salary = double.Parse(Console.ReadLine());
                list.Add(new Employees(id, name, salary));
            }

            Console.WriteLine("Enter the employee id that will have salary increase : ");
            int idEmployee = int.Parse(Console.ReadLine());
            Employees emp = list.Find(x => x.Id == idEmployee);

            if (emp != null)
            {
                Console.WriteLine("Enter the percentage");
                double percentage = double.Parse(Console.ReadLine());
                emp.increaseSalary(percentage);
            }
            else Console.WriteLine("This Id doesn't exist!");

            foreach (Employees obj in list)
            {
                Console.WriteLine($"{obj.Id}, {obj.Name}, {obj.Salary}");
            }

        }
    }

}