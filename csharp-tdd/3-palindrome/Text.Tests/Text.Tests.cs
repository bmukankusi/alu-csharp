using NUnit.Framework;

namespace Text.Tests
{

    // Contains unit tests for the Str class.
    [TestFixture]
    public class StrTests
    {
        [Test]
        public void IsPalindrome_WithPalindromeString_ReturnsTrue()
        {
            
            string input = "A man, a plan, a canal: Panama.";

            
            bool result = Str.IsPalindrome(input);

            
            Assert.IsTrue(result);
        }

        [Test]
        public void IsPalindrome_WithNonPalindromeString_ReturnsFalse()
        {
            
            string input = "Hello, World!";

            
            
            bool result = Str.IsPalindrome(input);

            
            Assert.IsFalse(result);
        }

        [Test]
        public void IsPalindrome_WithEmptyString_ReturnsTrue()
        {
          
            string input = "";

           
            bool result = Str.IsPalindrome(input);

            
            Assert.IsTrue(result);
        }

        [Test]
    public void IsPalindrome_WithSingleCharacterString_ReturnsTrue()
        {
            
            string input = "a";

            
            bool result = Str.IsPalindrome(input);

            
            Assert.IsTrue(result);
        }

        [Test]
        public void IsPalindrome_WithMixedCasePalindromeString_ReturnsTrue()
        {
            
            string input = "Racecar";

        
            bool result = Str.IsPalindrome(input);

           
            Assert.IsTrue(result);
        }
    }
}