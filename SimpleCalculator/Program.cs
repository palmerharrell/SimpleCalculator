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
      
      bool endProgram = false;
      Calculation calc = new Calculation();
      calc.calcCounter = 0;

      while (!endProgram)
      {
        //Console.Clear();
        Console.Write("\n[{0}]> ", calc.calcCounter);
        string userInput = Console.ReadLine();

        if (userInput.ToUpper() == "QUIT" || userInput.ToUpper() == "EXIT")
        {
          endProgram = true;
          Console.WriteLine("\nGoodbye\n");
        }
        else if (userInput.ToUpper() == "LAST")
        {
          //Console.Clear();
          Console.WriteLine("\nPrint result of last calculation here.\n");
        }
        else if (userInput.ToUpper() == "LASTQ")
        {
          //Console.Clear();
          Console.WriteLine("\nPrint last calculation here.\n");
        }
      }
      

      
    } // Main
  } // Program
} // Namespace
