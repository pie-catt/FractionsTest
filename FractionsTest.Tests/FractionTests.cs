using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using FractionsTest;
using Moq;

namespace FractionsTest.Tests
{
    [TestFixture]
    public class FractionTests
    {
       [Test]
        public void BaseConstructorTestNum()
        {
            var fr = new Mock<Fraction>(30, 42);
            Assert.That(() => fr.Object.numerator == 5);
        }

        [Test]
        public void BaseConstructorTestDen()
        {
            var fr = new Mock<Fraction>(30, 42);
            Assert.That(() => fr.Object.denumerator == 7);
        }

        [Test]
        public void BaseConstructorTestExcepion()
        {
            // var fr = new Mock<Fraction>(4, 0);
            Assert.That(() => new Fraction(4, 0), Throws.TypeOf<ArgumentException>());
        }

        [Test]
        public void SameSignConstructorTest()
        {
            var fr = new Fraction(-1, -2);
            Assert.That(() => fr.numerator == 1 && fr.denumerator == 2);
        }

        [Test]
        public void DenNegSignConstructorTest()
        {
            var fr = new Fraction(1, -2);
            Assert.That(() => fr.numerator == -1 && fr.denumerator == 2);
        }

        [Test]
        public void NormalFormConstructorTest()
        {
            var fr = new Fraction(90, -525);
            Assert.That(() => fr.numerator == -6 && fr.denumerator == 35);
            
        }

        [Test]
        public void SumOperatorTest()
        {
            var f1 = new Fraction(1,2);
            var f2 = new Fraction(2,5);
            var f3 = f1 + f2;
            TestContext.WriteLine(f3.denumerator);

            Assert.That(() => f3.numerator == 9 && f3.denumerator == 10);
        }

        [Test]
        public void MultOperatorTest()
        {
            var f1 = new Fraction(2, 5);
            var f2 = new Fraction(1, 2);
            var f3 = f1 * f2;
            Assert.That(() => f3.numerator == 1 && f3.denumerator == 5);
        }
    }
}
