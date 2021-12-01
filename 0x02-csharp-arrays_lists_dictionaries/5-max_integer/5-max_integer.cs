﻿using System;
using System.Collections.Generic;

class List
{
    public static int MaxInteger(List<int> myList)
    {
        List<int> iList = new List<int>();
        if (myList == null){
            Console.WriteLine("List is empty");
            return -1;
        }
        int max = myList[0];
        foreach (int i in myList)
        {
            if (max < i)
                max = i;
        }
        return max;
    }
}

