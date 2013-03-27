using System;
using System.Collections.Generic;
using ProjectToTest.Domain;

namespace ProjectToTest.Service
{
    class PersonService
    {
        private readonly IPersonRepository repository;

        public PersonService(IPersonRepository repository)
        {
            if (repository == null)
            {
                throw new ArgumentNullException("repository cannot be null.");
            }

            this.repository = repository;
        }

        public List<Person> GetAllPeople()
        {
            return repository.GetPeople();
        }

        public List<Person> GetAllPeopleStored()
        {
            List<Person> people = repository.GetPeople();
            people.Sort(delegate(Person onePerson, Person otherPerson)
                { return onePerson.LastName.CompareTo(otherPerson.LastName); });

            return people;
        }

        public Person GetPerson(int personId)
        {
            Person person = null;

            try
            {
                person = repository.GetPersonById(personId);
            }
            catch (ArgumentException)
            {
                // No op.
            }

            return person;
        }
    }
}
