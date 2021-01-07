using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    public class CalculateFactory
    {
        public ICalculate GetCalculation(string type)
        {
            ICalculate obj = null;

            if(type.ToLower().Equals("add"))
            {
                obj = new Add();
            }
            else if(type.ToLower().Equals("sabtract"))
            {
                obj = new Subtract();
            }
            else if(type.ToLower().Equals("divide"))
            {
                obj = new Divide();
            }
            else  
            {
                Console.WriteLine("we dont do that !");
            }
            return obj;
        }
    }
}
