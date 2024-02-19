using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeApp
{
    public  class Supervisor :IEmployee
    {
        private List<float> grades = new List<float>();
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Sex { get; private set; }

        public Supervisor(string FirstName, string LastName, string Sex)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Sex = Sex;
        }
        public Supervisor(string FirstName, string LastName)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Sex = "none";
        }

        public void AddGrade(float points)
        {
            if (points >= 0 && points <= 100)
            {
                this.grades.Add(points);
            }
            else
            {
                throw new Exception("Invalid data");
            }
        }

        public void AddGrade(double points)
        {
            float gradeAsFloat = (float)points;
            this.AddGrade(gradeAsFloat);
        }

        public void AddGrade(string points)
        {
            if (float.TryParse(points, out float result))
            {
                this.AddGrade(result);
            }
            else if (char.TryParse(points, out char resultChar))
            {
                AddGrade(resultChar);
            }
            else
            {
                switch (points)
                {
                    case "6":                    
                        AddGrade(100);
                        break;
                    case "+5":
                    case "5+":
                        AddGrade(85);
                        break;
                    case "5":
                        AddGrade(80);
                        break;
                    case "-5":
                    case "5-":
                        AddGrade(75);
                        break;
                    case "+4":
                    case "4+":
                        AddGrade(65);
                        break;
                    case "4":
                        AddGrade(60);
                        break;
                    case "-4":
                    case "4-":
                        AddGrade(55);
                        break;
                    case "+3":
                    case "3+":
                        AddGrade(45);
                        break;
                    case "3":
                        AddGrade(40);
                        break;
                    case "3-":
                    case "-3":
                        AddGrade(35);
                        break;
                    case "+2":
                    case "2+":
                        AddGrade(25);
                        break;
                    case "2":
                        AddGrade(20);
                        break;
                    case "-2":
                    case "2-":
                        AddGrade(15);
                        break;
                    case "1":
                        AddGrade(0);
                        break;
                    default:
                        throw new Exception("Wrong number");
                }
            }
        }

        public void AddGrade(char points)
        {
            switch (points)
            {
                case 'A':
                case 'a':
                    AddGrade(100);
                    break;
                case 'B':
                case 'b':
                    AddGrade(80);
                    break;
                case 'C':
                case 'c':
                    AddGrade(60);
                    break;
                case 'D':
                case 'd':
                    AddGrade(40);
                    break;
                case 'E':
                case 'e':
                    AddGrade(20);
                    break;
                default:
                    throw new Exception("Wrong Letter");
            }
        }

        public void SubtractPoints(float points)
        {
            if (points < 0 && points >= -100)
            {
                this.grades.Add(points);
            }
            else
            {
                throw new Exception("Please enter correct neagtive value");
            }
        }

        public Statistics GetStatistics()
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
            stat.Average = stat.Average / grades.Count;

            switch (stat.Average)
            {
                case var a when a >= 80:
                    stat.AverageLetter = 'A';
                    break;
                case var a when a >= 60:
                    stat.AverageLetter = 'B';
                    break;
                case var a when a >= 40:
                    stat.AverageLetter = 'C';
                    break;
                case var a when a >= 20:
                    stat.AverageLetter = 'D';
                    break;
                default:
                    stat.AverageLetter = 'E';
                    break;
            }
            return stat;
        }
    }
}

