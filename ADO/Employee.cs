using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO
{
    internal class Employee
    {
        public void CreateDatabase()
        {
            try
            {
                SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-111GVTE;Initial Catalog=master;Integrated Security=true");
                connection.Open();
                SqlCommand cmd = new SqlCommand("Create Database Employee", connection);
                cmd.ExecuteNonQuery();
                Console.WriteLine("Employee Database Created Successfully");
                connection.Close();
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
        }

        public SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-111GVTE;Initial Catalog=Employee;Integrated Security=true");
        public void CreateTable()
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("Create Table EmpData(Empid int identity(1,1) primary key, Empname varchar(200), Salary varchar(200), Age int)", connection);
                cmd.ExecuteNonQuery();
                Console.WriteLine("Table Created Successfully");
                connection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }


        public void InsertRecord(string name, string salary, int age)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("Insert into EmpData values('" + name + "','" + salary + "'," + age + ")", connection);
                cmd.ExecuteNonQuery();
                Console.WriteLine("Employee Database Created Successfully");
                connection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void Delete(string name)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("Delete from EmpData where Empname= ( '" + name + "' ) ", connection);
                cmd.ExecuteNonQuery();
                Console.WriteLine("Employee Delete Successfully");
                connection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void RetriveData()
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("Select * from EmpData", connection);
                SqlDataReader sdr = cmd.ExecuteReader();
                while (sdr.Read())
                {
                    var id = Convert.ToInt64(sdr["Empid"]);
                    string name = (string)sdr["Empname"];
                    string salary = (string)sdr["Salary"];
                    var age = Convert.ToInt64(sdr["Age"]);
                    Console.WriteLine("Empid=" + id+ "|"+" Empname="+name+ "|"+" Salary="+salary+ "|"+" Age="+age);

                }
                connection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void UpdateSalary(string name, string salary)
        {
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("Update EmpData set Salary= ( '" + salary + "' ) where Empname=('"+name+"')", connection);
                cmd.ExecuteNonQuery();
                Console.WriteLine("Update Successful");
                connection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

