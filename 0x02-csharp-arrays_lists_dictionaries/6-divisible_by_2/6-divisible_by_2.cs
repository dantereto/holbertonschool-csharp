using System;
using System.Collections.Generic;

class List
{
    public static List<bool> DivisibleBy2(List<int> myList)
    {
        List<bool> iList = new List<bool>();
        foreach (int i in myList)
        {
            if (i % 2 == 0)
                iList.Add(true);
            else
                iList.Add(false);
        }
        return iList;
    }

}
