using ProjectToTest.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectToTest.Domain;
using System.Collections.Generic;

namespace ProjectToTestMSTest
{
    
    
    /// <summary>
    ///This is a test class for PersonServiceTest and is intended
    ///to contain all PersonServiceTest Unit Tests
    ///</summary>
    [TestClass()]
    public class PersonServiceTest
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
        ///A test for PersonService Constructor
        ///</summary>
        [TestMethod()]
        public void PersonServiceConstructorTest()
        {
            IPersonRepository repository = null;
            PersonService target = new PersonService(repository);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for GetAllPeople
        ///</summary>
        [TestMethod()]
        public void GetAllPeopleTest()
        {
            IPersonRepository repository = null; // TODO: Initialize to an appropriate value
            PersonService target = new PersonService(repository); // TODO: Initialize to an appropriate value
            List<Person> expected = null; // TODO: Initialize to an appropriate value
            List<Person> actual;
            actual = target.GetAllPeople();
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for GetAllPeopleStored
        ///</summary>
        [TestMethod()]
        public void GetAllPeopleStoredTest()
        {
            IPersonRepository repository = null; // TODO: Initialize to an appropriate value
            PersonService target = new PersonService(repository); // TODO: Initialize to an appropriate value
            List<Person> expected = null; // TODO: Initialize to an appropriate value
            List<Person> actual;
            actual = target.GetAllPeopleStored();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetPerson
        ///</summary>
        [TestMethod()]
        public void GetPersonTest()
        {
            IPersonRepository repository = null; // TODO: Initialize to an appropriate value
            PersonService target = new PersonService(repository); // TODO: Initialize to an appropriate value
            int personId = 0; // TODO: Initialize to an appropriate value
            Person expected = null; // TODO: Initialize to an appropriate value
            Person actual;
            actual = target.GetPerson(personId);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
