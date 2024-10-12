namespace MyMath.Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

   // [Test]
   // public void Test_sumOfPositive_numbers()
   // {  
    //    var result = MyMath.Operations.Add(2,3);
    //        var expected = 5;
    //  Assert.That(expected, Is.EqualTo(result));
    //}
    [TestCase (2,3,5)]
    [TestCase (-1,-2,-3)]
    [TestCase(1,1,2)]
    public void Test_Addition(int a,int b, int result){
        Assert.That(result, Is.EqualTo(MyMath.Operations.Add(a,b)));
    }
}    