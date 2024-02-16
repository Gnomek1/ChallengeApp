namespace ChallengeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Employee employee1 = new Employee("Varg", "Vikernes");
            employee1.AddGrade(3.5f);
            employee1.AddGrade("4000");
            employee1.AddGrade("Varg");
            employee1.AddGrade(5f);
            employee1.AddGrade(6.5f);
            employee1.AddGrade("3");
            var stat1 = employee1.GetStatistics();
            Console.WriteLine($"Srednia ocena: {stat1.Average}");
            Console.WriteLine($"Maksymalnia ocena: {stat1.Max}");
            Console.WriteLine($"Minimalna ocena: {stat1.Min}");

           




            
        }
    }
}