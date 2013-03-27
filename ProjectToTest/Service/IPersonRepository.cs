using System.Collections.Generic;
using ProjectToTest.Domain;

namespace ProjectToTest.Service
{
    interface IPersonRepository
    {
        List<Person> GetPeople();

        Person GetPersonById(int personId);
    }
}
