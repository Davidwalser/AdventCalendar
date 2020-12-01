using System.Collections.Generic;

namespace AdventCalendar.Day1
{
    public class Day1
    {
        public IEnumerable<(int, int)> GetNumber(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] + numbers[j] == 2020)
                    {
                        yield return (numbers[i], numbers[j]);
                    }
                }
            }
        }
    }
}