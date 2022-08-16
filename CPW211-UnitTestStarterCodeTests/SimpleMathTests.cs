using Microsoft.VisualStudio.TestTools.UnitTesting;
using CPW211_UnitTestStarterCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPW211_UnitTestStarterCode.Tests
{
    [TestClass()]
    public class SimpleMathTests
    {
        [TestMethod()]
        [DataRow(5, 10)]
        [DataRow(0, 100)]
        [DataRow(-1, -10)]
        [DataRow(0, -0)]
        public void Add_TwoNumbers_ReturnsSum(double num1, double num2)
        {
            // Use the DataRow values to test the Add method
            // Arrange
            double correctAdd = num1 + num2;

            // Act
            double returnedAdd = SimpleMath.Add(num1, num2);

            // Assert
            Assert.AreEqual(correctAdd, returnedAdd);
        }

        [TestMethod]
        public void Multiply_TwoNumbers_ReturnsProduct()
        {
            // Use a few pairs of values to test the Multiply method
            // Arrange
            double num2 = 502;
            double num1 = 4;
            double expectedProduct = num2 * num1;

            // Act
            double returnedProduct = SimpleMath.Multiply(num1, num2);

            // Assert
            Assert.AreEqual(expectedProduct, returnedProduct);
        }

        [TestMethod]
        [DataRow(50, 0)]
        public void Divide_DenominatorZero_ThrowsArgumentException(double numerator, double denominator)
        {
            // Divide by zero should throw an argument exception with a message
            // "Denominator cannot be zero"
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => SimpleMath.Divide(numerator, denominator));           
        }

        // Test Divide method with two valid numbers
        [TestMethod]
        [DataRow(50, 2)]
        [DataRow(502, 4)]
        public void Divide_TwoNumbers_ReturnQuotient(double numerator, double denominator)
        {
            // Arrange
            double correctQuotient = numerator / denominator;

            // Act
            double returnedQuotient = SimpleMath.Divide(numerator, denominator);

            // Assert
            Assert.AreEqual(correctQuotient, returnedQuotient);
        }

        // TODO: Test subtract method with two valid numbers
    }
}