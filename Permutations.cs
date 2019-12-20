﻿using System;
using System.Collections.Generic;

namespace hello_dotnet_core
{
    partial class Program
    {
        // A string 'a' is a permutation of string 'b' iff the characters of
        // the string can be rearranged to form string 'b'
        private static void CheckPermutations()
        {
            Console.WriteLine("Checking strings for permutations...");
            List<Tuple<String, String>> strings = new List<Tuple<String, String>>
            {
                Tuple.Create<String,String>("abc 123", "a1b 2c3"),
                Tuple.Create<String,String>("abc 123", "abc123"),
                Tuple.Create<String,String>("abc 123 ", "1 23 abc"),
                Tuple.Create<String,String>("aab aab", "abc 123"),
                Tuple.Create<String,String>("abc 123", "aab aab"),

            };

            strings.ForEach(t =>
            {
                string a = t.Item1;
                string b = t.Item2;

                // Before bothering to do character checks, make sure strings are
                // the same length!
                if (a.Length != b.Length)
                {
                    WriteIsPermutation(a, b, false);
                    return;
                }

                // Now make sure string a has every character from string b
                foreach (char c in a)
                {
                    if (!b.Contains(c))
                    {
                        WriteIsPermutation(a, b, false);
                        return;
                    }
                }

                // Must also make sure every char in b is in a!
                foreach (char c in b)
                {
                    if (!a.Contains(c))
                    {
                        WriteIsPermutation(a, b, false);
                        return;
                    }
                }

                // Must be a permutation then!
                WriteIsPermutation(a, b, true);
            });

            // Local functions!
            void WriteIsPermutation(string a, string b, bool isPermutation)
            {
                Console.WriteLine("\"{0}\" {2} a permutation of \"{1}\"", a, b, isPermutation ? "IS" : "is NOT");
            }

        }
    }
}
