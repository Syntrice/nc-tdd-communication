using Microsoft.VisualBasic;
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

        public Rating GetFinalRating(List<Rating> studentRatings)
        {
            int dislikeCount = studentRatings.Where(item => item == Rating.DISLIKE).Count();
            int likeCount = studentRatings.Where(item => item == Rating.LIKE).Count();

            if (dislikeCount % 2 == 0) dislikeCount = 0;
            if (likeCount % 2 == 0) likeCount = 0;

            Rating finalRating = Rating.NEUTRAL;

            if (dislikeCount > likeCount)
            {
                finalRating = Rating.DISLIKE;
            }
            else if (likeCount > dislikeCount) 
            {
                 finalRating = Rating.LIKE;
            }
           
            return finalRating;

        }

        public string GetCaesarCipher(string inputString)
        {
            StringBuilder stringBuilder = new StringBuilder();
            
            foreach (char c in inputString)
            {
                
                if (!Char.IsLetter(c))
                {
                    stringBuilder.Append(c); 
                    continue;
                }

                int asciiStart;
                if (Char.IsUpper(c))
                {
                    asciiStart = (int)'A';
                }
                else
                {
                    asciiStart = (int)'a';
                }

                // Convert character c to int. To get alphabetic index, subtract asciiStart.
                int cInt = (int)c - asciiStart; // a = 0, b = 1

                // Move character forward by 13 places
                cInt = cInt + 13;

                // Wrap around back to 'a' after letter z (26th letter)
                cInt = cInt % 26;

                // convert cInt back into a char 
                char resultChar = (char)(cInt + asciiStart);

                stringBuilder.Append(resultChar);
            }

            return stringBuilder.ToString();
        }

    }
}
