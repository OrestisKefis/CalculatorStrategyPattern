using CalculatorStrategyPattern.Models;
using CalculatorStrategyPattern.StrategyPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorStrategyPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator(2, 3);

            Console.WriteLine($"First Number: {calculator.FirstNumber} Second Number: {calculator.SecondNumber}");

            CalculationStrategy strategyAdd = new CalculationStrategy(new CalculationAddition());
            Console.WriteLine($"Addition: {strategyAdd.Calculate(calculator)}");

            CalculationStrategy strategySub = new CalculationStrategy(new CalculationSubtraction());
            Console.WriteLine($"Subtraction: {strategySub.Calculate(calculator)}");

            CalculationStrategy strategyMult = new CalculationStrategy(new CalculationMultiplication());
            Console.WriteLine($"Multiplication: {strategyMult.Calculate(calculator)}");

            CalculationStrategy strategyDiv = new CalculationStrategy(new CalculationDivision());
            Console.WriteLine($"Division: {strategyDiv.Calculate(calculator)}");
        }
    }
}
