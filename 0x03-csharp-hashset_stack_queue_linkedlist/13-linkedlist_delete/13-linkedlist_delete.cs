using System;
using System.Collections.Generic;
class LList
{
    public static void Delete(LinkedList<int> myLList, int index)
    {
        int i = 0;
        LinkedListNode<int> del = myLList.First;
        for (; i < index && del.Next != null; i++)
            del = del.Next;
        if (i == index)
            myLList.Remove(del); 
    }
}
