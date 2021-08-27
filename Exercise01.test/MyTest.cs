using NUnit.Framework;
using Exercise01;
namespace Exercise01.test
{
    public class MyTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {

            Assert.Pass();
        }
        [Test]
        public void Eighteen_million_test()
        {
            long number = 18_000_000;
            string numberInWords = number.ToWords();
            Assert.AreEqual(numberInWords, "eighteen million ");
        }
    }
}