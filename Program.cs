using System;
using System.Collections.Generic;

namespace hello_dotnet_core
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> words = new List<String> {
                "Hello",
                "Helleh",
                "Heleh",
                "Helee"
            };

            words.ForEach(s => CheckPalindrome(new Word(s)));
        }

        static void CheckPalindrome(Word word)
        { 
            word = word ?? new Word(null);
            Console.WriteLine("\"{0}\" {1} a palindrome.", word, word.IsPalindrome ? "is" : "is NOT");
            Console.WriteLine();
        }
    }
}
