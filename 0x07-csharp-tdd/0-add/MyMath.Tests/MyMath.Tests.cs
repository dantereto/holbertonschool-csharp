using NUnit.Framework;
using System;
using MyMath;

namespace Tests
{
    public class Tests
    {

        [Test]
        public void Test1()
        {
            int a = 20;
            int b = 12;
            int c = Operations.Add(a, b);
            Assert.AreEqual(a + b, c);
        }
    }
}