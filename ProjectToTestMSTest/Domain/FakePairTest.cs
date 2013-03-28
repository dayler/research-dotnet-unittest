using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ProjectToTest.Domain;

//namespace ProjectToTestMSTest

namespace ProjectToTestMSTest.Domain
{
    
    
    /// <summary>
    ///This is a test class for FakePairTest and is intended
    ///to contain all FakePairTest Unit Tests
    ///</summary>
    [TestClass()]
    public class FakePairTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for FakePair Constructor
        ///</summary>
        [TestMethod()]
        public void FakePairConstructorTest()
        {
            string first = "first"; // TODO: Initialize to an appropriate value
            string second = "second"; // TODO: Initialize to an appropriate value
            FakePair fakePair = null;
            
            try
            {
                fakePair = new FakePair(first, second);
            }
            catch (Exception ex)
            {
                Assert.IsTrue(false, String.Format("Exception({0}) occurs when is created the FakePair class.",
                    ex.GetType()));
            }

            Assert.IsNotNull(fakePair, "The instance is null.");
        }

        /// <summary>
        ///A test for First
        ///</summary>
        [TestMethod()]
        public void FirstTest()
        {
            string first = "first";
            string second = "second";
            FakePair target = new FakePair(first, second);
            string actual = target.First;
            Assert.IsNotNull(actual, "The First property is null.");
            Assert.AreEqual(first, actual, "The First dont have the expected value.");
        }

        /// <summary>
        ///A test for Second
        ///</summary>
        [TestMethod()]
        public void SecondTest()
        {
            string first = "first";
            string second = "second";
            FakePair target = new FakePair(first, second);
            string actual = target.Second;
            Assert.IsNotNull(actual, "Second property resturns null");
            Assert.AreEqual(second, actual, "both object must to be equals.");
        }
    }
}
