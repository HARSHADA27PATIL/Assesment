﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment
{
    internal class AreaOfCircle
    {
 static void Main()
        {
            float area;
            float radius = 4;
            float pi = 3.14f;

            area = pi * radius * radius;
            Console.WriteLine("Area Of Circle is " + area);
        }
    }
}