using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7___OOP_Generic_collections
{
    public class Employee
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Salary { get; set; }


        public Employee(string ID, string Name, string Gender, int Salary)
        {
            this.ID = ID;
            this.Name = Name;
            this.Gender = Gender;
            this.Salary = Salary;
        }

        public void PrintValues()
        {
            Console.WriteLine($"ID: {ID}, Name: {Name}, Gender: {Gender}, Salary: {Salary}");
        }


    }
}
