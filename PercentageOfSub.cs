using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    internal class PercentageOfSub
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter marks for 5 subjects:");
            Console.Write("Subject 1: ");
            double subject1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Subject 2: ");
            double subject2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Subject 3: ");
            double subject3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Subject 4: ");
            double subject4 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Subject 5: ");
            double subject5 = Convert.ToDouble(Console.ReadLine());

         
            double totalMarks = subject1 + subject2 + subject3 + subject4 + subject5;

            double percentage = (totalMarks / 500) * 100;

          
            Console.WriteLine("\nTotal Marks: " + totalMarks);
            Console.WriteLine("Percentage: " + percentage.ToString("0.00") + "%");
        }
    }
}
