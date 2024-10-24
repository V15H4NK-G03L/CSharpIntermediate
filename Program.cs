using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate
{
    public class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Hello Circle!");
            //base.Draw();
        }
    }
    public class Car : Vehicle
    {
        public Car(string registrationNumber)
            : base(registrationNumber)
        {
            Console.WriteLine("Car is being initialized. {0}", registrationNumber);
        }
    }
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
            Console.WriteLine("Press any key to end this logger!");
            Console.ReadKey();

            var person = new Person();
            person.Name = "Jack";
            person.Introduce("John");

            var customer = new Customer(1,"Jack");
            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);

            var accessModifiers = new AccessModifiers(new DateTime(1900,1,1));
            Console.WriteLine("The Age of the Person is : " + accessModifiers.Age);

            var car = new Car("ABCD1234");

            var oval = new Circle();
            oval.Draw();

            Console.ReadKey();
        }
    }
}
