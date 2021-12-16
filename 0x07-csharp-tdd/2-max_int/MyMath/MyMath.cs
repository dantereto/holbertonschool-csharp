using System;
using System.Collections.Generic;
using System.Linq;
namespace MyMath
{
    /// <summary> Class of operations</summary>
    public class Operations
    {
        /// <summary> Max number of list</summary>
        public static int Max(List<int> nums)
        {
            if (nums == null || nums.Count == 0)
            {
                return (0);
            }
            return (nums.Max());
        }
    }
}
