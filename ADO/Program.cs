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
            EmployeModel model = new EmployeModel();
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
                        Console.WriteLine("Name: ");
                        model.EmpName=Console.ReadLine();
                        Console.WriteLine("Salary: "); 
                        model.Salary = Console.ReadLine();
                        Console.WriteLine("Age: ");
                        model.Age = Convert.ToInt32(Console.ReadLine());
                        employee.InsertRecord(model);   
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
                        model.EmpName = Console.ReadLine();
                        Console.WriteLine("Salary: ");
                        model.Salary = Console.ReadLine();
                        employee.UpdateRecord(model);
                        break;

                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }
            }
        }
    }
}
