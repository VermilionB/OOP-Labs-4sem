using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Laba_1.Interfaces;

namespace Laba_1.Classes
{
    public static class Calculator
    {
        public static int[] ConsonantsAndVowels(string str)
        {
            char[] consonants = new char[] { 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'r', 's', 't', 'v', 'w', 'x', 'y', 'z' };
            char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };
            int c = 0;
            int v = 0;

            foreach (char s in str)
            {
                if (consonants.Contains(Char.ToLower(s)))
                    c++;
                else if (vowels.Contains(Char.ToLower(s)))
                    v++;
            }

            return new int[] { c, v };
        }
        public static string GetLength(string str)
        {
            return str.Length.ToString();
        }

        public static string WordCount(string str)
        {
            return str.Split(' ').Length.ToString();
        }

        public static string SenCount(string str)
        {
            char[] endOfSen = new char[] { '.', '?', '!' };
            if (!endOfSen.Contains(str[str.Length - 1]))
            {
                return str.Split(endOfSen).Length.ToString();
            }
            else
            {
                int result = str.Split(endOfSen).Length - 1;
                return result.ToString();
            }
        }

    }
}
