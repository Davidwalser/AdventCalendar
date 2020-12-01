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
            Day1();
            Console.ReadLine();
        }

        private static void Day1()
        {
            var day1 = new Day1.Day1();
            var numbers = File.ReadAllLines(@"C:\Study\AdventCalendar\Day1\Numbers.txt").Select(int.Parse).ToArray();
            var puzzle1Result = day1.Puzzle1(numbers);
            Console.WriteLine("Puzzle1:");
            foreach (var (num1, num2) in puzzle1Result)
            {
                Console.WriteLine($"Found numbers:{num1},{num2} result:{num1 * num2}");
            }
            Console.WriteLine("Puzzle2:");
            var puzzle2Result = day1.Puzzle2(numbers);
            foreach (var (num1, num2,num3) in puzzle2Result)
            {
                Console.WriteLine($"Found numbers:{num1},{num2},{num3} result:{num1 * num2 * num3}");
            }
        }
    }
}
