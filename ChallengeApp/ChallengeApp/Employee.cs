using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeApp
{
    public class Employee
    {
        private List<int> points = new List<int>();
        public string FirstName { get; private set; }
        public string LastName { get; private set;}
        public int   Age { get; private set; }        
        public int Result
        {
            get
            {
                return this.points.Sum();
            }
        }

        public Employee(string FirstName, string LastName)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            
        }
        public Employee(string FirstName,string LastName, int Age) 
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Age = Age;
        }
        public void AddPoints(int points) 
        {
            if (points >=0 && points<=10) 
            {
                this.points.Add(points);
            }
            else
            {
                Console.WriteLine("Podaj wartość od 1 do 10");
            }
            
        }
        public void SubtractPoints(int points)
        {
            if (points < 0 && points >= -10)
            {
                this.points.Add(points);
            }
            else
            {
                Console.WriteLine("Podaj wartość od -1 do -10");
            }

        }


    }
}
