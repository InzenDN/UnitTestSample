using System;
using System.Collections.Generic;

namespace _70_483_playground.Scenarios
{
    class DjikstrakExpressionCalculator
    {
        static double CalculateExpression(string mathExp)
        {
            Stack<char> operators = new Stack<char>();
            Stack<double> operands = new Stack<double>();

            for(int i = 0; i < mathExp.Length; i++)
            {
                if(mathExp[i] == '(')
                { }
                else if(mathExp[i] == '+')
                { operators.Push(mathExp[i]); }
                else if(mathExp[i] == '-')
                { operators.Push(mathExp[i]); }
                else if(mathExp[i] == '*')
                { operators.Push(mathExp[i]); }
                else if(mathExp[i] == '/')
                { operators.Push(mathExp[i]); }
                else if(mathExp[i] == ')')
                {
                    char op = operators.Pop();
                    double operand = operands.Pop();

                    if(op == '+')
                    { operand = operands.Pop() + operand; }
                    else if(op == '-')
                    { operand = operands.Pop() - operand; }
                    else if(op == '*')
                    { operand = operands.Pop() * operand; }
                    else if(op == '/')
                    { operand = operands.Pop() / operand; }
                    operands.Push(operand);
                }
                else if(mathExp[i] != ' ')
                { operands.Push(Double.Parse(mathExp[i].ToString())); }
            }

            return operands.Pop();
        }

        static void Main(string[] args)
        {
            string mathExp = "(1 + ((2 + 3) * (4 * 5)))";
            if(args.Length > 0)
            {
                mathExp = args[0];
            }

            if(mathExp != "")
                Console.WriteLine(CalculateExpression(mathExp));
            else
                Console.WriteLine("Input is empty.");

            Console.ReadKey();
        }
    }
}
