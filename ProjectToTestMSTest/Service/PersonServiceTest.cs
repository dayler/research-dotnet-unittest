using ProjectToTest.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectToTest.Domain;
using System.Collections.Generic;
using NSubstitute;

namespace ProjectToTestMSTest.Service
{
    
    
    /// <summary>
    ///This is a test class for PersonServiceTest and is intended
    ///to contain all PersonServiceTest Unit Tests
    ///</summary>
    [TestClass()]
    public class PersonServiceTest
    {
        private IPersonRepository personRepository;

        private List<Person> people;

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
//        [ClassInitialize()]
//        public static void MyClassInitialize(TestContext testContext)
//        {
//        }
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        [TestInitialize()]
        public void MyTestInitialize()
        {
            personRepository = Substitute.For<IPersonRepository>();
            people = new List<Person>() { new Person(0, "onePersonFrirstName", "onePersonLatsName") };
        }
        //
        //Use TestCleanup to run code after each test has run
        [TestCleanup()]
        public void MyTestCleanup()
        {
            personRepository = null;
            people = null;
        }
        //
        #endregion

        /// <summary>
        ///A test for PersonService Constructor
        ///</summary>
        [TestMethod()]
        public void PersonServiceConstructorTest()
        {
            PersonService target = new PersonService(personRepository);
            Assert.IsNotNull(target, "The target cannot be null.");
        }

        /// <summary>
        ///A test for GetAllPeople
        ///</summary>
        [TestMethod()]
        public void GetAllPeopleTest()
        {
            personRepository.GetPeople().Returns(people);
            PersonService target = new PersonService(personRepository);
            List<Person> expected = new List<Person>(people);
            List<Person> actual = target.GetAllPeople();
            Assert.IsNotNull(actual, "The expected actual list cannot be null.");
            // Compare references.
            Assert.AreEqual(expected.Count, actual.Count, "The peple lists are not the same");
        }

        /// <summary>
        ///A test for GetAllPeopleStored
        ///</summary>
        [TestMethod()]
        public void GetAllPeopleStoredTest()
        {
            personRepository.GetPeople().Returns(people);
            PersonService target = new PersonService(personRepository);
            List<Person> expected = new List<Person>(people);
            List<Person> actual = target.GetAllPeopleStored();
            Assert.IsNotNull(actual, "The actual people list cannot be null.");
            Assert.AreEqual(expected.Count, actual.Count, "The people list are not the same.");
        }

        /// <summary>
        ///A test for GetPerson
        ///</summary>
        [TestMethod()]
        public void GetPersonTest()
        {
            int testId = 0;
            personRepository.GetPersonById(testId).Returns(people[0]);
            PersonService target = new PersonService(personRepository);
            Person expected = people[0];
            Person actual = target.GetPerson(testId);
            Assert.IsNotNull(actual, "The actual person cannot be null.");
            Assert.AreEqual(expected.Id, actual.Id, "The IDs are not the same.");
            Assert.AreEqual(expected.FirstName, expected.FirstName, "The first names are not the same.");
            Assert.AreEqual(expected.LastName, actual.LastName, "The last names are not the same.");
        }
    }
}
