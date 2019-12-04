using System;
using System.Collections.Specialized;
using System.Linq;

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

        public int Sum(string number)
        {
            var customSeparator = "";
            if (number.StartsWith("/"))
            {
                 customSeparator = CustomSeparator(number);
            }
            
            String[] separator = {",","\n","/",customSeparator};
            var stringNumbers = number.Split(separator, StringSplitOptions.RemoveEmptyEntries).ToList();
            var numbers = stringNumbers.Select(int.Parse).ToList();
            var sum = 0;
            var count = 0;
            var negativeNumbers = "";
            foreach (int intNumber in numbers)
            {
                if (intNumber < 0)
                {
                    negativeNumbers+=intNumber + ";";
                    count++;
                }
                sum += intNumber;
            }

            if (count > 0)
            {
                negativeNumbers=negativeNumbers.Remove((negativeNumbers.Length - 1));
                throw new ArgumentException($"negatives not allowed, there is {count} negative number:{negativeNumbers}");
            }
            return sum;
        }

        public string CustomSeparator(string number)
        {
            String[] separator = { ",", "\n", "/" };
            var stringNumbers = number.Split(separator, StringSplitOptions.RemoveEmptyEntries).ToList();
            return stringNumbers[0];
        }
    }
}
