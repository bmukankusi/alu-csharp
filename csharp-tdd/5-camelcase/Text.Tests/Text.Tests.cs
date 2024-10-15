using NUnit.Framework;

namespace Text.Tests
{
    [TestFixture]
    public class StrTests
    {
        [Test]
        public void CamelCase_WithMultipleWords_ReturnsWordCount()
        {
            string input = "thisIsCamelCase";

            int result = Str.CamelCase(input); // this te

            Assert.That(result, Is.EqualTo(4));
        }

        [Test]
        public void CamelCase_WithSingleWord_ReturnsOne()
        {
            string input = "word";

            int result = Str.CamelCase(input);

            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void CamelCase_WithEmptyString_ReturnsZero()
        {
            string input = "";

            int result = Str.CamelCase(input);

            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void CamelCase_WithNullString_ReturnsZero()
        {
            
            string input = null;

            int result = Str.CamelCase(input ?? string.Empty);

            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void CamelCase_WithNoCapitalLetters_ReturnsOne()
        {
            string input = "nocapitalletters";

            int result = Str.CamelCase(input);

            Assert.That(result, Is.EqualTo(1));
        }
    }
}