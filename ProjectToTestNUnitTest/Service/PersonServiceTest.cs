using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using NUnit.Mocks;
using NSubstitute;
using ProjectToTest.Domain;
using ProjectToTest.Service;

namespace ProjectToTestNUnitTest.Service
{
    [TestFixture]
    class PersonServiceTest
    {
#pragma warning disable 612,618
        private DynamicMock dynamicMock;
#pragma warning restore 612,618

        private Person firstPerson ;

        private Person seconPerson;

        private List<Person> peopleList;

        private IPersonRepository personRepository;

        [SetUp]
        public void SetUp()
        {
            firstPerson = new Person(1, "Simone", "Simons");
            seconPerson = new Person(2, "Amy", "Lee");
            peopleList = new List<Person>() {firstPerson, seconPerson};

            // Setup mock object.
            dynamicMock = new DynamicMock(typeof(IPersonRepository));
            personRepository = Substitute.For<IPersonRepository>();
        }

        [TearDown]
        public void TearDown()
        {
            firstPerson = null;
            seconPerson = null;
            peopleList = null;
            dynamicMock = null;
        }

        [Test]
        public void TestGetAllPeople()
        {
            dynamicMock.ExpectAndReturn("GetPeople", peopleList);
            var personRepository = dynamicMock.MockInstance as IPersonRepository;
            var personService = new PersonService(personRepository);
            List<Person> people = personService.GetAllPeople();
            Assert.IsNotNull(people, "The list of the people is null.");
            Assert.AreEqual(people.Count, peopleList.Count,
                "The people list does not have the same amount of the elements.");
        }

        [Test]
        public void TestGealAllStoredPeople()
        {
            personRepository.GetPeople().Returns(peopleList);
            var personService = new PersonService(personRepository);
            List<Person> storedPeople = personService.GetAllPeopleStored();
            
            // Verify the length.
            Assert.AreEqual(peopleList.Count, storedPeople.Count,
                "The Stored and Peple must to have the same length.");

            // Verify if the order for the list has changed.
            Person amyStored = storedPeople.First();

            Assert.AreEqual("Amy", amyStored.FirstName);
        }

        [Test]
        public void TestGetSinglePersongWithValidId()
        {
            int personId = firstPerson.Id;
            personRepository.GetPersonById(personId).Returns(firstPerson);
            var personService = new PersonService(personRepository);
            var personForValidId = personService.GetPerson(personId);

            // Verify that are not null
            Assert.IsNotNull(personForValidId, "The Person is null");

            // Verify that is the expected person
            Assert.AreEqual(personId, personForValidId.Id,
                "There are not the expected Person. The Id are diferents.");
        }

        [Test]
        public void TestGetSinglePersonForInvalidId()
        {
            int personId = seconPerson.Id;
            personRepository.GetPersonById(personId).Returns(seconPerson);
            var personservice = new PersonService(personRepository);
            int invalidId = 10;
            var personForInvalidId = personservice.GetPerson(invalidId);

            // Verify that is returned a null reference if the id is invalid.
            Assert.IsNull(personForInvalidId);
        }
    }
}
