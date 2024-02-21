namespace ChallengeApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            var emp1 =  new EmployeeInFile("Varg", "Vikernes");
            
            Console.WriteLine("Witamy w pragoramie do oceny pracowników");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();
            emp1.AddGrade(0.5f);
            emp1.AddGrade('c');
            emp1.AddGrade("b");
            emp1.AddGrade(100);
            var stat2 = emp1.GetStatistics();
            Console.WriteLine($"Srednia ocena: {Math.Round(stat2.Average, 2)} , Maksymalna ocena: {stat2.Max}, Minimalna ocena: {stat2.Min} Ocena jako Litera: {stat2.AverageLetter}");
            //while (true)
            //{
            //    Console.WriteLine("pisząc q wyjdziesz z dodania kolejnych ocen");
            //    Console.Write("Podaj ocenę pracownika:");
            //    var input = Console.ReadLine();
            //    if (input == "q")
            //    {
            //        break;
            //    }
            //    try
            //    {
            //        sup1.AddGrade(input);
            //    }
            //    catch (Exception e)
            //    {
            //        Console.WriteLine($"Exception catched {e.Message}");
            //    }
            //}

            //var stat1 = employee1.GetStatistics();
            //Console.WriteLine($"Srednia ocena: {Math.Round(stat1.Average, 2)} , Maksymalna ocena: {stat1.Max}, Minimalna ocena: {stat1.Min} Ocena jako Litera: {stat1.AverageLetter}");




        }
    }
}