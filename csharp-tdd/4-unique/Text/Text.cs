

namespace Text
{
    /// <summary>
    /// Provides string operations.
    /// </summary>
    public static class Str
    {
        /// <summary>
        /// Returns the index of the first non-repeating character in a string.
        /// </summary>
        /// <param name="s">The string to check.</param>
        /// <returns>The index of the first non-repeating character, or -1 if there is no non-repeating character.</returns>
        public static int UniqueChar(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return -1;
            }

            var charCount = new Dictionary<char, int>();

            // Count the occurrences of each character
            foreach (char c in s)
            {
                if (charCount.ContainsKey(c))
                {
                    charCount[c]++;
                }
                else
                {
                    charCount[c] = 1;
                }
            }

            // Find the index of the first non-repeating character
            for (int i = 0; i < s.Length; i++)
            {
                if (charCount[s[i]] == 1)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}