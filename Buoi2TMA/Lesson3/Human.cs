using System;
using System.Collections.Generic;
using System.Text;

namespace Buoi2TMA.Lesson3
{
    class Human
    {
        String lastName;
        String firstName;

        public Human(String lastName,
        String firstName)
        {
            this.lastName = lastName;
            this.firstName = firstName;
        }

        public string LastName { get => lastName; set => lastName = value; }
        public string FirstName { get => firstName; set => firstName = value; }
    }
}
