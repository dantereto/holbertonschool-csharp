using System;
using System.Collections.Generic;
class LList
{
    public static LinkedList<int> CreatePrint(int size)
    {
        if (size <= 0)
        {
            LinkedList<int> empty = new LinkedList<int>();
            return empty;
        }
        else
        {
            int[] num = new int[size];
            for (int i = 0; i < size; i++){
                num[i] = i;
                Console.WriteLine(num[i]);
            }
            LinkedList<int> linked_l = new LinkedList<int>(num);
            return linked_l;
        }
    }
}
