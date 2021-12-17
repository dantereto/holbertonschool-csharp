using NUnit.Framework;

namespace Text.Tests
{
    public class Tests
    {

        [Test]
        public void Test1()
        {
            string c = "hiHiHiHi";
            Assert.AreEqual(Str.CamelCase(c), 4);
        }
        [Test]
        public void TestCamel()
        {
            string c = "hihello";
            Assert.AreEqual(Str.CamelCase(c), 1);
        }
        [Test]
        public void TestNull()
        {
            string c = null;
            Assert.AreEqual(Str.CamelCase(c), 0);
        }
    }
}