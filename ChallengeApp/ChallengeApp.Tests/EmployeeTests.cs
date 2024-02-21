using ChallengeApp;
namespace ChallengeApp.Tests

{
    public class EmployeeTests
    {
        [Test]

        public void WhenCollectGradesDiferentTypes_ThenCorrectResult()
        {
            // arrange
            var employee = new EmployeeInMemory("Varg", "Vikernes");
            employee.AddGrade("100");
            employee.AddGrade('a');
            employee.AddGrade("a");
            employee.AddGrade(100);
            employee.AddGrade(100.00f);
            employee.AddGrade(100.00);

            // act
            var result = employee.GetStatistics();
            // assert
            Assert.AreEqual(100, result.Max);
        }
        [Test]

        public void WhenCollectGrades_ThenCorrectResult()
        {
            // arrange
            var employee = new EmployeeInMemory("Varg", "Vikernes");
            employee.AddGrade(90);
            employee.AddGrade(40);
            employee.AddGrade('c');
            employee.AddGrade("A");
           
            // act
            var result = employee.GetStatistics();
            // assert
            Assert.AreEqual(72.5f, result.Average);
            Assert.AreEqual(40, result.Min);
            Assert.AreEqual(100, result.Max);
            Assert.AreEqual('B', result.AverageLetter);

        }
     
    }
}