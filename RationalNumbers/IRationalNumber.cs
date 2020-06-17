using System;
namespace RationalNumbers
{
    public interface IRationalNumber
    {
        /// <summary>
        /// Adds given rational number.
        /// </summary>
        /// <param name="number">Addend - rational number</param>
        /// <returns>Sum - new rational number</returns>
        IRationalNumber Add(IRationalNumber number);

        /// <summary>
        /// Subtracts the given rational number.
        /// </summary>
        /// <param name="number">Subtrahend - rational number</param>
        /// <returns>Difference - new rational number</returns>
        IRationalNumber Subtract(IRationalNumber number);

        /// <summary>
        /// Multiplies rational number by provided rational number.
        /// </summary>
        /// <param name="number">Multiplier - rational number</param>
        /// <returns>Product - new rational number</returns>
        IRationalNumber Multiply(IRationalNumber number);

        /// <summary>
        /// Divides rational number by provided divisor.
        /// </summary>
        /// <param name="number">Divisor</param>
        /// <returns>Quotient - new rational number</returns>
        IRationalNumber Divide(IRationalNumber number);

        /// <summary>
        /// Get absolute value of rational number.
        /// </summary>
        /// <returns>Absolute value</returns>
        IRationalNumber Abs();

        /// <summary>
        /// Raises rational number to the integer.
        /// </summary>
        /// <param name="power">Exponent - integer</param>
        /// <returns></returns>
        IRationalNumber ExpRational(int power);

        /// <summary>
        /// Reduces rational number to the lowest terms.
        /// </summary>
        /// <returns>New rational number with reduced numerator and denominator.</returns>
        IRationalNumber Reduce();

        /// <summary>
        /// Raises rational number to real number.
        /// </summary>
        /// <param name="baseNumber">Exponent - real number</param>
        /// <returns>Real number</returns>
        double ExpToReal(double baseNumber);

        /// <summary>
        /// Raises real number to rational number.
        /// </summary>
        /// <param name="number">Real number to be raised</param>
        /// <returns>Result - Real number</returns>
        double ExpRealToRational(double number);
    }
}
