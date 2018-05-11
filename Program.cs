using Antlr4.Runtime;
using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
           AntlrInputStream inputStream = new AntlrInputStream("2 + 2");
           CalculatorLexer calcLexer = new CalculatorLexer(inputStream);
           CommonTokenStream commonTokenStream = new CommonTokenStream(calcLexer);
           CalculatorParser calcParser = new CalculatorParser(commonTokenStream);
           CalculatorParser.EquationContext equationContext = calcParser.equation();
           CalculatorVisitor calcVisitor = new CalculatorVisitor();
           calcVisitor.EnterEquation(equationContext);
           calcVisitor.printResult();
           Console.ReadLine();
        }
    }
}
