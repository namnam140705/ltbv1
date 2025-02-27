using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1
{
    [TestFixture]
    public class CalculatorTests
    {
        private Calculator calculator;

        [SetUp]
        public void Setup()
        {
            calculator = new Calculator();
        }

        [Test]
        public void Add_ShouldReturnSum_WhenTwoIntegersAreGiven()
        {
            Assert.AreEqual(5, calculator.Add(2, 3));
            Assert.AreEqual(-1, calculator.Add(-2, 1));
        }

        [Test]
        public void Subtract_ShouldReturnDifference_WhenTwoIntegersAreGiven()
        {
            Assert.AreEqual(1, calculator.Subtract(3, 2));
            Assert.AreEqual(-3, calculator.Subtract(-2, 1));
        }

        [Test]
        public void Multiply_ShouldReturnProduct_WhenTwoIntegersAreGiven()
        {
            Assert.AreEqual(6, calculator.Multiply(2, 3));
            Assert.AreEqual(-2, calculator.Multiply(-2, 1));
        }

        [Test]
        public void Divide_ShouldReturnQuotient_WhenTwoIntegersAreGiven()
        {
            Assert.AreEqual(2, calculator.Divide(6, 3));
        }

        [Test]
        public void Divide_ShouldThrowDivideByZeroException_WhenDividingByZero()
        {
            Assert.Throws<DivideByZeroException>(() => calculator.Divide(1, 0));
        }
    }
}
