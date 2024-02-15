using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeApp
{
    internal class Homeworks
    {
        public void Day4()
        {
            Console.Write("Enter your name:");
            string Name = Console.ReadLine();
            bool male = false;
            int age = 30;
            if (!male)
            {
                if (age < 30)
                {
                    Console.WriteLine("Kobieta poniżej 30 lat");
                }
                else if (age == 30 && Name == "Ewa")
                {
                    Console.WriteLine("Ewa, lat 30");
                }

            }
            else if (male && age < 18)
            {
                Console.WriteLine("Niepełnoletni Mężczyzna");
            }        
        }
        public void Day5() 
        {
            Console.Write("Enter a number: ");
            string number = Console.ReadLine();
            // mogłbym pierwsze przekonwertowac tą liczbę na inta ale nie ma to chyba sensu
            char[] numberInArray = number.ToArray();
            for (int i = 0; i < 10; i++)
            {
                int counter = 0;
                foreach (var c in numberInArray)
                {
                    if (i == (c - '0'))
                    {
                        counter++;
                    }

                }
                Console.WriteLine($"{i}=>{counter}");
            }
        }
       
    }
}
