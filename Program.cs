using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate
{
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
        }
    }
}
