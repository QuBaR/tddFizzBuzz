using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using TDDFizzBuzz;

namespace TDDFizzBuzzTests
{
    [TestClass]
    public class FizzBuzzEngineTests
    {
        // Test step method of FizzBuzzEngine
        [TestMethod]
        public void TestStep()
        {
            // Arrange
            var fizzBuzzEngine = new FizzBuzzEngine();
            fizzBuzzEngine.Value = 5;
            int expectedValue = 6;

            // Act
            fizzBuzzEngine.Step();

            // Assert
            Assert.AreEqual(expectedValue, fizzBuzzEngine.Value);
        }

        // Test getting correct value from FizzBuzzEngine string
        [TestMethod]
        [DataRow(1,"1"), DataRow(2, "2"), DataRow(4, "4")]
        [DataRow(3,"Fizz"), DataRow(6, "Fizz"), DataRow(9, "Fizz")]
        [DataRow(5,"Buzz"), DataRow(10, "Buzz"), DataRow(20, "Buzz")]
        [DataRow(15,"FizzBuzz"), DataRow(30, "FizzBuzz"), DataRow(45, "FizzBuzz")]
        public void TestGetFizzBuzzString(int testValue, string expectedValue)
        {
            // Arrange
            var fizzBuzzEngine = new FizzBuzzEngine();
            fizzBuzzEngine.Value = testValue;

            // Act
            string fizzBuzzValue = fizzBuzzEngine.GetFizzBuzzString();

            // Assert
            Assert.AreEqual(expectedValue, fizzBuzzValue);
        }
    }
}
