using System;

namespace Task05_Multiply_Big_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string bigNumber = Console.ReadLine();
            int number = int.Parse(Console.ReadLine());
            string result = string.Empty;

            if (number == 0)
            {
                result = "0";
            }
            else
            {
                while (bigNumber[0] == '0')
                {
                    bigNumber = bigNumber.Remove(0, 1);
                }


                int add = 0;

                for (int i = bigNumber.Length - 1; i >= 0; i--)
                {
                    int nextDigit = int.Parse(bigNumber[i].ToString());
                    int help = (nextDigit * number) + add;

                    if (help < 10)
                    {
                        result = result.Insert(0, help.ToString());
                        add = 0;
                    }
                    else if (i != 0)
                    {
                        result = result.Insert(0, (help % 10).ToString());
                        add = help / 10;
                    }
                    else
                    {
                        result = result.Insert(0, help.ToString());
                    }

                }
            }

            
            
            Console.WriteLine(result);
        }
    }
}
