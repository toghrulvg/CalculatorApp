using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public interface ICalculation
    {
        void Calculation(int number1, int number2, string operation);
    }
}