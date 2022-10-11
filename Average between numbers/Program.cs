using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Average_between_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Average";
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();

            Console.BackgroundColor = ConsoleColor.Black;

            int num1;
            int num2;
            int num3;

            Console.Write(userName + " Input a number!");
            num1 = Convert.ToInt16(Console.ReadLine());

            Console.Write(userName + " Input a second number!");
            num2 = Convert.ToInt16(Console.ReadLine());

            Console.Write(userName + " Input a third number");
            num3 = Convert.ToInt16(Console.ReadLine());

            Console.BackgroundColor = ConsoleColor.Red;

            int result = (num1 + num2 + num3) / 3;
            Console.WriteLine("The result is " + result);

            Console.ReadKey();


            Console.ReadLine();
        }
    }
}
