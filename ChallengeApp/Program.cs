namespace ChallengeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Employee e1 = new Employee("Krzysztof","Kononowicz",60);
            Employee e2 = new Employee("Wojciech","Suchodolski",70);
            Employee e3 = new Employee("Jan","Los",50);
            e1.AddPoints(1);
            e1.AddPoints(10);
            e1.AddPoints(4);
            e1.AddPoints(6);
            e1.AddPoints(2);

            e2.AddPoints(2);
            e2.AddPoints(10);
            e2.AddPoints(9);
            e2.AddPoints(8);
            e2.AddPoints(7);

            e3.AddPoints(7);
            e3.AddPoints(2);
            e3.AddPoints(1);
            e3.AddPoints(10);
            e3.AddPoints(10);

            List<Employee> list = new List<Employee>();
            list.Add(e1);
            list.Add(e2);
            list.Add(e3);

            int maxRes = 0;
            Employee eMaxRes = null;

            foreach (var item in list)
            {
                if (item.Result>=maxRes) 
                {
                    maxRes = item.Result;
                    eMaxRes = item;
                }
            }
            Console.WriteLine($"{eMaxRes.FirstName} {eMaxRes.LastName} zdobył {eMaxRes.Result} ptk.");




            Console.ReadLine();
        }
    }
}