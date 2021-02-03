using System;
using System.Collections.Generic;
using System.Linq;

namespace Questions
{
    class Program
    {
        static void Main(string[] args)
        {
            Phrase("Anaeko Your Trusted Data Partner");
            RDfromstring("Sample Sentence");
            Console.ReadLine();
        }


        // Q.1: 
        internal static void Phrase(string str)
        {

            Dictionary<char, int> Counts = new Dictionary<char, int>();

            foreach (var character in str)
            {
                if (character != ' ')
                {
                    if (!Counts.ContainsKey(character))
                    {
                        Counts.Add(character, 1);
                    }
                    else
                    {
                        Counts[character]++;
                    }
                }

            }
            foreach (var character in Counts)
            {
                Console.WriteLine("{0} - {1}", character.Key, character.Value);
            }
        }

        // Q.2:
        internal static void RDfromstring(string str)
        {

            string result = string.Empty;

            for (int i = 0; i < str.Length; i++)
            {
                if (!result.Contains(str[i]))
                {
                    result += str[i];
                }
            }
            Console.WriteLine(result);
        }

       
    }
}
