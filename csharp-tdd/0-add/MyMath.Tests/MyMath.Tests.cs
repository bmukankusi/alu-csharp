namespace MyMath.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(2, 3, 5)]
        [TestCase(-1, -2, -3)]
        [TestCase(1, 1, 2)]
        public void Test_Addition(int a, int b, int result)
        {
            Assert.That(result, Is.EqualTo(MyMath.Operations.Add(a, b)));
        }
    }
}