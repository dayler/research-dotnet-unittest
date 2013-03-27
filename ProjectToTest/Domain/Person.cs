using System;

namespace ProjectToTest.Domain
{
    class Person
    {
        private int id;

        private readonly String lastName;

        private readonly String firstName;

        public Person(int id, String firstName, String lastName)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public int Id
        {
            get { return id; }
        }

        public String LastName
        {
            get { return lastName; }
        }

        public String FirstName
        {
            get { return firstName; }
        }
    }
}
