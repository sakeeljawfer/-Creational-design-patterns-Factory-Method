﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
   public class Add : ICalculate
    {
        public void Calculate(double a, double b)
        {
            Console.WriteLine("Add : a+b is {0} ", a + b);
        }
    }
}
