using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleCalculator;

namespace SimpleCalculatorTests
{
  [TestClass]
  public class CalculationTests
  {
    [TestMethod]
    public void AddTestPass()
    {
      Calculation calcTest = new Calculation();
      Assert.AreEqual(3, calcTest.Add(1, 2));
    }

    [TestMethod]
    public void SubtractTestPass()
    {
      Calculation calcTest = new Calculation();
      Assert.AreEqual(-1, calcTest.Subtract(1, 2));
    }

    [TestMethod]
    public void MultiplyTestPass()
    {
      Calculation calcTest = new Calculation();
      Assert.AreEqual(6, calcTest.Multiply(2, 3));
    }

    [TestMethod]
    public void DivideTestPass()
    {
      Calculation calcTest = new Calculation();
      Assert.AreEqual(2, calcTest.Divide(8, 4));
    }
    
  }
}
