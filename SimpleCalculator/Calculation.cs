using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
  public class Calculation
  {
    public int calcCounter { get; set; }

    public int Add(int num1, int num2)
    {
      calcCounter++;
      return num1 + num2;
    }

    public int Subtract(int num1, int num2)
    {
      calcCounter++;
      return num1 - num2;
    }

    public int Multiply(int num1, int num2)
    {
      calcCounter++;
      return num1 * num2;
    }

    public int Divide(int num1, int num2)
    {
      calcCounter++;
      return num1 / num2;
    }
  }
}
