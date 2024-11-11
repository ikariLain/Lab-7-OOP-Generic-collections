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
        // Main method, the entry point of the application.
        static void Main(string[] args)
        {
            // Creating instances of the Employee class with ID, Name, Gender, and Salary.
            Employee ANNA = new Employee("F99", "Anna", "Female", 3000);
            Employee HÅKAN = new Employee("M75", "Håkan", "Male", 2500);
            Employee ANDERS = new Employee("M99", "Anders", "Male", 4000);
            Employee THOMAS = new Employee("M44", "Thomas", "Male", 3400);
            Employee MARIAN = new Employee("F77", "Marian", "Female", 5000);

            // Initializing a stack to store Employee objects.
            Stack<Employee> stack = new Stack<Employee>();

            // Adding (pushing) each Employee object onto the stack.
            stack.Push(ANNA); 
            stack.Push(ANDERS); 
            stack.Push(ANDERS); 
            stack.Push(THOMAS); 
            stack.Push(MARIAN);

            // Temporary list to store employees that are removed from the stack.
            List<Employee> poppedEmployeesList = new List<Employee>();

            // Displaying each employee in the stack using the PrintValues method.
            foreach (var item in stack)
            {
                item.PrintValues();
                Console.WriteLine($"Items left in the stack: {stack.Count}");
            }

            // Separator for readability.
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - - - - - - - -");

            // Informing the user about using the Pop method to retrieve items.
            Console.WriteLine("Retrieving Using POP Method");

            // Pop each employee from the stack until it is empty, printing each as it’s removed.
            while (stack.Count > 0)
            {
                Employee poppedEmployee = stack.Pop();
                poppedEmployee.PrintValues();

                Console.WriteLine($"Number of items left: {stack.Count}");

                // Adding the popped employee to a list for future use.
                poppedEmployeesList.Add(poppedEmployee);
            }

            // Adding all employees back onto the stack using Push.
            Console.WriteLine("\nAdding all items back to the stack with Push:");
            foreach (Employee employee in poppedEmployeesList)
            {
                stack.Push(employee);
            }

            // Displaying each employee in the stack again.
            Console.WriteLine("\nDisplaying items in the stack:");
            foreach (var item in stack)
            {
                item.PrintValues();
                Console.WriteLine($"Number of items left: {stack.Count}");
            }

            // Using the Peek method to view the top item without removing it.
            Console.WriteLine("Retrieve using Peek");

            Employee firstPeeked = stack.Peek();
            firstPeeked.PrintValues();
            Console.WriteLine($"Items left in stack = {stack.Count}");

            // Removing the top item using Pop.
            firstPeeked = stack.Pop();

            // Peeking at the next item on the stack.
            Employee secondPeeked = stack.Peek();
            secondPeeked.PrintValues();
            Console.WriteLine($"Items left in stack = {stack.Count}");
        }
    }
}
