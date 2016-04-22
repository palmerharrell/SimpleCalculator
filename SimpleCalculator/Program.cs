using System;
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
      Calculation calc = new Calculation();
      Stack history = new Stack();
      bool endProgram = false;

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
            // PARSE INPUT STRING HERE
            break;
        }
      }
      
    } // Main
  } // Program
} // Namespace
