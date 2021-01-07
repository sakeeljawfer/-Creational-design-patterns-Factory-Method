using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
   public class Divide : ICalculate
    {
        public void Calculate (double a,double b)
        {
            Console.WriteLine("Divide : a/b is : {0}", a / b);
        }
    }
}
