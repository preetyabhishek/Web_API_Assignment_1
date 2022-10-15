using System;
using Calculator_Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator_Test
{
    [TestClass]
    public class CalculatorMultiplicationTest
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
        [DataRow(6, 3, 2)]
        public void CalculatorCanMultiplyTwoPositiveNumbers(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Multiply(left, right));
        }

        [TestMethod]
        [DataRow(1, -1, -1)]
        [DataRow(2, -2, -1)]
        [DataRow(6, -3, -2)]
        public void CalculatorCanMultiplyTwoNegativeNumbers(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Multiply(left, right));
        }

        [TestMethod]
        [DataRow(-1, 1, -1)]
        [DataRow(-2, 2, -1)]
        [DataRow(-6, 3, -2)]
        public void CalculatorCanMultiplyPositiveLeftOperandByNegativeRightOperand(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Multiply(left, right));
        }

        [TestMethod]
        [DataRow(-1, -1, 1)]
        [DataRow(-2, -2, 1)]
        [DataRow(-6, -3, 2)]
        public void CalculatorCanMultiplyNegativeLeftOperandByPositiveRightOperand(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Multiply(left, right));
        }

        [TestMethod]
        [DataRow(double.MaxValue * 1, double.MaxValue, 1)]
        [DataRow(double.MaxValue * 13, double.MaxValue, 13)]
        [DataRow(double.MinValue * 29, double.MinValue, 29)]
        [DataRow(double.MinValue * 55, double.MinValue, 55)]
        public void CalculatorCanMultiplyLeftOperandAsMaxOrMinDoubleValueByPositiveRightOperand(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Multiply(left, right));
        }

        [TestMethod]
        [DataRow(1 * double.MaxValue, 1, double.MaxValue)]
        [DataRow(29 * double.MaxValue, 29, double.MaxValue)]
        [DataRow(33 * double.MinValue, 33, double.MinValue)]
        [DataRow(55 * double.MinValue, 55, double.MinValue)]
        public void CalculatorCanMultiplyPositiveLeftOperandByRightOperandAsMaxOrMinDoubleValue(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Multiply(left, right));
        }

        [TestMethod]
        [DataRow(double.MaxValue * (-1), double.MaxValue, -1)]
        [DataRow(double.MaxValue * (-13), double.MaxValue, -13)]
        [DataRow(double.MinValue * (-29), double.MinValue, -29)]
        [DataRow(double.MinValue * (-55), double.MinValue, -55)]
        public void CalculatorCanMultiplyLeftOperandAsMaxOrMinDoubleValueByNegativeRightOperand(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Multiply(left, right));
        }

        [TestMethod]
        [DataRow(-1 * double.MaxValue, -1, double.MaxValue)]
        [DataRow(-29 * double.MaxValue, -29, double.MaxValue)]
        [DataRow(-33 * double.MinValue, -33, double.MinValue)]
        [DataRow(-55 * double.MinValue, -55, double.MinValue)]
        public void CalculatorCanMultiplyNegativeLeftOperandByRightOperandAsMaxOrMinDoubleValue(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Multiply(left, right));
        }

        [TestMethod]
        [DataRow(double.MaxValue * double.MaxValue, double.MaxValue, double.MaxValue)]
        public void CalculatorCanMultiplyTwoMaxDoubleValueNumbers(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Multiply(left, right));
        }

        [TestMethod]
        [DataRow(double.MinValue * double.MinValue, double.MinValue, double.MinValue)]
        public void CalculatorCanMultiplyTwoMinDoubleValueNumbers(double expected, double left, double right)
        {
            Assert.AreEqual(expected, calc.Multiply(left, right));
        }
    }
}

