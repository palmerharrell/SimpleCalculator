using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleCalculator;

namespace SimpleCalculatorTests
{
  [TestClass]
  public class ExpressionTests
  {
    [TestMethod] // DONE
    public void ParseStrTestPass()
    {
      var testExpression = new Expression();
      Assert.IsTrue(testExpression.ParseStr("1+2"));
    }

    [TestMethod] // DONE
    public void ParseStrTestFail()
    {
      var testExpression = new Expression();
      Assert.IsFalse(testExpression.ParseStr("1+"));
    }

    [TestMethod] // DONE (probably)
    public void getOperandsTestPass()
    {
      // check for Array of Ints matching operands in string
      var testExpression = new Expression();
      testExpression.ParseStr("1+2");
      Assert.AreEqual(1, testExpression.Operands.GetValue(0));
      Assert.AreEqual(2, testExpression.Operands.GetValue(1));
    }

    [TestMethod] // DONE (probably)
    public void getOperandsTestFail()
    {
      // pass bad string and check that operands are null
      var testExpression = new Expression();
      testExpression.ParseStr("1+");
      Assert.IsNull(testExpression.Operands.GetValue(0));
      Assert.IsNull(testExpression.Operands.GetValue(1));
    }

    [TestMethod] // DONE (probably)
    public void getOperatorTestPass()
    {
      // check for Operator char matching opertor in string
      var testExpression = new Expression();
      testExpression.ParseStr("12+22");
      Assert.AreEqual('+', testExpression.Operator);
    }

    [TestMethod] // DONE (probably)
    public void getOperatorTestFail()
    {
      // pass bad string and check that operator is null
      var testExpression = new Expression();
      testExpression.ParseStr("12+");
      Assert.IsNull(testExpression.Operator);
    }
  }
}
