using System;

namespace Task04_Caesar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string output = string.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                int asciiCode = input[i] + 3;
                output += (char) asciiCode;
            }
            
            
            Console.WriteLine(output);
        }
    }
}
