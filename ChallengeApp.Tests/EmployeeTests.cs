using ChallengeApp;
namespace ChallengeApp.Tests

{
    public class EmployeeTests
    {
        [Test]
        public void WhenEmployeeScores30Points_ThenCorrectResult()
        {
            var employee1 = new Employee("Peter", "Steel",5);
            employee1.AddPoints(3);
            employee1.AddPoints(5);
            employee1.AddPoints(9);
            employee1.AddPoints(1);
            employee1.AddPoints(7);
            employee1.AddPoints(3);
            employee1.AddPoints(2);


            int result = employee1.Result;


            Assert.AreEqual(30, result);
        }
        [Test]
        public void WhenEmployeeScoresNegativePoints_ThenThrowError()
        {
            var employee2 = new Employee("Peter", "Steel", 10);
            employee2.AddPoints(3);
            employee2.AddPoints(5);
            employee2.AddPoints(-10);
            employee2.AddPoints(-1);

            int result= employee2.Result;


            Assert.Negative(result);
        }
        [Test]
        public void WhenEmployeeAddAndSubtractPoints_ThenCorrectResult()
        {
            var employee3 = new Employee("Peter", "Steel", 15);
            employee3.AddPoints(3);
            employee3.AddPoints(5);
            employee3.SubtractPoints(-5);
            employee3.SubtractPoints(-4);

            int result = employee3.Result;


            Assert.AreEqual(-1,result);
        }
    }
}