using System;
using NUnit.Framework;
using ProjectToTest.Util;

namespace ProjectToTestNUnitTest.Util
{
    [TestFixture]
    public class MathObjectTest
    {
        [Test]
        public void TestAddTwoInts()
        {
            MathObject mathObject = new MathObject();
            int expectedResult = 3 + 4;
            int calculatedResult = mathObject.AddTwoInts(3, 4);
            Assert.AreEqual(calculatedResult, expectedResult, String.Format("The expected result was {0}", expectedResult));
        }

        [Test]
        public void TestAddTwoIntsFail()
        {
            var mathObject = new MathObject();
            int expectedResult = 3 + 1;
            int calculatedResult = mathObject.AddTwoInts(3, 4);
            Assert.AreEqual(calculatedResult, expectedResult, String.Format("The expected result is {0}", expectedResult));
        }
    }
}