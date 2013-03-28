using ProjectToTest.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ProjectToTestMSTest.Util
{
    /// <summary>
    ///This is a test class for MathObjectTest and is intended
    ///to contain all MathObjectTest Unit Tests
    ///</summary>
    [TestClass()]
    public class MathObjectTest
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
        ///A test for MathObject Constructor
        ///</summary>
        [TestMethod()]
        public void MathObjectConstructorTest()
        {
            try
            {
                MathObject target = new MathObject();
            }
            catch (Exception ex)
            {
                Assert.IsTrue(false, String.Format("Exception({0}) occurss when the 'MathObject' class is intantiated.",
                    ex.GetType()));
            }
        }

        /// <summary>
        ///A test for AddTwoInts
        ///</summary>
        [TestMethod()]
        public void AddTwoIntsTest()
        {
            MathObject target = new MathObject();
            int num1 = 2;
            int num2 = 3;
            int expected = num1 + num2;
            int actual;
            actual = target.AddTwoInts(num1, num2);
            Assert.AreEqual(expected, actual, "Expected and calculated value are diferent.");
        }
    }
}
