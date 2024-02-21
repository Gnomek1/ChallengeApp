namespace ChallengeApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Witamy w pragoramie do oceny pracowników");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();

            var employee = new EmployeeInMemory("Varg", "Vikernes");

            employee.GradeAdded += EmployeeGradeAdded;

            void EmployeeGradeAdded(object  sender,EventArgs args)
            {
                Console.WriteLine("Dodano nową ocenę");
            }

            var stat1 = employee.GetStatistics();

            while(true)
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
                    employee.AddGrade(input);
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Exception catched {e.Message}");
                }
            }
        }
    }
}