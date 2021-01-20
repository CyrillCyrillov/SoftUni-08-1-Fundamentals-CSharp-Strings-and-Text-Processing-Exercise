using System;

namespace Task07_String_Explosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            for (int i = 0; i < text.Length; i++)
            {
                if(text[i] == '>')
                {
                    int energy = int.Parse(text[i + 1].ToString());
                    while(energy > 0)
                    {
                        if(text[i + 1] != '>')
                        {
                            text = text.Remove(i + 1, 1);
                            energy -= 1;
                        }
                        else
                        {
                            i += 1;
                            if(i == text.Length - 1)
                            {
                                break;
                            }
                            energy = int.Parse(text[i + 1].ToString()) + 1;
                        }
                    }

                }
            }
            
            
            Console.WriteLine(text);
        }
    }
}
