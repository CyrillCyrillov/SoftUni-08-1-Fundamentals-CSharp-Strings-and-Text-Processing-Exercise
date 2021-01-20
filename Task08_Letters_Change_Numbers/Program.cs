using System;
using System.Linq;


namespace Task08_Letters_Change_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputData = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
            double sum = 0.00;

            for (int i = 0; i < inputData.Length; i++)
            {
                sum += CalculateSum(inputData[i]);
            }
            
            
            Console.WriteLine($"{sum:f2}");
        }

        private static double CalculateSum(string nextData)
        {
            char firstChar = nextData[0];
            char lastChar = nextData[nextData.Length - 1];
            
            nextData = nextData.Remove(0, 1);
            nextData = nextData.Remove(nextData.Length - 1, 1);

            double result = double.Parse(nextData);

            if(firstChar >= 65 && firstChar <= 90)
            {
                result = result / (firstChar - 64);
            }
            else
            {
                result = result * (firstChar - 96);
            }

            if(lastChar >= 97 && lastChar <= 122)
            {
                result += (lastChar - 96);
            }
            else
            {
                result -= (lastChar - 64);
            }

            return result;
        }
    }
}
