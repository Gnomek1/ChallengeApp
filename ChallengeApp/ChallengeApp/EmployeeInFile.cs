using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeApp
{
    public class EmployeeInFile : EmployeeBase
    {
        private const string fileName = "grade.txt";
        public override event GradeAddedDelegate GradeAdded;
        public EmployeeInFile(string FirstName, string LastName) : base(FirstName, LastName)
        {
        }

        public override void AddGrade(float points)
        {

            if (points >= 0 && points <= 100)
            {
                using (var writer = File.AppendText(fileName))
                {
                    writer.WriteLine(points);
                }
                if (GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }
            else
            {
                throw new Exception("Invalid data (float method)");
            }
        }
        public override void AddGrade(double points)
        {
            float gradeAsFloat = (float)points;
            this.AddGrade(gradeAsFloat);
        }

        public override void AddGrade(string points)
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

        public override void AddGrade(char points)
        {
            switch (points)
            {
                case 'A' or 'a':
                    AddGrade(100);
                    break;
                case 'B' or 'b':
                    AddGrade(80);
                    break;
                case 'C' or 'c':
                    AddGrade(60);
                    break;
                case 'D' or 'd':
                    AddGrade(40);
                    break;
                case 'E' or 'e':
                    AddGrade(20);
                    break;
                default:
                    throw new Exception("Wrong Letter (char method)");
            }
        }

        public override Statistics GetStatistics()
        {
            var stats = new Statistics();
            if (File.Exists(fileName))
            {
                using (var reader = File.OpenText(fileName))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        var number = float.Parse(line);
                        stats.AddGrade(number);
                        line = reader.ReadLine();
                    }
                }
            }

            return stats;
        }

        public override void SubtractPoints(float points)
        {
            if (points < 0 && points >= -100)
            {
                AddGrade(points);
            }
            else
            {
                throw new Exception("Please enter correct neagtive value");
            }
        }
    }
}
