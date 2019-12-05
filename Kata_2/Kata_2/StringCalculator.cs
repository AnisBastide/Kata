using System;
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

            var sum = Sum(number);
            
            return sum;
        }

        public int Sum(string number)
        {
            String[] separator = { ",","\n","/",CustomSeparator(number) };
            var stringNumbers=number.Split(separator, StringSplitOptions.RemoveEmptyEntries);
            var intNumbers = stringNumbers.Select(int.Parse).ToList();
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

        public string CustomSeparator(string number)
        {
            var customSeparator = "";
            String[] separator = { ",", "\n","/" };
            if (number.StartsWith("//"))
            {
                var stringNumber=number.Split(separator,StringSplitOptions.RemoveEmptyEntries).ToList();
                customSeparator = stringNumber[0];
            }

            return customSeparator;
        }

    }
}
