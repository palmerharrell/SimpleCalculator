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
    private Dictionary<char, int> _constants = new Dictionary<char, int>();
    private bool _constAdded = false;

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

    public bool constAdded
    {
      get
      {
        return _constAdded;
      }
    }

    // IN PROGRESS
    public bool ParseStr(string userInput)
    {
      int opIndex;
      string substring1 = "";
      string substring2 = "";
      char constChar;
      int constValue;

      // Reset vars first
      _operand1 = null;
      _operand2 = null;
      _operator = null;
      _constAdded = false;

      if (userInput.IndexOf("=") != -1) // Check for Constant declaration
      {
        // try to convert string before equals to single char
        if (Char.TryParse(userInput.Substring(0, userInput.IndexOf("=")), out constChar))
        {
          // Check that single char is a letter
          if (!Char.IsLetter(constChar)) return false;
        }
        else
        {
          return false; // No suitable char found in constant declaration
        }

        // try to convert string after equals to int
        if (!int.TryParse(userInput.Substring(userInput.IndexOf("=") + 1), out constValue))
        {
          return false; // No suitable value found in constant declaration
        }
        
        // If both work: save as constant in dictionary (NEED TO CHECK IF ALREADY EXISTS!)
        _constants.Add(constChar, constValue);
        Console.WriteLine(_constants[constChar]);
        _constAdded = true; // Set constAdded flag for logic in Main
        return true; // Constant successfully saved
      }

      else // Check for operator
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
        
        substring1 = userInput.Substring(0, userInput.IndexOf((char)_operator));
        substring2 = userInput.Substring(userInput.IndexOf((char)_operator) + 1);
        
      }
      return true; //TEMPORARY
    } // ParseStr method


  } // Expression class
} // namespace
