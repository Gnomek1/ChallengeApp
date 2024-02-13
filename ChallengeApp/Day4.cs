using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeApp
{
    internal class Day4
    {
        public void Homework()
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
       
    }
}
