using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
  public class Expression
  {
    private int? _operand1 = null;
    private int? _operand2 = null;
    private char? _operator = null;
    private Array _operands = new int?[] { null, null };
    Dictionary<string, int> constants = new Dictionary<string, int>();

    public char? Operator
    {
      get
      {
        return _operator;
      }
    }

    public Array Operands
    {
      get
      {
        return _operands;
      }
    }

    // IN PROGRESS (Probably should start over. Look at whiteboard.)
    public bool ParseStr(string userInput)
    {
      int opIndex;
      string substring1 = "";
      string substring2 = "";
      if (userInput.IndexOf("=") != -1) // Check for Constant declaration
      {
        Console.WriteLine("Equals symbol found");
      }
      else // Store operator and strings before and after it
      {
        if (userInput.IndexOf("+") != -1)
        {
          _operator = '+';
          opIndex = userInput.IndexOf("+");
        }
        else if (userInput.IndexOf("-") != -1)
        {
          _operator = '-';
          opIndex = userInput.IndexOf("-");
        }
        else if (userInput.IndexOf("*") != -1)
        {
          _operator = '*';
          opIndex = userInput.IndexOf("*");
        }
        else if (userInput.IndexOf("/") != -1)
        {
          _operator = '/';
          opIndex = userInput.IndexOf("/");
        }
        else
        {
          return false; // No suitable operator found
        }

        substring1 = userInput.Substring(0, opIndex).Trim();
        substring2 = userInput.Substring(opIndex + 1).Trim();
        Console.WriteLine("substring1: {0}", substring1);
        Console.WriteLine("substring2: {0}", substring2);
      }
      return true; //TEMPORARY
    } // ParseStr method


  } // Expression class
} // namespace
