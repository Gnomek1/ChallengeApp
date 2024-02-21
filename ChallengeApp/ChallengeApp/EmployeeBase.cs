using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeApp
{
    public abstract class EmployeeBase : IEmployee
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public delegate void GradeAddedDelegate(object sender, EventArgs args);
        public abstract event GradeAddedDelegate GradeAdded;
        public EmployeeBase(string FirstName, string LastName)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
        }

        public abstract void AddGrade(float points);    
        public abstract void AddGrade(double points);
        public abstract void AddGrade(string points);
        public abstract void AddGrade(char points);
        public abstract void SubtractPoints(float points);
        public abstract Statistics GetStatistics();

    }
}
