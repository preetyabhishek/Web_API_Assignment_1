using System;

namespace Calculator_Logic
{
    public class Calculator
    {
        // Operation "Add" by adding left and right operands together
        public double Add(double left, double right)
        {
            return left + right;
        }

        // Operation "Subtract" by subtracting right operand from left operand
        public double Subtract(double left, double right)
        {
            return left - right;
        }

        // Operation "Multiply" by multiplying left operand by right operand
        public double Multiply(double left, double right)
        {
            return left * right;
        }

        // Operation "Divide" by dividing left operand by right operand
        // This will throw an exception when a division by zero occurs
        public double Divide(double left, double right)
        {
            if (right == 0)
            {
                throw new DivideByZeroException();
            }
            return left / right;
        }
    }
}

