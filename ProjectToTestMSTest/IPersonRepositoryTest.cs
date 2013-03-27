using ProjectToTest.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ProjectToTest.Domain;
using System.Collections.Generic;

namespace ProjectToTestMSTest
{
    
    
    /// <summary>
    ///This is a test class for IPersonRepositoryTest and is intended
    ///to contain all IPersonRepositoryTest Unit Tests
    ///</summary>
    [TestClass()]
    public class IPersonRepositoryTest
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


        internal virtual IPersonRepository CreateIPersonRepository()
        {
            // TODO: Instantiate an appropriate concrete class.
            IPersonRepository target = null;
            return target;
        }

        /// <summary>
        ///A test for GetPeople
        ///</summary>
        [TestMethod()]
        public void GetPeopleTest()
        {
            IPersonRepository target = CreateIPersonRepository();
            List<Person> expected = null;
            List<Person> actual;
            actual = target.GetPeople();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetPersonById
        ///</summary>
        [TestMethod()]
        public void GetPersonByIdTest()
        {
            IPersonRepository target = CreateIPersonRepository(); // TODO: Initialize to an appropriate value
            int personId = 0; // TODO: Initialize to an appropriate value
            Person expected = null; // TODO: Initialize to an appropriate value
            Person actual;
            actual = target.GetPersonById(personId);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
