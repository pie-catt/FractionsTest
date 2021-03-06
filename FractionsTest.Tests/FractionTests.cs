﻿using System;
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
            var fr = new Fraction(30, 42);
            Assert.That(() => fr.Numerator == 5);
        }

        [Test]
        public void BaseConstructorTestDen()
        {
            var fr = new Fraction(30, 42);
            Assert.That(() => fr.Denominator == 7);
        }

        [Test]
        public void SameSignConstructorTest()
        {
            var fr = new Fraction(-1, -2);
            Assert.That(() => fr.Numerator == 1 && fr.Denominator == 2);
        }

        [Test]
        public void DenNegSignConstructorTest()
        {
            var fr = new Fraction(1, -2);
            Assert.That(() => fr.Numerator == -1 && fr.Denominator == 2);
        }

        [Test]
        public void NormalFormConstructorTest()
        {
            var fr = new Fraction(90, -525);
            Assert.That(() => fr.Numerator == -6 && fr.Denominator == 35);
            
        }

        [Test]
        public void SumOperatorTest()
        {
            var f1 = new Fraction(1,2);
            var f2 = new Fraction(2,5);
            var f3 = f1 + f2;
            TestContext.WriteLine(f3.Denominator);

            Assert.That(() => f3.Numerator == 9 && f3.Denominator == 10);
        }

        [Test]
        public void MultOperatorTest()
        {
            var f1 = new Fraction(2, 5);
            var f2 = new Fraction(1, 2);
            var f3 = f1 * f2;
            Assert.That(() => f3.Numerator == 1 && f3.Denominator == 5);
        }

        [Test]
        public void MinusOperatorTest()
        {
            var f1 = new Fraction(3, 5);
            var f2 = new Fraction(2, 5);
            var f3 = f1 - f2;
            Assert.That(() => f3.Numerator == 1 && f3.Denominator == 5);
        }

        [Test]
        public void DivideOperatorTest()
        {
            var f1 = new Fraction(33, 42);
            var f2 = new Fraction(111, 8);
            var f3 = f1 / f2;
            Assert.That(() => f3.Numerator == 44 && f3.Denominator == 777);
        }

        [TestCase(11, 5, "11/5")]
        [TestCase(22, 11, "2")]
        [TestCase(22, -11, "-2")]
        public void ToStringTest(int n, int d, string rapr)
        {
            var fr = new Fraction(n, d);
            Assert.That(() => fr.ToString() == rapr);
        }

        [Test]
        public void TestEquals()
        {
            var f1 = new Fraction(2, 4);
            var f2 = new Fraction(1, 2);
            Assert.That(f1.Equals(f2));
        }

        [Test]
        public void BaseConstructorTestNullDenExcepion()
        {
            Assert.That(() => new Fraction(4, 0), Throws.TypeOf<ArgumentException>());
        }

    }
}
