using NUnit.Framework;

namespace Text.Tests
{
    [TestFixture]
    public class StrTests
    {
        [Test]
        public void UniqueChar_WithNonRepeatingCharacter_ReturnsIndex()
        {
            string input = "leetcode";

            int result = Str.UniqueChar(input);

           
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void UniqueChar_WithRepeatingCharacters_ReturnsIndex()
        {
            string input = "loveleetcode";

            int result = Str.UniqueChar(input);

           
            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void UniqueChar_WithAllRepeatingCharacters_ReturnsMinusOne()
        {
            string input = "aabbcc";

            int result = Str.UniqueChar(input);

           
            Assert.That(result, Is.EqualTo(-1));
        }

        [Test]
        public void UniqueChar_WithEmptyString_ReturnsMinusOne()
        {
            string input = "";

            int result = Str.UniqueChar(input);

           
            Assert.That(result, Is.EqualTo(-1));
        }

        [Test]
        public void UniqueChar_WithSingleCharacterString_ReturnsZero()
        {
            string input = "z";

            int result = Str.UniqueChar(input);

           
            Assert.That(result, Is.EqualTo(0));
        }
    }
}