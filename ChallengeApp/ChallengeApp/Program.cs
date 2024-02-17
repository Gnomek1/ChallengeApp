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
            employee1.AddGrade(4.5);
            employee1.AddGrade(4);

            var stat1 = employee1.GetStatisticsWithForEach();
            Console.WriteLine($"foreach:  Srednia ocena: {Math.Round(stat1.Average, 2)} , Maksymalnia ocena: {stat1.Max}, Minimalna ocena: {stat1.Min}");

            var stat2 = employee1.GetStatisticsWithFor();
            Console.WriteLine($"for:  Srednia ocena: {Math.Round(stat2.Average, 2)} , Maksymalnia ocena: {stat2.Max}, Minimalna ocena: {stat2.Min}");

            var stat3 = employee1.GetStatisticsWithWhile();
            Console.WriteLine($"while:  Srednia ocena: {Math.Round(stat3.Average, 2)} , Maksymalnia ocena: {stat3.Max}, Minimalna ocena: {stat3.Min}");

            var stat4 = employee1.GetStatisticsWithForEach();
            Console.WriteLine($"dowhle:   Srednia ocena: {Math.Round(stat4.Average,2)} , Maksymalnia ocena: {stat4.Max}, Minimalna ocena: {stat4.Min}");
        }
    }
}