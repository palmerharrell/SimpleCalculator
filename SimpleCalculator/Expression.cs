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

    // get and store operands & operator
    public bool ParseStr(string userInput)
    {

      return false;
    }


  } // Expression Class
} // namespace
