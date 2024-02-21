using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeApp
{
    public interface IEmployee
    {
        string FirstName { get; }
        string LastName { get; }

        event EmployeeBase.GradeAddedDelegate GradeAdded;

        void AddGrade(float points);
        void AddGrade(double points);
        void AddGrade(string points);
        void AddGrade(char points);
        void SubtractPoints(float points);        
        Statistics GetStatistics();
    }
}
