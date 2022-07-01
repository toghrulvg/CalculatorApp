using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Calculating : ICalculation
    {
        public void Calculation(int number1, int number2, string operation)
        {
            int add = number1 + number2;
            int div = number1 / number2;
            int multip= number1 * number2;
            int substract = number1 - number2;
            
            

            {
                if (operation == "+")
                {
                    Console.WriteLine(add);
                }
                else if (operation == "-")
                {
                    Console.WriteLine(substract);
                }
                else if (operation == "*")
                {
                    Console.WriteLine(multip);
                }
                else if (operation == "/")
                {
                    Console.WriteLine(div);
                }
            }
        }
    }
}