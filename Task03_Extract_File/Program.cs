using System;
using System.Linq;

namespace Task03_Extract_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] comandLine = Console.ReadLine().Split(new char[] { ':', '.', (char) 92 }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            string fileName = comandLine[comandLine.Length - 2];
            string extention = comandLine[comandLine.Length - 1];
            
            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {extention}");
        }
    }
}
