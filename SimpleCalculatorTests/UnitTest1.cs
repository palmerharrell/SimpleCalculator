using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleCalculator;

namespace SimpleCalculatorTests
{
  [TestClass]
  public class UnitTest1
  {
    [TestMethod]
    public void ParseStrTestPass()
    {
      var testExpression = new Expression();
      Assert.IsTrue(testExpression.ParseStr("1+2"));
    }

    [TestMethod]
    public void ParseStrTestFail()
    {
      var testExpression = new Expression();
      Assert.IsFalse(testExpression.ParseStr("1+"));
    }

    [TestMethod] // check for Array of Ints matching operands in string
    public void getOperandsTestPass()
    {
      var testExpression = new Expression();
      testExpression.ParseStr("1+2");
      Assert.AreEqual(new int[] { 1, 2 }, testExpression.Operands);
    }

    [TestMethod] // pass bad string and check that operands are null
    public void getOperandsTestFail()
    {
      
    }

    [TestMethod] // check for Operator char matching opertor in string
    public void getOperatorTestPass()
    {
      
    }

    [TestMethod] // pass bad string and check that operator is null
    public void getOperatorTestFail()
    {
      
    }
  }
}
