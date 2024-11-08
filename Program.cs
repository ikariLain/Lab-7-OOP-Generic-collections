using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab_7___OOP_Generic_collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee ANNA = new Employee ("F99","Anna","Female",3000);

            Employee HÅKAN = new Employee("M75", "Håkan", "Male",2500);

            Employee ANDERS = new Employee("M99", "Ander", "Male", 4000);

            Employee THOMAS = new Employee("M44", "Thoms", "Male", 3400);

            Employee MARIAN = new Employee("F77", "Marian", "Female", 5000); 

            Stack<Employee> stack = new Stack<Employee>();

            //Pushad alla objects i stacken
            stack.Push(ANNA); 
            stack.Push(ANDERS); 
            stack.Push(ANDERS); 
            stack.Push(THOMAS); 
            stack.Push(MARIAN);

            //Temporär lista
            List<Employee> poppedEmployeesList = new List<Employee>();

            //Skriver ut alla objekt med hjälp med metoden PrintValues
            foreach (var item in stack)
            {
                item.PrintValues();
                Console.WriteLine($"Item left in the stack: {stack.Count} ");
            }

            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - -");

            Console.WriteLine("Retrive Using POP Method");

            while (stack.Count > 0)
            {
      
                Employee poppedEmployee = stack.Pop();
                poppedEmployee.PrintValues();

                Console.WriteLine($"Antalet objekts: {stack.Count} ");



                poppedEmployeesList.Add(poppedEmployee);
            }

            Console.WriteLine("\nLägger till alla objekt igen i stacken med Push:");
            foreach (Employee employee in poppedEmployeesList)
            {
                stack.Push(employee);
            }

            Console.WriteLine("\nskriver ut objekten");
            foreach (var item in stack)
            {
                item.PrintValues();
                Console.WriteLine($"Antalet objekts: {stack.Count} ");
            }

            Console.WriteLine("Retrive ussing Peek");

            Employee firstPeeked = stack.Peek();
            firstPeeked.PrintValues();
            Console.WriteLine($"Items left in stack = {stack.Count}");

            firstPeeked =stack.Pop();

            Employee secoundPeeked = stack.Peek();

            secoundPeeked.PrintValues();
            Console.WriteLine($"Items left in stack = {stack.Count}");




        }


    }
}
