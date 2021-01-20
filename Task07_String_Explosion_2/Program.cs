using System;
using System.Linq;


namespace Task07_String_Explosion_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string symbols = Console.ReadLine();

            int energy = 0;

            for (int i = 0; i < symbols.Length; i++)
            {
                if(symbols[i] == '>')
                {
                    energy += int.Parse(symbols[i + 1].ToString());
                }
                else if(energy > 0)
                {
                    symbols = symbols.Remove(i, 1);
                    energy--;
                    i--;
                }
            }
            
            
            Console.WriteLine(symbols);
        }
    }
}
