namespace ChallengeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Employee employee1 = new Employee("Varg", "Vikernes");
            employee1.AddGrade(3.5f);           
            employee1.AddGrade(5f);
            employee1.AddGrade(6.5f);
            employee1.AddGrade("3");            
            employee1.AddGrade(4);

            var stat1 = employee1.GetStatistics();
            Console.WriteLine($"foreach:  Srednia ocena: {Math.Round(stat1.Average, 2)} , Maksymalnia ocena: {stat1.Max}, Minimalna ocena: {stat1.Min}");

           
        }
    }
}