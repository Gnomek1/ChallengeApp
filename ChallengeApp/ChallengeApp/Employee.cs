using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeApp
{
    public class Employee
    {
        private List<float> grades = new List<float>();
        public string FirstName { get; private set; }
        public string LastName { get; private set;}
        public int   Age { get;  set; }        
        

        public Employee(string FirstName, string LastName)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            
        }
      
        public void AddGrade(float points) 
        {
            if (points>=0 && points<=100)
            {
                this.grades.Add(points);
            }
            else 
            {
                Console.WriteLine("Invalid data");
            }            
        }

        public void AddGrade(string points)
        {
            if (float.TryParse(points, out float result)) 
            {
                AddGrade(result);
            }
            else
            {
                Console.WriteLine("String is not float");
            }
        }
        public void AddGrade (int points) 
        {
            var result = (float)points;
            if (result >= 0 && result <= 100)
            {
                AddGrade(result);
            }
            else
            {
                Console.WriteLine("Invalid data");
            }
        }
        public void AddGrade(double points)
        {
            float result = (float)points;
            if (result >= 0 && result <= 100)
            {
                AddGrade(result);
            }
            else
            {
                Console.WriteLine("Invalid data");
            }
        }
        public void AddGrade(decimal points)
        {
            float result = (float)points;
            if (result >= 0 && result <= 100)
            {
                AddGrade(result);
            }
            else
            {
                Console.WriteLine("Invalid data");
            }
        }

       

        public void SubtractPoints(float points)
        {
         
          this.grades.Add(points);
        }
        public Statistics GetStatisticsWithForEach()
        {
            Statistics stat = new Statistics();
            stat.Average = 0;
            stat.Max = float.MinValue;
            stat.Min = float.MaxValue;

            foreach (var item in grades)
            {
                stat.Max = Math.Max(stat.Max, item);
                stat.Min = Math.Min(stat.Min, item);
                stat.Average += item;
            }

            stat.Average = stat.Average/ grades.Count;
            return stat;
        }
        public Statistics GetStatisticsWithFor()
        {
            Statistics stat = new Statistics();
            stat.Average = 0;
            stat.Max = float.MinValue;
            stat.Min = float.MaxValue;

            for (int i = 0; i < grades.Count; i++)
            {
                stat.Max = Math.Max(stat.Max, grades[i]);
                stat.Min = Math.Min(stat.Min, grades[i]);
                stat.Average += grades[i];
            }

            stat.Average = stat.Average / grades.Count;
            return stat;
        }
        public Statistics GetStatisticsWithWhile()
        {
            Statistics stat = new Statistics();
            stat.Average = 0;
            stat.Max = float.MinValue;
            stat.Min = float.MaxValue;
            int index = 0;

            while (index < this.grades.Count) 
            {
                stat.Max = Math.Max(stat.Max, this.grades[index]);
                stat.Min = Math.Min(stat.Min, this.grades[index]);
                stat.Average += this.grades[index];
                index++;
            } 

            stat.Average = stat.Average / grades.Count;
            return stat;
        }

        public Statistics GetStatisticsWithDoWhile()
        {
            Statistics stat = new Statistics();
            stat.Average = 0;
            stat.Max = float.MinValue;
            stat.Min = float.MaxValue;
            int index = 0;
            do
            {
                stat.Max = Math.Max(stat.Max, this.grades[index]);
                stat.Min = Math.Min(stat.Min, this.grades[index]);
                stat.Average += this.grades[index];
                index++;
            } while (index < this.grades.Count);
            stat.Average = stat.Average / grades.Count;
            return stat;
        }



    }
}
