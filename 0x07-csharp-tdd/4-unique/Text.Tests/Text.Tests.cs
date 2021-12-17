using NUnit.Framework;

namespace Text.Tests
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            string co= "oooooonooo";
            Assert.AreEqual(Str.UniqueChar(co), 6);
        }
        [Test]
        public void TestSame()
        {
            string co= "aaaaaaaaa";
            Assert.AreEqual(Str.UniqueChar(co), -1);
        }
        [Test]
        public void TestNone()
        {
            string co= "aaddiittppqq";
            Assert.AreEqual(Str.UniqueChar(co), -1);
        }
        [Test]
        public void Test2()
        {
            string co= "asdjsja";
            Assert.AreEqual(Str.UniqueChar(co), 2);
        }
    }
}