namespace ChallengeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 65; i <=90; i++)
            {
                var a = (char)i;
                Console.Write($"{a}, ");

            }
            Console.ReadLine();
        }
    }
}