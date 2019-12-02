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
            string[] separatorForCustomStrings = {"/","\n"};
            string[] separatorList= number.Split(separatorForCustomStrings, StringSplitOptions.RemoveEmptyEntries);
            string separator1 = separatorList[0];
            string[] separator = {",", "\n","/", separator1 };
            string[] stringList = number.Split(separator, StringSplitOptions.RemoveEmptyEntries);
            int result = 0;
            List<int> intList = stringList.Select(int.Parse).ToList();
            var count = 0;
            foreach (int N in intList)
            {

                if (N < 0)
                {
                    count++;
                    throw new ArgumentException("Pas de nombres negatif");
                }
                result = result + N;
            }
            return result;
        }
    }
}
