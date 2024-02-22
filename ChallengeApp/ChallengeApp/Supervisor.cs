using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeApp
{
    public class Supervisor
    {
        private List<float> grades = new List<float>();
        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public Supervisor(string FirstName, string LastName)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
        }

        public void AddGrade(float points)
        {
            if (points >= 0 && points <= 100)
            {
                this.grades.Add(points);
            }
            else
            {
                throw new Exception("Invalid data (float method)");
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
                        throw new Exception("number is out of range (string method)");
                }
            }
            else if (char.TryParse(points, out char resultChar))
            {
                AddGrade(resultChar);
            }
            else
            {
                this.AddGrade(result);
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

            foreach (var item in this.grades)
            {
                stat.AddGrade(item);
            }
            return stat;
        }
    }
}

