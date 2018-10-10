using System;
using System.Collections.Generic;
using System.Linq;

namespace BASolutions
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var evenNumbers = new List<int>();
            var oddNumbers = new List<int>();

            var interval1 = GetInterval();
            var interval2 = GetInterval();
            if (interval1 > 0 && interval2 > 0 && interval1 <= interval2)
            {
                for (int i = interval1; i <= interval2; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine($"{i} is even");
                        evenNumbers.Add(i);
                    }
                    else
                    {
                        Console.WriteLine($"{i} is odd");
                        oddNumbers.Add(i);
                    }
                }
                //Print sum and get it.
                var evenSum = GetAndPrintSum(evenNumbers, "is sum of even numbers");
                var oddSum = GetAndPrintSum(oddNumbers, "is sum of odd numbers");

                //Print and get individual sum numbers
                GetReversedNumbers(evenSum);
                GetReversedNumbers(oddSum);
            }
            else
            {
                Console.WriteLine("Check your numbers! First number must be smaller then second.");
            }
            Console.ReadLine();
        }

        private static int GetAndPrintSum(List<int> numbers, string definition)
        {
            var sum = numbers.Sum();
            Console.WriteLine($"{sum} {definition}");
            return sum;
        }

        private static void GetReversedNumbers(int x)
        {
            var numberAsString = x.ToString().Reverse();
            Console.WriteLine($"Reversed number of {x} is: {string.Join(" ", numberAsString)}");
        }

        private static int GetInterval()
        {
            Console.WriteLine("Set positive number of interval:");
            var isNumeric = int.TryParse(Console.ReadLine(), out int interval);
            return interval;
        }
    }
}

