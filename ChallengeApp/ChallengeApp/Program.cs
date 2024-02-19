namespace ChallengeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee("Varg", "Vikernes");
            Console.WriteLine("Witamy w pragoramie do oceny pracowników");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();
            
            while (true) 
            {
                Console.WriteLine("pisząc q wyjdziesz z dodania kolejnych ocen");
                Console.Write("Podaj ocenę pracownika:");
                var input = Console.ReadLine();
                if (input == "q")
                {
                    break;
                }
                try
                {
                    employee1.AddGrade(input);
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Exception catched {e.Message}");
                }
            }
            
            var stat1 = employee1.GetStatistics();
            Console.WriteLine($"Srednia ocena: {Math.Round(stat1.Average, 2)} , Maksymalna ocena: {stat1.Max}, Minimalna ocena: {stat1.Min} Ocena jako Litera: {stat1.AverageLetter}");

           
        }
    }
}