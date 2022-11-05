using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            while (true)
            {
                Console.WriteLine("1.Ceate Database\n2.Create Table\n3.Insert Record\n4.Delete\n5.Retrive");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        employee.CreateDatabase();
                        break;

                    case 2:
                        employee.CreateTable();
                        break;

                    case 3:
                        Console.WriteLine("First Name: ");
                        string name=Console.ReadLine();
                        Console.WriteLine("Salary: ");
                        string salary = Console.ReadLine();
                        Console.WriteLine("Age: ");
                        int age = Convert.ToInt32(Console.ReadLine());
                        employee.InsertRecord(name, salary, age);   
                        break;
                    case 4:
                        Console.WriteLine("First Name: ");
                        string name1 = Console.ReadLine();
                        employee.Delete(name1);
                        break;
                    case 5:
                        employee.RetriveData();
                        break;
                    case 6:
                        Console.WriteLine("Name: ");
                        string name2 = Console.ReadLine();
                        Console.WriteLine("Salary: ");
                        string salary1 = Console.ReadLine();
                        employee.UpdateSalary(name2,salary1);
                        break;

                    default:
                        Console.WriteLine("Error");
                        break;
                }
            }
        }
    }
}