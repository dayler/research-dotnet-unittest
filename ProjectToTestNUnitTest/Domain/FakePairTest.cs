using System;
using NUnit.Framework;
using ProjectToTest.Domain;

namespace ProjectToTestNUnitTest.Domain
{
    [TestFixture]
    public class FakePairTest
    {
        private FakePair fakePair;
        private String first = "first";
        private String second = "second";

        [SetUp]
        public void SetUp()
        {
            fakePair = new FakePair(first, second);
        }

        [TearDown]
        public void TearDown()
        {
            fakePair = null;
        }

        [Test]
        public void TestFaKePair()
        {
            var obj = new FakePair(first, second);
            Assert.IsNotNull(obj);
        }

        [Test]
        public void TestFakePairNullParam()
        {
            Assert.Throws<ArgumentNullException>(delegate { new FakePair(first, null); }, "The exception is not and instance of ArgumentNullException");
            Assert.Throws<ArgumentNullException>(delegate { new FakePair(null, second); }, "The exception is not and instance of ArgumentNullException");
            Assert.Throws<ArgumentNullException>(delegate { new FakePair(null, null); }, "The exception is not and instance of ArgumentNullException");
        }

        [Test]
        public void TestGetFirst()
        {
            Assert.IsNotNull(fakePair.First, String.Format("The property 'First', should not be null."));
            Assert.AreEqual(first, fakePair.First, "The expected value for the 'First' poperty is {0}", first);
        }

        [Test]
        public void TestGetSecond()
        {
            Assert.IsNotNull(fakePair.Second, String.Format("The property 'First', should not be null."));
            Assert.AreEqual(second, fakePair.Second, "The expected value for the 'First' poperty is {0}", second);
        }
    }
}