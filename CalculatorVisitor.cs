using Antlr4.Runtime.Tree;
using System;
using System.Collections.Generic;

public class CalculatorVisitor : CalculatorBaseListener
{
    List<int> values;
    string op;  

    public override void EnterEquation(CalculatorParser.EquationContext context)
    {
      op = context.OPERATOR().GetText();
      values = new List<int>();
      foreach (ITerminalNode number in context.NUMBERS())
        values.Add(int.Parse(number.GetText()));

    }

    public int PerformOperator(string op)
    {
      switch (op)
      {
        case "+":
          return values[0] + values[1];
        case "-":
          return values[0] - values[1];
        case "*":
         return values[0] * values[1];
        case "/":
          return values[0] / values[1];
      }

      return -1;
    }
    
    public void printResult()
    {
      Console.WriteLine(PerformOperator(op));
    }
}