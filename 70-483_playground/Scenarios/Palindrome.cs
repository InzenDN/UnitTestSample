using System;
using System.Collections.Generic;

namespace _70_483_playground.Scenarios
{
    class Palindrome
    {
        public static bool IsPalindrome(string word)
        {
            Stack<char> stack = new Stack<char>();

            foreach(var letter in word)
            {
                stack.Push(letter);
            }

            string word2 = new string(stack.ToArray());

            return word.ToUpper() == word2.ToUpper();
        }

        public static void Main(string[] args)
        {
            Console.WriteLine(Palindrome.IsPalindrome("Deleveled"));
        }
    }
}
