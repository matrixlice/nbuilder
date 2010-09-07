using System;
using System.Linq;
using System.Text;
using FizzWare.NBuilder.Tests.TestClasses;
using NUnit.Framework;
using Rhino.Mocks;

namespace FizzWare.NBuilder.Tests.Integration
{
    [TestFixture]
    public class SingleObjectBuilderTests_WithAClassThatHasANonParameterlessConstructor
    {
        private const string theString = "string";
        private const decimal theDecimal = 10m;
        private const int theInt = 5;
        private const float theFloat = 15f;

        [Test]
        public void ShouldBeAbleToCreateAnObject()
        {
            var obj = Builder<MyClassWithConstructor>.CreateNew().WithConstructorArgs(theString, theDecimal).Build();

            Assert.That(obj.String, Is.EqualTo(theString));
            Assert.That(obj.Decimal, Is.EqualTo(theDecimal));
        }

        [Test]
        public void ShouldChooseCorrectConstructor()
        {
            var obj = Builder<MyClassWithConstructor>.CreateNew().WithConstructorArgs(theInt, theFloat).Build();

            Assert.That(obj.Int, Is.EqualTo(theInt));
            Assert.That(obj.Float, Is.EqualTo(theFloat));
        }
    }
}