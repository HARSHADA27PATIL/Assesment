using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    internal class GreatestNumber
    {
     static void Main(string[]args)
        {

            Console.WriteLine("Enter a number1:");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number2:");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number3:");
            int number3 = Convert.ToInt32(Console.ReadLine());

            int greatest = number1;
            if(number2>greatest)
            {
                greatest = number2;
            }
            if (number3 > greatest)
            {
                greatest = number3;
            }
            Console.WriteLine("The greatest number is:+greatest");
        }
    }
}
