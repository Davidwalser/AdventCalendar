using System;
using System.IO;
using System.Linq;

namespace AdventCalendar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Happy Advent!");
            var day1 = new Day1.Day1();
            var numbers = File.ReadAllLines(@"C:\Study\AdventCalendar\Day1\Numbers.txt").Select(int.Parse).ToArray();
            var result = day1.GetNumber(numbers);
            foreach (var (num1,num2) in result)
            {
                Console.WriteLine($"Found numbers:{num1},{num2} result:{num1*num2}");
            }

            Console.ReadLine();
        }
    }
}
