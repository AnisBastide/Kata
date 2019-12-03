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

            string custom_separator = "";
            string slash = "/";
            if (Equals(number[0] , slash[0]))
            {
                string[] separator1 = { ",", "\n","/" };
                List<string> customSeparatorList = number.Split(separator1, StringSplitOptions.RemoveEmptyEntries).ToList();
                custom_separator = customSeparatorList[0];
            }
            string[] separator = {",","\n",custom_separator,"/"};
            List<string> stringList = number.Split(separator,StringSplitOptions.RemoveEmptyEntries).ToList();
            List<int> intList =stringList.Select(int.Parse).ToList();
            int sum = 0;
            var count = 0;
            List<int> negativeList = new List<int>();
            foreach (int N in intList)
            {
                
                if (N < 0)
                {
                    negativeList.Add(N);
                    count++;
                }
                sum = sum + N;
            }

            string negativeNumbers = "";

            foreach (int negativeNumber in negativeList)
            {
                negativeNumbers = negativeNumbers + negativeNumber + ";";
            }

            if (count != 0)
            {
                throw new ArgumentException($"No Negative Number, there is {count} negative number , ({negativeNumbers})");
            }
            return sum;

        }
    }
}
