using System;

namespace Task06_Replace_Repeating_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            int index = 0;

            while (index < text.Length - 1)
            {
                if(text[index] == text[index +1])
                {
                    text = text.Remove(index + 1, 1);
                }
                else
                {
                    index += 1;
                }
            }
            
            
            Console.WriteLine(text);
        }
    }
}
