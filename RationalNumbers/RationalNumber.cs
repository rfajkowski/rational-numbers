using System;

namespace RationalNumbers
{
    public struct RationalNumber : IRationalNumber
    {
        public int Numerator { get; }
        public int Denominator { get; }

        public RationalNumber(int numerator, int denominator)
        {
            if(denominator == 0)
            {
                throw new ArgumentException("The denominator cannot be 0");
            }
            if(denominator < 0)
            {
                this.Numerator = -numerator;
                this.Denominator = Math.Abs(denominator);
            } else
            {
                this.Numerator = numerator;
                this.Denominator = denominator;
            }
        }

        public static IRationalNumber operator +(RationalNumber r1, RationalNumber r2) => r1.Add(r2);

        public static IRationalNumber operator -(RationalNumber r1, RationalNumber r2) => r1.Subtract(r2);

        public static IRationalNumber operator *(RationalNumber r1, RationalNumber r2) => r1.Multiply(r2);

        public static IRationalNumber operator /(RationalNumber r1, RationalNumber r2) => r1.Divide(r2);

        // Gives absolute value of relational numbers
        public IRationalNumber Abs() => new RationalNumber(Math.Abs(Numerator), Math.Abs(Denominator));

        // Reduces numerator and denominator by GCD
        public IRationalNumber Reduce()
        {
            var gcd = this.GetGreatestCommonDivisor();
            return new RationalNumber(Numerator / gcd, Denominator / gcd);
        }

        // Exponents rational number to an integer power
        public IRationalNumber ExpRational(int power)
        {
            int exponent = Math.Abs(power);

            int newNumerator = (int)Math.Pow(Numerator, exponent);
            int newDenominator = (int)Math.Pow(Denominator, exponent);
            //if power is negative, numerator and denominator have to be swapped around in new rational number.
            if (power < 0)
                return new RationalNumber(newDenominator, newNumerator).Reduce();
            return new RationalNumber(newNumerator, newDenominator).Reduce();
        }

        // Exponents rational number to a real (floating-point) power,
        public double ExpToReal(double realNum) => Math.Pow(this.Numerator, realNum) / Math.Pow(this.Denominator, realNum);
        
        // Gets Exponentiation of a real number to rational number.
        public double ExpRealToRational(double number) => Math.Pow(Math.Pow(number, this.Numerator), 1.0 / Denominator);
        public IRationalNumber Add(IRationalNumber number)
        {
            var rationalNumber = (RationalNumber) number;
            var (numerator2, denominator2) = (rationalNumber.Numerator, rationalNumber.Denominator);
            int newNumerator = Numerator * denominator2 + numerator2 * Denominator;
            int newDenominator = Denominator * denominator2;
            if (newNumerator == 0)
            {
                return new RationalNumber(0, 1);
            }
            return new RationalNumber(newNumerator, newDenominator).Reduce();
        }

        // Subtracts one rational number
        public IRationalNumber Subtract(IRationalNumber number)
        {
            var rationalNumber = (RationalNumber)number;
            var (numerator2, denominator2) = (rationalNumber.Numerator, rationalNumber.Denominator);
            int newNumerator = (Numerator * denominator2 - numerator2 * Denominator);
            int newDenominator = (Denominator * denominator2);
            if (newNumerator == 0)
            {
                return new RationalNumber(0, 1);
            }
            return new RationalNumber(newNumerator, newDenominator).Reduce();
        }

        public IRationalNumber Multiply(IRationalNumber number)
        {
            var rationalNumber = (RationalNumber)number;
            var (newNumerator, newDenominator) = (Numerator * rationalNumber.Numerator, Denominator * rationalNumber.Denominator);
            
            return new RationalNumber(newNumerator, newDenominator).Reduce();
        }

        // Divides 2 rational numbers and returns new number reduced to lowest terms
        public IRationalNumber Divide(IRationalNumber number)
        {
            var rationalNumber = (RationalNumber)number;
            var (newNumerator, newDenominator) = (Numerator * rationalNumber.Denominator, Denominator * rationalNumber.Numerator);

            return new RationalNumber(newNumerator, newDenominator).Reduce();
        }

        public override string ToString()
        {
            return $"{this.Numerator}/{this.Denominator}";
        }

        public override bool Equals(object obj)
        {
            if(obj is RationalNumber number)
            {
                return this.Numerator == number.Numerator && this.Denominator == number.Denominator;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Numerator * Denominator; // replace this with the correct expression or remove
        }
    }

    public static class IntNumberExtension
    {
        // Gets exponentiation int number to the rational number power
        public static double ExpReal(this int intNumber, RationalNumber r) => r.ExpRealToRational(intNumber);
        
    }

    public static class DoubleNumberExtension
    {
        // Gets exponentiation real number to the rational number power
        public static double ExpReal(this double doubleNumber, RationalNumber r) => r.ExpRealToRational(doubleNumber);

    }

    /// <summary>
    /// Extension class for RationalClass
    /// </summary>
    public static class RationalNumberExtension
    {
        /// <summary>
        /// Calculates common divisor for rational numbers numerator and denominator
        /// </summary>
        /// <param name="number">Rational Number</param>
        /// <seealso cref="RationalNumber"/>
        /// <returns>Greatest common divisor of Numerator and Denominator</returns>
        public static int GetGreatestCommonDivisor(this RationalNumber number)
        {
            int number1 = Math.Abs(number.Numerator);
            int number2 = Math.Abs(number.Denominator);
            while (number1 != 0 && number2 != 0)
            {
                if (number1 > number2)
                    number1 %= number2;
                else
                    number2 %= number1;
            }
            int gcd = number1 == 0 ? number2 : number1;

            return gcd;
        }
    }
}
