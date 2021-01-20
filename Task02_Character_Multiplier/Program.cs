using System;
using System.Linq;

namespace Task02_Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

            
            string firstString = input[0];
            string secondString = input[1];

            int multiplier = GetMultiplier(firstString, secondString);

            
            Console.WriteLine(multiplier);
        }

        private static int GetMultiplier(string firstString, string secondString)
        {
            int smallerLenght = -1;
            bool isStringEqual = false;
            string longerString = string.Empty;
            int result = 0;

            if(firstString.Length == secondString.Length)
            {
                isStringEqual = true;
                smallerLenght = firstString.Length;
            }

            else if(firstString.Length < secondString.Length)
            {
                smallerLenght = firstString.Length;
                longerString = secondString;
            }
            else
            {
                smallerLenght = secondString.Length;
                longerString = firstString;
            }

            for (int i = 0; i < smallerLenght; i++)
            {
                result += (firstString[i] * secondString[i]);
            }
            if(isStringEqual == false)
            {
                for (int i = smallerLenght; i < longerString.Length; i++)
                {
                    result += longerString[i];
                }
            }

            return result;

        }
    }
}
