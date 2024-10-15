using System;
using System.Linq;

namespace Text
{
    /// <summary>
    /// Provides string operations.
    /// </summary>
    public static class Str
    {
        /// <summary>
        /// Determines whether the specified string is a palindrome.
        /// </summary>
        /// <param name="s">The string to check.</param>
        /// <returns>True if the string is a palindrome, False otherwise.</returns>
        public static bool IsPalindrome(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return true;
            }

            // Remove non-alphanumeric characters and convert to lowercase
            var cleanedString = new string(s.Where(char.IsLetterOrDigit).ToArray()).ToLower();

            // Check if the cleaned string is a palindrome
            return cleanedString.SequenceEqual(cleanedString.Reverse());
        }
    }
}