using CalculatorStrategyPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorStrategyPattern.StrategyPattern
{
    public class CalculationDivision : ICalculationStrategy
    {
        public decimal Calclulate(Calculator calculator) => calculator.FirstNumber / calculator.SecondNumber;
    }
}
