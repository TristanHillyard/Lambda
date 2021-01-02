using System;
using System.Collections.Generic;
using System.Linq;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Emp> employees = new List<Emp>();
            List<string> firstnames = new List<string>()
            {
                "Joe", "Tim", "Lin", "Hon", "Joe", "Tristan", "Tayd", "Cole", "Kip", "Lebron", "Luka"
            };
            List<string> lastnames = new List<string>()
            {
                "Smo", "Tat", "Lan", "Solo", "Mo", "Hill", "Tot", "Smith", "More", "James", "Doncic"
            };
            List<int> IDs = new List<int>()
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10
            };
            int i = 0;
            foreach(var firstName in firstnames)
            {
                employees.Add(new Emp(firstName, lastnames[i], IDs[i]));
            }
            foreach(Emp employee in employees)
            {
                if(employee.firstname == employee.firstname)
            }

        }
    }
}
