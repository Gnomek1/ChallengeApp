using ChallengeApp;
namespace ChallengeApp.Tests

{
    public class EmployeeTests
    {
        [Test]

        public void WhenResultMaxValue_ThenCorrectResult()
        {
            // arrange
            var employee = new Employee("Varg", "Vikernes");
            employee.AddGrade(1);
            employee.AddGrade(6.66f);
            employee.AddGrade(9);
            int maxGrade = 9;
            // act
            var result = employee.GetStatistics();
            // assert
            Assert.AreEqual(maxGrade, result.Max);
        }
        [Test]

        public void WhenResultAverageValue_ThenCorrectResult()
        {
            // arrange
            var employee = new Employee("Varg", "Vikernes");
            employee.AddGrade(4);
            employee.AddGrade(4.5f);
            employee.AddGrade(4.5f);
            employee.AddGrade(5f);
            employee.AddGrade(5);
            float avgGrade = 4.6f;
            // act
            var result = employee.GetStatistics();
            // assert
            Assert.AreEqual(avgGrade, result.Average);
        }
        [Test]

        public void WhenResultMinValue_ThenCorrectResult()
        {
            // arrange
            var employee = new Employee("Varg", "Vikernes");
            employee.AddGrade(4);
            employee.AddGrade(4.5f);
            employee.AddGrade(4.5f);
            employee.AddGrade(5f);
            employee.AddGrade(5);
            float minGrade = 4f;
            // act
            var result = employee.GetStatistics();
            // assert
            Assert.AreEqual(minGrade, result.Min);
        }
        
    }
}