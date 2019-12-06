using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace Kata_2
{
    public class StringCalculator
    {
        public int Add(string numbers)
        {
            if (numbers == "")
            {
                return 0;
            }

            return DoSum.PublicSum(numbers);
        }
    }

    public class VerifyIfNumberArePositive
    {
        public static int PublicCheckNegativeNumbers(List<int> intNumbers)
        {
            return CheckNegativeNumbers(intNumbers);
        }
        private static int CheckNegativeNumbers(List<int> intNumbers)
        {

            var negativeNumbers = "";
            foreach (int intNumber in intNumbers)
            {
                if (intNumber < 0)
                {
                    negativeNumbers += intNumber + ";";
                }


            }

            if (negativeNumbers != "")
            {
                throw new ArgumentException($"no negatives allowed {negativeNumbers}");
            }
            return DoSum.PublicSumWithIntegerList(intNumbers);

        }
    }

    public class DoSum
    {
        public static int PublicSum(string numbers)
        {
            return Sum(numbers);
        }
        public static int PublicSumWithIntegerList(List<int> intNumbers)
        {
            return DoSumWithIntegerList(intNumbers);
        }
        private static int Sum(string numbers)
        {
            var intNumbers = ConvertNumberToIntegerLists.PublicConvertNumbersIntoIntegerList(numbers);

            return VerifyIfNumberArePositive.PublicCheckNegativeNumbers(intNumbers);

        }

        private static int DoSumWithIntegerList(List<int> intNumbers)
        {
            var sum = 0;
            foreach (int intNumber in intNumbers)
            {
                sum += intNumber;
            }

            return sum;
        }
    }

    public class ConvertNumberToIntegerLists
    {
        public static List<int> PublicConvertNumbersIntoIntegerList(string numbers)
        {
            return ConvertNumbersIntoIntegerList(numbers);
        }

        private static List<int> ConvertNumbersIntoIntegerList(string numbers)
        {
            string[] separator = { ",", "\n", "/", CustomSeparator.PublicGetCustomSeparator(numbers) };
            var stringNumbers = numbers.Split(separator, StringSplitOptions.RemoveEmptyEntries);
            var intNumbers = stringNumbers.Select(int.Parse).ToList();
            return intNumbers;
        }
    }

    public class CustomSeparator
    {
        public static string PublicGetCustomSeparator(string numbers)
        {
            return GetCustomSeparator(numbers);
        }
        private static string GetCustomSeparator(string numbers)
        {
            var customSeparator = "";
            String[] separator = { ",", "\n", "/" };
            if (numbers.StartsWith("//"))
            {
                var stringNumber = numbers.Split(separator, StringSplitOptions.RemoveEmptyEntries).ToList();
                customSeparator = stringNumber[0];
            }

            return customSeparator;
        }
    }

}
