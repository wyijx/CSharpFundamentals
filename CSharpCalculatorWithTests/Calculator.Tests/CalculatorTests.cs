using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.Tests {
    [TestClass]
    public class CalculatorTests {
        [TestMethod]
        public void TestAddNums() {
            // Arrange
            var calculator = new CalculatorWithTests.Calculator();
            // Act
            var result = calculator.AddNums(13, 17);
            // Assert
            Assert.AreEqual(30, result);
        }

        [TestMethod]
        public void TestSubNums() {
            // Arrange
            var calc = new CalculatorWithTests.Calculator();

            //Act
            var result = calc.SubNums(17, 13);

            // Assert
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void TestMultNums() {

            var calc = new CalculatorWithTests.Calculator();

            var result = calc.MultNums(5, 5);

            Assert.AreEqual(25, result);
        }

        [TestMethod]
        public void TestDivNums() {
            var calc = new CalculatorWithTests.Calculator();

            var result = calc.DivNums(20, 4);

            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void TestExp() {
            var calc = new CalculatorWithTests.Calculator();

            var result = calc.Exp(2, 3);

            Assert.AreEqual(8, result);
        }
    }
}
