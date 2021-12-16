using NUnit.Framework;
using Text;
namespace Text.Tests
{
    public class Tests
    {
        [Test]
        public void CorrectCase()
        {
            Assert.IsTrue(Text.Str.IsPalindrome("level"));
        }
        [Test]
        public void FailCase()
        {
            Assert.IsFalse(Text.Str.IsPalindrome("hello"));
        }
        [Test]
        public void NullCase()
        {
            Assert.IsTrue(Text.Str.IsPalindrome(""));
        }
    }
}