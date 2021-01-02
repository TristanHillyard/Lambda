using System;
using System.Collections.Generic;
using System.Linq;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Employee> employees = new List<Employee>();
            Employee employee1 = new Employee();
            employee1.firstname = "Joe";
            employee1.lastname = "Smo";
            employee1.ID = 1;
            employees.Add(employee1);

            Employee employee2 = new Employee();
            employee2.firstname = "Tim";
            employee2.lastname = "Tat";
            employee2.ID = 2;
            employees.Add(employee2);

            Employee employee3 = new Employee();
            employee3.firstname ="Lin";
            employee3.lastname = "Lan";
            employee3.ID = 3;
            employees.Add(employee3);

            Employee employee4 = new Employee();
            employee4.firstname = "Hon";
            employee4.lastname = "Solo";
            employee4.ID = 4;
            employees.Add(employee4);

            Employee employee5 = new Employee();
            employee5.firstname = "Joe";
            employee5.lastname = "Mo";
            employee5.ID = 5;
            employees.Add(employee5);

            Employee employee6 = new Employee();
            employee6.firstname = "Tristan";
            employee6.lastname = "Hill";
            employee6.ID = 6;
            employees.Add(employee6);

            Employee employee7 = new Employee();
            employee7.firstname = "Tayd";
            employee7.lastname = "Tot";
            employee7.ID = 7;
            employees.Add(employee7);

            Employee employee8 = new Employee();
            employee8.firstname = "Cole";
            employee8.lastname = "Smith";
            employee8.ID = 8;
            employees.Add(employee8);

            Employee employee9 = new Employee();
            employee9.firstname = "Kip";
            employee9.lastname = "More";
            employee9.ID = 9;
            employees.Add(employee9);

            Employee employee10 = new Employee();
            employee10.firstname = "Lebron";
            employee10.lastname = "James";
            employee10.ID = 10;
            employees.Add(employee10);

            foreach(Employee employee in employees)
            {
                if(employee.firstname == "Joe")
                {
                    List<Employee> newemployees = new List<Employee>();
                    Console.WriteLine(newemployees);
                }
            }
            List<Employee> joeEmployees = joeEmployees.Where(x => x > 5).ToList();
            List<Employee> employID = employID.Where(ID > 5).ToList();
        }
    }
}
