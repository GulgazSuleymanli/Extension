using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Extention.Models
{
    internal static class ExtensionMethods
    {
        public static bool IsOdd(this int value)
        {
            if (value % 2 == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool IsEven(this int value)
        {
            if (value % 2 == 0)
            {
                return true;
            }
            return false;
        }

        public static bool IsContainsDigit(this string word)
        {
            if(word.Any(char.IsDigit))
            {
                return true;
            }
            return false;
        }

        public static string ToCapitalize(this string word)
        {
            word = word.ToLower();
            StringBuilder newWord = new StringBuilder();
            newWord.Append(char.ToUpper(word[0]));
            for (int i = 1; i < word.Length; i++)
            {
                newWord.Append(word[i]);
            }
            return newWord.ToString();
        }

        public static int[] GetValueIndexes(this string word, char letter)
        {
            int[] indexes= new int[0];
            for (int i = 0; i < word.Length; i++)
            {
                if ((word[i] == letter))
                {
                    Array.Resize(ref indexes, indexes.Length+1);
                    indexes[indexes.Length-1] = i;
                }
            }
            return indexes;
        }
    }
}
