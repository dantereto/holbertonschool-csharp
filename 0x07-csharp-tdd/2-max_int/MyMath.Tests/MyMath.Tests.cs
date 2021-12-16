using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
namespace MyMath.Tests
{
    public class Tests
    {

        [Test]
        public void Max()
        {
            List<int> list_d = new List<int>()
            {2,3,5,10};
            int max = Operations.Max(list_d);
            Assert.AreEqual(max, 10);
        }
        [Test]
        public void Empty()
        {
            List<int> list_d = null;
            int max = Operations.Max(list_d);
            Assert.AreEqual(max, 0);
        }
        [Test]
        public void null_d()
        {
            List<int> list_d = new List<int>();
            Assert.AreEqual(Operations.Max(list_d), 0);
        }
    }
}