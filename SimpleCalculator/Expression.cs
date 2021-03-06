﻿using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
  public class Expression
  {
    private int _operand1;
    private int _operand2;
    private char? _operator = null;
    private int?[] _operands = new int?[] { null, null };
    private ConcurrentDictionary<char, int> _constants = new ConcurrentDictionary<char, int>();
    private bool _constAdded = false;
    // private bool _constAlreadyExists = false;
    private bool _constLookup = false;
    private bool _constFound = false;
    private int _constValue;

    public char? Operator
    {
      get
      {
        return _operator;
      }
    }

    public int?[] Operands
    {
      get
      {
        return _operands;
      }
    }

    public ConcurrentDictionary<char, int> Constants
    {
      get
      {
        return _constants;
      }
    }

    public bool constAdded
    {
      get
      {
        return _constAdded;
      }
    }

    // public bool constAlreadyExists
    // {
    //   get
    //   {
    //     return _constAlreadyExists;
    //   }
    // }

    public bool constLookup
    {
      get
      {
        return _constLookup;
      }
    }

    public bool constFound
    {
      get
      {
        return _constFound;
      }
    }

    public int constLookupValue
    {
      get
      {
        return _constValue;
      }
    }


    public bool ParseStr(string userInput)
    {
      int opIndex;
      string substring1 = "";
      string substring2 = "";
      char constChar; // used for both getting and setting constants
      int constValue;

      // Reset vars first
      _operands.SetValue(null, 0);
      _operands.SetValue(null, 1);
      _operator = null;
      _constAdded = false;
      // _constAlreadyExists = false;
      _constLookup = false;
      _constFound = false;

      // ~~ TO DO ~~
      // CHECK FOR CONSTANT LOOKUP FIRST (_constLookup & constLookup vars created)
      // check for single char and that it exists in dictionary, return true
      if (userInput.Trim().Count() == 1 && Char.IsLetter(userInput.Trim()[0]))
      {
        _constLookup = true;
        if (_constants.TryGetValue(Char.ToUpper(userInput[0]), out _constValue))
        {
          _constFound = true;
        }
        return true;
      }


      if (userInput.IndexOf("=") != -1) // Check for Constant declaration
      {
        // Try to convert string before equals to single char
        if (Char.TryParse(userInput.Substring(0, userInput.IndexOf("=")), out constChar))
        {
          // Check that single char is a letter
          if (!Char.IsLetter(constChar)) return false;
        }
        else
        {
          return false; // No suitable char found in constant declaration
        }

        // Try to convert string after equals to int
        if (!int.TryParse(userInput.Substring(userInput.IndexOf("=") + 1), out constValue))
        {
          return false; // No suitable value found in constant declaration
        }
        
        // If both work: try to save as constant in dictionary
        if(!_constants.TryAdd(Char.ToUpper(constChar), constValue))
        {
          // _constAlreadyExists = true;
          return true;
        }
        _constAdded = true;
        return true; // Constant successfully saved
      }

      else // Check for operator, operands, constants
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

        // check if substrings are ints, if not, check if they are constants, if not, return false
        if (!int.TryParse(substring1.Trim(), out _operand1))
        {
          if (Char.TryParse(substring1.Trim(), out constChar))
          {
            if(!_constants.TryGetValue(Char.ToUpper(constChar), out _operand1))
            {
              _operator = null; // to make unit test happy
              return false; // Not in constants dictionary
            }
          }
          else
          {
            _operator = null; // to make unit test happy
            return false; // Not a char
          }
        }

        if (!int.TryParse(substring2.Trim(), out _operand2))
        {
          if (Char.TryParse(substring2.Trim(), out constChar))
          {
            if (!_constants.TryGetValue(Char.ToUpper(constChar), out _operand2))
            {
              _operator = null; // to make unit test happy
              return false; // Not in constants dictionary
            }
          }
          else
          {
            _operator = null; // to make unit test happy
            return false; // Not a char
          }
        }

        // Store operands in operands array
        _operands.SetValue(_operand1, 0);
        _operands.SetValue(_operand2, 1);

        return true; // All good, ready for calculation
      }
      
    } // ParseStr method


  } // Expression class
} // namespace
