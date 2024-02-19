using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeApp
{
    public abstract class Person
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Sex { get; private set; }
        public int Age { get; private set; }

        public Person(string FirstName, string LastName, string Sex, int Age)
        {
            this.FirstName = FirstName;
            this.LastName = FirstName;
            this.Sex = Sex;
            this.Age = Age;
        }
        public Person(string FirstName, string LastName)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
        }
    }
}
