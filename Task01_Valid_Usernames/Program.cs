using System;
using System.Linq;
using System.Text;

namespace Task01_Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] usersPerCheck = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();

            foreach (var word in usersPerCheck)
            {
                bool isValid = true;

                for (int i = 0; i < word.Length; i++)
                {
                    if(word.Length < 3 || word.Length >16)
                    {
                        isValid = false;
                        break;
                    }
                    
                    if(char.IsDigit(word[i]) || char.IsLetter(word[i]) || word[i] == '-' || word[i] == '_')
                    {

                    }
                    else
                    {
                        isValid = false;
                        break;
                    }
                }

                if(isValid)
                {
                    Console.WriteLine(word);
                }
                
            }
        }
    }
}
