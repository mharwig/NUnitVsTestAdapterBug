using NUnit.Framework;

namespace NUnitVsTestAdapterBug
{
  [TestFixture]
  public class ExampleTestFixture
  {
    [Test]
    public void ExampleTest()
    {
      const int one = 1;
      const int two = 2;
      
      TestContext.Progress.WriteLine("Example of progress message in test");

      Assert.That(one + two, Is.EqualTo(3));
    }
  }
}
