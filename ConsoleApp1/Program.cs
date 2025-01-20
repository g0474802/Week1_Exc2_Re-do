using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exc1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your first name?");//to get first name
            string firstName = Console.ReadLine()//to get first name
            Console.WriteLine("What is your last name?");//to get last name
            string lastName = Console.ReadLine();//to get last name
            Console.WriteLine("What is your age?");//to get age
            string age = Console.ReadLine();//to get age
            Console.WriteLine("What is your favorite color?");//to get colors
            string favColor = Console.ReadLine();//to get colors
            Console.WriteLine("Hello " + firstName + " " + lastName + " you are " + age + " and your favorite color is " + favColor + ".");//final output
        }
    }
}
