using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorStrategyPattern.Models
{
    public class Calculator
    {
        public decimal FirstNumber { get; set; }
        public decimal SecondNumber { get; set; }

        public Calculator() { }
        public Calculator(decimal firstNum, decimal secondNum)
        {
            FirstNumber = firstNum;
            SecondNumber = secondNum;
        }
    }
}
