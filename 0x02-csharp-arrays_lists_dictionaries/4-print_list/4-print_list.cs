using System;
using System.Collections.Generic;

class List
{
    public static List<int> CreatePrint(int size)
    {
        if (size < 0)
            {
                Console.WriteLine("Size cannot be negative");
                return null;
            }
        List<int> iList = new List<int>();
        for(int i = 0; i < size; i++)
        {
            iList.Add(i);
            if (i != size -1)
                Console.Write("{0} ", i);
            else
                Console.Write(i);
        }
        Console.WriteLine();
        return iList;
    }
}
