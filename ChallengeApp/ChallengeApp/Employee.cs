﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeApp
{
    public class Employee : IEmployee
    {
        private List<float> grades = new List<float>();
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
       
        public Employee(string FirstName, string LastName)
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
                throw new Exception("Invalid data(float method)");
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
                throw new Exception("Invalid data (string method)");
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
                    throw new Exception("Wrong Letter (char method)");
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
