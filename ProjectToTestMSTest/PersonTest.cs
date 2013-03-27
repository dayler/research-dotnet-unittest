using ProjectToTest.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ProjectToTestMSTest
{
    
    
    /// <summary>
    ///This is a test class for PersonTest and is intended
    ///to contain all PersonTest Unit Tests
    ///</summary>
    [TestClass()]
    public class PersonTest
    {
        private int personId = 5;
        
        private String firstName = "Amy";
        
        private String lastName = "Lee";
        
        private Person testPerson;

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

        [ClassInitialize()]
        public static void MyClassInitialize(TestContext testContext)
        {

        }

        [ClassCleanup()]
        public static void MyClassCleanup()
        {
        }
        
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
        ///A test for Person Constructor
        ///</summary>
        [TestMethod()]
        public void PersonConstructorTest()
        {
            try
            {
                var target = new Person(personId, firstName, lastName);
            }
            catch (Exception ex)
            {
                Assert.IsTrue(false, String.Format("An exception({0}) Occurred.", ex.GetType()));
            }
        }

        /// <summary>
        ///A test for FirstName
        ///</summary>
        [TestMethod()]
        public void FirstNameTest()
        {
            var target = new Person(personId, firstName, lastName);
            String actual = target.FirstName;
            Assert.IsNotNull(actual, "The FirstName property is null.");
            Assert.AreEqual(firstName, actual, "The FirstName property has not the expected value.");
        }

        /// <summary>
        ///A test for Id
        ///</summary>
        [TestMethod()]
        public void IdTest()
        {
            var target = new Person(personId, firstName, lastName);
            int actual = target.Id;
            Assert.AreEqual(personId, actual, "The Id property has not the expected value.");
        }

        /// <summary>
        ///A test for LastName
        ///</summary>
        [TestMethod()]
        public void LastNameTest()
        {
            Person target = new Person(personId, firstName, lastName);
            String actual = target.LastName;
            Assert.IsNotNull(actual, "The LastName proeprty is null.");
            Assert.AreEqual(lastName, actual, "The LastName property does not have the expected value.");
        }
    }
}
