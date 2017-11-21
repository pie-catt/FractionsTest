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
            var fr = new Mock<Fraction>(4, 5);
            Assert.That(() => fr.Object.numerator == 4);
        }

        [Test]
        public void BaseConstructorTestDen()
        {
            var fr = new Mock<Fraction>(4, 5);
            Assert.That(() => fr.Object.denumerator == 5);
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
        public void NormalFormConstructorTest()
        {
            var fr = new Fraction(-2, 4);
            Assert.That(() => fr.numerator == -1 && fr.denumerator == 2);
            
        }
}
}
