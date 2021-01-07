using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    class Test
    {
        static void Main()
        {
            Console.WriteLine("Enter first Number :");
            string input = Console.ReadLine();
            double num1, num2;

            bool result = Double.TryParse(input, out num1);
            if (!result)
            {
                Console.WriteLine("Please enter  Number : ");
                return;
            }
            Console.WriteLine("Enter second Number :");
            result = Double.TryParse(Console.ReadLine(), out num2);
            if (!result)
            {
                Console.WriteLine("Please enter  Number : ");
                return;
            }
            Console.WriteLine("Enter add,sabtract,divide");
            CalculateFactory factory = new CalculateFactory();
            ICalculate obj = factory.GetCalculation(Console.ReadLine());
            //Divide obj = new Divide();
            obj.Calculate(num1, num2);
            Main();
        }
    }
}
