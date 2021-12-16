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
            var list = new List<int>()
            {2,3,5,10};
            int max = Operations.Max(list);
            Assert.AreEqual(max, 10);
        }
        public void Empty()
        {
            var list = new List<int>();
            int max = Operations.Max(list);
            Assert.AreEqual(max, 0);
        }
    }
}