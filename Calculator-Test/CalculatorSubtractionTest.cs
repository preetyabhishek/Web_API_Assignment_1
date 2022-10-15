using System;
using Calculator_Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator_Test
{
    [TestClass]
    public class CalculatorSubtractionTest
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
        [DataRow(0, 1, 1)]
        [DataRow(1, 2, 1)]
        [DataRow(1, 3, 2)]
        public void CalculatorCanSubtractTwoPositiveNumbers(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Subtract(left, right));
        }

        [TestMethod]
        [DataRow(0, -1, -1)]
        [DataRow(-1, -2, -1)]
        [DataRow(-1, -3, -2)]
        public void CalculatorCanSubtractTwoNegativeNumbers(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Subtract(left, right));
        }

        [TestMethod]
        [DataRow(-2, -1, 1)]
        [DataRow(-3, -2, 1)]
        [DataRow(-5, -3, 2)]
        public void CalculatorCanSubtractPositiveRightOperandFromNegativeLeftOperand(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Subtract(left, right));
        }

        [TestMethod]
        [DataRow(2, 1, -1)]
        [DataRow(3, 2, -1)]
        [DataRow(5, 3, -2)]
        public void CalculatorCanSubtractNegativeRightOperandFromPositiveLeftOperand(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Subtract(left, right));
        }

        [TestMethod]
        [DataRow(double.MaxValue - 1, double.MaxValue, 1)]
        [DataRow(double.MaxValue - 13, double.MaxValue, 13)]
        [DataRow(double.MinValue - 29, double.MinValue, 29)]
        [DataRow(double.MinValue - 55, double.MinValue, 55)]
        public void CalculatorCanSubtractPositiveRightOperandFromLeftOperandAsMaxOrMinDoubleValue(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Subtract(left, right));
        }

        [TestMethod]
        [DataRow(double.MaxValue - (-1), double.MaxValue, -1)]
        [DataRow(double.MaxValue - (-13), double.MaxValue, -13)]
        [DataRow(double.MaxValue - (-29), double.MaxValue, -29)]
        [DataRow(double.MaxValue - (-55), double.MaxValue, -55)]
        public void CalculatorCanSubtractNegativeRightOperandFromLeftOperandAsMaxOrMinDoubleValue(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Subtract(left, right));
        }

        [TestMethod]
        [DataRow(1 - double.MaxValue, 1, double.MaxValue)]
        [DataRow(29 - double.MaxValue, 29, double.MaxValue)]
        [DataRow(33 - double.MinValue, 33, double.MinValue)]
        [DataRow(55 - double.MinValue, 55, double.MinValue)]
        public void CalculatorCanSubtractRightOperandAsMaxOrMinDoubleValueFromPositiveLeftOperand(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Subtract(left, right));
        }

        [TestMethod]
        [DataRow(-1 - double.MaxValue, -1, double.MaxValue)]
        [DataRow(-29 - double.MaxValue, -29, double.MaxValue)]
        [DataRow(-33 - double.MinValue, -33, double.MinValue)]
        [DataRow(-55 - double.MinValue, -55, double.MinValue)]
        public void CalculatorCanSubtractRightOperandAsMaxOrMinDoubleValueFromNegativeLeftOperand(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Subtract(left, right));
        }

        [TestMethod]
        [DataRow(double.MaxValue - double.MaxValue, double.MaxValue, double.MaxValue)]
        public void CalculatorCanSubtractTwoMaxDoubleValueNumbers(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Subtract(left, right));
        }

        [TestMethod]
        [DataRow(double.MinValue - double.MinValue, double.MinValue, double.MinValue)]
        public void CalculatorCanSubtractTwoMinDoubleValueNumbers(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Subtract(left, right));
        }
    }
}

