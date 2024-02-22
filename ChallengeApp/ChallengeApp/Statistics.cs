using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeApp
{
    public class Statistics
    {
        public float Min { get; private set; }
        public float Max { get; private set; }
        public float Sum { get; private set; }
        public int  Count { get; private set; }
        public float Average
        {
            get
            {
                return Sum / Count;
            }
        }
        public char AverageLetter
        {
            get
            {
                switch (Average)
                {
                    case var a when a >= 80:
                        return 'A';                        
                    case var a when a >= 60:
                        return 'B';
                    case var a when a >= 40:
                        return 'C';
                    case var a when a >= 20:
                        return 'D';
                    default:
                        return 'E';
                }
            }
        }

        public Statistics()
        {
            Count = 0;
            Sum = 0;
            Max = float.MinValue;
            Min = float.MaxValue;
        }

        public void AddGrade(float points)
        {
            Count++;
            Sum += points;
            Min = Math.Min(points, Min);
            Max = Math.Max(points, Max);
        }
    }
}
