using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void ReferenceTypeTest()
        {
            var employee1 = GetEmployee("Dead", "Mayhem");
            var employee2 = GetEmployee("Varg", "Vikerness");
            Assert.AreNotEqual(employee1, employee2);
        }

        [Test]
        public void ValueTypeTestFloat()
        {
            var x = 7.5;
            var y = 14.5;
            var result = x + y;
            Assert.AreEqual(result, 22);
        }

        [Test]
        public void ValueTypeTestString()
        {
            var employee1 = GetEmployee("Varg", "Mayhem");
            var employee2 = GetEmployee("Varg", "Vikerness");
            Assert.AreEqual(employee1.FirstName, employee2.FirstName);
        }
        [Test]
        public void ValueTypeTestInt()
        {
            int x = -1;
            int y = -3;
            int result = x + y;
            Assert.Negative(result);
        }

        private Employee GetEmployee(string firstName, string lastName)
        {
            return new Employee(firstName, lastName);
        }

    }
}
