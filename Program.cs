using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate
{
    public class Person
    {
        public string Name;

        public void Introduce(string to)
        {
            Console.WriteLine("Hi {0}, I am {1}",Name,to);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your custom Error Message :");
            string errorMessage = Console.ReadLine();
            Logger.WriteLog(errorMessage);
            Console.WriteLine($"The Error Message : \"{errorMessage}\" was successfully written to the log file.");
            Console.WriteLine("Press any key to end the program!");
            Console.ReadKey();

            var person = new Person();
            person.Name = "Jack";
            person.Introduce("John");

            var customer = new Customer(1,"Jack");
            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);


            Console.ReadKey();

        }
    }
}
