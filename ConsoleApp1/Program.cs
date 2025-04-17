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
            Console.WriteLine("What is your first name?");//Prompts user to input first name
            string firstName = Console.ReadLine()//Gets first name from user
            Console.WriteLine("What is your last name?");//Prompts user to input last name
            string lastName = Console.ReadLine();//Gets last name from user
            Console.WriteLine("What is your age?");////Prompts user to input age
            string age = Console.ReadLine();//Gets age from user
            Console.WriteLine("What is your favorite color?");//Prompts user to input favorite color
            string favColor = Console.ReadLine();//Gets color from user
            Console.WriteLine("Hello " + firstName + " " + lastName + " you are " + age + " and your favorite color is " + favColor + ".");//final output
        }
    }
}
