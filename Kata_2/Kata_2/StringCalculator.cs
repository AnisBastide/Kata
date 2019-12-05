using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            String[] separator = { "," };
            var stringNumbers=number.Split(separator, StringSplitOptions.RemoveEmptyEntries);
            var intNumbers = stringNumbers.Select(int.Parse).ToList();
            var sum = 0;
            foreach (int intNumber in intNumbers)
            {
                sum += intNumber;
            }

            return sum;
        }
    }
}
