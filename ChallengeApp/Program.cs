namespace ChallengeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            string number = Console.ReadLine();
            // mogłbym pierwsze przekonwertowac tą liczbę na inta ale nie ma to chyba sensu
            char[] numberInArray = number.ToArray();
            for (int i = 0; i < 10; i++)
            {
                int counter =0;
                foreach (var c in numberInArray)
                {
                    if ( i== (c - '0'))
                    {
                        counter++;
                    }

                }
                Console.WriteLine($"{i}=>{counter}");
            }
            Console.ReadLine();
        }
    }
}