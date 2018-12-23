using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            #region ENTER A NAME

            string firstname = "John";
            string lastname = "Doe";
            Console.WriteLine("Name : " + firstname + " " + lastname);
            Console.WriteLine("Please enter a new firstname");
            firstname = Console.ReadLine();

            Console.WriteLine("New name : " + firstname + " " + lastname);
            //Console.ReadLine();
            #endregion

            #region SUM NUMBERS
            int number1, number2;

            Console.WriteLine("Please enter a number :");
            number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("One more number :");
            number2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Sum of the numbers : " + (number1 + number2));
            //Console.ReadLine();
            #endregion

            #region IF ELSE

            int number3;

            Console.WriteLine("Please enter a number between 0 and 10");
            number3 = int.Parse(Console.ReadLine());

            if (number3 > 10)
                Console.WriteLine("Number must be less than 10!");
            else
                if (number3 < 0)
                    Console.WriteLine("Number must be larger than 0!");
                else
                    Console.WriteLine("Aferim len!");

            Console.ReadLine();

            #endregion
        }
    }
}
