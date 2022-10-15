using System;
using System.Diagnostics;
using Calculator_Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator_Test
{
    [TestClass]
    public class CalculatorDivisionTest
    {
        Calculator calc;

        [TestInitialize]
        public void Instantiate()
        {
            calc = new Calculator();
        }

        [TestCleanup]
        public void TearDown()
        {
            calc = null;
        }

        [TestMethod]
        public void CalculatorClassIsInstantiable()
        {
            Assert.IsNotNull(calc);
        }

        [TestMethod]
        [DataRow(1, 1, 1)]
        [DataRow(2, 2, 1)]
        [DataRow(1.5, 3, 2)]
        public void CalculatorCanDivideTwoPositiveNumbers(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Divide(left, right));
        }

        [TestMethod]
        [DataRow(1, -1, -1)]
        [DataRow(2, -2, -1)]
        [DataRow(1.5, -3, -2)]
        public void CalculatorCanDivideTwoNegativeNumbers(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Divide(left, right));
        }

        [TestMethod]
        [DataRow(-1, 1, -1)]
        [DataRow(-2, 2, -1)]
        [DataRow(-1.5, 3, -2)]
        public void CalculatorCanDividePositiveLeftOperandByNegativeRightOperand(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Divide(left, right));
        }

        [TestMethod]
        [DataRow(-1, -1, 1)]
        [DataRow(-2, -2, 1)]
        [DataRow(-1.5, -3, 2)]
        public void CalculatorCanDivideNegativeLeftOperandByPositiveRightOperand(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Divide(left, right));
        }

        [TestMethod]
        [DataRow(double.MaxValue, double.MaxValue, 1)]
        [DataRow(double.MaxValue / 13, double.MaxValue, 13)]
        [DataRow(double.MinValue / 29, double.MinValue, 29)]
        [DataRow(double.MinValue / 55, double.MinValue, 55)]
        public void CalculatorCanDivideLeftOperandAsMaxOrMinDoubleValueByPositiveRightOperand(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Divide(left, right));
        }

        [TestMethod]
        [DataRow(1 / double.MaxValue, 1, double.MaxValue)]
        [DataRow(29 / double.MaxValue, 29, double.MaxValue)]
        [DataRow(33 / double.MinValue, 33, double.MinValue)]
        [DataRow(55 / double.MinValue, 55, double.MinValue)]
        public void CalculatorCanDividePositiveLeftOperandByRightOperandAsMaxOrMinDoubleValue(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Divide(left, right));
        }

        [TestMethod]
        [DataRow(double.MaxValue / (-1), double.MaxValue, -1)]
        [DataRow(double.MaxValue / (-13), double.MaxValue, -13)]
        [DataRow(double.MinValue / (-29), double.MinValue, -29)]
        [DataRow(double.MinValue / (-55), double.MinValue, -55)]
        public void CalculatorCanDivideLeftOperandAsMaxOrMinDoubleValueByNegativeRightOperand(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Divide(left, right));
        }

        [TestMethod]
        [DataRow(-1 / double.MaxValue, -1, double.MaxValue)]
        [DataRow(-29 / double.MaxValue, -29, double.MaxValue)]
        [DataRow(-33 / double.MinValue, -33, double.MinValue)]
        [DataRow(-55 / double.MinValue, -55, double.MinValue)]
        public void CalculatorCanDivideNegativeLeftOperandByRightOperandAsMaxOrMinDoubleValue(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Divide(left, right));
        }

        [TestMethod]
        [DataRow(1, double.MaxValue, double.MaxValue)]
        public void CalculatorCanDivideTwoMaxDoubleValueNumbers(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Divide(left, right));
        }

        [TestMethod]
        [DataRow(1, double.MinValue, double.MinValue)]
        public void CalculatorCanDivideTwoMinDoubleValueNumbers(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Divide(left, right));
        }

        [TestMethod]
        [DataRow(1, 0)]
        [DataRow(9, 0)]
        [DataRow(33, 0)]
        public void CalculatorThrowsExceptionWhenDividingByZero(double left, double right)
        {
            Assert.ThrowsException<DivideByZeroException>(() => { calc.Divide(left, right); });
        }
    }
}

