using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace Kata_2
{
    public class StringCalculator
    {
        public int Add(string number)
        {
            if (number == "")
            {
                return 0;
            }

            return Sum(number);
        }

        private int Sum(string number)
        {
            var intNumbers = IntList(number);

            return CheckNegativeNumbers(intNumbers);
        }

        private static int CheckNegativeNumbers(List<int> intNumbers)
        {
            var sum = 0;
            var negativeNumbers = "";
            foreach (int intNumber in intNumbers)
            {
                if (intNumber < 0)
                {
                    negativeNumbers = negativeNumbers + intNumber + ";";
                }

                sum += intNumber;
            }

            if (negativeNumbers != "")
            {
                throw new ArgumentException($"no negatives allowed {negativeNumbers}");
            }

            return sum;
        }

        private List<int> IntList(string number)
        {
            string[] separator = { ",", "\n", "/", CustomSeparator(number) };
            var stringNumbers = number.Split(separator, StringSplitOptions.RemoveEmptyEntries);
            var intNumbers = stringNumbers.Select(int.Parse).ToList();
            return intNumbers;
        }

        private string CustomSeparator(string number)
        {
            var customSeparator = "";
            String[] separator = { ",", "\n", "/" };
            if (number.StartsWith("//"))
            {
                var stringNumber = number.Split(separator, StringSplitOptions.RemoveEmptyEntries).ToList();
                customSeparator = stringNumber[0];
            }

            return customSeparator;
        }

    }
}
