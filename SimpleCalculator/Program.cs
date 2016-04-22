﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
  class Program
  {
    static void Main(string[] args)
    {
      Expression expr = new Expression();
      Calculation calc = new Calculation();
      Stack history = new Stack();
      bool endProgram = false;
      char? operation;
      int?[] operands;
      int result;

      calc.calcCounter = 0;
      history.lastQ = null;
      history.lastA = null;

      while (!endProgram)
      {
        Console.Write("\n[{0}]> ", calc.calcCounter);
        string userInput = Console.ReadLine();

        switch (userInput.ToUpper())
        {
          case "QUIT":
            endProgram = true;
            Console.WriteLine("\nGoodbye\n");
            break;
          case "EXIT":
            endProgram = true;
            Console.WriteLine("\nGoodbye\n");
            break;
          case "LAST":
            Console.WriteLine(history.lastA);
            break;
          case "LASTQ":
            Console.WriteLine(history.lastQ);
            break;
          default:
            if(expr.ParseStr(userInput))
            {
              // Check constAdded flag 
              //   skip calculation if declaring a constant
              if (expr.constAdded)
              {
                Console.WriteLine("Constant saved for future use.");
                break; // Skip calculation
              }
              else if (expr.constAlreadyExists)
              {
                Console.WriteLine("Constant already has a value.");
                break; // Skip calculation
              }
              else
              {
                operation = expr.Operator;
                operands = expr.Operands;

                switch (operation)
                {
                  case '+':
                    result = calc.Add((int)operands[0], (int)operands[1]);
                    Console.WriteLine("     = {0}", result);
                    break;
                  case '-':
                    result = calc.Subtract((int)operands[0], (int)operands[1]);
                    Console.WriteLine("     = {0}", result);
                    break;
                  case '*':
                    result = calc.Multiply((int)operands[0], (int)operands[1]);
                    Console.WriteLine("     = {0}", result);
                    break;
                  case '/':
                    result = calc.Divide((int)operands[0], (int)operands[1]);
                    Console.WriteLine("     = {0}", result);
                    break;
                  default:
                    Console.WriteLine("THIS SHOULDN'T HAPPEN");
                    break;
                }
              }
            }
            else // userInput invalid
            {
              Console.WriteLine("Invalid expression. Please try again.");
            }
            break;
        }
      }
      
    } // Main
  } // Program
} // Namespace
