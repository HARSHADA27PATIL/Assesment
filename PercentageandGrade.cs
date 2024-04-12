using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    internal class PercentageandGrade
    {
      static void Main(string[]args)
        {
            Console.WriteLine("Enter marks for 5 subjects");
            int[] marks = new int[5];
            for(int i=0;i<marks.Length;i++)
            {
                Console.WriteLine("Subject");
                marks[i] = Convert.ToInt32(Console.ReadLine());
            }
            int totalMarks = 0;
            foreach(int mark in marks)
            {
                totalMarks += marks;
            }
            double percentage = (double)totalMarks / totalMarks;
        }
    }
}
