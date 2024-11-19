using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDCommunication
{
    public class Kata1
    {

        public int SumMiddleNumbers(int[] numberArray)
        {
            int sum = 0;
            Array.Sort(numberArray);
            for (int i = 1; i < numberArray.Length - 1; i++)
            {
                sum += numberArray[i];
            }

            return sum;

        }
        public double GetMeanOfNumbers(int[] numberArray)
        {
            double sum = 0;

            for (int i = 0;i < numberArray.Length; i++)
            {
                sum += numberArray[i];
            }

            return Math.Round((double)sum/ numberArray.Length, 2);
            

        }
        public int GetSumOfASCII(string inputString)
        {
            int sum = 0;
            foreach (char c in inputString)
            {
                sum += (int)c;
            }

            return sum;
        }
    }
}
