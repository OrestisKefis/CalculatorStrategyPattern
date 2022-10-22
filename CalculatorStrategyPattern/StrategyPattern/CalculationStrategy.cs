using CalculatorStrategyPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorStrategyPattern.StrategyPattern
{
    public class CalculationStrategy
    {
        private ICalculationStrategy _strategy;

        public CalculationStrategy(ICalculationStrategy strategy)
        {
            _strategy = strategy;
        }

        public decimal Calculate(Calculator calculator)
        {
            return _strategy.Calclulate(calculator);
        }
    }
}
