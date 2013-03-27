using System;
using NUnit.Framework;
using ProjectToTest.Domain;

namespace ProjectToTestNUnitTest.Domain
{
    [TestFixture]
    class PersonTest
    {
        private Person person;
        private readonly int mockPersonId = 1;
        private readonly string mockFirstName = "First Name";
        private readonly string mockLastName = "Last Name";

        [SetUp]
        public void SetUp()
        {
            person = new Person(mockPersonId, mockFirstName, mockLastName);
        }

        [TearDown]
        public void TearDown()
        {
            person = null;
        }

        [Test]
        public void TestPerson()
        {
            Person testPerson = null;
            Assert.DoesNotThrow(delegate { testPerson = new Person(1, "first name", "last name"); },
                "An exception occurs when Person is instantiated.");
            Assert.IsNotNull(testPerson, "The person is not null.");
        }

        [Test]
        public void TestId()
        {
            Assert.AreEqual(mockPersonId, person.Id);
        }

        [Test]
        public void TestFirstName()
        {
            Assert.IsFalse(String.IsNullOrWhiteSpace(person.FirstName), "The first name is empty / null / white space");
            Assert.AreEqual(mockFirstName, person.FirstName, "The first name is incorrect");
           
        }

        [Test]
        public void TestLastName()
        {
            Assert.IsFalse(String.IsNullOrWhiteSpace(person.LastName), "The last name is empty / null / white space");
            Assert.AreEqual(mockLastName, person.LastName, "The last name is incorrect");
        }
    }
}
