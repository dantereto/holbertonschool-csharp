using NUnit.Framework;
using System;
using MyMath;
namespace MyMath.Tests
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            int num = 5;
            int[,] array1 = new int[2, 2]
            {
                {4, 5}, {9, 0}
            };
            int[,] Result = Matrix.Divide(array1, num);
            Assert.AreEqual(array1, Result);
        }
    }
}