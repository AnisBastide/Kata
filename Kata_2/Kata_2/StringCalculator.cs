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

            return Sum(numbers);
        }

        private int Sum(string numbers)
        {
            var intNumbers = ConvertNumbersIntoIntegerList(numbers);

            return CheckNegativeNumbers(intNumbers);

        }



        private List<int> ConvertNumbersIntoIntegerList(string numbers)
        {
            string[] separator = { ",", "\n", "/", GetCustomSeparator(numbers) };
            var stringNumbers = numbers.Split(separator, StringSplitOptions.RemoveEmptyEntries);
            var intNumbers = stringNumbers.Select(int.Parse).ToList();
            return intNumbers;
        }
        private string GetCustomSeparator(string numbers)
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

        private static int CheckNegativeNumbers(List<int> intNumbers)
        {
            
            var negativeNumbers = "";
            foreach (int intNumber in intNumbers)
            {
                if (intNumber < 0)
                {
                    negativeNumbers+=  intNumber + ";";
                }

                
            }

            if (negativeNumbers != "")
            {
                throw new ArgumentException($"no negatives allowed {negativeNumbers}");
            }
            return Sum(intNumbers);

        }
        private static int Sum(List<int> intNumbers)
        {
            var sum = 0;
            foreach (int intNumber in intNumbers)
            {
                sum += intNumber;
            }

            return sum;
        }
    }
}
