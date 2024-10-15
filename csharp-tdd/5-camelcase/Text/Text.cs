namespace Text
{
    /// <summary>
    /// String operations, camelcase.
    /// </summary>
    public static class Str
    {
        /// <summary>
        /// Determines how many words are in a camelCase string.
        /// Each word begins with a capital letter except the first word.
        /// </summary>
        /// <param name="s">The camelCase string to check.</param>
        /// <returns>The number of words in the string.</returns>
        public static int CamelCase(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return 0;
            }

            int wordCount = 1; // Start with 1 because the first word starts with a lowercase letter

            foreach (char c in s)
            {
                if (char.IsUpper(c))
                {
                    wordCount++;
                }
            }

            return wordCount;
        }
    }
}