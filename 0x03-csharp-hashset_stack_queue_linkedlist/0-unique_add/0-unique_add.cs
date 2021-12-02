using System;
using System.Collections.Generic;
using System.Linq;
class List
{
    public static int Sum(List<int> myList)
    {
        int sum = 0;
        List<int> copy = new HashSet<int>(myList).ToList();
        for (int i = 0; i < copy.Count; i++)
        {
            sum += copy[i];
        }
        return sum;
    }
}
