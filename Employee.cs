using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab_7___OOP_Generic_collections
{
    // Defines the Employee class, representing an employee with specific attributes.
    public class Employee
    {
        // Properties to store the employee's unique ID, name, gender, and salary.
        public string ID { get; set; }      // Employee's ID.
        public string Name { get; set; }    // Employee's Name.
        public string Gender { get; set; }  // Employee's Gender.
        public int Salary { get; set; }     // Employee's Salary.

        // Constructor to initialize a new Employee object with specified values for each property.
        public Employee(string ID, string Name, string Gender, int Salary)
        {
            this.ID = ID;          // Assigns the parameter ID to the property ID.
            this.Name = Name;      // Assigns the parameter Name to the property Name.
            this.Gender = Gender;  // Assigns the parameter Gender to the property Gender.
            this.Salary = Salary;  // Assigns the parameter Salary to the property Salary.
        }

        // Method to display the values of an Employee's properties in the console.
        public void PrintValues()
        {
            // Writes the employee's details (ID, Name, Gender, Salary) to the console in a formatted string.
            Console.WriteLine($"ID: {ID}, Name: {Name}, Gender: {Gender}, Salary: {Salary}");
        }
    }
}
