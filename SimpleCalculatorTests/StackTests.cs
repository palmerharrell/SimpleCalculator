using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleCalculator;

namespace SimpleCalculatorTests
{
  [TestClass]
  public class StackTests
  {
    [TestMethod]
    public void lastQtestPass()
    {
      Stack testStack = new Stack();
      testStack.lastQ = "3+2";
      Assert.AreEqual("3+2", testStack.lastQ);
    }

    [TestMethod]
    public void lastQtestFail()
    {
      Stack testStack = new Stack();
      testStack.lastQ = "3+2";
      Assert.AreNotEqual("2+3", testStack.lastQ);
    }

    [TestMethod]
    public void lastAtestPass()
    {
      Stack testStack = new Stack();
      testStack.lastA = 32;
      Assert.AreEqual(32, testStack.lastA);
    }

    [TestMethod]
    public void lastAtestFail()
    {
      Stack testStack = new Stack();
      testStack.lastA = 32;
      Assert.AreNotEqual(33, testStack.lastA);
    }

  }
}
