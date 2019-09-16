using System;

namespace ClassTest
{
    class Day
    {
        public int number;//число
        public string month;//месяц
        public Day( int n, string m) { number = n; month = m; }
    }
    class Exact:Day
    {
        public string name;//день недели
        public Exact(string name, int number, string month) : base(number, month)
        {
            this.name = name;
           
        }
        public void GetInfo()
        {
            Console.WriteLine($"Число: {number} Месяц: {month} День недели:{name}");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Exact fifteenseptember = new Exact("Sunday", 15, "September");
            fifteenseptember.GetInfo();
        }
    }
}
