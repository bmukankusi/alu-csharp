using NUnit.Framework;
using MyMath;

namespace MyMath.Tests;
{
    [TestFixture]
    public class OperationsTests
    {
        [Test]
        public void Add_ReturnSum_WhenTwoNumbersAreGiven()
    }

    int a = 1;
    int b = 7;

    //Add the two numbers
    int sum = Operations.Add(a, b);

    //Assert
    Assert.AreEqual(8, sum);
}