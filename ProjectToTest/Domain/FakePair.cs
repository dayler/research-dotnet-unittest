using System;

namespace ProjectToTest.Domain
{
    class FakePair
    {
        /// <summary>
        /// Test comment
        /// </summary>
        private readonly String first;
        private readonly String second;

        public FakePair(String first, String second)
        {
            if (first == null)
            {
                throw new ArgumentNullException("The 'first' parameter is null");
            }

            if (second == null)
            {
                throw new ArgumentNullException("The 'second' parameter is null");
            }

            this.first = first;
            this.second = second;
        }

        public String First
        {
            get
            {
                return first;
            }
        }

        public String Second
        {
            get
            {
                return second;
            }
        }
    }
}