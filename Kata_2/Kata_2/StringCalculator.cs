using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;

namespace Kata_2
{
    public class StringCalculator
    {
        public int Add(string input)
        {
            if (input == "")
            {
                return 0;
            }

            var separators = GetSeparators(input);

            var numbers = GetNumbers(input, separators);

            AssertNumbersAreAllPositive(numbers);

            return Add(numbers);
        }

        private static int Add(List<int> numbers)
        {
            return numbers.Where(intNumber => intNumber <= 1000).Sum();
        }

        private static void AssertNumbersAreAllPositive(List<int> numbers)
        {
            var negativeNumbers = numbers.Where(intNumber => intNumber < 0).ToList();
            throw new NegativeNumberException(negativeNumbers);
            //if (negativeNumbers.Any())
            //{
            //    var negativeNumbersString = string.Join(",", negativeNumbers);
            //    throw new ArgumentException($"negatives not allowed, there is {negativeNumbers.Count} negative number:{negativeNumbersString}");
            //}
        }

        private static List<int> GetNumbers(string number, string[] separators)
        {
            var stringNumbers = number.Split(separators, StringSplitOptions.RemoveEmptyEntries).ToList();
            return stringNumbers.Select(int.Parse).ToList();
        }

        private string[] GetSeparators(string number)
        {
            var customSeparator = "";
            if (number.StartsWith("/"))
            {
                customSeparator = CustomSeparator(number);
            }

            return new[] { ",", "\n", "/", customSeparator };
        }

        public string CustomSeparator(string number)
        {
            String[] separator = { ",", "\n", "/" };
            var stringNumbers = number.Split(separator, StringSplitOptions.RemoveEmptyEntries).ToList();
            return stringNumbers[0];
        }
    }
}
