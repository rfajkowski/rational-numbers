using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace RationalNumbers.Test
{
    [TestClass]
    public class RationalTests
    {
        [TestMethod]
        public void Add_two_positive_rational_numbers()
        {
            Assert.AreEqual(new RationalNumber(7, 6), new RationalNumber(1, 2) + new RationalNumber(2, 3));
        }

        [TestMethod]
        public void Add_a_positive_rational_number_and_a_negative_rational_number()
        {
            Assert.AreEqual(new RationalNumber(-1, 6), new RationalNumber(1, 2) + new RationalNumber(-2, 3));
        }

        [TestMethod]
        public void Add_two_negative_rational_numbers()
        {
            Assert.AreEqual(new RationalNumber(-7, 6), new RationalNumber(-1, 2) + new RationalNumber(-2, 3));
        }

        [TestMethod]
        public void Add_a_rational_number_to_its_additive_inverse()
        {
            Assert.AreEqual(new RationalNumber(0, 1), new RationalNumber(1, 2) + new RationalNumber(-1, 2));
        }

        [TestMethod]
        public void Subtract_two_positive_rational_numbers()
        {
            Assert.AreEqual(new RationalNumber(-1, 6), new RationalNumber(1, 2) - new RationalNumber(2, 3));
        }

        [TestMethod]
        public void Subtract_a_positive_rational_number_and_a_negative_rational_number()
        {
            Assert.AreEqual(new RationalNumber(7, 6), new RationalNumber(1, 2) - new RationalNumber(-2, 3));
        }

        [TestMethod]
        public void Subtract_two_negative_rational_numbers()
        {
            Assert.AreEqual(new RationalNumber(1, 6), new RationalNumber(-1, 2) - new RationalNumber(-2, 3));
        }

        [TestMethod]
        public void Subtract_a_rational_number_from_itself()
        {
            Assert.AreEqual(new RationalNumber(0, 1), new RationalNumber(1, 2) - new RationalNumber(1, 2));
        }

        [TestMethod]
        public void Multiply_two_positive_rational_numbers()
        {
            Assert.AreEqual(new RationalNumber(1, 3), new RationalNumber(1, 2) * new RationalNumber(2, 3));
        }

        [TestMethod]
        public void Multiply_a_negative_rational_number_by_a_positive_rational_number()
        {
            Assert.AreEqual(new RationalNumber(-1, 3), new RationalNumber(-1, 2) * new RationalNumber(2, 3));
        }

        [TestMethod]
        public void Multiply_two_negative_rational_numbers()
        {
            Assert.AreEqual(new RationalNumber(1, 3), new RationalNumber(-1, 2) * new RationalNumber(-2, 3));
        }

        [TestMethod]
        public void Multiply_a_rational_number_by_its_reciprocal()
        {
            Assert.AreEqual(new RationalNumber(1, 1), new RationalNumber(1, 2) * new RationalNumber(2, 1));
        }

        [TestMethod]
        public void Multiply_a_rational_number_by_1()
        {
            Assert.AreEqual(new RationalNumber(1, 2), new RationalNumber(1, 2) * new RationalNumber(1, 1));
        }

        [TestMethod]
        public void Multiply_a_rational_number_by_0()
        {
            Assert.AreEqual(new RationalNumber(0, 1), new RationalNumber(1, 2) * new RationalNumber(0, 1));
        }

        [TestMethod]
        public void Divide_two_positive_rational_numbers()
        {
            Assert.AreEqual(new RationalNumber(3, 4), new RationalNumber(1, 2) / new RationalNumber(2, 3));
        }

        [TestMethod]
        public void Divide_a_positive_rational_number_by_a_negative_rational_number()
        {
            Assert.AreEqual(new RationalNumber(-3, 4), new RationalNumber(1, 2) / new RationalNumber(-2, 3));
        }

        [TestMethod]
        public void Divide_two_negative_rational_numbers()
        {
            Assert.AreEqual(new RationalNumber(3, 4), new RationalNumber(-1, 2) / new RationalNumber(-2, 3));
        }

        [TestMethod]
        public void Divide_a_rational_number_by_1()
        {
            Assert.AreEqual(new RationalNumber(1, 2), new RationalNumber(1, 2) / new RationalNumber(1, 1));
        }

        [TestMethod]
        public void Divide_a_rational_number__by_0_Throws_Exception()

        {
            Assert.ThrowsException<System.ArgumentException>(() => new RationalNumber(1, 1) / new RationalNumber(0, 1));
        }

        [TestMethod]
        public void Absolute_value_of_a_positive_rational_number()
        {
            Assert.AreEqual(new RationalNumber(1, 2), new RationalNumber(1, 2).Abs());
        }

        [TestMethod]
        public void Absolute_value_of_a_positive_rational_number_with_negative_numerator_and_denominator()
        {
            Assert.AreEqual(new RationalNumber(1, 2), new RationalNumber(-1, -2).Abs());
        }

        [TestMethod]
        public void Absolute_value_of_a_negative_rational_number()
        {
            Assert.AreEqual(new RationalNumber(1, 2), new RationalNumber(-1, 2).Abs());
        }

        [TestMethod]
        public void Absolute_value_of_a_negative_rational_number_with_negative_denominator()
        {
            Assert.AreEqual(new RationalNumber(1, 2), new RationalNumber(1, -2).Abs());
        }

        [TestMethod]
        public void Absolute_value_of_zero()
        {
            Assert.AreEqual(new RationalNumber(0, 1), new RationalNumber(0, 1).Abs());
        }

        [TestMethod]
        public void Raise_a_positive_rational_number_to_a_positive_integer_power()
        {
            Assert.AreEqual(new RationalNumber(1, 8), new RationalNumber(1, 2).ExpRational(3));
        }

        [TestMethod]
        public void Raise_a_negative_rational_number_to_a_positive_integer_power()
        {
            Assert.AreEqual(new RationalNumber(-1, 8), new RationalNumber(-1, 2).ExpRational(3));
        }

        [TestMethod]
        public void Raise_zero_to_an_integer_power()
        {
            Assert.AreEqual(new RationalNumber(0, 1), new RationalNumber(0, 1).ExpRational(5));
        }

        [TestMethod]
        public void Raise_one_to_an_integer_power()
        {
            Assert.AreEqual(new RationalNumber(1, 1), new RationalNumber(1, 1).ExpRational(4));
        }

        [TestMethod]
        public void Raise_a_positive_rational_number_to_the_power_of_zero()
        {
            Assert.AreEqual(new RationalNumber(1, 1), new RationalNumber(1, 2).ExpRational(0),
                "Method doesn't return rational 1/1 when raised to 0");
        }

        [TestMethod]
        public void Raise_a_negative_rational_number_to_the_power_of_zero()
        {
            Assert.AreEqual(new RationalNumber(1, 1), new RationalNumber(-1, 2).ExpRational(0),
                "ExpRational with negative number to the power of zero doesn't return rational 1");
        }

        [TestMethod]
        public void Raise_a_rational_number_to_the_negative_integer_power()
        {
            Assert.AreEqual(new RationalNumber(4, 1), new RationalNumber(1, 2).ExpRational(-2), 
                "ExpRational should swap numerator and denominator around and raise to the power");
        }

        [TestMethod]
        public void Raise_a_int_number_to_a_positive_rational_number()
        {
            Assert.AreEqual(16, 8.ExpReal(new RationalNumber(4, 3)), 0.0000001);
        }

        [TestMethod]
        public void Raise_a_int_number_to_a_negative_rational_number()
        {
            Assert.AreEqual(0.33333334, 9.ExpReal(new RationalNumber(-1, 2)), 0.000001);
        }

        [TestMethod]
        public void Raise_a_int_number_to_a_zero_rational_number()
        {
            Assert.AreEqual(1.41421, 2.ExpReal(new RationalNumber(1, 2)), 0.00001);
        }

        [TestMethod]
        public void Raise_a_double_number_to_a_positive_rational_number()
        {
            Assert.AreEqual(16, 8.0.ExpReal(new RationalNumber(4, 3)), 0.0000001);
        }


        [TestMethod]
        public void Raise_a_real_number_to_a_negative_rational_number()
        {
            Assert.AreEqual(0.33333334, 9.0.ExpReal(new RationalNumber(-1, 2)), 0.000001);
        }

        [TestMethod]
        public void Raise_a_real_number_to_a_zero_rational_number()
        {
            Assert.AreEqual(1.41421, 2.0.ExpReal(new RationalNumber(1, 2)), 0.00001, "Real number raised to 0 rational number incorrectly");
        }


        [TestMethod]
        public void Reduce_a_positive_rational_number_to_lowest_terms()
        {
            Assert.AreEqual(new RationalNumber(1, 2), new RationalNumber(2, 4).Reduce(), "Number reduced incorrectly");
        }

        [TestMethod]
        public void Reduce_a_negative_rational_number_to_lowest_terms()
        {
            Assert.AreEqual(new RationalNumber(-2, 3), new RationalNumber(-4, 6).Reduce(), "Number reduced incorrectly");
        }

        [TestMethod]
        public void Reduce_a_rational_number_with_a_negative_denominator_to_lowest_terms()
        {
            Assert.AreEqual(new RationalNumber(-1, 3), new RationalNumber(3, -9).Reduce(), "Denominator should be positive and numerator negative");
        }

        [TestMethod]
        public void Reduce_zero_to_lowest_terms()
        {
            Assert.AreEqual(new RationalNumber(0, 1), new RationalNumber(0, 6).Reduce(), "Reduce doesn't reduce to rational 0");
        }

        [TestMethod]
        public void Reduce_an_integer_to_lowest_terms()
        {
            Assert.AreEqual(new RationalNumber(-2, 1), new RationalNumber(-14, 7).Reduce());
        }

        [TestMethod]
        public void Reduce_one_to_lowest_terms()
        {
            Assert.AreEqual(new RationalNumber(1, 1), new RationalNumber(13, 13).Reduce());
        }

        [TestMethod]
        public void Create_rational_number_with_denominator_0_throws_argumentException()
        {
            try
            {
                var rationalNumber = new RationalNumber(1, 0);
            }
            catch (System.ArgumentException e)
            {
                StringAssert.Contains(e.Message, "The denominator cannot be 0");
                return;
            }

            Assert.Fail("The expected exception was not thrown.");
        }

        [TestMethod]
        public void Rational_number_with_negative_denominator_is_negative_number()
        {
            Assert.AreEqual(new RationalNumber(-3, 4), new RationalNumber(3, -4), "The number is not converted to negative number when denominator is negative");
        }

        [TestMethod]
        public void Rational_number_with_negative_numerator_and_denominator_is_positive_number()
        {
            Assert.AreEqual(new RationalNumber(3, 7), new RationalNumber(-3, -7), "Rational number with negative numerator and denominator is not converted to positive number.");
        }

        [TestMethod]
        public void Get_Greatest_Common_Divisor_Of_Rational_Number_Values()
        {
            var number = new RationalNumber(3, 9);
            int gcd = number.GetGreatestCommonDivisor();
            Assert.AreEqual(3, gcd, "Number is reduced incorrectly.");
        }

        [TestMethod]
        public void ExpToReal_Return_Real_Number()
        {
            var number = new RationalNumber(1, 2);
            Assert.AreEqual(0.35, number.ExpToReal(1.5), 0.01, "Number is raised incorrectly.");
        }

        [TestMethod]
        public void ExpToReal_Rise_To_0_Returns_1()
        {
            var number = new RationalNumber(1, 2);
            Assert.AreEqual(1, number.ExpToReal(0), 0.01, "Number is raised incorrectly.");
        }

        [TestMethod]
        public void ToString_Displays_RationalNumber_In_Right_Format()
        {
            var number = new RationalNumber(1, 2);
            Assert.AreEqual("1/2", number.ToString(), "The number is displayed in wrong format");
        }

    }
}